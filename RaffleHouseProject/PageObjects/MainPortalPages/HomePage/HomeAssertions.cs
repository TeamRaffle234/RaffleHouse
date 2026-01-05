using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class Home
    {
        [AllureStep("Verify title on hero video")]
        public Home VerifyTitleOnHeroVideo()
        {
            string getTitleValueFromHeroVideoActualResult = GetTitleValueFromHeroVideoActualResult();
            Assert.AreEqual(getTitleValueFromHeroVideoActualResult, homePageIfOnlyBasicDreamHomeRaffle.SectionHeroVideo.Title);
            Console.WriteLine($"Title on hero video: {getTitleValueFromHeroVideoActualResult}");

            return this;
        }
    }
}