using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.EarlyBirdPage
{
    public partial class EarlyBirdMainPg
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'bonus-draw-hero']//div[@class = 'video-block-content']//div//span")]
        public IWebElement TitleFromHeroVideoActualResult;
    }
}
