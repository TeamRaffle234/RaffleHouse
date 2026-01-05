using NUnit.Allure.Steps;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignIn
    {
        [AllureStep("Verify Title Sign in page")]
        public SignIn VerifyTitleSignIn()
        {
            WaitUntil.StaticElementIsVisible(TitleSignIn);
            Assert.IsTrue(Title.IsVisible(TitleSignIn));

            return this;
        }

        [AllureStep("Verify Text Dont have an account?")]
        public SignIn VerifyTextDontHaveAnAccount()
        {
            WaitUntil.StaticElementIsVisible(TextDontHaveAnAccount);
            Assert.IsTrue(Text.IsVisible(TextDontHaveAnAccount));

            return this;
        }

        [AllureStep("Verify Button name sign up here")]
        public SignIn VerifyButtonNameSignUpHere()
        {
            WaitUntil.WaitForElementToBeClickableAndVisible(ButtonNameSignUpHere);
            Assert.IsTrue(ButtonName.IsVisible(ButtonNameSignUpHere));

            return this;
        }

        [AllureStep("Verify Button name Google Sign in")]
        public SignIn VerifyButtonNameGoogleSignIn()
        {
            WaitUntil.WaitForElementToBeClickableAndVisible(ButtonGoogleNameSignIn);
            Assert.IsTrue(ButtonGoogleNameSignIn.Displayed);

            string buttonText = ButtonGoogleNameSignIn.Text;
            Console.WriteLine($"Button name: Google {buttonText}");

            return this;
        }

        [AllureStep("Verify Button name Apple Sign in")]
        public SignIn VerifyButtonNameAppleSignIn()
        {
            WaitUntil.WaitForElementToBeClickableAndVisible(ButtonAppleNameSignIn);
            Assert.IsTrue(ButtonAppleNameSignIn.Displayed);

            string buttonText = ButtonAppleNameSignIn.Text;
            Console.WriteLine($"Button name: Apple {buttonText}");

            return this;
        }

        [AllureStep("Verify Title Dream Home in box")]
        public SignIn VerifyTitleDreamHome()
        {
            WaitUntil.StaticElementIsVisible(TitleDreamHome);
            Assert.IsTrue(Text.IsVisible(TitleDreamHome));

            return this;
        }

        [AllureStep("Verify Text first for Dream Home in box")]
        public SignIn VerifyTextFirstForDreamHomeBox()
        {
            WaitUntil.StaticElementIsVisible(TextFirstForDreamHomeBox);
            Assert.IsTrue(Text.IsVisible(TextFirstForDreamHomeBox));

            return this;
        }

        [AllureStep("Verify Text second for Dream Home in box")]
        public SignIn VerifyTextSecondForDreamHomeBox()
        {
            WaitUntil.StaticElementIsVisible(TextSecondForDreamHomeBox);
            Assert.IsTrue(Text.IsVisible(TextSecondForDreamHomeBox));

            return this;
        }

        [AllureStep("Verify button name Forgot pssword?")]
        public SignIn VerifyButtonForgotPassword()
        {
            WaitUntil.WaitForElementToBeClickableAndVisible(ButtonForgotPassword);
            Assert.IsTrue(ButtonName.IsVisible(ButtonForgotPassword));

            return this;
        }
    }
}
