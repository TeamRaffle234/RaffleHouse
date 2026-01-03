using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RaffleHouseProject.GuiHelpers
{
    public class WaitUntil
    {
        public static void ShouldLocate(By location)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(location));
        }

        public static void CustomElementIsClickable(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);

            DateTime endTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endTime)
            {
                try
                {
                    if (ExpectedConditions.ElementToBeClickable(element).Invoke(Browser._Driver) != null)
                    {
                        return; 
                    }
                }
                catch (NoSuchElementException)
                {
                    
                }
                catch (StaleElementReferenceException)
                {
                    
                }

                Thread.Sleep(100); 
            }
        }

        public static void WaitSomeInterval(int milliSeconds)
        {
            Task.Delay(TimeSpan.FromMilliseconds(milliSeconds)).Wait();
        }

        public static void WaitForElementToBeClickableAndVisible(IWebElement element, int seconds = 10)
        {
            if (Browser._Driver == null)
                throw new InvalidOperationException("WebDriver is not initialized");

            if (element == null)
                throw new ArgumentNullException(nameof(element), "Element cannot be null");

            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            try
            {
                bool isVisible = wait.Until(driver =>
                {
                    try
                    {
                        return element.Displayed;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                });

                if (isVisible)
                {
                    bool isEnabled = wait.Until(driver => element.Enabled);

                    if (isEnabled && element.GetAttribute("disabled") == null)
                    {
                        Console.WriteLine($"[SUCCESS] Элемент найден и кликабелен");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"[WARNING] Элемент появился, но он некликабелен. Enabled={element.Enabled}, Disabled attr={element.GetAttribute("disabled")}");
                        throw new ElementNotInteractableException("Element is not clickable");
                    }
                }
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"[ERROR] Элемент не появился в течение {seconds} секунд");
                throw;
            }
            catch (ElementNotInteractableException)
            {
                throw;
            }
        }

        public static void SuccessCustomElementIsVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {
                            Console.WriteLine(element.Text);

                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }
        }

        public static void StaticElementIsVisible(IWebElement element, int seconds = 10)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);

            bool isVisible = false;

            try
            {
                isVisible = wait.Until(_ =>
                {
                    try
                    {
                        if (element.Displayed)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                isVisible = false;
            }

            if (isVisible)
            {
                Console.WriteLine("[SUCCESS] Успешно Элемент видимый");
            }
            else
            {
                Console.WriteLine("[ERROR] Ошибка Элемент не отобразился");
            }
        }

        public static void StaticElementIsInVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);

            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (!element.Displayed)
                        {
                            Console.WriteLine("[SUCCESS] Element is not displayed (invisible)");
                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        Console.WriteLine("[SUCCESS] Element is not displayed (invisible)");
                        return true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        Console.WriteLine("[SUCCESS] Element is not displayed (invisible)");
                        return true;
                    }
                });
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("[SUCCESS] Element is not displayed (invisible)");
            }
            catch (StaleElementReferenceException)
            {
                Console.WriteLine("[SUCCESS] Element is not displayed (invisible)");
            }
            catch (WebDriverTimeoutException)
            {
                // Без сообщения об ошибке, как запрошено
            }
        }

        public static void WaitForElementToDisappear(IWebElement element, int seconds = 10)
        {
            Task.Delay(TimeSpan.FromMilliseconds(550)).Wait();
            IWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Browser._Driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Message = $"The search element is still visible after {seconds} sec"
            };
            try
            {
                wait.Until(driver =>
                {
                    try
                    {
                        if (element.Enabled == false || element.Displayed == false)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception) { return true; }
                });
                Task.Delay(TimeSpan.FromMilliseconds(350)).Wait();
            }
            catch (Exception) { throw new ArgumentException(wait.Message); }
        }
    }
}
