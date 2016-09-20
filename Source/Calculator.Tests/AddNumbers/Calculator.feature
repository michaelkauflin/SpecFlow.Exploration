# Calculator.feature
Feature: Calculator
	I want to test the behavior of a Calculator

Scenario Outline: Add two numbers
	Given I have a Calculator
	When I add <first> to <second>
	Then the result should be <result>
	
	Examples: 
	| first | second | result |
	| 17    | 25     | 42     |
	| 10    | 78     | 88     |
	| 2     | 25     | 27     |
	| 5     | -17    | -12    |