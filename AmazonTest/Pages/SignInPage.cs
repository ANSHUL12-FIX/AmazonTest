using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTest.Pages
{
    public class SignInPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly string url = "https://www.amazon.in/-/hi/ap/signin?openid.pape.max_auth_age=3600&openid.return_to=https%3A%2F%2Fwww.amazon.in%2Fspr%2Freturns%2Fgift&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=amzn_psr_desktop_in&openid.mode=checkid_setup&language=en_IN&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0";
       
        public SignInPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void NavigateTo()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmailOrMobile(string emailOrMobile)
        {
            var emailInput = driver.FindElement(By.Id("ap_email"));
            emailInput.SendKeys(emailOrMobile);
        }

        public void EnterPassword(string password)
        {
            var passwordInput = driver.FindElement(By.Id("ap_password"));
            passwordInput.SendKeys(password);
        }

        public void ClickSignInButton()
        {
            var signInButton = driver.FindElement(By.Id("signInSubmit"));
            signInButton.Click();
        }

        public void ClickForgotPasswordLink()
        {
            var forgotPasswordLink = driver.FindElement(By.Id("auth-fpp-link-bottom"));
            forgotPasswordLink.Click();
        }

        public void ClickCreateAccountLink()
        {
            var createAccountLink = driver.FindElement(By.Id("createAccountSubmit"));
            createAccountLink.Click();
        }
        public bool IsSignInErrorDisplayed()
        {
            try
            {
                var error = driver.FindElement(By.XPath("//span[@class='a-list-item']"));
                return error.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsEmailErrorDisplayed()
        {
            try
            {
                var error = driver.FindElement(By.Id("auth-email-missing-alert"));
                return error.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsPasswordErrorDisplayed()
        {
            try
            {
                var error = driver.FindElement(By.Id("auth-password-missing-alert"));
                return error.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsLoaded()
        {
            // Verify if the sign-in button is present on the sign-in page
            try
            {
                wait.Until(d => d.FindElement(By.Id("signInSubmit")).Displayed);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }
    }
}
