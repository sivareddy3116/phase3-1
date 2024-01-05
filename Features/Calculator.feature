Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowAssignment 1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
  Scenario: Multiplication
    Given I have entered 5 into the calculator
    And I have entered 3 into the calculator
    When I press multiply
    Then the result should be 15 on the screen


  Scenario: Subtraction
    Given I have entered 10 into the calculator
    And I have entered 4 into the calculator
    When I press subtract
    Then the result should be 6 on the screen

  
  Scenario: Division
    Given I have entered 20 into the calculator
    And I have entered 5 into the calculator
    When I press divide
    Then the result should be 4 on the screen