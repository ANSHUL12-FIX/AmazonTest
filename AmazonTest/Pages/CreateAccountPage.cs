using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonTest.Pages
{
    public class CreateAccountPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CreateAccountPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void EnterName(string name)
        {
            var nameInput = driver.FindElement(By.Id("ap_customer_name"));
            nameInput.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            var emailInput = driver.FindElement(By.Id("ap_email"));
            emailInput.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            var passwordInput = driver.FindElement(By.Id("ap_password"));
            passwordInput.SendKeys(password);
        }

        public void ReenterPassword(string password)
        {
            var reenterPasswordInput = driver.FindElement(By.Id("ap_password_check"));
            reenterPasswordInput.SendKeys(password);
        }

        public void ClickCreateAccountButton()
        {
            var createAccountButton = driver.FindElement(By.Id("continue"));
            createAccountButton.Click();

        }
    }
}
