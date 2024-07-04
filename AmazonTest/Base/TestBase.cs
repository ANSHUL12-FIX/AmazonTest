using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmazonTest.Base
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
           
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Initialize WebDriverWait with a timeout of 10 seconds
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Implicit wait for the entire driver session
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Add a fixed delay of 5 seconds after opening the browser
           /* Thread.Sleep(5000);*/

            // Alternatively, you can wait for a specific condition
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            // Navigate to the Amazon sign-in page
            driver.Navigate().GoToUrl("https://www.amazon.in/-/hi/ap/signin?openid.pape.max_auth_age=3600&openid.return_to=https%3A%2F%2Fwww.amazon.in%2Fspr%2Freturns%2Fgift&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=amzn_psr_desktop_in&openid.mode=checkid_setup&language=en_IN&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0");

            // Check for CAPTCHA and pause for manual solving if present
            if (IsCaptchaPresent())
            {
                PauseForManualCaptcha();
            }
        }

            [TearDown]
        public void TearDown()
        {
            /*  if (driver != null)
              {
                  *//*Thread.Sleep(5000);*//*

                  driver?.Quit();
                  driver?.Dispose();
              }*/
          /*  Thread.Sleep(5000);*/
            driver?.Quit();
            driver?.Dispose();
        }
        protected bool IsCaptchaPresent()
        {
            try
            {
                // Update the XPath to match the CAPTCHA element on Amazon
                return driver.FindElement(By.XPath("//*[contains(@src, 'captcha')]")).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        protected void PauseForManualCaptcha()
        {
            Console.WriteLine("CAPTCHA detected. Please solve the CAPTCHA and then press any key to continue...");
            Console.ReadKey();
        }
    }
}
