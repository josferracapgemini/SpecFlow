Feature: SpecFlowFeatureLogin
	In order to log in 
	As a waiter
	I want to be told when the waiter logs in

Scenario: Waiter logs in
	Given I have entered "waiter" into the username
	And I have entered "waiter" into the password
	And The result of login process is "true"
	When I press login
	Then the result should be "true"

Scenario: Waiter logs in error
	Given I have entered "waiter" into the username
	And I have entered "aaaa" into the password
	And The result of login process is "false"
	When I press login
	Then the result should not be "true"

Scenario: User0 logs in
	Given I have entered "user0" into the username
	And I have entered "password" into the password
	And The result of login process is "true"
	When I press login
	Then the result should be "true"

Scenario: User0 logs in wrong
	Given I have entered "user0" into the username
	And I have entered "password" into the password
	And The result of login process is "false"
	When I press login
	Then the result should not be "true"

#Other way to test multiple data (using the Scenario Outline):
Scenario Outline: User logs in correctly
	Given I have entered <username> into the username TableExample
	And I have entered <password> into the password TableExample
	And The result of login process is "true"
	When I press login
	Then the result should be "true"
	Examples: 
	| username | password |
	| waiter   | waiter   |
	| user0    | password |

Scenario Outline: User logs in fails
	Given I have entered <username> into the username TableExample
	And I have entered <password> into the password TableExample
	And The result of login process is "false"
	When I press login
	Then the result should not be "true"
	Examples: 
	| username | password |
	| waiter   | aaa      |
	| user0    | aaa      |
