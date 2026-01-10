using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SubscriptionsPage
{
    public partial class SubscriptionsMainPg
    {
        [AllureStep("Verify Title Never miss your chance to deam big and do good")]
        public SubscriptionsMainPg VerifyTitleNeverMissYourChanceToDreamBigAndDoGood()
        {
            WaitUntil.StaticElementIsVisible(TitleNeverMissYourChanceToDreamBigAndDoGood);
            Assert.IsTrue(Title.IsVisible(TitleNeverMissYourChanceToDreamBigAndDoGood));

            return this;
        }
    }
}
