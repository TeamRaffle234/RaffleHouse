using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage
{
    public partial class PaymentPg
    {
        [AllureStep("Verify title There are no items in your basket")]
        public PaymentPg VerifyTitleThereAreNoItemsInYourBasket()
        {
            WaitUntil.StaticElementIsVisible(TitleThereAreNoItemsInYourBasket);
            Assert.IsTrue(Title.IsVisible(TitleThereAreNoItemsInYourBasket));

            return this;
        }
    }
}
