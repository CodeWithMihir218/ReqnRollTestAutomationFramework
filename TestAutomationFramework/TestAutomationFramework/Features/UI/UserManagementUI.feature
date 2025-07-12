@UITest
Feature: User Management
  As an admin
  I want to add a new user
  So that they can access the system

  Background:
    Given I choose to run "UI" for "User"
    And I navigate to OrangeHRM login page
    And I login with username "Admin" and password "admin123"
    Then I should be redirected to the dashboard

  Scenario: Add a new user using UI
    When I add a user with username "uiviewer" and role "ESS"
    Then the user "uiviewer" should be added successfully
