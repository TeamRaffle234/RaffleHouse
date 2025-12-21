using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignIn
    {
        UserBuyer userBuyer = UserBuyer.Generate();

        [AllureStep("Enter email user without phone")]
        public SignIn EnterEmailUserWithoutPhoneFirst()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, userBuyer.UserAlreadyCreatedWihtoutPhone.Email);

            return this;
        }

        [AllureStep("Enter password minimum length")]
        public SignIn EnterPasswordMinimumLength()
        {
            WaitUntil.CustomElementIsVisible(FieldInputPassword);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, userBuyer.UserAlreadyCreatedWihtoutPhone.PasswordMinimumLength);

            return this;
        }

        [AllureStep("Click icon eye for field input password")]
        public SignIn ClickIconEyeForFieldInputPassword()
        {
            Button.Click(IconEyeForFieldInputPassword);

            return this;
        }

        [AllureStep("Click button Sign in via email")]
        public SignIn ClickButtonSignInViaEmail()
        {
            Button.Click(ButtonSignInViaEmail);

            return this;
        }
    }
}
