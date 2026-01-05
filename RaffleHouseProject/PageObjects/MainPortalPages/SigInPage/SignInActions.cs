using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignIn
    {
        UserBuyer userBuyer = UserBuyer.Generate();

        [AllureStep("Enter email user without phone")]
        public SignIn EnterEmailUserWithoutPhoneFirst()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmail, userBuyer.UserAlreadyCreatedWihtoutPhone.Email);
            Console.WriteLine($"Email field");

            return this;
        }

        [AllureStep("Enter password minimum length")]
        public SignIn EnterPasswordMinimumLength()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPassword, userBuyer.UserAlreadyCreatedWihtoutPhone.PasswordMinimumLength);
            Console.WriteLine($"Password field");

            return this;
        }

        [AllureStep("Click icon eye for field input password")]
        public SignIn ClickIconEyeForFieldInputPassword()
        {
            Button.Click(IconEyeForFieldInputPassword);
            Console.WriteLine($"Icon button in the form eye for password field");

            return this;
        }

        [AllureStep("Click button Sign in via email")]
        public SignIn ClickButtonSignInViaEmail()
        {
            Button.Click(ButtonSignInViaEmail);
            Console.WriteLine($"Sign in button");

            return this;
        }

        [AllureStep("Check box RememberMe")]
        public SignIn CheckBoxRememberMe()
        {
            Button.Click(CheckBoxContainerRememberMe);
            Console.WriteLine($"Check box RememberMe");

            return this;
        }

        [AllureStep("Click button Forgot password?")]
        public SignIn ClickButtonForgotPassword()
        {
            Button.Click(ButtonForgotPassword);
            Console.WriteLine($"Button Forgot password?");

            return this;
        }
    }
}
