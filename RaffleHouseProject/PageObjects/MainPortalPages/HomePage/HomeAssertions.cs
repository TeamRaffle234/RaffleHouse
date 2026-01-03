using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace RaffleHouseProject.PageObjects.MainPortalPages.HomePage
{
    public partial class Home
    {
        [AllureStep("Verify title on hero video")]
        public Home VerifyTitleOnHeroVideo()
        {
            string getTitleValueFromHeroVideoActualResult = GetTitleValueFromHeroVideoActualResult();
            Assert.AreEqual(getTitleValueFromHeroVideoActualResult, TitleFromHeroVideoExpectedResult());

            return this;
        }
    }
}