Feature: CalculatorAddition

Scenario: Add two positive numbers
	Given I have cleared any previous result
	When I enter 30 into the calculator
		And I choose addition
		And I enter 20 into the calculator
	Then the result should be 50

Scenario: Add two negative numbers
	Given I have cleared any previous results
	When I enter -30 into the calculator
		And I choose addition
		And I enter -20 into the calculator
	Then the result should be -50

Scenario: Add two numbers
	Given I have cleared any previous result
	When I add 1 and 2 together
	Then the result should be 3


