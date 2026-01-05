using NUnit.Allure.Attributes;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [AllureStep("Transitions from burger menu to pages")]
        public BurgerMenu TransitionsFromBurgerMenuToPages()
        {
            ClickButtonIconCart();
            PagesUsersPortals.Header
                .ClickButtonHamburger();
            ClickButtonIconCloseFormCross();
            PagesUsersPortals.Header
                .ClickButtonHamburger();
            ClickButtonLogoRaffleHouse();
            PagesUsersPortals.Home
                .VerifyTitleOnHeroVideo();

            return this;
        }
    }
}
