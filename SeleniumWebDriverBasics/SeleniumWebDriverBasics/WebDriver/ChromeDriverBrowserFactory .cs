using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverBasics.WebDriver
{
    public class ChromeDriverBrowserFactory : IDriver
    {
        private IWebDriver driver = null;

        public IWebDriver Driver
        {
            get 
            {
                if (driver==null)
                {
                    var service = ChromeDriverService.CreateDefaultService();
                    var option = new ChromeOptions();
                    option.AddArgument("disable-infobars");
                    driver = new ChromeDriver(service, option);
                }

                return driver; 
            }
        }
    }
}