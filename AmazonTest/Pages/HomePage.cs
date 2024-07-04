using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmazonTest.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly string accountLinkXPath = "//a[@id='nav-link-accountList']";
        private readonly string hamburgerMenuXPath = "//i[@class='hm-icon nav-sprite']";
        private readonly string signOutXPath = "//a[@class='hmenu-item'][normalize-space()='Sign Out']";

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public bool IsLoaded()
        {
            // Verify if the account link is present on the home page
            try
            {
                wait.Until(d => d.FindElement(By.XPath(accountLinkXPath)).Displayed);
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public void OpenHamburgerMenu()
        {
            var hamburgerMenu = wait.Until(d => d.FindElement(By.XPath(hamburgerMenuXPath)));
            hamburgerMenu.Click();
        }

        public void Logout()
        {
            OpenHamburgerMenu();

            // Wait until the sign-out link is visible in the sidebar menu
            var signOutButton = wait.Until(d => d.FindElement(By.XPath(signOutXPath)));

            // Use JavaScript to click the sign-out button
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", signOutButton);
       /*     signOutButton.Click();*/
        }
    }
}
