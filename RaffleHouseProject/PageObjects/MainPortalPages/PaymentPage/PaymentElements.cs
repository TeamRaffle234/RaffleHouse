using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage
{
    public partial class PaymentMainPg
    {
        [FindsBy(How = How.XPath, Using = "//h2[normalize-space() = 'There are no items in your basket']")]
        public IWebElement TitleThereAreNoItemsInYourBasket;
    }
}
