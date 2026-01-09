using NUnit.Allure.Attributes;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenuMainSite
    {
        [AllureStep("Transitions from burger menu to pages")]
        public BurgerMenuMainSite TransitionsFromBurgerMenuToPages()
        {
            ClickButtonIconCart();
            PagesMainSite.PaymentPg
                .VerifyTitleThereAreNoItemsInYourBasket();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonIconCloseFormCross();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonLogoRaffleHouse();
            PagesMainSite.HomeMainPg
                .VerifyAreEqualTitleOnHeroVideo();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonLogIn();
            PagesMainSite.SignInPg
                .VerifyTitleSignIn();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonSignUp();
            PagesMainSite.SignUpForAnAccountPg
                .VerifyTitleSignUpForAnAccount();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonBuyATicket();
            PagesMainSite.TicketSelectorMainPg
                .VerifyTitleYourDreamHomeIsUpForGrabs();
            PagesMainSite.HeaderMainSite
                .ClickLogButtonoRaffleHouse()
                .ClickButtonHamburger();
            ClickButtonEarlyBird();
            PagesMainSite.EarlyBirdPg
                .VerifyAreEqualTitleOnHeroVideo();
            PagesMainSite.HeaderMainSite
                .ClickLogButtonoRaffleHouse()
                .ClickButtonHamburger();

            return this;
        }
    }
}
