using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace OrangeHRM_xUnit.Setups
{
    public class Setup : IDisposable
    {
        protected IWebDriver driver;

        public Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
