using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace RaffleHouseProject.PageObjects.EarlyBirdPage
{
    public partial class EarlyBirdPg
    {
        [AllureStep("Verify title on hero video")]
        public EarlyBirdPg VerifyTitleOnHeroVideo()
        {
            string getTitleValueFromHeroVideoActualResult = GetTitleValueFromHeroVideoActualResult();
            Assert.AreEqual(getTitleValueFromHeroVideoActualResult, earlyBirdObject.SectionHeroVideo.Title);
            Console.WriteLine($"Title on hero video: {getTitleValueFromHeroVideoActualResult}");

            return this;
        }
    }
}
