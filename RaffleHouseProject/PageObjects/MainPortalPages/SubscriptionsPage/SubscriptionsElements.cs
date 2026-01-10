using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SubscriptionsPage
{
    public partial class SubscriptionsMainPg
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'subscription-page']//div[@class = 'first-block-details']//div//h1//span[text() = ' Never miss your chance to dream big and do good']")]
        public IWebElement TitleNeverMissYourChanceToDreamBigAndDoGood;
    }
}
