using NUnit.Allure.Attributes;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenuMainSite
    {
        [AllureStep("Transitions from burger menu to pages")]
        public BurgerMenuMainSite TransitionsFromBurgerMenuToPages()
        {
            ClickButtonIconCart();
            PagesMainSite.PaymentMainPg
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
            PagesMainSite.SignInMainPg
                .VerifyTitleSignIn();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonSignUp();
            PagesMainSite.SignUpForAnAccountMainPg
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
            PagesMainSite.EarlyBirdMainPg
                .VerifyAreEqualTitleOnHeroVideo();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            ClickButtonOurCharityPartners();
            PagesMainSite.CharityMainPg
                .VerifyTitleDiscoverTheRaffleHouseCharityRaffle();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            PagesMainSite.BurgerMenuMainSite
                .ClickButtonOurWinners();
            PagesMainSite.OurWinnersMainsPg
                .VerifyTitleMeetOurWinners();
            PagesMainSite.HeaderMainSite
                .ClickButtonHamburger();
            PagesMainSite.BurgerMenuMainSite
                .ClickButtonRaffleHouseSubscriptions();
            PagesMainSite.SubscriptionsMainPg
                .VerifyTitleNeverMissYourChanceToDreamBigAndDoGood();


            return this;
        }
    }
}
