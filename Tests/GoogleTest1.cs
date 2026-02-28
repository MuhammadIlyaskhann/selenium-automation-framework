using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Muhammad.Automation.Framework;

public class BrowserTest
{
    private IWebDriver? driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void OpenGoogleTest()
    {
        driver!.Navigate().GoToUrl("https://google.com");
        Assert.That(driver.Title, Does.Contain("Google"));
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}