using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VICR.Registration.Pages;

namespace VICR.Registration.Tests
{
    [Binding]
    public class CreateUVPSteps
    {
        [BeforeFeature]
        public static void Init()
        {
            AllPages.Init();
        }

        [Given(@"I am on the uvp page")]
        public void ShowUvpPage()
        {
            Assert.True(AllPages.UvpPage.Show(), "User is currently on the UVP Page");
        }

        [When(@"I create a passenger uvp for a passenger vehicle type (.*) garaged at (.*) with permit start date as today for duration (.*) days")]
        public void CreatePassengerUVP(string passengerVehicleType, string address, string permitDuration)
        {
            AllPages.UvpPage.EnterVehicleType("Passenger vehicle");
            AllPages.UvpPage.EnterPassengerVehicleType(passengerVehicleType);
            AllPages.UvpPage.EnterAddress(address);
            AllPages.UvpPage.EnterPermitStartDate(DateTime.Now);
            AllPages.UvpPage.EnterPermitDuration(permitDuration);
        }

        [When(@"I navigate to the next step to enter the permit type")]
        public void NavigateToPermitType()
        {
            AllPages.UvpPage.SubmitAndGoToNextPage();
        }

        [When(@"I select uvp permit type for preparation for registration in Victoria and click next")]
        public void SelectPermitTypeAndProceed()
        {
            AllPages.PermitTypePage.EnterPermitType("Preparation for Registration in Victoria");
            AllPages.PermitTypePage.SubmitAndGoToNextPage();
        }

        [Then(@"the page to enter vehicle details page is dispalyed")]
        public void VerifyEnterVehicleDetailsPage()
        {
            Assert.True(AllPages.VehicleDetailsPage.IsVehicleDetailsPageDisplayed());
        }

        [AfterFeature]
        public static void Dispose()
        {
            AllPages.Dispose();
        }
    }
}
