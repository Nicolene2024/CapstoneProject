# Capstone Project
The Capstone project is a display of automated testing that includes C#, Selenium and Sikuli. The project consists of 7 test cases using the Demo Web Shop website. 

![image](https://github.com/Nicolene2024/CapstoneProject/assets/170109090/d543c520-ccb6-4d41-a213-d42fa8fdb029)

## 1. Index
- [Preconditions](#preconditions)
- [Dependencies added](#dependencies-added)
- [Configuration File Created](#configuration-file-created)
- [Functions added](#functions-added)
- [Test cases - Steps](#test-case-steps)
- [More in detail](#more-in-detail)
- [Report](#report)
- [How to install](#how-to-install)

## 2. Preconditions
    2.1  Nunit Project created
    2.2  Dependencies added
    2.3  Configuration File created
	
## 3. Dependencies
    3.1  Selenium.WebDriver
    3.2  Selenium.Support
    3.3  ExtentReports
    3.4  SikuliSharp
    3.5  InputSimulator
	
## 4. Configuration File Created
The configuration file has been created to store login details (username and password). It will also be used for all the test cases.

## 5. Functions added
    5.1  OneTimeSetup
	 This function is called at the start of each test case to create the session and the driver.

    5.2  OneTimeTearDown
	 This function is called at the end of each test case to close the session and the driver.

## 6. Test cases - Steps
    6.1  Navigate to the Demo Web Shop Website
    6.2  Login
    6.3  Select category
    6.4  Change display view
    6.5  Add product to the cart
    6.6  Proceed to Checkout
    6.7  Return to home page & logout

## 7. More in detail (Test cases)
Each test case run on it's own. The user can select to run ReturnToHomeWeb in order to run all test cases consequetively.
    7.1  Navigate to the Demo Web Shop Website
         Using Selenium, open Chrome Browser and navigate to the https://demowebshop.tricentis.com webpage and verify Page title
    7.2  Login
         Using Selenium, login from the login link on the page header. 
	 Login Page is displayed. 
	 Verify that the entry box header is Returning Customer. 
	 Home page & user email is displayed
    7.3  Select category
         Using Selenium, select Jewelry under the categories section. 
	 Jewelry downloads page is displayed and verifies that the url contains Jewelry.
    7.4  Change display view
         Using Selenium, select the List option under the View as dropdown. 
	 Products will be displayed underneath each other.
    7.5  Add product to the cart
         Using Sikuli, click on the product labeled Create Your Own Jewelry image.
	 Select the Gold (1mm) option from the material dropdown. 
	 Enter 30 into the Length in cm source field.
	 Select the heart radio button option under Pendant.
	 Increase Quantity to 2.
	 Click on the Add to cart button.
	 Click on the Shopping Cart Link in the page header.
	 Product page as well as Shopping cart page is displayed.
    7.6  Proceed to Checkout
         Using Sikuli, select Country from the dropdown.
	 Select American Samoa as the dropdown option.
	 Insert 96799 into the Zipcode source field.
	 Select the Agree to TC & C checkbox.
	 Click on the Checkout button.
	 Checkout page is displayed.
         Using Selenium to verify the page header is Checkout.
    7.7  Return to home page & logout
         Using Selenium, select the Demo WorkShop logo and select on the logout link in the page header to Logout.  
	 Home page with login option is displayed.

		 
## 8. Reporting
ExtentSparkReporter - a Rich-HTML reporter available from the standard ExtendReports library.

![image](https://github.com/KarenvanWyk/CapstoneProject/assets/170109090/66889ad0-a884-4c0b-b067-1ed493e3dc9f)

## 9. How to Install
Create a C:\Training\CapstoneProject directory with folders Images and Reports in order for the project to pick up the screenshots and HTML reports:

C:\\Training\\CapstoneProject\\Images

C:\\Training\\CapstoneProject\\Report
