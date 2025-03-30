using OpenQA.Selenium;

namespace OrangeHRM_xUnit.Pages
{
    public class LandingPage
    {
        private readonly string _baseUrl = "https://opensource-demo.orangehrmlive.com";
        private readonly IWebDriver _driver;
        private readonly By _usernameField = By.Name("username");
        private readonly By _passwordField = By.Name("password");
        private readonly By _loginButton = By.CssSelector("[type=submit]");

        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLandingPage()
        {
            _driver.Navigate().GoToUrl(_baseUrl);
        }

        public void DoLogin(string username, string password)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
            _driver.FindElement(_passwordField).SendKeys(password);
            _driver.FindElement(_loginButton).Click();
        }

        public void VerifyValidLogin()
        {
            Assert.Contains("dashboard", _driver.Url);
        }
    }
}
