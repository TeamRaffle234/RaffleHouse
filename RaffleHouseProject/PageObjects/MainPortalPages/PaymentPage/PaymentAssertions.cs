using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;
using RaffleHouseProject.PageObjects.MainPortalPages.SigInPage;

namespace RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage
{
    public partial class PaymentPg
    {
        [AllureStep("Verify Title Sign in page")]
        public PaymentPg VerifyTitleThereAreNoItemsInYourBasket()
        {
            WaitUntil.StaticElementIsVisible(TitleThereAreNoItemsInYourBasket);
            Assert.IsTrue(Title.IsVisible(TitleThereAreNoItemsInYourBasket));

            return this;
        }
    }
}
