## Web-Automation-on-OrangeHRM-with-xUnit

This repository contains automated tests for the OrangeHRM application using xUnit and Selenium WebDriver. The tests ensure the functionality of the login process, validating that users can log in with correct credentials and are redirected to the dashboard page.

## Video

https://github.com/user-attachments/assets/8375da08-3d33-4f47-989e-d88dc12df204

## Test Scenario Step-by-Step:

1. **Navigate to the Landing Page**
   - Open the browser and navigate to `https://opensource-demo.orangehrmlive.com`.

2. **Login with Valid Credentials**
   - Enter the username `Admin` in the username field.
   - Enter the password `admin123` in the password field.
   - Click the login button.

3. **Verify Successful Login**
   - After logging in, check if the current URL contains the string `dashboard`, indicating successful login.

## Screenshot (Report)

![image](https://github.com/user-attachments/assets/cd1afd04-8a8f-4ee7-b7d5-26260841a1e4)

