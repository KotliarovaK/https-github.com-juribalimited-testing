Feature: CreateComputerScheduledProject
	Runs Project related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	Then "Projects Home" page is displayed to the user

@Senior @Projects_Administration @ComputerScheduledProject @Delete_Newly_Created_Team
Scenario: Projects_CreateComputerScheduledProject
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates Project
	| ProjectName                  | ProjectShortName | ProjectDescription | ProjectTypeString        |
	| 000 ComputerScheduledProject | TestText         | TestText           | ComputerScheduledProject |
	Then Error message is not displayed
	When User clicks "Create Project" button
	Then Error message is not displayed
	Then "Manage Project Details" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	Then User create a new Dashworks User
	| Username                     | FullName                   | Password | ConfirmPassword | RolesString            |
	| AAA0ComputerScheduledProject | ComputerScheduledProject 0 | 1234qwer | 1234qwer        | DashworksEvergreenUser |
	And Success message is displayed
	And created User is displayed in the table
	And User create a new Dashworks User
	| Username                     | FullName                   | Password | ConfirmPassword | RolesString            |
	| AAA1ComputerScheduledProject | ComputerScheduledProject 1 | 1234qwer | 1234qwer        | DashworksEvergreenUser |
	And Success message is displayed
	And created User is displayed in the table
	And User create a new Dashworks User
	| Username                     | FullName                   | Password | ConfirmPassword | RolesString            |
	| AAA2ComputerScheduledProject | ComputerScheduledProject 2 | 1234qwer | 1234qwer        | DashworksEvergreenUser |
	And Success message is displayed
	And created User is displayed in the table
	When User navigate to Dashworks User Site link
	And User navigate to Projects link
	Then "Projects Home" page is displayed to the user
	When User select Project
	Then User make this Project Default
	And Default Project News Title is displayed correctly
	And User navigate to created Project
	And "Manage Project Details" page is displayed to the user
	And Project Name is displayed correctly
	When User updates the Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications |  TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 |Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	Then Success message is displayed with "Project was successfully updated" text
		#Creating Request Types
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description                | ObjectTypeString |
	| 1 TestRequestTypeName | ComputerScheduledProject 1 | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description                | ObjectTypeString |
	| 2 TestRequestTypeName | ComputerScheduledProject 2 | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description                | ObjectTypeString |
	| 3 TestRequestTypeName | ComputerScheduledProject 3 | Computer         |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name               | Description                | ObjectTypeString |
	| 1 TestRequestTypeName | ComputerScheduledProject 1 | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	And User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name               | Description                | ObjectTypeString |
	| 2 TestRequestTypeName | ComputerScheduledProject 2 | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	And User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description                | ObjectTypeString |
	| 3 TestRequestTypeName | ComputerScheduledProject 3 | Computer         |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	And User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	And User create Category
	| Name             | Description              | ObjectTypeString |
	| TestCategoryName | ComputerScheduledProject | User             |
	Then Success message is displayed with "Category successfully created." text
	When User clicks "« Go Back" button
	Then created Category is displayed in the table
		#Creating Stage
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Stage 1   |
	When User clicks "Create Stage" button
	Then Error message is not displayed
	Then created Stage is displayed in the table
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Stage 2   |
	When User clicks "Create Stage" button
	Then Error message is not displayed
	Then created Stage is displayed in the table
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Stage 3   |
	When User clicks "Create Stage" button
	Then Error message is not displayed
	Then created Stage is displayed in the table
	When User clicks "Create Stage" button
	And User create Stage
	| StageName |
	| Stage 4   |
	When User clicks "Create Stage" button
	Then Error message is not displayed
	Then created Stage is displayed in the table
		#Creating Mail Template
	When User navigate to "Mail Templates" tab
	Then "Manage Mail Templates" page is displayed to the user
	When User clicks "Create Mail Template" button
	And User create Mail Template
	| Name                 | Description              | SubjectLine | BodyText |
	| TestMailTemplateName | ComputerScheduledProject | TestText    | TestText |
	Then Success message is displayed with "Mail Template successfully created." text
		#Creating Tasks 1
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User create Task
	| Name          | Help          | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Forecast Date | Forecast Date | Stage1           | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | ForecastDate          | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 2
	When User clicks "Create Task" button
	And User create Task
	| Name        | Help        | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Target Date | Target Date | Stage2           | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | TargetDate            | false       | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 3
	When User clicks "Create Task" button
	And User create Task
	| Name           | Help           | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Scheduled Date | Scheduled Date | Stage3           | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | ScheduledDate         | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 4
	When User clicks "Create Task" button
	And User create Task
	| Name          | Help          | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Migrated Date | Migrated Date | Stage4           | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | MigratedDate          | false       | true          | false      | true        |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 5
	When User clicks "Create Task" button
	And User create Task
	| Name           | Help           | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Completed Date | Completed Date | Stage4           | Normal         | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | CompletedDate         | true        | true          | false      | true        |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 6
	When User clicks "Create Task" button
	And User create Task
	| Name            | Help            | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Group Date Task | Group Date Task | Stage1           | Group          | Date            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | BulkUpdate | GroupTaskDashboard |
	| true           | DateOnly       | None                  | true        | false      | true               |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 7
	When User clicks "Create Task" button
	And User create Task
	| Name      | Help      | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Text Task | Text Task | Stage2           | Normal         | Text            | Computer         |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TextModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| SingleLine     |                       | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 8
	When User clicks "Create Task" button
	And User create Task
	| Name                       | Help                       | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString       | ApplyToAllCheckbox |
	| Radiobutton RAG Owner Date | Radiobutton RAG Owner Date | Stage3           | Normal         | Radiobutton     | Computer         | ReadinessNnsfcWithDueDateOwner | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Values" page
	And User clicks "Add Value" button
	And User create new Value
	| Name    | ReadinessString | TaskStatusString | DefaultValue |
	| Blocked | Purple          | Open             | false        |
	And User clicks "Save Value" button
	And User navigates to "Not Started" Value
	And User edit selected Value
	| Name | ReadinessString | TaskStatusString | DefaultValue |
	|      | Blue            |                  | true         |
	And User clicks "Save Value" button
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 9
	When User clicks "Create Task" button
	And User create Task
	| Name                   | Help                   | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString     | ApplyToAllCheckbox |
	| Dropdown Non RAG Owner | Dropdown Non RAG Owner | Stage4           | Normal         | DropDownList    | Computer         | NoReadinessNaEnabledDisabled | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          |                | Workflow              | false          | false                | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Values" page
	And User clicks "Add Value" button
	And User create new Value
	| Name         | ReadinessString | TaskStatusString | DefaultValue |
	| Out of Scope |                 | Closed           | false        |
	And User clicks "Save Value" button
	And User navigates to "Enabled" Value
	And User edit selected Value
	| Name | ReadinessString | TaskStatusString | DefaultValue |
	|      |                 | Open             | true         |
	And User clicks "Save Value" button
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 10
	When User clicks "Create Task" button
	And User create Task
	| Name                                  | Help                                  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString       | ApplyToAllCheckbox |
	| Group Radiobutton RAG Date Time Owner | Group Radiobutton RAG Date Time Owner | Stage2           | Group          | Radiobutton     | Computer         | ReadinessNnsfcWithDueDateOwner | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString          | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | GroupTaskDashboard | BulkUpdate |
	| false          | DateTime       | SelfServiceEnabledComputerMode | true           | true                 | true        | false              | true       |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Values" page
	And User clicks "Add Value" button
	And User create new Value
	| Name    | ReadinessString       | TaskStatusString | DefaultValue |
	| Unknown | ReallyExtremelyOrange | Open             | true         |
	And User clicks "Save Value" button
	And User navigates to "Not Applicable" Value
	And User edit selected Value
	| Name | ReadinessString | TaskStatusString | DefaultValue |
	| N/A  | None            |                  | false        |
	And User clicks "Save Value" button
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 11
	When User clicks "Create Task" button
	And User create Task
	| Name                     | Help                     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString  | ApplyToAllCheckbox |
	| Dropdown RAG Date & Time | Dropdown RAG Date & Time | Stage3           | Normal         | DropDownList    | Computer         | ReadinessNnsfcWithDueDate | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | None                  | true           | false       | false         | false      | true        |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Request Types" page
	Then "Edit Task" page is displayed to the user
	When User select "3 TestRequestTypeName" Request Type on Task page
	And User save selected Request Type
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 12
	When User clicks "Create Task" button
	And User create Task
	| Name             | Help             | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Text Task (User) | Text Task (User) | Stage1           | Normal         | Text            | User             |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TextModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| MultipleLine   | EmailAddressUser      | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 13
	When User clicks "Create Task" button
	And User create Task
	| Name                              | Help                              | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString  | ApplyToAllCheckbox |
	| Radiobutton RAG Owner Date (User) | Radiobutton RAG Owner Date (User) | Stage2           | Normal         | Radiobutton     | User             | ReadinessNnsfcWithDueDate | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString      | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | SelfServiceEnabledUserMode | true                 | true           | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Value" page
	And User clicks "Add Value" button
	And User create new Value
	| Name    | ReadinessString | TaskStatusString | DefaultValue |
	| Blocked | LightBlue       | Open             | false        |
	And User clicks "Save Value" button
	And User navigates to "Not Started" Value
	And User edit selected Value
	| Name          | ReadinessString | TaskStatusString | DefaultValue |
	| To Be Started | None            |                  | true         |
	And User clicks "Save Value" button
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 14
	When User clicks "Create Task" button
	And User create Task
	| Name                      | Help                      | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Group Dropdown RAG (User) | Group Dropdown RAG (User) | Stage3           | Group          | DropDownList    | User             | ReadinessNnsfc           | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString  | TaskImpactsReadiness | ShowDetails | BulkUpdate | GroupTaskDashboard |
	| false          |                | EmailNotificationsUser | true                 | true        | false      | false              |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Value" page
	And User navigates to "Complete" Value
	And User edit selected Value
	| Name     | ReadinessString | TaskStatusString | DefaultValue |
	| Finished | Brown           |                  | false        |
	And User clicks "Save Value" button
	And User navigate to "Request Types" page
	Then "Edit Task" page is displayed to the user
	When User select "[Default (User)]" Request Type on Task page
	And User save selected Request Type
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 15
	When User clicks "Create Task" button
	And User create Task
	| Name             | Help             | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Date Task (User) | Date Task (User) | Stage4           | Normal         | Date            | User             |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString                       | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           |                | SelfServiceProjectDateCompletedDateUserMode | false       | true          | true       | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 16
	When User clicks "Create Task" button
	And User create Task
	| Name                                         | Help                                         | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString         | ApplyToAllCheckbox |
	| Radiobutton Non RAG Owner Date (Application) | Radiobutton Non RAG Owner Date (Application) | Stage1           | Normal         | Radiobutton     | Application      | NoReadinessNnsfcWithDueDateOwner | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateTime       | Workflow              | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Value" page
	And User clicks "Add Value" button
	And User create new Value
	| Name    | ReadinessString | TaskStatusString | DefaultValue |
	| Unknown |                 | Open             | true         |
	And User clicks "Save Value" button
	And User navigates to "Started" Value
	And User edit selected Value
	| Name        | ReadinessString | TaskStatusString | DefaultValue |
	| In Progress |                 |                  | false        |
	And User clicks "Save Value" button
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 17
	When User clicks "Create Task" button
	And User create Task
	| Name                             | Help                             | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Dropdown RAG Owner (Application) | Dropdown RAG Owner (Application) | Stage2           | Normal         | DropDownList    | Application      | ReadinessNnsfc           | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          |                | None                  | true                 | true        | false         | false      | true        |
	Then Success message is displayed with "Task successfully updated" text
	When User navigate to "Value" page
	And User clicks "Add Value" button
	And User create new Value
	| Name                | ReadinessString | TaskStatusString | DefaultValue |
	| Under Investigation | Amber           | Open             | false        |
	And User clicks "Save Value" button
	And User navigates to "Not Applicable (Default)" Value
	And User edit selected Value
	| Name | ReadinessString | TaskStatusString | DefaultValue |
	| N/A  | None            |                  | true         |
	And User clicks "Save Value" button
	And User navigate to "Request Types" page
	Then "Edit Task" page is displayed to the user
	When User select "2 TestRequestTypeName" Request Type on Task page
	And User save selected Request Type
	And User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 18
	When User clicks "Create Task" button
	And User create Task
	| Name                      | Help                      | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Application Delivery Date | Application Delivery Date | Stage3           | Normal         | Date            | Application      |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString   | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | ApplicationDeliveryDate | true        | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Tasks 19
	When User clicks "Create Task" button
	And User create Task
	| Name                    | Help                    | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| Text Task (Application) | Text Task (Application) | Stage4           | Normal         | Text            | Application      |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TextModeString | DateModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| SingleLine     |                | DeploymentTarget      | true        | false         | false      | true        |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Teams
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Create Team" button
	And User create Team
	| TeamName                     | ShortDescription |
	| 000 ComputerScheduledProject | TestText 0       |
	And User clicks "Add Member" button
	And User select "1" user to add as member
	And User clicks "Add Selected" button
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
	When User clicks "Create Team" button
	And User create Team
	| TeamName                     | ShortDescription |
	| 001 ComputerScheduledProject | TestText 1       |
	And User clicks "Add Member" button
	And User select "2" user to add as member
	And User clicks "Add Selected" button
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
	When User clicks "Create Team" button
	And User create Team
	| TeamName                     | ShortDescription |
	| 002 ComputerScheduledProject | TestText 2       |
	And User clicks "Add Member" button
	And User select "3" user to add as member
	And User clicks "Add Selected" button
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
		#Creating Groups
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Create Group" button
	And User create Group owned for "1" Team
	| GroupName                  |
	| 0 ComputerScheduledProject |
	Then created Group is displayed in the table
	When User clicks "Create Group" button
	And User create Group owned for "2" Team
	| GroupName                  |
	| 1 ComputerScheduledProject |
	Then created Group is displayed in the table
	When User clicks "Create Group" button
	And User create Group owned for "3" Team
	| GroupName                  |
	| 2 ComputerScheduledProject |
	Then created Group is displayed in the table
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	And "1" number of Groups is displayed for "3" Team
		#Creating News
	When User navigate to "News" tab
	Then "Manage News" page is displayed to the user
	When User updating News page
	| Title                    | Text     |
	| ComputerScheduledProject | TestText |
	Then Success message is displayed with "Project news was successfully updated." text
		#Self Service tabs
	When User navigate to "Self Service" tab
	Then "Manage Self Service" page is displayed to the user
	When User updates the Details page on Self Service tab
	| EnableSelfServicePortal | AllowAnonymousUsers | ThisProjectDefault | ModeUser | ModeComputer | NoLink | DashworksProjectHomepage | CustomUrl | CustomUrlTextFiald |
	| false                   | false               | true               | true     | false        | true   | false                    | false     | http://Test        |
	Then Success message is displayed with "Details successfully updated." text
	When User navigate to "Welcome" page on Self Service tab
	And User updates the Welcome page on Self Service tab
	| AllowToSearchForAnotherUser | AllowToChangeLanguage | ShowProjectSelector | ShowMoreDetailsLink | PageDescription | ProjectName              |
	| true                        | false                 | false               | true                | TestText        | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Computer Ownership" page on Self Service tab
	And User updates the Ownership page on Self Service tab
	| ShowScreen | ShowComputers | ShowCategory | AllowUsersToSearch | AllowUsersToSetPrimary | AllowUsersToAddANote | LimitMaximum | LimitMinimum | PageDescription          |
	| true       | true          | false        | false              | false                  | false                | 100          | 10           | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Department and Location" page on Self Service tab
	And User updates the Department and Location page on Self Service tab
	| ShowScreen | ShowDepartmentFullPath | ShowLocationFullPath | AllowUsersToAddANote | Department | DepartmentDoNotPush | DepartmentPushToOwned | DepartmentPushToAll | Location | LocationDoNotPush | LocationPushToOwned | LocationPushToAll | DepartmentFeed | HrLocationFeed | ManualLocationFeed | HistoricLocationFeed |
	| true       | false                  | false                | false                | false      | false               | false                 | false               | false    | false             | false               | false             | true           | false          | false              | false                |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Apps List" page on Self Service tab
	And User updates the Apps List page on Self Service tab
	| ShowThisScreen | ShowCoreApps | ShowTargetStateReadiness | ShowRequiredColumnAndSticky | ShowOnlyApplication | AllowUsersToAddANote | PageDescription          |
	| true           | true         | true                     | true                        | true                | true                 | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Project Date" page on Self Service tab
	And User updates the Project Date page on Self Service tab
	| AllowUsersToAddANote | MinimumHours | MaximumHours | PageDescription          |
	| true                 | 10           | 100          | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 1" page on Self Service tab
	And User updates the first Other Options page on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription          |
	| false      | true                 | false     | true      | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 2" page on Self Service tab
	And User updates the second Other Options page on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription          |
	| false      | true                 | true      | false     | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Thank You" page on Self Service tab
	And User updates the Thank You page on Self Service tab
	| SelfServicePortal | NavigationMenu | ChoicesSummary | IncludeLink | PageDescription          |
	| true              | false          | false          | false       | ComputerScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
		#Capacity tabs
	When User navigate to "Capacity" tab
	Then "Manage Capacity" page is displayed to the user
	When User updates the Details on Capacity tab
	| EnablePlanning | DisplayColors | EnforceOonSelfServicePage | EnforceOnProjectObjectPage | CapacityToReach |
	| true           | true          | true                      | true                       | 80              |
	Then Success message is displayed with "Details successfully updated." text
	When User navigate to "Capacity" page
	And User updates the Capacity page on Capacity tab for "1" Team
	| StartDate   | EndDate     | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	| 06 Apr 2016 | 19 Apr 2018 | false          | false           | false             | false            | false          | false            | false          | 100    | 100     | 100       | 100      | 100    | 100      | 100    |
	Then Success message is displayed with "Capacity information successfully updated." text
	When User updates the Capacity page on Capacity tab for "2" Team
	| StartDate   | EndDate       | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	| 08 May 2013 | 20 March 2015 | false          | false           | false             | false            | false          | false            | false          | 10     | 10      | 10        | 10       | 10     | 10       | 10     |
	Then Success message is displayed with "Capacity information successfully updated." text
	When User updates the Capacity page on Capacity tab for "3" Team
	| StartDate    | EndDate     | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	| 16 June 2012 | 27 May 2016 | false          | false           | false             | false            | false          | false            | false          | 100    | 100     | 100       | 100      | 100    | 100      | 100    |
	Then Success message is displayed with "Capacity information successfully updated." text
	When User navigate to "Summary" page
	And User select created request type on Summary tab
	Then table for selected request type is displayed
	When User navigate to "Override Dates" page
	And User updates the Override Dates on Capacity tab
	| Date        | Capacity | Comment                  |
	| 03 Apr 2016 | 0        | ComputerScheduledProject |
	Then Success message is displayed with "Override date successfully inserted" text
		#removing
	When User navigate to "Groups" tab
	And User removes created Group
	Then selected Group was removed
	When User removes created Group
	Then selected Group was removed
	When User removes created Group
	Then selected Group was removed
	When User navigate to "Teams" tab
	And User removes created Team
	Then selected Team was removed
	When User removes created Team
	Then selected Team was removed
	When User removes created Team
	Then selected Team was removed
	When User navigate to "Tasks" tab
	And User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User removes created Task
	Then selected Task was removed
	And Success message is displayed with "Task successfully deleted." text
	When User navigate to "Stages" tab
	And User removes created Stage
	Then selected Stage was removed
	And Success message is displayed with "Stage successfully deleted." text
	When User removes created Stage
	Then selected Stage was removed
	And Success message is displayed with "Stage successfully deleted." text
	When User removes created Stage
	Then selected Stage was removed
	And Success message is displayed with "Stage successfully deleted." text
	When User navigate to "Categories" tab
	And User removes created Category
	Then selected Category was removed
	And Success message is displayed with "Category successfully deleted." text
	When User navigate to "Request Types" tab
	And User makes "[Default (Computer)]" Request Type default
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	And User removes created Request Type
	Then selected Request Type was removed
	And Success message is displayed with "Request Type successfully deleted" text
	When User makes "[Default (Application)]" Request Type default
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	And User removes created Request Type
	Then selected Request Type was removed
	And Success message is displayed with "Request Type successfully deleted" text
	When User makes "[Default (User)]" Request Type default
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	And User removes created Request Type
	Then selected Request Type was removed
	And Success message is displayed with "Request Type successfully deleted" text
	When User navigate to "Mail Templates" tab
	And User removes created Mail Template
	Then selected Mail Template was removed
	And Success message is displayed with "Mail Template successfully deleted." text
	When User navigate to "Details" tab
	And User removes the Project
	Then Success message is displayed with "Project successfully deleted" text
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes created User
	Then selected User was removed
	And Success message is displayed
	When User removes created User
	Then selected User was removed
	And Success message is displayed
	When User removes created User
	Then selected User was removed
	And Success message is displayed