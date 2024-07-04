using NUnit.Framework;
using AmazonTest.Base;
using AmazonTest.Pages;
using AmazonTest.Config;
using OpenQA.Selenium;

namespace AmazonTest.Tests
{
    [TestFixture]
    public class AmazonSignInTest : TestBase
    {
        [Test]
        public void SignInWithValidCredentials()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.EnterEmailOrMobile(GlobalConfig.Email);
            signInPage.EnterPassword(GlobalConfig.Password);
            signInPage.ClickSignInButton();

            // Add verification logic to confirm successful sign-in
        }

        [Test]
        public void SignInWithInvalidCredentials()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.EnterEmailOrMobile("invalid@example.com");
            signInPage.EnterPassword("invalid_password");
            signInPage.ClickSignInButton();
        }
        [Test]
        public void SignInEmptyEmail()
        {
            // Navigate to the sign-in page
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();

            // Leave email field empty
            signInPage.EnterEmailOrMobile("");
            signInPage.EnterPassword("valid_password");

            // Click on the sign-in button
            signInPage.ClickSignInButton();

            // Add assertion to verify error message for empty email field
        }
        [Test]
        public void SignInEmptyPassword()
        {
            // Navigate to the sign-in page
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();

            // Leave password field empty
            signInPage.EnterEmailOrMobile("valid_email@example.com");
            signInPage.EnterPassword("");

            // Click on the sign-in button
            signInPage.ClickSignInButton();
        }


        [Test]
        public void NavigateToCreateAccount()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();
        }

        [Test]
        public void NavigateToForgotPassword()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickForgotPasswordLink();
        }
        [Test]
        public void LogoutAndRedirectToSignIn()
        {
            // Sign in first
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.EnterEmailOrMobile(GlobalConfig.Email);
            signInPage.EnterPassword(GlobalConfig.Password);
            signInPage.ClickSignInButton();

            var homePage = new HomePage(driver, wait);
            Assert.That(homePage.IsLoaded(), "Failed to navigate to the Amazon home page after sign-in.");

            // Perform logout
            homePage.Logout();

            bool isRedirectedToSignIn = wait.Until(d => d.Url.Contains("https://www.amazon.in/ap/signin"));
            Assert.That(isRedirectedToSignIn, "Failed to redirect to the sign-in page after logout.");
        }
    }
}
