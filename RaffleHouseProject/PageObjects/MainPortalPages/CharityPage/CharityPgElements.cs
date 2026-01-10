using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.CharityPage
{
    public partial class CharityMainPg
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Discover the Raffle House Charity Raffle']")]
        public IWebElement TitleDiscoverTheRaffleHouseCharityRaffle;
    }
}
