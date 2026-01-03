using OpenQA.Selenium;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class Home
    {
        public IWebElement TitleFromHeroVideoExpectedResult()
        {
            HomePageIfOnlyBasicDreamHomeRaffle homePageIfOnlyBasicDreamHomeRaffle = HomePageIfOnlyBasicDreamHomeRaffle.Generate();

            var xpath = "//section[@class = 'hero-block']//div[@class = 'hero-block__tabpanels']//div[@id = 'tour-tabpanel']//div[@class = 'main-image-block']//div//div[@class = 'video-block-heading']//p[text() = '" + homePageIfOnlyBasicDreamHomeRaffle.SectionHeroVideo.Title + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        [FindsBy(How = How.XPath, Using = "//section[@class = 'hero-block']//div[@class = 'hero-block__tabpanels']//div[@id = 'tour-tabpanel']//div[@class = 'main-image-block']//div//div[@class = 'video-block-heading']//p")]
        public IWebElement TitleFromHeroVideoActualResult;
    }
}
