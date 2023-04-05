using OpenQA.Selenium;

namespace SeleniumWebDriverBasics.WebDriver
{
    public interface IDriver
    {
        IWebDriver Driver { get; }
    }
}