using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleHouseProject.GuiHelpers;

namespace RaffleHouseProject.PageObjects.MainPortalPages.PaymentPage
{
    public partial class PaymentMainPg
    {
        [AllureStep("Verify title Payment page")]
        public PaymentMainPg VerifyTitleThereAreNoItemsInYourBasket()
        {
            WaitUntil.StaticElementIsVisible(TitleThereAreNoItemsInYourBasket);
            Assert.IsTrue(Title.IsVisible(TitleThereAreNoItemsInYourBasket));

            return this;
        }
    }
}
