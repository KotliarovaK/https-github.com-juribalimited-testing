Feature: CreateProject
	Runs Project related tests

@Projects @CreateProject @Delete_Newly_Created_Team
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
	| ProjectName     | ProjectShortName | ProjectDescription | 
	| TestProjectName | TestText         | TestText           |
	When User clicks "Create Project" button
	Then "Manage Project Details" page is displayed to the user
	When User navigate to Manage link
	When User select "Manage Users" option in Management Console
	Then User create a new Dashworks User
	| Username | FullName       | Password | ConfirmPassword |
	| AAA0Test | TestUserName 0 | 1234qwer | 1234qwer        |
	Then Success message is displayed
	Then created User is displayed in the table
	#Then User create a new Dashworks User
	#| Username | FullName       | Password | ConfirmPassword |
	#| AAA1Test | TestUserName 1 | 1234qwer | 1234qwer        |
	#Then Success message is displayed
	#Then created User is displayed in the table
	#Then User create a new Dashworks User
	#| Username | FullName       | Password | ConfirmPassword |
	#| AAA2Test | TestUserName 2 | 1234qwer | 1234qwer        |
	#Then Success message is displayed
	#Then created User is displayed in the table
	When User navigate to Dashworks User Site link
	When User navigate to Projects link
	Then "Projects Home" page is displayed to the user
	When User select Project
	Then User make this Project Default
	Then Default Project News Title is displayed correctly
	Then User navigate to created Project
	Then "Manage Project Details" page is displayed to the user
	Then Project Name is displayed correctly
	When User updates the Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 | Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	Then Success message is displayed with "Project was successfully updated" text
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description | ObjectTypeString |
	| TestRequestTypeName | TestText 0  | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description | ObjectTypeString |
	| TestRequestTypeName | TestText 1  | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description | ObjectTypeString |
	| TestRequestTypeName | TestText 2  | Computer         |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	#When User clicks "Create Request Type" button
	#When User create Request Type
	#| Name                | Description | ObjectTypeString |
	#| TestRequestTypeName | TestText 0  | User             |
	#Then Success message is displayed
	#When User clicks "Cancel" button
	#Then created Request Type is displayed in the table
	#When User click on the created Request Type
	#Then User updates the Request Type page
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#Then created Request Type is a Default
	#When User clicks "Create Request Type" button
	#When User create Request Type
	#| Name                | Description | ObjectTypeString |
	#| TestRequestTypeName | TestText 1  | Application      |
	#Then Success message is displayed
	#When User clicks "Cancel" button
	#Then created Request Type is displayed in the table
	#When User click on the created Request Type
	#Then User updates the Request Type page
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#Then created Request Type is a Default
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description | ObjectTypeString |
	| TestRequestTypeName | TestText 2  | Computer         |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	Then User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	When User create Category
	| Name             | Description |
	| TestCategoryName | TestText    |
	Then Success message is displayed with "Category successfully created." text
	When User clicks "« Go Back" button
	Then created Category is displayed in the table
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	When User create Stage
	| StageName       |
	| 0 TestStageName |
	Then created Stage is displayed in the table
	When User clicks "Create Stage" button
	When User create Stage
	| StageName       |
	| 1 TestStageName |
	Then created Stage is displayed in the table
	When User clicks "Create Stage" button
	When User create Stage
	| StageName       |
	| 2 TestStageName |
	Then created Stage is displayed in the table
	When User navigate to "Mail Templates" tab
	Then "Manage Mail Templates" page is displayed to the user
	When User clicks "Create Mail Template" button
	When User create Mail Template
	| Name                 | Description | SubjectLine | BodyText |
	| TestMailTemplateName | TestText    | TestText    | TestText |
	Then Success message is displayed with "Mail Template successfully created." text
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	When User create Task
	| Name           | Help     | ObjectTypeString | TaskValuesTemplateCheckbox |
	| TestTaskName 0 | TestText | Computer         | true                       |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | true                 | false          | true        | true          | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Values" on selected tab
	When User clicks "Add Value" button
	Then User create new Value
	| Name            | Help   | DefaultValue |
	| TestValueName 0 | Test 0 | false        |
	When User clicks "Save Value" button
	When User navigate to "Emails" on selected tab
	When User clicks "Add Email" button
	Then User create new Email
	| CountDays | SendOnceOnly | RequestTypesAll | ApllyEmailToAll | To              |
	| true      | true         | false           | true            | Test0@email.com |
	When User clicks "Create Email Notification" button
	Then Success message is displayed with "Email notification for task successfully created" text
	When User clicks "« Go Back" button
	Then created Email is displayed in the table
	When User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
	When User clicks "Create Task" button
	When User create Task
	| Name           | Help     | ObjectTypeString | TaskValuesTemplateCheckbox |
	| TestTaskName 1 | TestText | Application      | true                       |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | true                 | false          | false       | false         | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Values" on selected tab
	When User clicks "Add Value" button
	Then User create new Value
	| Name            | Help | DefaultValue |
	| TestValueName 1 | Test | false        |
	When User clicks "Save Value" button
	When User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
	When User clicks "Create Task" button
	When User create Task
	| Name           | Help     | ObjectTypeString | TaskValuesTemplateCheckbox |
	| TestTaskName 2 | TestText | User             | true                       |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | true                 | false          | false       | true          | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Values" on selected tab
	When User clicks "Add Value" button
	Then User create new Value
	| Name            | Help | DefaultValue |
	| TestValueName 2 | Test | true         |
	When User clicks "Save Value" button
	When User navigate to "Emails" on selected tab
	When User clicks "Add Email" button
	Then User create new Email
	| CountDays | SendOnceOnly | RequestTypesAll | ApllyEmailToAll | To              |
	| true      | true         | true            | true            | Test2@email.com |
	When User clicks "Create Email Notification" button
	Then Success message is displayed with "Email notification for task successfully created" text
	When User clicks "« Go Back" button
	Then created Email is displayed in the table
	When User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Create Team" button
	When User create Team
	| TeamName         | ShortDescription |
	| 000 TestTeamName | TestText 0       |
	When User clicks "Add Member" button
	Then User select Users by Username
	When User clicks "Add Selected" button
	When User clicks "Cancel" button
	Then created Team is displayed in the table
	Then "2" number of Members is displayed for created team
	#When User clicks "Create Team" button
	#When User create Team
	#| TeamName         | ShortDescription |
	#| 001 TestTeamName | TestText 1       |
	#When User clicks "Add Member" button
	#Then User select Users by Username
	#When User clicks "Add Selected" button
	#When User clicks "Cancel" button
	#Then created Team is displayed in the table
	#Then "2" number of Members is displayed for created team
	#When User clicks "Create Team" button
	#When User create Team
	#| TeamName         | ShortDescription |
	#| 002 TestTeamName | TestText 2       |
	#When User clicks "Add Member" button
	#Then User select Users by Username
	#When User clicks "Add Selected" button
	#When User clicks "Cancel" button
	#Then created Team is displayed in the table
	#Then "2" number of Members is displayed for created team
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Create Group" button
	When User create Group
	| GroupName       |
	| TestGroupName 0 |
	Then created Group is displayed in the table
	#When User clicks "Create Group" button
	#When User create Group
	#| GroupName       |
	#| TestGroupName 1 |
	#Then created Group is displayed in the table
	#When User clicks "Create Group" button
	#When User create Group
	#| GroupName       |
	#| TestGroupName 2 |
	#Then created Group is displayed in the table
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	Then required number of Groups is displayed for created team
	When User navigate to "News" tab
	Then "Manage News" page is displayed to the user
	When User updating News page
	| Title     | Text     |
	| TestTitle | TestText |
	Then Success message is displayed with "Project news was successfully updated." text
	When User navigate to "Self Service" tab
	Then "Manage Self Service" page is displayed to the user
	Then User updates the Details on Self Service tab
	| EnableSelfServicePortal | AllowAnonymousUsers | ThisProjectDefault | ModeUser | ModeComputer | NoLink | DashworksProjectHomepage | CustomUrl |
	| false                   | false               | true               | true     | false        | true   | false                    | false     |
	Then Success message is displayed with "Details successfully updated." text
	When User navigate to "Welcome" on Self Service tab
	Then User updates the Welcome on Self Service tab
	| AllowToSearchForAnotherUser | AllowToChangeLanguage | ShowProjectSelector | ShowMoreDetailsLink | PageDescription | ProjectName |
	| true                        | false                 | false               | true                | TestText        | ProjectName |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Computer Ownership" on Self Service tab
	Then User updates the Computer Ownership on Self Service tab
	| ShowScreen | ShowComputers | ShowCategory | AllowUsersToSearch | AllowUsersToSetPrimary | AllowUsersToAddANote | LimitMaximum | LimitMinimum | PageDescription |
	| true       | true          | false        | false              | false                  | false                | 100          | 10           | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Department and Location" on Self Service tab
	Then User updates the Department and Location on Self Service tab
	| ShowScreen | ShowDepartmentFullPath | ShowLocationFullPath | AllowUsersToAddANote | Department | Location | DepartmentFeed | HrLocationFeed | ManualLocationFeed | HistoricLocationFeed |
	| true       | false                  | false                | false                | false      | false    | true           | false          | false              | false                |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Apps List" on Self Service tab
	Then User updates the Apps List on Self Service tab
	| ShowThisScreen | ShowCoreApps | ShowTargetStateReadiness | ShowRequiredColumnAndSticky | ShowOnlyApplication | AllowUsersToAddANote | PageDescription |
	| true           | true         | true                     | true                        | true                | true                 | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Project Date" on Self Service tab
	Then User updates the Project Date on Self Service tab
	| AllowUsersToAddANote | MinimumHours | MaximumHours | PageDescription |
	| true                 | 10           | 100          | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 1" on Self Service tab
	Then User updates the first Other Options on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription |
	| false      | true                 | false     | true      | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 2" on Self Service tab
	Then User updates the second Other Options on Self Service tab
	| ShowScreen | AllowUsersToAddANote | OnlyOwned | AllLinked | PageDescription |
	| false      | true                 | true      | false     | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Thank You" on Self Service tab
	Then User updates the Thank You on Self Service tab
	| SelfServicePortal | NavigationMenu | ChoicesSummary | IncludeLink | PageDescription |
	| true              | false          | false          | false       | TestText        |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Capacity" tab
	Then "Manage Capacity" page is displayed to the user
	Then User updates the Details on Capacity tab
	| EnablePlanning | DisplayColors | EnforceOonSelfServicePage | EnforceOnProjectObjectPage | CapacityToReach |
	| true           | true          | true                      | true                       | 80              |
	Then Success message is displayed with "Details successfully updated." text
	When User navigate to "Capacity" on selected tab
	Then User updates the Capacity on Capacity tab
	| StartDate   | EndDate     | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	| 06 Apr 2016 | 19 Apr 2018 | false          | false           | false             | false            | false          | false            | false          | 100    | 100     | 100       | 100      | 100    | 100      | 100    |
	Then Success message is displayed with "Capacity information successfully updated." text
	When User navigate to "Summary" on selected tab
	When User select created request type on Summary tab
	Then table for selected request type is displayed
	When User navigate to "Override Dates" on selected tab
	Then User updates the Override Dates on Capacity tab
	| Date        | Capacity | Comment  |
	| 03 Apr 2016 | 0        | TestText |
	Then Success message is displayed with "Override date successfully inserted" text
	When User navigate to "Groups" tab
	Then User removes created Group
	#Then selected Group was removed
	When User navigate to "Teams" tab
	Then User removes created Team
	#Then selected Team was removed
	When User navigate to "Tasks" tab
	Then User removes created Task
	#Then selected Task was removed
	Then Success message is displayed with "Task successfully deleted." text
	When User navigate to "Stages" tab
	Then User removes created Stage
	#Then selected Stage was removed
	Then Success message is displayed with "Stage successfully deleted." text
	When User navigate to "Categories" tab
	Then User removes created Category
	#Then selected Category was removed
	Then Success message is displayed with "Category successfully deleted." text
	When User navigate to "Request Types" tab
	When User click on the "[Default (Computer)]" Request Type
	Then User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then User removes created Request Type
	#Then selected Request Type was removed
	Then Success message is displayed with "Request Type successfully deleted" text
	#When User click on the "[Default (Application)]" Request Type
	#Then User updates the Request Type page
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#Then User removes created Request Type
	##Then selected Request Type was removed
	#Then Success message is displayed with "Request Type successfully deleted" text
	#When User click on the "[Default (User)]" Request Type
	#Then User updates the Request Type page
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#Then User removes created Request Type
	##Then selected Request Type was removed
	#Then Success message is displayed with "Request Type successfully deleted" text
	When User navigate to "Mail Templates" tab
	Then User removes created Mail Template
	#Then selected Mail Template was removed
	Then Success message is displayed with "Mail Template successfully deleted." text
	When User navigate to "Details" tab
	Then User removes the Project
	Then Success message is displayed with "Project successfully deleted" text
	When User navigate to Manage link
	When User select "Manage Users" option in Management Console
	Then User removes created User
	#Then selected User was removed
	Then Success message is displayed
	#Then User removes created User
	##Then selected User was removed
	#Then Success message is displayed
	#Then User removes created User
	##Then selected User was removed
	#Then Success message is displayed