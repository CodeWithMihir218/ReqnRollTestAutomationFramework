@UITest
Feature: Employee Management
  As an HR Manager
  I want to add employees
  So that their records are maintained

  Background:
    Given I choose to run "UI" for "Employee"
    When I navigate to OrangeHRM login page
    And I login with username "Admin" and password "admin123"
    Then I should be redirected to the dashboard

  Scenario Outline: Add a new employee using UI
    When I add employee with ID <EmployeeId>, first name "<FirstName>", last name "<LastName>", department "<Department>", joined date "<JoinedDate>"
    Then the employee "<FirstName> <LastName>" should be added

    Examples:
      | EmployeeId | FirstName | LastName | Department  | JoinedDate  |
      | 2002       | Ravi      | Patel    | Finance     | 2024-06-15  |
      | 2003       | Anjali    | Verma    | HR          | 2024-06-20  |
      | 2004       | Raj       | Mehta    | Engineering | 2024-06-25  |

