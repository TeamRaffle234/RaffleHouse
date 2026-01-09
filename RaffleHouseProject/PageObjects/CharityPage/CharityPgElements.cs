using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.CharityPage
{
    public partial class CharityMainPgA
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Discover the Raffle House Charity Raffle']")]
        public IWebElement TitleDiscoverTheRaffleHouseCharityRaffle;
    }
}
