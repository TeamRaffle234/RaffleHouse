using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenuMainSite
    {
        [AllureStep("Verify button icon close form cross")]
        public BurgerMenuMainSite VerifyButtonIconCloseFormCross()
        {

            if (ButtonIconCloseFormCross == null)
            {
                Console.WriteLine("❌ ЭЛЕМЕНТ НЕ НАЙДЕН: Button Icon Close Form Cross");
                throw new NoSuchElementException("Элемент не найден по XPath: //button[@class = 'sidebar__close-btn']");
            }

            Console.WriteLine("✓ Элемент найден в DOM");
            Console.WriteLine($"Enabled: {ButtonIconCloseFormCross.Enabled}");

            Assert.IsTrue(ButtonIconCloseFormCross.Enabled,
                "Кнопка закрытия формы должна быть доступна (Enabled)");

            Console.WriteLine($"✅ Проверка Button Icon Close Form Cross завершена успешно");

            return this;
        }

        [AllureStep("Verify button logo Raffle House")]
        public BurgerMenuMainSite VerifyButtonLogoRaffleHouse()
        {

            if (ButtonLogoRaffleHouse == null)
            {
                Console.WriteLine("❌ ЭЛЕМЕНТ НЕ НАЙДЕН: Button Logo Raffle House");
                throw new NoSuchElementException("Элемент не найден по XPath: //a[@class = 'sidebar__logo']");
            }

            Console.WriteLine("✓ Элемент найден в DOM");
            Console.WriteLine($"Enabled: {ButtonLogoRaffleHouse.Enabled}");

            Assert.IsTrue(ButtonLogoRaffleHouse.Enabled,
                "Кнопка закрытия формы должна быть доступна (Enabled)");

            Console.WriteLine($"✅ Проверка Button Logo Raffle House завершена успешно");

            return this;
        }

        [AllureStep("Verify button icon Cart")]
        public BurgerMenuMainSite VerifyButtonIconCart()
        {

            if (ButtonLogoRaffleHouse == null)
            {
                Console.WriteLine("❌ ЭЛЕМЕНТ НЕ НАЙДЕН: button icon Cart");
                throw new NoSuchElementException("Элемент не найден по XPath: //a[@class = 'sidebar__cart']");
            }

            Console.WriteLine("✓ Элемент найден в DOM");
            Console.WriteLine($"Enabled: {ButtonIconCart.Enabled}");

            Assert.IsTrue(ButtonIconCart.Enabled,
                "Кнопка закрытия формы должна быть доступна (Enabled)");

            Console.WriteLine($"✅ Проверка button icon Cart завершена успешно");

            return this;
        }
    }
}
