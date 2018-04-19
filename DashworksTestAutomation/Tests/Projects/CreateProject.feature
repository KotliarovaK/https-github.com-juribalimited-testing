Feature: CreateProject
	Runs Project related tests

@Projects @CreateProject
Scenario: Projects_CreateProject
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
	| TestProject | Test             | Test               | Computer Scheduled Project |
	Then "Manage Project Details" page is displayed to the user
	When User updating Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 | Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	And User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Request Type" create button
	Then User create Request Type
	| Name            | Description |
	| TestRequestType | Test        |
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Category" create button
	Then User create Category
	| Name         | Description |
	| TestCategory | Test        |
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Stage" create button
	Then User create Stage
	| StageName |
	| Test      |
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Task" create button
	Then User create Task
	| Name     | Help | StageName | ValueType   | TaskValuesTemplateCheckbox |
	| TestTask | Test | Test      | Radiobutton | false                      |
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Team" create button
	Then User create Team
	| TeamName | ShortDescription |
	| TestTeam | Test             |
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Group" create button
	Then User create Group
	| GroupName |
	| TestGroup |
	When User navigate to "Mail Templates" tab
	Then "Manage Mail Templates" page is displayed to the user
	When User clicks "Mail Template" create button
	Then User create Mail Template
	| GroupName        | Description | SubjectLine | BodyText |
	| TestMailTemplate | Test        | Test        | Test     |
	When User navigate to "News" tab
	Then "Manage News" page is displayed to the user
	And User updating News page
	| Title     | Text |
	| TestGroup | Test |

@Projects @CreateProject @Teams
Scenario: Projects_checkHowManyGroupInATeam
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
	| TestProject | Test             | Test               | Computer Scheduled Project |
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Team" create button
	Then User create Team
	| TeamName     | ShortDescription |
	| AAA TestTeam | Test             |
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Group" create button
	Then User create Group
	| GroupName | Owned By Team |
	| TestGroup | AAA TestTeam  |
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	Then in the ""(.*)"" team found ""(.*)"" groups