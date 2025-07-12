@ApiTest
Feature: User Management
  As an admin
  I want to add a new user
  So that they can access the system

  Scenario: Add a new user using API
    Given I choose to run "API" for "User"
    When I add a user with username "newuser" and role "Admin"
    Then the user "newuser" should be added successfully
