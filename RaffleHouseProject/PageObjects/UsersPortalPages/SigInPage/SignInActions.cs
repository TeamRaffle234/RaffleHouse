using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.UsersPortalObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
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

        [AllureStep("Enter password basic")]
        public SignIn EnterPasswordBasic()
        {
            WaitUntil.CustomElementIsVisible(FieldInputPassword);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, userBuyer.UserAlreadyCreatedWihtoutPhone.Password);

            return this;
        }
    }
}
