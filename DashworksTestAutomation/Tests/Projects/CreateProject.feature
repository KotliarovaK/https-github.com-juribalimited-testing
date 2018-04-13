Feature: CreateProject
	Runs Project related tests

@Projects @CreateProject
Scenario: Projects_CreateAProject
	Given User is on Dashworks Homepage
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Projects link
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates Project
	| ProjectName | ProjectShortName | ProjectDescription | ProjectType            | DefaultLanguage |
	| Test        | Test             | Test               | User Scheduled Project | English         |
	Then "Manage Project Details" page is displayed to the user
	When User updating Details page