using AmazonTest.Base;
using AmazonTest.Config;
using AmazonTest.Pages;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonTest.Tests
{
    [TestFixture]
    public class AmazonForgotPasswordTest : TestBase
    {
        [Test]
        public void ForgotPassword_StepByStep()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickForgotPasswordLink();

            var forgotPasswordPage = new ForgotPasswordPage(driver, wait);
            forgotPasswordPage.EnterEmail(GlobalConfig.Email);
            forgotPasswordPage.ClickContinueButton();
        }
        [Test]
        public void ForgotPassword_EmptyEmailValidationBox()
        {
            var signInPage = new SignInPage(driver, wait);
            signInPage.NavigateTo();
            signInPage.ClickForgotPasswordLink();

            var forgotPasswordPage = new ForgotPasswordPage(driver, wait);
            forgotPasswordPage.EnterEmail("");
            forgotPasswordPage.ClickContinueButton();
        }
    }
}
