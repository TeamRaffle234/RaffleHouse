using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.TicketSelectorPage
{
    public partial class TicketSelector
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'ticket-selector-page']//h1[text() = 'Your Dream Home is up for grabs. A ticket today enters you into this month’s draw. Someone’s got to win!']")]
        public IWebElement TitleYourDreamHomeIsUpForGrabs;
    }
}
