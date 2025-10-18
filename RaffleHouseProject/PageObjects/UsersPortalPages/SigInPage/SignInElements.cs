using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
{
    public partial class SignIn
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'loginGroupSignIn']//h1[text() = 'Sign in']")]
        public IWebElement TitleSignIn;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'signInHere']//span[text() = 'Don`t have an account?']")]
        public IWebElement TextDontHaveAnAccount;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'signInHere']//a[text() = 'sign up here']")]
        public IWebElement ButtonNameSignUpHere;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']]")]
        public IWebElement FieldInputPassword;
    }
}