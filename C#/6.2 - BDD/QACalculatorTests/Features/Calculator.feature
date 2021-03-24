Feature:
	Various scenarios to test the calculator

Scenario: Add two numbers
	Given a calculator
	When I add 2 and 9
	Then the outcome should be 11

Scenario: Subtract two numbers
	Given a calculator
	When I subtract 9 and 2
	Then the outcome should be 7

Scenario: Multiply two numbers
	Given a calculator
	When I multiply 9 and 2
	Then the outcome should be 18