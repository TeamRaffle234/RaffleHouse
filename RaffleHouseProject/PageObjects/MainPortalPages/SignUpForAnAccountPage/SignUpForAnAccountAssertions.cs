using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SignUpForAnAccountPage
{
    public partial class SignUpForAnAccountPg
    {
        [AllureStep("Verify Title Sign-up for an account page")]
        public SignUpForAnAccountPg VerifyTitleSignUpForAnAccount()
        {
            WaitUntil.StaticElementIsVisible(TitleSignUpForAnAccount);
            Assert.IsTrue(Title.IsVisible(TitleSignUpForAnAccount));

            return this;
        }
    }
}
