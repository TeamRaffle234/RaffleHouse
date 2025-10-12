using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.UsersPortalPages.SigInPage
{
    public partial class SignIn
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement TitleName;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']]")]
        public IWebElement FieldInputPassword;
    }
}