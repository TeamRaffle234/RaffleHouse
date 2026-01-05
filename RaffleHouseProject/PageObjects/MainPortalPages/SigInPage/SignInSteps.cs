using NUnit.Allure.Steps;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignIn
    {
        [AllureStep("Authorize verify as a user without phone")]
        public SignIn AuthorizeVerifyUserWithoutPhone()
        {
            VerifyTitleSignIn();
            VerifyTextDontHaveAnAccount();
            VerifyButtonNameSignUpHere();
            VerifyButtonNameGoogleSignIn();
            VerifyButtonNameAppleSignIn();
            VerifyTitleDreamHome();
            VerifyTextFirstForDreamHomeBox();
            VerifyTextSecondForDreamHomeBox();
            EnterEmailUserWithoutPhoneFirst();
            EnterPasswordMinimumLength();
            //ClickIconEyeForFieldInputPassword();
            CheckBoxRememberMe();
            VerifyButtonForgotPassword();
            ClickButtonSignInViaEmail();

            return this;
        }
    }
}
