using NUnit.Allure.Attributes;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [AllureStep("Transitions from burger menu to pages")]
        public BurgerMenu TransitionsFromBurgerMenuToPages()
        {
            ClickButtonIconCart();
            PagesMainSite.Payment
                .VerifyTitleThereAreNoItemsInYourBasket();
            PagesMainSite.Header
                .ClickButtonHamburger();
            ClickButtonIconCloseFormCross();
            PagesMainSite.Header
                .ClickButtonHamburger();
            ClickButtonLogoRaffleHouse();
            PagesMainSite.Home
                .VerifyTitleOnHeroVideo();
            PagesMainSite.Header
                .ClickButtonHamburger();
            ClickButtonLogIn();
            PagesMainSite.SignIn
                .VerifyTitleSignIn();
            PagesMainSite.Header
                .ClickButtonHamburger();
            ClickButtonSignUp();
            PagesMainSite.SignUpForAnAccount
                .VerifyTitleSignUpForAnAccount();
            PagesMainSite.Header
                .ClickButtonHamburger();

            return this;
        }
    }
}
