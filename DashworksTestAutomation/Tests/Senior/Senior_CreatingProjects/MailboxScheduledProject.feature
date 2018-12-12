Feature: CreateMailboxScheduledProject
	Runs Project related tests

Background: Pre-Conditions
	Given User is logged in to the Projects
	Then "Projects Home" page is displayed to the user

@Senior @Projects_Administration @MailboxScheduledProject @Delete_Newly_Created_Team
Scenario: Projects_CreateMailboxScheduledProject
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates Project
	| ProjectName                 | ProjectShortName | ProjectDescription      | ProjectTypeString       |
	| 000 MailboxScheduledProject | Mailbox          | MailboxScheduledProject | MailboxScheduledProject |
	Then Error message is not displayed
	When User clicks "Create Project" button
	Then Error message is not displayed
	Then "Manage Project Details" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	Then User create a new Dashworks User
	| Username                    | FullName                  | Password | ConfirmPassword | RolesString |
	| AAA0MailboxScheduledProject | MailboxScheduledProject 0 | 1234qwer | 1234qwer        |             |
	And Success message is displayed
	And created User is displayed in the table
	And User create a new Dashworks User
	| Username                    | FullName                  | Password | ConfirmPassword | RolesString |
	| AAA1MailboxScheduledProject | MailboxScheduledProject 1 | 1234qwer | 1234qwer        |             |
	And Success message is displayed
	And created User is displayed in the table
	And User create a new Dashworks User
	| Username                    | FullName                  | Password | ConfirmPassword | RolesString |
	| AAA2MailboxScheduledProject | MailboxScheduledProject 2 | 1234qwer | 1234qwer        |             |
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
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 |  Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	Then Success message is displayed with "Project was successfully updated" text
		#Creating Request Types
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description               | ObjectTypeString |
	| 1 TestRequestTypeName | MailboxScheduledProject 1 | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description               | ObjectTypeString |
	| 2 TestRequestTypeName | MailboxScheduledProject 2 | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description               | ObjectTypeString |
	| 3 TestRequestTypeName | MailboxScheduledProject 3 | Mailbox          |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User removes created Request Type
	And User clicks "Create Request Type" button
	And User create Request Type
	| Name                  | Description               | ObjectTypeString |
	| 1 TestRequestTypeName | MailboxScheduledProject 1 | User             |
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
	| Name                  | Description               | ObjectTypeString |
	| 2 TestRequestTypeName | MailboxScheduledProject 2 | Application      |
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
	| Name                  | Description               | ObjectTypeString |
	| 3 TestRequestTypeName | MailboxScheduledProject 3 | Mailbox          |
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
		#Creating Category
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	And User create Category
	| Name          | Description             | ObjectTypeString |
	| User Category | MailboxScheduledProject | User             |
	Then Success message is displayed with "Category successfully created." text
	When User clicks "« Go Back" button
	Then created Category is displayed in the table
	When User clicks "Create Category" button
	And User create Category
	| Name             | Description             | ObjectTypeString |
	| Mailbox Category | MailboxScheduledProject | Mailbox          |
	Then Success message is displayed with "Category successfully created." text
	When User clicks "« Go Back" button
	Then created Category is displayed in the table
	When User clicks "Create Category" button
	And User create Category
	| Name                 | Description             | ObjectTypeString |
	| Application Category | MailboxScheduledProject | Application      |
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
		#Creating Mail Template
	When User navigate to "Mail Templates" tab
	Then "Manage Mail Templates" page is displayed to the user
	When User clicks "Create Mail Template" button
	And User create Mail Template
	| Name                 | Description             | SubjectLine | BodyText |
	| TestMailTemplateName | MailboxScheduledProject | TestText    | TestText |
	Then Success message is displayed with "Mail Template successfully created." text
		#Creating Tasks 1
	When User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User create Task
	| Name          | Help                    | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| TestTaskName0 | MailboxScheduledProject | Stage 1          | Normal         | Radiobutton     | User             |                          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true                 | false          | true        | true          | false      | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User publishes the task
	Then selected task was published
	When User navigate to "Values" page
	And User clicks "Add value" button
	When User create new Value
	| Name          | TaskStatusString | DefaultValue |
	| TestValueName | Open             | true         |
	And User clicks "Save Value" button
	When User clicks "« Go Back to Tasks" button
	Then created Task is displayed in the table
		#Creating Tasks 2
	When User clicks "Create Task" button
	And User create Task
	| Name          | Help                     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| TestTaskName1 | ComputerScheduledProject | Stage 2          | Group          | DropDownList    | User             | ReadinessNnsfc           | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskImpactsReadiness | TaskHasAnOwner | ShowDetails | BulkUpdate | GroupTaskDashboard |
	| true           | DateOnly       | Workflow              | true                 | true           | true        | false      | false              |
	Then Success message is displayed with "Task successfully updated" text
	When User clicks "Cancel" button
	Then created Task is displayed in the table
	When User clicks "Create Task" button
	And User create Task
	| Name          | Help                    | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | ApplyToAllCheckbox |
	| TestTaskName2 | MailboxScheduledProject | Stage 3          | Normal         | Text            | Mailbox          | true               |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TextModeString | TaskProjectRoleString | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| SingleLine     | None                  | true        | false         | true       | false       |
	Then Success message is displayed with "Task successfully updated" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	Then created Task is displayed in the table
		#Creating Teams
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	When User clicks "Create Team" button
	And User create Team
	| TeamName                    | ShortDescription |
	| 000 MailboxScheduledProject | TestText 0       |
	And User clicks "Add Member" button
	And User select user with "Admin" name to add as member
	And User clicks "Add Member" button
	And User select "1" user to add as member
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
	When User clicks "Create Team" button
	And User create Team
	| TeamName                    | ShortDescription |
	| 001 MailboxScheduledProject | TestText 1       |
	And User clicks "Add Member" button
	And User select user with "Admin" name to add as member
	And User clicks "Add Member" button
	And User select "2" user to add as member
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
	When User clicks "Create Team" button
	And User create Team
	| TeamName                    | ShortDescription |
	| 002 MailboxScheduledProject | TestText 2       |
	And User clicks "Add Member" button
	And User select user with "Admin" name to add as member
	And User clicks "Add Member" button
	And User select "3" user to add as member
	And User clicks "Cancel" button
	Then created Team is displayed in the table
	And "2" number of Members is displayed for created Team
		#Creating Groups
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Create Group" button
	And User create Group owned for "1" Team
	| GroupName                 |
	| 0 MailboxScheduledProject |
	Then created Group is displayed in the table
	When User clicks "Create Group" button
	And User create Group owned for "2" Team
	| GroupName                 |
	| 1 MailboxScheduledProject |
	Then created Group is displayed in the table
	When User clicks "Create Group" button
	And User create Group owned for "3" Team
	| GroupName                 |
	| 2 MailboxScheduledProject |
	Then created Group is displayed in the table
	When User navigate to "Teams" tab
	Then "Manage Teams" page is displayed to the user
	And "1" number of Groups is displayed for "3" Team
		#Creating News
	When User navigate to "News" tab
	Then "Manage News" page is displayed to the user
	When User updating News page
	| Title                   | Text     |
	| MailboxScheduledProject | TestText |
	Then Success message is displayed with "Project news was successfully updated." text
		#Self Service tabs
	When User navigate to "Self Service" tab
	Then "Manage Self Service" page is displayed to the user
	When User updates the Details page on Self Service tab
	| EnableSelfServicePortal | AllowAnonymousUsers | ThisProjectDefault | Mode1 | Mode2 | BaseUrl | NoLink | DashworksProjectHomepage | CustomUrl | CustomUrlTextField    |
	| false                   | false               | true               | false | true  |         | false  | false                    | true      | http://www.juriba.com |
	Then Success message is displayed with "Details successfully updated." text
	When User navigate to "Welcome" page on Self Service tab
	And User updates the Welcome page on Self Service tab
	| AllowUsersToSearch | AllowToChangeLanguage | ShowProjectSelector | ShowObjectDetails | ShowMoreDetailsLink | PageDescription | ProjectName             |
	| true               | false                 | false               |                   | true                | TestText        | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Mailbox Ownership" page on Self Service tab
	And User updates the Ownership page on Self Service tab
	| ShowScreen | ShowCategory | AllowUsersToSearch | AllowUsersToSetPrimary | AllowUsersToAddANote | PageDescription         |
	| true       | false        | false              | false                  | false                | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Department and Location" page on Self Service tab
	And User updates the Department and Location page on Self Service tab
	| ShowScreen | ShowDepartmentFullPath | ShowLocationFullPath | AllowUsersToAddANote | Department | DepartmentDoNotPush | DepartmentPushToOwned | DepartmentPushToAll | Location | LocationDoNotPush | LocationPushToOwned | LocationPushToAll | DepartmentFeed | HrLocationFeed | ManualLocationFeed | HistoricLocationFeed |
	| true       | false                  | false                | false                | false      | true                | false                 | false               | false    | false             | false               | false             | false          | false          | false              | false                |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Apps List" page on Self Service tab
	And User updates the Apps List page on Self Service tab
	| ShowThisScreen | ShowCoreApps | ShowTargetStateReadiness | ShowRequiredColumnAndSticky | ShowOnlyApplication | AllowUsersToAddANote | PageDescription         | ViewString         |
	| true           | true         | true                     | true                        | true                | true                 | MailboxScheduledProject | ComparisonExpanded |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Project Date" page on Self Service tab
	And User updates the Project Date page on Self Service tab
	| ShowScreen | ShowComputerNameString | AllowUsersToAddANote | MinimumHours | MaximumHours | PageDescription         |
	| true       | DoNotShow              | true                 | 10           | 100          | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 1" page on Self Service tab
	And User updates the first Other Options page on Self Service tab
	| ShowScreen | AllowUsersToAddANote | PageDescription         |
	| false      | true                 | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Other Options 2" page on Self Service tab
	And User updates the second Other Options page on Self Service tab
	| ShowScreen | AllowUsersToAddANote | PageDescription         |
	| false      | true                 | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
	When User navigate to "Thank You" page on Self Service tab
	And User updates the Thank You page on Self Service tab
	| SelfServicePortal | NavigationMenu | ChoicesSummary | IncludeLink | PageDescription         |
	| true              | false          | false          | false       | MailboxScheduledProject |
	Then Success message is displayed with "Self Service Screen successfully updated" text
		#Capacity tabs
	#When User navigate to "Capacity" tab
	#Then "Manage Capacity" page is displayed to the user
	#When User updates the Details on Capacity tab
	#| EnablePlanning | DisplayColors | EnforceOonSelfServicePage | EnforceOnProjectObjectPage | CapacityToReach |
	#| true           | true          | true                      | true                       | 80              |
	#Then Success message is displayed with "Details successfully updated." text
	#When User navigate to "Capacity" page
	#And User updates the Capacity page on Capacity tab for "1" Team
	#| StartDate   | EndDate     | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	#| 06 Apr 2016 | 19 Apr 2018 | false          | false           | false             | false            | false          | false            | false          | 100    | 100     | 100       | 100      | 100    | 100      | 100    |
	#Then Success message is displayed with "Capacity information successfully updated." text
	#When User updates the Capacity page on Capacity tab for "2" Team
	#| StartDate   | EndDate       | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	#| 08 May 2013 | 20 March 2015 | false          | false           | false             | false            | false          | false            | false          | 10     | 10      | 10        | 10       | 10     | 10       | 10     |
	#Then Success message is displayed with "Capacity information successfully updated." text
	#When User updates the Capacity page on Capacity tab for "3" Team
	#| StartDate    | EndDate     | MondayCheckbox | TuesdayCheckbox | WednesdayCheckbox | ThursdayCheckbox | FridayCheckbox | SaturdayCheckbox | SundayCheckbox | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday |
	#| 16 June 2012 | 27 May 2016 | false          | false           | false             | false            | false          | false            | false          | 100    | 100     | 100       | 100      | 100    | 100      | 100    |
	#Then Success message is displayed with "Capacity information successfully updated." text
	#When User navigate to "Summary" page
	#And User select created request type on Summary tab
	#Then table for selected request type is displayed
	#When User navigate to "Override Dates" page
	#And User updates the Override Dates on Capacity tab
	#| Date         | Capacity | Comment                 |
	#| 06 June 2016 | 0        | MailboxScheduledProject |
	#Then Success message is displayed with "Override date successfully inserted" text
		#removing
	#When User navigate to "Groups" tab
	#And User removes created Group
	#Then selected Group was removed
	#When User removes created Group
	#Then selected Group was removed
	#When User removes created Group
	#Then selected Group was removed
	#When User navigate to "Teams" tab
	#And User removes created Team
	#Then selected Team was removed
	#When User removes created Team
	#Then selected Team was removed
	#When User removes created Team
	#Then selected Team was removed
	#When User navigate to "Tasks" tab
	#And User removes created Task
	#Then selected Task was removed
	#And Success message is displayed with "Task successfully deleted." text
	#When User removes created Task
	#Then selected Task was removed
	#And Success message is displayed with "Task successfully deleted." text
	#When User removes created Task
	#Then selected Task was removed
	#And Success message is displayed with "Task successfully deleted." text
	#When User navigate to "Stages" tab
	#And User removes created Stage
	#Then selected Stage was removed
	#And Success message is displayed with "Stage successfully deleted." text
	#When User removes created Stage
	#Then selected Stage was removed
	#And Success message is displayed with "Stage successfully deleted." text
	#When User removes created Stage
	#Then selected Stage was removed
	#And Success message is displayed with "Stage successfully deleted." text
	#When User navigate to "Categories" tab
	#And User removes created Category
	#Then selected Category was removed
	#And Success message is displayed with "Category successfully deleted." text
	#When User navigate to "Request Types" tab
	#And User makes "[Default (Mailbox)]" Request Type default
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#And User removes created Request Type
	#Then selected Request Type was removed
	#And Success message is displayed with "Request Type successfully deleted" text
	#When User makes "[Default (Application)]" Request Type default
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#And User removes created Request Type
	#Then selected Request Type was removed
	#And Success message is displayed with "Request Type successfully deleted" text
	#When User makes "[Default (User)]" Request Type default
	#| DefaultRequestType |
	#| true               |
	#Then Success message is displayed with "Request Type successfully updated" text
	#When User clicks "Cancel" button
	#And User removes created Request Type
	#Then selected Request Type was removed
	#And Success message is displayed with "Request Type successfully deleted" text
	#When User navigate to "Mail Templates" tab
	#And User removes created Mail Template
	#Then selected Mail Template was removed
	#And Success message is displayed with "Mail Template successfully deleted." text
	#When User navigate to "Details" tab
	#And User removes the Project
	#Then Success message is displayed with "Project successfully deleted" text
	#When User navigate to Manage link
	#And User select "Manage Users" option in Management Console
	#And User removes created User
	#Then selected User was removed
	#And Success message is displayed
	#When User removes created User
	#Then selected User was removed
	#And Success message is displayed
	#When User removes created User
	#Then selected User was removed
	#And Success message is displayed