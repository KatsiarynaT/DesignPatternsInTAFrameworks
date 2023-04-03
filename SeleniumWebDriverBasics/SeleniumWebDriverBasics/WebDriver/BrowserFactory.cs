using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using static SeleniumWebDriverBasics.Utilities.BrowserList;

namespace SeleniumWebDriverBasics.WebDriver
{
    public class BrowserFactory
    {
        public static IWebDriver GetDriver(BrowserType type, int timeoutSec)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.Chrome:
                    {
                        var service = ChromeDriverService.CreateDefaultService();
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeoutSec));
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        var service = FirefoxDriverService.CreateDefaultService();
                        var options = new FirefoxOptions();
                        driver = new FirefoxDriver(service, options, TimeSpan.FromSeconds(timeoutSec));
                        break;
                    }
                case BrowserType.RemoteFirefox:
                    {
                        var option = new FirefoxOptions();
                        option.AddArgument("disable-infobars");
                        option.AddArgument("--no-sandbox");
                        driver = new RemoteWebDriver(new Uri("http://localhost:6656/wd/hub"), option.ToCapabilities());
                        break;
                    }
                case BrowserType.RemoteChrome:
                    {
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        option.AddArgument("--no-sandbox");
                        driver = new RemoteWebDriver(new Uri("http://localhost:6656/wd/hub"), option.ToCapabilities());
                        break;
                    }
            }

            return driver;
        }
    }
}