using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SignUpForAnAccountPage
{
    public partial class SignUpForAnAccount
    {
        [AllureStep("Verify Title Sign-up for an account page")]
        public SignUpForAnAccount VerifyTitleSignUpForAnAccount()
        {
            WaitUntil.StaticElementIsVisible(TitleSignUpForAnAccount);
            Assert.IsTrue(Title.IsVisible(TitleSignUpForAnAccount));

            return this;
        }
    }
}
