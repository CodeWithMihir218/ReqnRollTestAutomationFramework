@UITest
Feature: Leave Application
  Employees should be able to apply for leave

  Background:
    Given I choose to run "UI" for "Leave"
    When I navigate to OrangeHRM login page
    And I login with username "Admin" and password "admin123"
    Then I should be redirected to the dashboard

  Scenario: Apply for leave using UI
    When I navigate to the leave application page
    And I apply for leave of type "Annual" from "2024-07-10" to "2024-07-12" with reason "Fever" for employee ID 1001
    Then the leave should be submitted with status "Pending"
