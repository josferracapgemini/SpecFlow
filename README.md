# Initial guide for SpecFlow:

## Setting up the enviroment:

- Go to Tools > Extensions and Updates…
	- Install SpecFlow for Visual Studio 2017

- Create a new Unit Test Project(.NET Framework)
- Go to Nuget Manager for this project and istall:
	- SpecFlow
	- SpecRun.Runner
	- SpecRun.SpecFlow
	- Moq

## Folders Organization:

- Project
	- SpecFlow
		- Code of the user story from JIRA -> e.g.(KSAPP_131)
			- Features
				- Description of what we are going to test -> e.g(TestName.feature)
				- …
			- Steps
				- The same name of the feature file that we refer to + Steps -> e.g(TestNameSteps.cs)
				- …
	- Helper
	- Utils
	- …

## How to use SpecFlow:

1 - Create the feature file -> right click on the "Features" folder > Add > New Item > Select"SpecFlow Feature File"

2 - Go to you feature file ande define all your scenarios.
- Given …
- When …
- Then …

3 - Right click on one of the scenarios > click on Generate Steps Definitions > Put the correct Name > Click on Generate > Select the correct Path.(follow the folders organization)

4 - Go to the Spets file.

5 - Set up your Step file by:
- Create your class variables.
- You have to set up the enviroment by mocking the necesary Services.
- Define the response of the fake call of the mocked servide.
	
6 - Implement your Steps
- Given …
- Define your class variables inputs.
- When …
- Define the actions by calling the method of the Mocked Service or the function that you need to test.
- Then …
- Define your Asserts that prove your result is what you expected.

## Run the test:

- Go to Test > Windows > Test Explorer.
- Then select the test that you want to run and run it.
- You can also run all your test by clicking on Run All.

## Test Results:

- Open your solution folder in you File Explorer.
- Go to TestResults folder.
- Open the html file that Specflow has generated.

## Related Links:

- Oficial documentation SpecFlow -> https://specflow.org/docs/
- Getting started -> https://specflow.org/getting-started/

- Projects Examples: 
	- https://github.com/techtalk/SpecFlow.Plus.Examples
	- https://github.com/techtalk/SpecFlow-Examples

## Demo project notes:

- You can observe the folder organization.
- In the ExampleTest folder you can observe a basic example of how to use specflow and how can we get diferent type from the imput.
- In LoginUserTest you can observe a more complex examples where we Mock some objects and Servces.






