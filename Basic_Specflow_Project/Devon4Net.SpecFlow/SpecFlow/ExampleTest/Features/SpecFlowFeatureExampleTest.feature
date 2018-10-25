Feature: SpecFlowFeatureExampleTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 as first element of calculator
	And I have entered 70 as second element of calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add two numbers wrong
	Given I have entered 50 as first element of calculator
	And I have entered 70 as second element of calculator
	When I press add
	Then the result should not be 150 on the screen

# Different data types examples
Scenario: JSON object example
	Given I have recived the following JSON object: '{"number1":50,"number2":70}'
	When I press add
	Then the result should be 120 on the screen

Scenario: Serie of elements example
	Given I entered the following serie: "50,60,10"
	When I press addSerie
	Then the result should be 120 on the screen

Scenario: Table of elements example
	Given I entered numbers
	| elements |
	| 50       |
	| 50       |
	| 20       |
	When I press addTableElements
	Then the result should be 120 on the screen


