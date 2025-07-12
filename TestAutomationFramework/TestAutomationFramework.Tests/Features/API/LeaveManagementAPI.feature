@ApiTest
Feature: Leave Application
  Employees should be able to apply for leave

  Scenario: Apply for leave using API
    Given I choose to run "API" for "Leave"
    When I apply for leave of type "Sick" from "2024-07-10" to "2024-07-12" with reason "Fever" for employee ID 1001
    Then the leave should be submitted with status "Pending"