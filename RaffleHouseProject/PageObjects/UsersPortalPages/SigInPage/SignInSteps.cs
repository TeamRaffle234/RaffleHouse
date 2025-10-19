using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
{
    public partial class SignIn
    {
        [AllureStep("Authorize verify as a user without phone")]
        public SignIn AuthorizeVerifyUserWithoutPhone()
        {
            VerifyTitleSignIn();
            VerifyTextDontHaveAnAccount();
            VerifyButtonNameSignUpHere();
            //Verify Google button
            //Verify Apple button
            VerifyTitleDreamHome();
            VerifyTextFirstForDreamHomeBox();
            VerifyTextSecondForDreamHomeBox();

            return this;
        }
    }
}
