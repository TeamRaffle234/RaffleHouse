using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignInPg
    {
        UserBuyerObject userBuyerObject = UserBuyerObject.Generate();

        [AllureStep("Enter email user without phone")]
        public SignInPg EnterEmailUserWithoutPhoneFirst()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmail, userBuyerObject.UserAlreadyCreatedWihtoutPhone.Email);
            Console.WriteLine($"Email field");

            return this;
        }

        [AllureStep("Enter password minimum length")]
        public SignInPg EnterPasswordMinimumLength()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPassword, userBuyerObject.UserAlreadyCreatedWihtoutPhone.PasswordMinimumLength);
            Console.WriteLine($"Password field");

            return this;
        }

        [AllureStep("Click icon eye for field input password")]
        public SignInPg ClickIconEyeForFieldInputPassword()
        {
            Button.Click(IconEyeForFieldInputPassword);
            Console.WriteLine($"Icon button in the form eye for password field");

            return this;
        }

        [AllureStep("Click button Sign in via email")]
        public SignInPg ClickButtonSignInViaEmail()
        {
            Button.Click(ButtonSignInViaEmail);
            Console.WriteLine($"Sign in button");

            return this;
        }

        [AllureStep("Check box RememberMe")]
        public SignInPg CheckBoxRememberMe()
        {
            Button.Click(CheckBoxContainerRememberMe);
            Console.WriteLine($"Check box RememberMe");

            return this;
        }

        [AllureStep("Click button Forgot password?")]
        public SignInPg ClickButtonForgotPassword()
        {
            Button.Click(ButtonForgotPassword);
            Console.WriteLine($"Button Forgot password?");

            return this;
        }
    }
}
