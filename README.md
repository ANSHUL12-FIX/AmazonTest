# AmazonTest Automation Project

---
#### Project Name: AmazonTest Automation Project

#### Objective:
The objective of this test plan is to ensure the functionality and reliability of the Amazon web application by testing key features such as account creation, password recovery, search functionality, and user sign-in.

#### Test Cases:

1. **Create Account Functionality**
   - **Objective:** Verify that users can create an account successfully with valid details.
   - **Test Plan:**
     - Navigate to the create account page.
     - Enter valid user details (name, email, password).
     - Click on the create account button.
   - **Expected Result:** User should be redirected to the confirmation page after successful account creation.

2. **Password Recovery Functionality**
   - **Objective:** Verify that users can recover their password using the forgot password feature.
   - **Test Plan:**
     - Navigate to the forgot password page.
     - Enter the registered email address.
     - Click on the continue button.
   - **Expected Result:** User should receive a password recovery email.

3. **Search Functionality**
   - **Objective:** Verify that users can search for items using valid search terms.
   - **Test Plan:**
     - Navigate to the home page.
     - Enter a valid search term in the search bar.
     - Click on the search button.
   - **Expected Result:** Relevant search results should be displayed.

4. **Sign-In Functionality**
   - **Objective:** Verify that users can sign in successfully with valid credentials.
   - **Test Plan:**
     - Navigate to the sign-in page.
     - Enter valid email and password.
     - Click on the sign-in button.
   - **Expected Result:** User should be redirected to the home page after successful sign-in.

5. **Invalid Login Attempt**
   - **Objective:** Verify the behavior when users attempt to log in with invalid credentials.
   - **Test Plan:**
     - Navigate to the sign-in page.
     - Enter invalid email and/or password.
     - Click on the sign-in button.
   - **Expected Result:** Error message should be displayed indicating invalid credentials.

#### Test Plan Strategy:

- **Automation Testing:** Implement automated tests using Selenium WebDriver with NUnit for regression testing of critical functionalities.
- **Manual Testing:** Perform manual testing for exploratory testing, edge cases, and user experience validation.
- **Test Environment:** Utilize multiple browsers (Chrome, Firefox) to ensure cross-browser compatibility.
- **Test Data:** Use the `correct_search_terms.xlsx` file for search functionality tests and prepare other necessary test data for various scenarios.
- **Test Reporting:** Generate detailed test reports including test results.
- **Test Coverage:** Ensure test coverage for all functional requirements and user stories related to account management, search functionality, and authentication.

#### Project Structure

The project is organized into the following folders:

- **Base**: Contains base classes for test setup and teardown.
  - `TestBase.cs`: Contains setup and teardown methods for the tests.

- **Helpers**: Contains helper classes for various utilities.
  - `ExcelHelper.cs`: Contains methods to read and write Excel files.

- **Pages**: Contains Page Object Model (POM) classes representing different pages of the application under test.
  - `CreateAccountPage.cs`: Page class for the create account page.
  - `ForgotPasswordPage.cs`: Page class for the forgot password page.
  - `HomePage.cs`: Page class for the home page.
  - `SignInPage.cs`: Page class for the sign-in page.

- **TestData**: Contains test data files.
  - `correct_search_terms.xlsx`: Excel file with test data for search terms.

- **Tests**: Contains test classes.
  - `AmazonCreateAccountTest.cs`: Test class for create account functionality.
  - `AmazonForgotPasswordTest.cs`: Test class for forgot password functionality.
  - `AmazonSearchTests.cs`: Test class for search functionality.
  - `AmazonSignInTest.cs`: Test class for sign-in functionality.

- **GlobalConfig.cs**: Contains global configuration settings for the tests.

## Getting Started

### Prerequisites

- Visual Studio
- .NET Framework
- NUnit Framework

