﻿Feature: NameTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator as first number
	And I have entered 70 into the calculator as second number
	When I press adds
	Then the result should be 120 on the screens