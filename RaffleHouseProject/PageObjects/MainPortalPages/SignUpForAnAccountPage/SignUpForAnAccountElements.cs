using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace RaffleHouseProject.PageObjects.MainPortalPages.SignUpForAnAccountPage
{
    public partial class SignUpForAnAccountPg
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Sign-up for an account']")]
        public IWebElement TitleSignUpForAnAccount;
    }
}
