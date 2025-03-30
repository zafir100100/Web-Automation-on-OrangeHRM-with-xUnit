using OrangeHRM_xUnit.Pages;
using OrangeHRM_xUnit.Setups;

namespace OrangeHRM_xUnit.TestRunners
{
    public class LoginTestRunner : Setup
    {
        private LandingPage? landingPage;

        public LoginTestRunner() : base() { }

        [Fact]
        public void LoginWithValidCredentials()
        {
            landingPage = new LandingPage(driver);
            landingPage.NavigateToLandingPage();
            landingPage.DoLogin("Admin", "admin123");
            landingPage.VerifyValidLogin();
        }
    }
}
