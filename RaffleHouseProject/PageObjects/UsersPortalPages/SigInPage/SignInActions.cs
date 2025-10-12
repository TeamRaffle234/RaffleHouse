using NUnit.Allure.Attributes;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.UsersPortalObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
{
    public partial class SignIn
    {
        UserBuyer userBuyer = UserBuyer.Generate();

        [AllureStep("Enter email")]
        public SignIn EnterEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, userBuyer.UserAlreadyCreatedWihtoutPhone.Email);

            return this;
        }
    }
}
