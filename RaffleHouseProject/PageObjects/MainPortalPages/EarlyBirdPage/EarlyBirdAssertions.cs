using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.EarlyBirdPage
{
    public partial class EarlyBirdMainPg
    {
        [AllureStep("Verify are equal title on hero video")]
        public EarlyBirdMainPg VerifyAreEqualTitleOnHeroVideo()
        {
            string getTitleValueFromHeroVideoActualResult = GetTitleValueFromHeroVideoActualResult();
            Assert.AreEqual(getTitleValueFromHeroVideoActualResult, earlyBirdObject.SectionHeroVideo.Title);
            Console.WriteLine($"Title on hero video: {getTitleValueFromHeroVideoActualResult}");

            return this;
        }
    }
}
