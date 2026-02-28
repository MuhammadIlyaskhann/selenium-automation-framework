using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Muhammad.Automation.Framework.Drivers;

public class DriverManager
{
    public static IWebDriver CreateDriver(string browser = "chrome")
    {
        return browser.ToLower() switch
        {
            "chrome" => new ChromeDriver(),
            _ => throw new ArgumentException("Browser not supported")
        };
    }
}