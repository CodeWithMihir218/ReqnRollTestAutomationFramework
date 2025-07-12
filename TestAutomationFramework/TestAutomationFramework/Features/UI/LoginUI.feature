@UITest
Feature: Login to OrangeHRM
  As an admin user
  I want to log in to the OrangeHRM application
  So that I can access the dashboard

  Scenario: Valid login with admin credentials
    Given I navigate to OrangeHRM login page
    When I login with username "Admin" and password "admin123"
    Then I should be redirected to the dashboard