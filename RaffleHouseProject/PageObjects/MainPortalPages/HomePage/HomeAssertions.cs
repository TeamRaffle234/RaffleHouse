using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class HomeMainPg
    {
        [AllureStep("Verify are equal title on hero video")]
        public HomeMainPg VerifyAreEqualTitleOnHeroVideo()
        {
            string getTitleValueFromHeroVideoActualResult = GetTitleValueFromHeroVideoActualResult();
            Assert.AreEqual(getTitleValueFromHeroVideoActualResult, homePageIfOnlyBasicDreamHomeRaffle.SectionHeroVideo.Title);
            Console.WriteLine($"Title on hero video: {getTitleValueFromHeroVideoActualResult}");

            return this;
        }
    }
}