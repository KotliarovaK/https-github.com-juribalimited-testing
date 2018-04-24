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
	| ProjectName     | ProjectShortName | ProjectDescription | ProjectType                |
	| TestProjectName | TestText         | TestText           | Computer Scheduled Project |
	Then "Manage Project Details" page is displayed to the user
	When User updates the Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 | Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	And User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Request Type" create button
	Then User create Request Type
	| Name                | Description |
	| TestRequestTypeName | TestText    |
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Category" create button
	Then User create Category
	| Name             | Description |
	| TestCategoryName | TestText    |
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Stage" create button
	Then User create Stage
	| StageName     |
	| TestStageName |
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Task" create button
	Then User create Task
	| Name         | Help     | TaskType | ValueType   | TaskValuesTemplateCheckbox |
	| TestTaskName | TestText | Normal   | Radiobutton | true                       |
	Then User updates the Task page
	| ValueType   | TaskHaADueDate | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| Radiobutton | true           | false                | false          | false       | true          | false      | true        |
	Then User publishes the task
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Team" create button
	Then User create Team
	| TeamName         | ShortDescription |
	| 001 TestTeamName | TestText         |
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Group" create button
	Then User create Group
	| GroupName     |
	| TestGroupName |
	When User navigate to "Mail Templates" tab
	Then "Manage Mail Templates" page is displayed to the user
	When User clicks "Mail Template" create button
	Then User create Mail Template
	| Name                 | Description | SubjectLine | BodyText |
	| TestMailTemplateName | TestText    | TestText    | TestText |
	When User navigate to "News" tab
	Then "Manage News" page is displayed to the user
	And User updating News page
	| Title     | Text     |
	| TestTitle | TestText |
	When User navigate to "Self Service" tab
	Then "Manage Self Service" page is displayed to the user
	Then User updates the Details on Self Service tab
	| EnableSelfServicePortal | AllowAnonymousUsers | ThisProjectDefault | ModeUser | ModeComputer | NoLink | DashworksProjectHomepage | CustomUrl |
	| false                   | false               | true               | false    | true         | true   | false                    | false     |
	When User navigate to "Welcome" on selected tab
	Then User updates the Welcome on Self Service tab
	| AllowToSearchForAnotherUser | AllowToChangeLanguage | ShowProjectSelector | ShowMoreDetailsLink | Type      | PageDescription | ProjectName |
	| true                        | false                 | false               | true                | Attribute | TestText        | ProjectName |
	When User navigate to "Computer Ownership" on selected tab
	Then User updates the Computer Ownership on Self Service tab
	| ShowScreen | ShowComputers | ShowCategory | AllowUsersToSearch | AllowUsersToSetPrimary | AllowUsersToAddANote | LimitMaximum | LimitMinimum | PageDescription |
	| true       | true          | false        | false              | false                  | false                | 100          | 10           | TestText        |
	When User navigate to "Department and Location" on selected tab
	Then User updates the Department and Location on Self Service tab
	| ShowScreen | ShowDepartmentFullPath | ShowLocationFullPath | AllowUsersToAddANote | Department | Location | DepartmentFeed | HrLocationFeed | ManualLocationFeed | HistoricLocationFeed |
	| true       | false                  | false                | false                | false      | false    | true           | true           | true               | true                 |
	When User navigate to "Apps List" on selected tab
	Then User updates the Apps List on Self Service tab
	| ShowThisScreen | ShowCoreApps | ShowTargetStateReadiness | ShowRequiredColumnAndSticky | ShowOnlyApplication | AllowUsersToAddANote | PageDescription |
	| true           | true         | true                     | true                        | true                | true                 | TestText        |
	When User navigate to "Project Date" on selected tab
	Then User updates the Project Date on Self Service tab
	| ShowScreen | AllowUsersToAddANote | MinimumHours | MaximumHours | PageDescription |
	| true       | true                 | 10           | 100          | TestText        |
	When User navigate to "Other Options 1" on selected tab
	Then User updates the first Other Options on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription |
	| false      | true                 | true      |           | TestText        |
	When User navigate to "Other Options 2" on selected tab
	Then User updates the second Other Options on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription |
	| false      | true                 | true      |           | TestText        |
	When User navigate to "Thank You" on selected tab
	Then User updates the Thank You on Self Service tab
	| SelfServicePortal | NavigationMenu | ChoicesSummary | IncludeLink | PageDescription |
	| true              | false          | false          | false       | TestText        |

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
	| TeamName      | ShortDescription |
	| AAA01TestTeam | Test             |
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Group" create button
	Then User create Group
	| GroupName |
	| TestGroup |
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	Then groups is displayed in the "AAA01TestTeam" team

@Projects @CreateProject @Teams
Scenario: Projects_checkSelfServiceandCapacityTabs
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
	| TestProject | TestText         | TestText           | Computer Scheduled Project |
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Self Service" tab
	Then "Manage Self Service" page is displayed to the user
	When User navigate to "Thank You" on selected tab
	Then User updates the Thank You on Self Service tab
	| SelfServicePortal | NavigationMenu | ChoicesSummary | IncludeLink | PageDescription |
	| true              | false          | false          | false       | TestText        |