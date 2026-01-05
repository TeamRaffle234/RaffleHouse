using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SigInPage
{
    public partial class SignIn
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'loginGroupSignIn']//h1[text() = 'Sign in']")]
        public IWebElement TitleSignIn;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Don’t have an account?']")]
        public IWebElement TextDontHaveAnAccount;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'social-auth-wrap']//button[@class = 'social-btn social-g-btn']//span[text() = 'Sign In']")]
        public IWebElement ButtonGoogleNameSignIn;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'social-auth-wrap']//button[@class = 'social-btn social-ap-btn']//span[text() = 'Sign In']")]
        public IWebElement ButtonAppleNameSignIn;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'signInHere']//a[text() = 'sign up here']")]
        public IWebElement ButtonNameSignUpHere;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        public IWebElement FieldInputPassword;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement IconEyeForFieldInputPassword;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'Dream Home']")]
        public IWebElement TitleDreamHome;

        [FindsBy(How = How.XPath, Using = "//div[@class='sign-in-subtitles']/following-sibling::p[text() = \"This is your chance to win your own home, Stamp Duty and legal fees paid while donating to worthy causes. We'll even chuck in your bills and utility costs for a year.\"]")]
        public IWebElement TextFirstForDreamHomeBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='sign-in-subtitles']/following-sibling::p/span[text() = \"Be mortgage-free for life; live in it, rent it, or sell it — it'll be yours, no strings attached.\"]")]
        public IWebElement TextSecondForDreamHomeBox;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sign-in-button']")]
        public IWebElement ButtonSignInViaEmail;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'agreeRemebmer']//span[text() = 'Remember me']")]
        public IWebElement CheckBoxContainerRememberMe;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'agreeRemebmer']//span[text() = 'Forgot password?']")]
        public IWebElement ButtonForgotPassword;
    }
}