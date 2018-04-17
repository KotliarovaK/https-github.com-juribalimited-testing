Feature: CreateProject
	Runs Project related tests

@Projects @CreateProject
Scenario: Projects_CreateAProject
	Given User is on Dashworks Homepage
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Projects link
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates Project
	| ProjectName | ProjectShortName | ProjectDescription | ProjectType                |
	| Test        | Test             | Test               | Computer Scheduled Project |
	Then "Manage Project Details" page is displayed to the user
	When User updating Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 | Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User click create Request Type button
	When User create Request Type
	| Name | Description |
	| Test | Test        |
	When User navigate to "Manage Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User create Categories
	| Name | Description |
	| Test | Test        |