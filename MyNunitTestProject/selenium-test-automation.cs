using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Demo
{
    class Selenium_Demo
    {
        readonly String test_url = "https://www.google.com";

        IWebDriver driver;

        [SetUp]
        public void Start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(100);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));

            searchButton.Click();

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void Close_Browser()
        {
            driver.Quit();
        }
    }
}