using NUnit.Allure.Steps;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
{
    public partial class SignIn
    {
        [AllureStep("Verify Title Sign in page")]
        public SignIn VerifyTitleSignIn()
        {
            Assert.IsTrue(Title.IsVisible(TitleSignIn));

            return this;
        }

        [AllureStep("Verify Text Dont have an account?")]
        public SignIn VerifyTextDontHaveAnAccount()
        {
            Assert.IsTrue(Text.IsVisible(TextDontHaveAnAccount));

            return this;
        }

        [AllureStep("Verify Button name sign up here")]
        public SignIn VerifyButtonNameSignUpHere()
        {
            Assert.IsTrue(ButtonName.IsVisible(ButtonNameSignUpHere));

            return this;
        }
    }
}
