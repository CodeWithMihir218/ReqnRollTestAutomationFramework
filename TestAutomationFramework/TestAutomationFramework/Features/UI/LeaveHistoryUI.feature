@UITest
Feature: Leave History
  Employees should be able to view their past leaves

  Background:
    Given I choose to run "UI" for "Leave"
    When I navigate to OrangeHRM login page
    And I login with username "Admin" and password "admin123"
    Then I should be redirected to the dashboard

  Scenario: View leave history via UI
    When I view leave history
    Then I should see previously approved and rejected leaves
