using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Muhammad.Automation.Framework.Drivers;

public class DriverManager
{
    public static IWebDriver CreateDriver(string browser)
    {
        if (browser.ToLower() == "chrome")
        {
            var options = new ChromeOptions();

            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");

            return new ChromeDriver(options);
        }

        throw new ArgumentException("Browser not supported");
    }
}