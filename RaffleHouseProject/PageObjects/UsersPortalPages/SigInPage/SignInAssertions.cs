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

        [AllureStep("Verify Title Dream Home in box")]
        public SignIn VerifyTitleDreamHome()
        {
            Assert.IsTrue(Text.IsVisible(TitleDreamHome));

            return this;
        }

        [AllureStep("Verify Text first for Dream Home in box")]
        public SignIn VerifyTextFirstForDreamHomeBox()
        {
            Assert.IsTrue(Text.IsVisible(TextFirstForDreamHomeBox));

            return this;
        }

        [AllureStep("Verify Text second for Dream Home in box")]
        public SignIn VerifyTextSecondForDreamHomeBox()
        {
            Assert.IsTrue(Text.IsVisible(TextSecondForDreamHomeBox));

            return this;
        }
    }
}
