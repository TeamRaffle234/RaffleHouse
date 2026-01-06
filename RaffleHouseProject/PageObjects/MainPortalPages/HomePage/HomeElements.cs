using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class HomeMainPg
    {
        [FindsBy(How = How.XPath, Using = "//section[@class = 'hero-block']//div[@class = 'hero-block__tabpanels']//div[@id = 'tour-tabpanel']//div[@class = 'main-image-block']//div//div[@class = 'video-block-heading']//p")]
        public IWebElement TitleFromHeroVideoActualResult;
    }
}
