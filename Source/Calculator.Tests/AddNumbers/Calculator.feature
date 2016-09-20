# Calculator.feature
Feature: Calculator
	I want to test the behavior of a Calculator

Scenario Outline: Add two numbers
	Given I have a Calculator
	When I add <first> to <second>
	Then the result should be <result>
	
	Examples: 
	| description | first | second | result |
	| 17_25       | 17    | 25     | 42     |
	| 10_78       | 10    | 78     | 88     |
	| 2_25        | 2     | 25     | 27     |
	| 5_minus12   | 5     | -17    | -12    |

Scenario Outline: Sub two numbers
	Given I have a Calculator
	When I subtract <first> to <second>
	Then the result should be <result>

	Examples: 
	| description | first | second | result |
	| 17_59       | 17    | 59     | -42    |
	| 10_3        | 10    | 3      | 7      |