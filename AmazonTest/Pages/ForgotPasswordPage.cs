using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.Pages
{
    public class ForgotPasswordPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ForgotPasswordPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void EnterEmail(string email)
        {
            var emailInput = driver.FindElement(By.Id("ap_email"));
            emailInput.SendKeys(email);
        }

        public void ClickContinueButton()
        {
            var continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();
            System.Threading.Thread.Sleep(15000); // Wait for the next page to load
        }

        internal object GetValidationBoxText()
        {
            throw new NotImplementedException();
        }
    }
}
