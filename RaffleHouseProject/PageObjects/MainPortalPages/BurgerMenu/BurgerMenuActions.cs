using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenu
    {
        #region Header

        [AllureStep("Click button icon Cart in burger menu")]
        public BurgerMenu ClickButtonIconCart()
        {
            Button.Click(ButtonIconCart);

            return this;
        }

        [AllureStep("Click button icon close form cross in burger menu")]
        public BurgerMenu ClickButtonIconCloseFormCross()
        {
            Button.Click(ButtonIconCloseFormCross);

            return this;
        }

        [AllureStep("Click button logo Raffle House")]
        public BurgerMenu ClickButtonLogoRaffleHouse()
        {
            Button.Click(ButtonLogoRaffleHouse);

            return this;
        }

        #endregion

        [AllureStep("Click button Login in burger menu")]
        public BurgerMenu ClickButtonLogIn()
        {
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("Click button Sign up in burger menu")]
        public BurgerMenu ClickButtonSignUp()
        {
            Button.Click(ButtonSignUp);

            return this;
        }

        [AllureStep("Click button Sign up in burger menu")]
        public BurgerMenu ClickButtonSignUpButtonBuyATicket()
        {
            Button.Click(ButtonBuyATicket);

            return this;
        }
    }
}
