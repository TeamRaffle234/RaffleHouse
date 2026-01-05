using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage
{
    public partial class Payment
    {
        [AllureStep("Verify title There are no items in your basket")]
        public Payment VerifyTitleThereAreNoItemsInYourBasket()
        {
            WaitUntil.StaticElementIsVisible(TitleThereAreNoItemsInYourBasket);
            Assert.IsTrue(Title.IsVisible(TitleThereAreNoItemsInYourBasket));

            return this;
        }
    }
}
