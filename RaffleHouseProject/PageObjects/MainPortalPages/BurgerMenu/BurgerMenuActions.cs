using NUnit.Allure.Steps;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.ObjectsData.MainPortalObjects;
using System;

namespace RaffleHouseProject.PageObjects.MainPortalPages.BurgerMenu
{
    public partial class BurgerMenuMainSite
    {
        #region Header

        [AllureStep("Click button icon Cart in burger menu")]
        public BurgerMenuMainSite ClickButtonIconCart()
        {
            Button.Click(ButtonIconCart);
            Console.WriteLine($"Cart icon button in burger menu");

            return this;
        }

        [AllureStep("Click button icon close form cross in burger menu")]
        public BurgerMenuMainSite ClickButtonIconCloseFormCross()
        {
            Button.Click(ButtonIconCloseFormCross);
            Console.WriteLine($"Cross icon button in burger menu");

            return this;
        }

        [AllureStep("Click button logo Raffle House")]
        public BurgerMenuMainSite ClickButtonLogoRaffleHouse()
        {
            Button.Click(ButtonLogoRaffleHouse);
            Console.WriteLine($"Logo Raffle House icon button in burger menu");

            return this;
        }

        #endregion

        #region Basic items

        [AllureStep("Click button Login in burger menu")]
        public BurgerMenuMainSite ClickButtonLogIn()
        {
            Button.Click(ButtonLogIn);
            Console.WriteLine($"Login button in burger menu");

            return this;
        }

        [AllureStep("Click button Sign up in burger menu")]
        public BurgerMenuMainSite ClickButtonSignUp()
        {
            Button.Click(ButtonSignUp);
            Console.WriteLine($"Sign up button in burger menu");

            return this;
        }

        [AllureStep("Click button Buy a ticket in burger menu")]
        public BurgerMenuMainSite ClickButtonBuyATicket()
        {
            Button.Click(ButtonBuyATicket);
            Console.WriteLine($"Buy a ticket button in burger menu");

            return this;
        }

        [AllureStep("Click button Early Bird in burger menu")]
        public BurgerMenuMainSite ClickButtonEarlyBird()
        {
            Button.Click(ButtonEarlyBird);
            Console.WriteLine($"Early Bird button in burger menu");

            return this;
        }

        #endregion
    }
}
