using NUnit.Framework;
using AmazonTest.Base;
using AmazonTest.Pages;

namespace AmazonTest.Tests
{
    [TestFixture]
    public class AmazonCreateAccountTest : TestBase
    {
        [Test]
        public void CreateAmazonAccount_StepByStep()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("new_user@example.com");
            createAccountPage.EnterPassword("new_user_password");
            createAccountPage.ReenterPassword("new_user_password");
            createAccountPage.ClickCreateAccountButton();

            // Add verification logic for account creation process
        }
        [Test]
        public void CreateAccountWithInvalidEmail()
        {
            // Navigate to the create account page
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            // Enter account details with invalid email
            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("invalid_email");
            createAccountPage.EnterPassword("new_user_password");
            createAccountPage.ReenterPassword("new_user_password");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for invalid email
        }
        [Test]
        public void ValidateEmptyNameField()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("");
            createAccountPage.EnterEmail("valid_email@example.com");
            createAccountPage.EnterPassword("valid_password");
            createAccountPage.ReenterPassword("valid_password");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for empty name field
        }

        [Test]
        public void ValidateEmptyEmailField()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("");
            createAccountPage.EnterPassword("valid_password");
            createAccountPage.ReenterPassword("valid_password");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for empty email field
        }

        [Test]
        public void ValidateEmptyPasswordField()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("valid_email@example.com");
            createAccountPage.EnterPassword("");
            createAccountPage.ReenterPassword("");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for empty password field
        }

        [Test]
        public void ValidatePasswordStrength()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("valid_email@example.com");
            createAccountPage.EnterPassword("123");
            createAccountPage.ReenterPassword("123");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for weak password
        }

        [Test]
        public void ValidateEmptyReenterPasswordField()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickCreateAccountLink();

            var createAccountPage = new CreateAccountPage(driver, wait);
            createAccountPage.EnterName("New User");
            createAccountPage.EnterEmail("valid_email@example.com");
            createAccountPage.EnterPassword("valid_password");
            createAccountPage.ReenterPassword("");
            createAccountPage.ClickCreateAccountButton();

            // Add assertion to verify error message for empty re-enter password field
        }

    }
}
