using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.OurWinnersPage
{
    public partial class OurWinnersMainsPg
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'winners-wrap']//div[@class = 'winnersDateWrapper']//h1[text() = 'Meet our winners']")]
        public IWebElement TitleMeetOurWinners;
    }
}
