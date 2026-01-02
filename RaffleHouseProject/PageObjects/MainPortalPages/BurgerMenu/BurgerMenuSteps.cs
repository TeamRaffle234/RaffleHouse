using NUnit.Allure.Attributes;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        [AllureStep("Verify elements in header")]
        public BurgerMenu VerifyElementsInHeader()
        {
            VerifyButtonIconCloseFormCross();
            VerifyButtonLogoRaffleHouse();
            VerifyButtonIconCart();

            return this;
        }
    }
}
