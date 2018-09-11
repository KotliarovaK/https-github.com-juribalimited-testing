Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS12761 @DAS11770 @DAS12999 @Project_Creation_and_Scope @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters " " in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	Then Create Project button is disabled
	When User enters "All Devices Project" in the Project Name field
	And User clicks Create button on the Create Project page
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters " all devices project" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Error message with "A project already exists with this name" text is displayed
	When User create static list with "StaticList4581" name on "Devices" page with following items
	| ItemName       |
	| 0AN6PG99INA7R2 |
	| 0B4UHHUZQBRXKE |
	Then "StaticList4581" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject84" in the Project Name field
	And User selects "StaticList4581" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "TestProject84" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "DynamicList5531" name on "Devices" page
	Then "DynamicList5531" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject1258" in the Project Name field
	And User selects "DynamicList5531" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User enters "Devices" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11891 @DAS11747 @Delete_Newly_Created_Bucket @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	Then Search fields for "Devices" column contain correctly value
	Then Search fields for "Users" column contain correctly value
	Then Search fields for "Mailboxes" column contain correctly value
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters " " in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	Then Create Bucket button is disabled
	When User clicks "Buckets" link on the Admin page
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed
	And There are no errors in the browser console
	Then Delete "TestBucket1" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11747 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyTeamName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters " " in the Team Name field
	And User enters "test" in the Team Description field
	Then Create Team button is disabled
	When User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @DAS11886 @DAS12613 @DAS13199 @Delete_Newly_Created_List @Delete_Newly_Created_Project @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedAfterDeletingUsedForProjectLists 
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	And User create dynamic list with "ListForProject" name on "Users" page
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the Project Name field
	And User selects "ListForProject" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject1" record in the grid
	Then Project "TestProject1" is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And Update Project buttons is disabled
	When User selects "Scope Details" tab on the Project details page
	When User selects "All Users" in the Scope Project details
	When User selects "Scope Changes" tab on the Project details page
	Then Warning message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959 @DAS12553 @DAS11744 @DAS12742 @DAS12999 @DAS13199 @DAS13254 @DAS13323 @DAS13393 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject1" is displayed to user
	When User clicks "Details" tab
	And User changes Project Name to "NewProjectName"
	And User changes Project Short Name to "NewShort4875"
	And User changes Project Description to "45978DescriptionText"
	And User changes project language to "Dutch"
	And User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	And There are no errors in the browser console
	When User click on Back button
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks Actions button on the Projects page
	And User clicks Delete Project button
	And User clicks Delete button
	Then Delete button is displayed to the User on the Projects page
	When User cancels the selection of all rows on the Projects page
	Then Delete button is not displayed to the User on the Projects page
	When User enters "NewProjectName" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following associations are disabled:
	| AssociationName                        |
	| Entitled to the device owner           |
	| Used by the device owner on any device |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Include device owners" checkbox on the Project details page
	Then Scope List dropdown is active
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Associations are available
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 14631 selected)" is displayed to the user in the Project Scope Changes section
	When User click on Back button
	And User enters "NewProjectName" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11931 @DAS12742 @DAS11769 @DAS12999 @Project_Creation_and_Scope @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectsAreDeletedSuccessfullyAndThereAreNoConsoleErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User selects "<ScopeList>" in the Scope Project dropdown
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected project has been deleted" text
	And There are no errors in the browser console
	Then "<ProjectName>" item was removed
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User selects "<StaticList>" in the Scope Project dropdown
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User selects "<DynamicList>" in the Scope Project dropdown
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text

Examples:
	| ProjectName  | ScopeList     | StaticList     | PageName  | Item                   | ColumnName    | DynamicList     |
	| TestProject2 | All Devices   | StaticList8812 | Devices   | 00KWQ4J3WKQM0G         | Hostname      | DynamicList9517 |
	| TestProject3 | All Users     | StaticList8813 | Users     | 003F5D8E1A844B1FAA5    | Username      | DynamicList9518 |
	| TestProject4 | All Mailboxes | StaticList8814 | Mailboxes | ZVI880605@bclabs.local | Email Address | DynamicList9519 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	#Then Counter shows "558" found rows
	When User have opened Column Settings for "Bucket" column
	And User clicks Filter button on the Column Settings panel
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User have opened Column Settings for "Devices" column
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then Content is present in the table on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Default" column
	When User clicks "True" checkbox from String Filter on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Project" column
	When User clicks "Select All" checkbox from String Filter on the Admin page
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	#Add sorting check for "Bucket" column
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in ascending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in descending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @DAS12999 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Team" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column
	Then Counter shows "1" found rows
	When User clicks content from "Team" column
	Then "Administrative Team" team details is displayed to the user
	When User have opened Column Settings for "Username" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User click on Back button
	And User have opened Column Settings for "Default" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	When User clicks "True" checkbox from String Filter on the Admin page
	Then Counter shows "2,789" found rows
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	Then Content is present in the table on the Admin page
	When User enters "Team 10" text in the Search field for "Description" column
	Then Counter shows "111" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "1" text in the Search field for "Evergreen Buckets" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "5" text in the Search field for "Project Buckets" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "2" text in the Search field for "Members" column
	Then Counter shows "4" found rows
	When User clicks Reset Filters button on the Admin page
	And User click on "Team" column header on the Admin page
	#Remove hash after fix sort order
	#Then data in table is sorted by "Team" column in ascending order on the Admin page
	When User click on "Team" column header on the Admin page
	Then data in table is sorted by "Team" column in descending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in ascending order on the Admin page
	When User click on "Description" column header on the Admin page
	Then data in table is sorted by "Description" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in descending order on the Admin page
	When User click on "Members" column header on the Admin page
	Then numeric data in table is sorted by "Members" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in descending order on the Admin page
	When User click on "Evergreen Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Evergreen Buckets" column in ascending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in descending order on the Admin page
	When User click on "Project Buckets" column header on the Admin page
	Then numeric data in table is sorted by "Project Buckets" column in ascending order on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11879 @DAS12742 @DAS12752 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSpecificWarningMessageIsNotDisplayedAfterTryingToDeleteNonDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Bucket Settings" tab
	Then Default Bucket checkbox is selected
	When User click on Back button
	When User clicks Reset Filters button on the Admin page
	And User enters "Chicago" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	When User clicks Delete button
	Then "You can not delete the default bucket" warning message is not displayed on the Buckets page
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12182 @DAS12999 @DAS13199 @DAS13297 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject5" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject5" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 16765 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Associations are selected by default
	When User navigates to the "Device Scope" tab in the Scope section on the Project details page
	And User selects "Do not include owned devices" checkbox on the Project details page
	Then Scope List dropdown is disabled
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following associations are disabled:
	| AssociationName                         |
	| Entitled to a device owned by the user  |
	| Installed on a device owned by the user |
	| Used on an owned device by any user     |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 247 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Details" tab
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	Then There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12154 @DAS12742 @DAS12872 @Delete_Newly_Created_List @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedWhenDeletingListUsingInTheProjectThatWasDeleted
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList0A78U9" name on "Devices" page
	Then "TestList0A78U9" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject6" in the Project Name field
	And User selects "TestList0A78U9" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then "Projects" page should be displayed to the user
	Then Success message is displayed and contains "Your project has been created" text
	And There are no errors in the browser console
	When User enters "TestProject6" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A78U9" list
	And User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And no Warning message is displayed in the lists panel

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11748 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNotificationMessageIsDisplayedAfterUpdatingBucketToDefaultType
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket2" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "TestBucket2" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	And User updates the Default Bucket checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Bucket Settings" tab
	Then Default Bucket checkbox is selected
	When User click on Back button
	And User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User updates the Default Bucket checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "TestBucket2" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11763 @DAS12742 @DAS12760 @Buckets @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeletingBucketFromBucketsSection
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "IB Team" team details is displayed to the user
	When User clicks "Buckets" tab
	And User enters "Group IB Team" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete Buckets" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761 @DAS12999 @DAS13199 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam1" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	Then "TestTeam1" team details is displayed to the user
	When User clicks "Team Settings" tab
	And User enters "" in the Team Description field
	Then Update Team button is disabled
	When User enters " " in the Team Description field
	Then Update Team button is disabled
	When User enters "testTeamtest" in the Team Description field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text
	And There are no errors in the browser console
	When User clicks refresh button in the browser
	When User enters "" in the Team Name field
	Then Update Team button is disabled
	When User enters " " in the Team Name field
	Then Update Team button is disabled
	When User enters "NewTeamName" in the Team Name field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text
	And There are no errors in the browser console
	Then Delete "NewTeamName" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170 @DAS13011 @Buckets @Remove_Added_Objects_From_Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatMailboxesAreSuccessfullyAddedToBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Birmingham" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	Then Counter shows "147" found rows
	When User clicks the "ADD MAILBOX" Action button
	And User adds following Objects from list
	| Objects                          |
	| 040698EE82354C17B60@bclabs.local |
	| 04D8FC40F25547E7B4D@bclabs.local |
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And Counter shows "149" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170 @DAS13011 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingMailboxesToTheBucketWhereNoMailboxesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	When User clicks the "ADD MAILBOX" Action button
	Then No items text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11982 @DAS12773 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatAllAssociationsAreSelectedByDefaultInTheProjectApplicationsScope
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject7" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject7" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Associations are selected by default
	When  User selects "Do not include applications" checkbox on the Project details page
	Then All Associations are disabled
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When  User selects "Include applications" checkbox on the Project details page
	Then All Associations are selected by default

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @Buckets @DAS13011 @Remove_Added_Objects_From_Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingDevicesInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Counter shows "20" found rows
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects        |
	| VXERDNJ3KRJ421 |
	| XV20GW6HJRVE2R |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	And Counter shows "22" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @Buckets @DAS13011
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingDevicesToTheBucketWhereNoDevicesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks the "ADD DEVICE" Action button
	Then No items text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170 @DAS13011 @Buckets @Remove_Added_Objects_From_Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingUsersInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Users" tab
	Then Counter shows "15" found rows
	When User clicks the "ADD USER" Action button
	And User adds following Objects from list
	| Objects   |
	| ADK614179 |
	| AAT858228 |
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And Counter shows "17" found rows
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11697 @DAS12744 @DAS12999 @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCancelButtonOnTheCreateProjectPageRedirectsToTheLastPage
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then "<ListName>" list should be displayed to the user

Examples:
	| ListName  |
	| Devices   |
	| Users     |
	| Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12189 @DAS12523 @DAS12521 @DAS12744 @DAS12162 @DAS12532 @Delete_Newly_Created_List @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorsAreDisplayedInTheProjectScopeChangesSectionAfterUsingSavedDevicesList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Vendor is adobe" name on "Applications" page
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association         |
	| Vendor is adobe | Used on device      |
	| Vendor is adobe | Entitled to device  |
	| Vendor is adobe | Installed on device |
	Then "Application" filter is added to the list
	When User create dynamic list with "DevicesList1584" name on "Devices" page
	Then "DevicesList1584" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject9" in the Project Name field
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject9" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	And User clicks "Devices" tab in the Project Scope Changes section
	And User clicks "Applications" tab in the Project Scope Changes section
	#Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "K-Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "K-Team" team details is displayed to the user
	When User clicks Add Members button on the Teams page
	Then Panel of available members is displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552 @DAS13011
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "Migration phase 3 team" text in the Search field for "Team" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "=8" text in the Search field for "Project Buckets" column
	Then Counter shows "0" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "Administrative Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User enters "readonly" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User clicks "Buckets" tab
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	When User enters "=35" text in the Search field for "Devices" column
	Then Counter shows "0" found rows
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Counter shows "2" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "=2" text in the Search field for "Users" column
	Then Counter shows "2" found rows
	When User clears Search field for "Project Buckets" column
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User enters "M1D" text in the Search field for "Hostname" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "Windows XP" text in the Search field for "Operating System" column
	Then Counter shows "2" found rows
	When User clicks "Users" tab
	When User enters "Danielle A. Tate" text in the Search field for "Display Name" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "TZV202" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User click on Back button
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Mailboxes" tab
	And User enters "DiscoverySearchMailbox{D919BA05-46A6-415f-80AD-7E09334BB852}@juriba1.onmicrosoft.com" text in the Search field for "Email Address (Primary)" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "RD-EXCH2K3" text in the Search field for "Server Name" column
	Then Counter shows "6" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12236 @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedAfterUpdatingProjectScopeChanges
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject5" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject5" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User clicks "Entitled to the device owner" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	When User selects following Objects
	| Objects                     |
	| 20040610sqlserverck (1.0.0) |
	| 7zip                        |
	| ACDSee 4.0 (4.0.0)          |
	And User clicks the "UPDATE APPLICATION CHANGES" Action button
	Then Warning message with "3 applications will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	And "Applications to add (0 of 2126 selected)" is displayed to the user in the Project Scope Changes section
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "birmingham" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforTeamsList
	When User clicks Admin on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User enters "K-Team" text in the Search field for "Team" column
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12370
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportProjectButtonEnabledAfterWarningOnImportProjectPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	Then "Import Project" page should be displayed to the user
	When User selects incorrect file to upload on Import Project page
	And User selects "Import to new project" in the Import dropdown on the Import Project Page
	And User enters "TestProjectNameDAS12370" in the Project Name field on Import Project page
	And User clicks Import Project button on the Import Project page
	And User selects correct file to upload on Import Project page
	Then Import Project button is enabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12333 @DAS12999 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_ChecksThatDeviceScopeDDLIsDisabledWhenDoNotIncludeOwnedDevicesIsSelected
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Rainbow" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "Rainbow" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12578 @DAS12999 @DAS13429 @Delete_Newly_Created_List @Projects @Not_Run
Scenario Outline: EvergreenJnr_AdminPage_CheckThatTheEditListFunctionIsHiddenAfterCancelingCreatingProjectFromTheMainLists
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then "<DynamicListName>" list is displayed to user
	And Edit List menu is not displayed
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject7894" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks the "CANCEL" Action button
	Then "Projects" page should be displayed to the user

Examples:
	| ListName  | ColumnName    | DynamicListName |
	| Devices   | Hostname      | TestList6589    |
	| Users     | Username      | TestList6588    |
	| Mailboxes | Email Address | TestList6587    |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12751 @DAS12747 @DAS12999 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedCheckboxIsSelectedAfterSwitchingBetweenTabs
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject13" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject13" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then Update Project buttons is disabled
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 02UXAL8OAR3K1O |
	Then Update Project button is active
	And "Devices to add (1 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                   |
	| AAH0343264 (Luc Gauthier) |
	And User clicks "Devices" tab in the Project Scope Changes section
	When User expands the object to add 
	Then following items are still selected
	And "Devices to add (1 of 17225 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12760 @DAS13254 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckMessageThatDisplayedWhenDeletingBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket4" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket4" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected bucket has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12387 @DAS12757 @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardingOfObjectsIsProceedForScopedProjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DDPPProject14" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "DDPPProject14" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User adds following Objects to the Project
	| Objects        |
	| 0317IPQGQBVAQV |
	| 00I0COBFWHOF27 |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User clicks "Users" tab in the Project Scope Changes section
	And User adds following Objects to the Project
	| Objects                       |
	| AAG081456 (Melanie Z. Fowler) |
	| AAH0343264 (Luc Gauthier)     |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User click on Back button
	And User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "NewProject15" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "NewProject15" is displayed to user
	And Success message is not displayed on the Projects page
	When User click on Back button
	Then data in table is sorted by "Project" column in ascending order by default on the Admin page
	When User enters "NewProject15" text in the Search field for "Project" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Active" column on the Admin page
	When User clicks "True" checkbox from String Filter on the Admin page
	Then Counter shows "0" found rows
	#When User clicks Reset Filters button on the Admin page
	#When User clicks String Filter button for "Type" column on the Admin page
	#When User selects "Device scoped" checkbox from String Filter on the Admin page
	#Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page 
	When User enters "DDPP" text in the Search field for "Short Name" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page 
	When User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Project ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Project ID |
	And content is present in the following newly added columns:
	| ColumnName |
	| Project ID |
	When User enters "01" text in the Search field for "Project ID" column
	Then Counter shows "0" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12332 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatRedBannerWithOkMessageIsNotDisplayedAfterAddingItemsToCreatedProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12332" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12332" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add
	And User selects following Objects
	| Objects        |
	| 1DPQO52HJQZJ0H |
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects                                    |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "1 device will be added, 1 user will be added, 1 application will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12796 @DAS12872 @Delete_Newly_Created_List @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatNumberOfObjectIsUpdatedInTheScopeChangesOfProjectAfterTheChangeCustomList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	And "<RowsCount>" rows are displayed in the agGrid
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "<ProjectName>" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsCount>" is displayed to the user in the Project Scope Changes section
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to the "<DynamicListName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <Checkbox>     |
	When User update current custom list
	Then "<NewRowsCount>" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "<ProjectName>" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "<NewCount>" is displayed to the user in the Project Scope Changes section

Examples:
	| ListName  | ColumnName    | DynamicListName | RowsCount | ProjectName     | ObjectsCount | FilterName  | Checkbox | NewRowsCount | NewCount | DeleteProject   |
	| Devices   | Hostname      | ProjectList4587 | 17,225    | TestProject4511 | 17225        | Device Type | Desktop  | 8,103        | 8103     | TestProject4511 |
	| Users     | Username      | ProjectList4511 | 41,339    | TestProject4512 | 41339        | Domain      | CORP     | 103          | 103      | TestProject4512 |
	| Mailboxes | Email Address | ProjectList4548 | 14,784    | TestProject4513 | 14784        | Owner City  | London   | 3,294        | 3294     | TestProject4513 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12816 @DAS12873 @DAS13007 @DAS13199 @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatObjectsIsOnboardedToTheProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject19" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	And There are no errors in the browser console
	When User clicks newly created object link
	Then Project "TestProject19" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 01BQIYGGUW5PRP6 |
	And User clicks the "UPDATE DEVICE CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message with "1 object queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Queue" tab on the Project details page
	Then There are no errors in the browser console
	Then Error message is not displayed on the Projects page
	Then following Items are onboarded
	| Items           |
	| 01BQIYGGUW5PRP6 |
	When User selects "History" tab on the Project details page
	Then There are no errors in the browser console
	Then Error message is not displayed on the Projects page
	Then following Items are onboarded
	| Items           |
	| 01BQIYGGUW5PRP6 |
	When User click on Back button
	And User enters "TestProject19" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks refresh button in the browser

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12490 @DAS13007 @DAS12999 @DAS13199 @DAS12680 @Project_Creation_and_Scope @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectDetailsForOnboardedObjectsIsDisplayedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12490" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12490" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects        |
	| 0IJB93JZPG72PX |
	| 04I01QSFL1AWKM |
	When User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects                        |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8 (8.0.39)              |
	When User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects                        |
	| ABQ575757 (Salvador K. Waller) |
	| ADG685492 (Eugene N. Stanton)  |
	Then "Devices 2/0" is displayed in the tab header on the Admin page
	And "Users 2/0" is displayed in the tab header on the Admin page
	And "Applications 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then "Devices 0/0" is displayed in the tab header on the Admin page
	And "Users 0/0" is displayed in the tab header on the Admin page
	And "Applications 0/0" is displayed in the tab header on the Admin page
	When User selects "Queue" tab on the Project details page
	#Then There are no errors in the browser console
	Then Error message is not displayed on the Projects page
	And following Items are onboarded
	| Items                          |
	| 0IJB93JZPG72PX                 |
	| 04I01QSFL1AWKM                 |
	| ABQ575757 (Salvador K. Waller) |
	| ADG685492 (Eugene N. Stanton)  |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8 (8.0.39)              |
	Then Counter shows "6" found rows
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by "Date" column in descending order on the Admin page
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by "Date" column in ascending order on the Admin page
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by "Item" column in ascending order on the Admin page
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by "Item" column in descending order on the Admin page
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by "Object Type" column in ascending order on the Admin page
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by "Object Type" column in descending order on the Admin page
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by "Action" column in ascending order on the Admin page
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by "Action" column in descending order on the Admin page
	#When User click on "Bucket" column header on the Admin page
	#Then data in table is sorted by "Bucket" column in ascending order on the Admin page
	#When User click on "Bucket" column header on the Admin page
	#Then data in table is sorted by "Bucket" column in descending order on the Admin page
	When User selects following date filter on the Projects page
	| FilterData |
	| 7302017    |
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "0IJB93JZPG72PX" text in the Search field for "Item" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "User" text in the Search field for "Object Type" column
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then Counter shows "4" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Computer Object" checkbox from String Filter on the Admin page
	Then Counter shows "4" found rows
	When User selects "History" tab on the Project details page
	#Then There are no errors in the browser console
	Then Error message is not displayed on the Projects page
	Then following Items are onboarded
	| Items                          |
	| 0IJB93JZPG72PX                 |
	| 04I01QSFL1AWKM                 |
	| ABQ575757 (Salvador K. Waller) |
	| ADG685492 (Eugene N. Stanton)  |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8 (8.0.39)              |
	Then Counter shows "6" found rows
	Then data in table is sorted by "Item" column in ascending order by default on the Admin page
	Then data in table is sorted by "Date" column in descending by default order on the Admin page
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by "Date" column in descending order on the Admin page
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by "Date" column in ascending order on the Admin page
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by "Item" column in ascending order on the Admin page
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by "Item" column in descending order on the Admin page
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by "Object Type" column in ascending order on the Admin page
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by "Object Type" column in descending order on the Admin page
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by "Action" column in ascending order on the Admin page
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by "Action" column in descending order on the Admin page
	When User click on "Status" column header on the Admin page
	Then data in table is sorted by "Status" column in ascending order on the Admin page
	When User click on "Status" column header on the Admin page
	Then data in table is sorted by "Status" column in descending order on the Admin page
	When User selects following date filter on the Projects page
	| FilterData |
	| 7302017    |
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "0IJB93JZPG72PX" text in the Search field for "Item" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "User" text in the Search field for "Object Type" column
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then Counter shows "4" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Computer Object" checkbox from String Filter on the Admin page
	Then Counter shows "4" found rows
	When User clicks String Filter button for "Status" column on the Admin page
	When User selects "Succeeded" checkbox from String Filter on the Admin page
	Then Counter shows "0" found rows
	When User type "0IJB93JZPG72PX" in Global Search Field
	Then User clicks on "0IJB93JZPG72PX (Carmen H. Benson)" search result
	When User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	#Remove hash after fix
	#And User clicks "TestProject12490" link on the Details Page
	#Then "Project Object" page is displayed to the user
	#Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11700 @Delete_Newly_Created_Project @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIdColumnIsAddedAndDisplayedCorrectlyToTheAdminProjectGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject11700" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	When User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Project ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Project ID |
	And content is present in the following newly added columns:
	| ColumnName |
	| Project ID |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11985 @DAS12857 @Delete_Newly_Created_Project @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectNameIsDisplayedCorrectlyWhenSpecialSymbolsAreUsedInTheProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<TestProject11985>" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "<TestProject11985>" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806 @DAS12999 @DAS13199 @DAS12680 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject20" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject20" is displayed to user
	When User clicks "Details" tab
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown
	When User expands the object to add
	And User selects following Objects
	| Objects         |
	| 0281Z793OLLLDU6 |
	| 03U75EKEMUQMUS  |
	Then "Devices 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "Devices 0/0" is displayed in the tab header on the Admin page
	When User click on Back button
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User clicks "Buckets" tab
	When User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks Admin on the left-hand menu

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12364 @DAS12999 @DAS13199 @DAS13297 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIsUpdatedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12364" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestProject12364" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	Then Project "TestProject12364" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add
	And User selects following Objects
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	| 01FF97A1FFAC48A1803 (Aultman, Chanel) |
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 16765 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 0SH2BQ3EPXTEWN |
	| 30LA8G32UF7HQC |
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects                                          |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	| Backburner (2.1.2.0)                             |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "6 objects queued for onboarding, 0 objects offboarded" text
	Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 16763 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 41337 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11729 @DAS13199 @Delete_Newly_Created_List @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedIfTryToRemoveCreatedListThatUsedInAnyProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "TestDynamicList11729" name on "Devices" page
	Then "TestDynamicList11729" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11729" in the Project Name field
	And User selects "TestDynamicList11729" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11729" name is displayed correctly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "TestDynamicList11729" list
	And User clicks Delete button for custom list
	Then "TestDynamicList11729" list "list is used by 1 project, do you wish to proceed?" message is displayed in the list panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestName11729" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName11729" is displayed to user
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11758
Scenario: EvergreenJnr_AdminPage_CheckThatSelectAllCheckboxIsWorkingCorrectlyOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "1Checkbox11758" name is displayed correctly
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "2Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "2Checkbox11758" name is displayed correctly
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "3Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "3Checkbox11758" name is displayed correctly
	When User selects all rows on the grid
	Then Select All selectbox is checked on the Admin page
	When User select "Project" rows in the grid on the Admin page
	| SelectedRowsName |
	| 1Checkbox11758   |
	Then Select All selectbox is unchecked on the Admin page
	When User select "Project" rows in the grid on the Admin page
	| SelectedRowsName |
	| 1Checkbox11758   |
	Then Select All selectbox is checked on the Admin page
	When User enters "Checkbox11758" text in the Search field for "Project" column
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @DAS12999 @DAS13199 @12846 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedTeamUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "11770" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	Then "11770" team details is displayed to the user
	When User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User click on Back button
	When User enters "11770" text in the Search field for "Team" column
	When User clicks content from "Team" column
	When User clicks "Team Settings" tab
	Then Default Team checkbox is not active
	When User click on Back button
	When User enters "My Team" text in the Search field for "Team" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User click on Back button
	When User enters "My Team" text in the Search field for "Team" column
	Then "TRUE" value is displayed for Default column
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters " 11770" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedBucketUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "11770" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created, Click here to view the 11770 bucket" text
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters " 11770" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed
	And Delete "11770" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11881 @DAS12999 @DAS13297 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatEmptyGreenAlertLineIsNotDisplayedOnProjectScopeChangesPageAfterMakingSomeChangesOnScopePage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11881" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11881" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestName11881" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then All Associations are disabled
	When User selects "Scope Changes" tab on the Project details page
	Then Warning message is not displayed on the Admin page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Include applications" checkbox on the Project details page
	Then All Associations are selected by default
	Then Scope List dropdown is active
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12155 @Delete_Newly_Created_List @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatScopePanelHaveCorrectlySizeWhenUsedListWithLongName
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" name on "Devices" page
	Then "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User clicks in the Scope field on the Admin page
	Then Scope DDL have the "658" Width

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12349 @DAS12364 @DAS13199 @Delete_Newly_Created_List @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThat500ISEInvalidColumnNameIsNotDisplayedWhenUsedAppSavedListForFilteringDeviceList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" without added column and following value:
	| Values |
	| 8      |
	And User create dynamic list with "ListName12349" name on "Applications" page
	Then "ListName12349" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList  | Association    |
	| ListName12349 | Used on device |
	Then "Application (Saved List)" filter is added to the list
	And "99" rows are displayed in the agGrid
	And "Any Application in list ListName12349 used on device" is displayed in added filter info
	And "(Application (Saved List) = ListName12349 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User create dynamic list with "SavedList12349" name on "Devices" page
	Then "SavedList12349" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12349" in the Project Name field
	And User selects "SavedList12349" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestProject12349" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12349" is displayed to user
	And There are no errors in the browser console
	Then Error message is not displayed
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 0QLZFK7RHMWJLQM |
	| 0RGBQGA7XOOPJSW |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then There are no errors in the browser console
	Then Error message is not displayed
	When User selects "Scope Details" tab on the Project details page
	Then There are no errors in the browser console
	Then Error message is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12777 @Project_Creation_and_Scope
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreatingProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject22" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	And There are no errors in the browser console
	When User enters "TestProject22" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12336 @DAS12745 @DAS13199 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedAfterAddingObjectsOnTheProjectScopeChangesTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12336" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12336" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestName12336" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	And User selects all objects to the Project
	Then "Devices to add (17225 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	Then "Devices to add (0 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User enters "111" text in the Object Search field
	And User selects all objects to the Project
	Then "Devices to add (5 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	And User selects following Objects
	| Objects         |
	| 07RJRCQQJNBJIJQ |
	| 0CFHJY5A8WLUB0J |
	Then "Devices to add (2 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks the "UPDATE DEVICE CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Scope Details" tab on the Project details page
	Then Warning message is not displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12891 @DAS12894 @DAS13254
Scenario: EvergreenJnr_AdminPage_CheckThatCancelButtonIsDisplayedWithCorrectColourOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12891" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12891" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "TestName12891" text in the Search field for "Project" column
	And User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then User sees Cancel button in banner
	And Cancel button is displayed with correctly color
	When User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11701 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatTheFilterSearchIsNotCaseSensitive
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TESTNAME_capital letters" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TESTNAME_capital letters" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "testname_small letters" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "testname_small letters" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "TestName" text in the Search field for "Project" column
	Then created Project with "testname_small letters" name is displayed correctly
	Then created Project with "TESTNAME_capital letters" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12680 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatDevicesToAddAndRemoveAreChangingAppropriate
	When User create static list with "StaticList6527" name on "Devices" page with following items
	| ItemName        |
	| 00BDM1JUR8IF419 |
	| 011PLA470S0B9DJ |
	Then "StaticList6527" list is displayed to user
	When User create static list with "StaticList6528" name on "Devices" page with following items
	| ItemName       |
	| 041V8ZALQ4XPL9 |
	| 04WJ5P9DN0VEEW |
	Then "StaticList6528" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject" in the Project Name field
	And User selects "StaticList6527" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "DevicesProject" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 00BDM1JUR8IF419 |
	| 011PLA470S0B9DJ |
	Then "Devices to add (2 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks the "UPDATE DEVICE CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Scope Details" tab on the Project details page
	When User selects "StaticList6528" in the Scope Project details
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	Then "Devices to remove (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	And Add Objects panel is collapsed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12680 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatUsersToAddAndRemoveAreChangingAppropriate
	When User create static list with "StaticList6529" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	| 002B5DC7D4D34D5C895 |
	Then "StaticList6529" list is displayed to user
	When User create static list with "StaticList6530" name on "Users" page with following items
	| ItemName            |
	| 02642091E2484C9C989 |
	| 02769746B44A414593E |
	Then "StaticList6530" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "UsersProject" in the Project Name field
	And User selects "StaticList6529" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message with "Your project has been created" text is displayed on the Projects page
	When User clicks newly created object link
	Then Project "UsersProject" is displayed to user
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	When User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects                                   |
	| 000F977AC8824FE39B8 (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895 (Collor, Christopher) |
	Then "Users to add (2 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks the "UPDATE USER CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Scope Details" tab on the Project details page
	And User selects "StaticList6530" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	#And "Users to remove (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	And Add Objects panel is collapsed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12903 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationFromListPageWithUseEvergreenBucket
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<ListName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<ListName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text

Examples:
	| ListName  | ProjectName | StaticList     | Item                   | ColumnName    | DynamicList  |
	| Devices   | Project2587 | StaticList6521 | 00KLL9S8NRF0X6         | Hostname      | TestList6584 |
	| Mailboxes | Project2587 | StaticList6522 | ZVI880605@bclabs.local | Email Address | TestList6583 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12799 @Project_Creation_and_Scope @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckMailboxProjectCreationWithCloneEvergreenBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxesProject25" in the Project Name field
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "MailboxesProject25" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected project has been deleted" text
	And There are no errors in the browser console
	When User create static list with "StaticList5846" name on "Mailboxes" page with following items
	| ItemName                         |
	| 000F977AC8824FE39B8@bclabs.local |
	Then "StaticList5846" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxesProject26" in the Project Name field
	And User selects "StaticList5846" in the Scope Project dropdown
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "MailboxesProject26" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click on 'Email Address' column header
	And User create dynamic list with "DynamicList9513" name on "Mailboxes" page
	Then "DynamicList9513" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxesProject27" in the Project Name field
	And User selects "DynamicList9513" in the Scope Project dropdown
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationWithCloneEvergreenBucketsFromListPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Clone evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text

Examples:
	| ProjectName     | StaticList     | PageName | Item                | ColumnName | DynamicList     |
	| TestProject9543 | StaticList8851 | Devices  | 00KWQ4J3WKQM0G      | Hostname   | DynamicList9527 |
	| TestProject9544 | StaticList8852 | Users    | 003F5D8E1A844B1FAA5 | Username   | DynamicList9528 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text

Examples:
	| ProjectName     | StaticList     | PageName  | Item                             | ColumnName    | DynamicList     |
	| TestProject9553 | StaticList8891 | Mailboxes | 00A5B910A1004CF5AC4@bclabs.local | Email Address | DynamicList9537 |
	| TestProject9554 | StaticList8892 | Users     | 003F5D8E1A844B1FAA5              | Username      | DynamicList9538 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12948 @DAS13073 @DAS12999 @Delete_Newly_Created_Project @Buckets @Projects
Scenario: EvergreenJnr_AdminPage_CheckTheBucketStateForOnboardedObjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12948" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then Bucket dropdown is not displayed on the Project details page
	When User click on Back button
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "Bucket12948" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User updates the Default Bucket checkbox state
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 0TTSZRQ1ZTIXWM |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	Then following Items are onboarded
	| Items          |
	| 0TTSZRQ1ZTIXWM |
	When User have opened Column Settings for "Action" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Bucket" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Bucket     |
	Then "Unassigned" text is displayed in the table content
	When User click on Back button
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "[Unassigned]" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	And User updates the Default Bucket checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "Bucket12948" Bucket in the Administration
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project12948" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Details" tab
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	#And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject9753" in the Project Name field
	And User selects "<AllListName>" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject9753" is displayed to user
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "<TabName>" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects        |
	| <ObjectsToAdd> |
	And User clicks the "<ButtonName>" Action button
	Then Warning message with "<WarningMessageText>" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "<SuccessMessageText>" text

Examples:
	| AllListName   | TabName   | ButtonName             | ObjectsToAdd                                       | WarningMessageText      | SuccessMessageText                                   |
	| All Mailboxes | Mailboxes | UPDATE MAILBOX CHANGES | 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) | 1 mailbox will be added | 1 object queued for onboarding, 0 objects offboarded |
	| All Devices   | Users     | UPDATE USER CHANGES    | ADC714277 (Dina Q. Knight)                         | 1 user will be added    | 1 object queued for onboarding, 0 objects offboarded |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12781 @DAS12903 @Projects @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1MailboxesProject" in the Project Name field
	And User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User clicks "Details" tab
	Then "Mailbox scoped project" is displayed in the disabled Project Type field
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_ChangingBucketFromCloneEvergreenBucketsToUseProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "UsersProject5" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User clicks "Details" tab
	And User selects "Use project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Unassigned" is displayed in the Bucket dropdown
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_ChangingBucketFromCloneEvergreenBucketsToUseEvergreenBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxesProject5" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User clicks "Details" tab
	And User selects "Use project buckets" in the Buckets Project dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project details have been updated" text
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	Then "Unassigned" is displayed in the Bucket dropdown
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12903 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListUsingEvergreenBuckets
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	Then "3,808" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList54" name on "Devices" page
	Then "DynamicList54" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject34" in the Project Name field
	Then Scope field is automatically populated
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 3808 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "All Devices" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListForDevicesProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Operating System" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| OS X 10.10     |
	Then "1" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList56" name on "Devices" page
	Then "DynamicList56" list is displayed to user
	When User create static list with "StaticList6579" name on "Devices" page with following items
	| ItemName        |
	| 00SH8162NAS524  |
	| 011PLA470S0B9DJ |
	Then "StaticList6579" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject2" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "StaticList6579" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "DynamicList56" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 1 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopeListToAnotherList
	When User create static list with "StaticList6179" name on "Users" page with following items
	| ItemName |
	| barbosaj |
	| clarkc   |
	Then "StaticList6179" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject6" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14631 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "StaticList6179" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationsScopeListToAnotherList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList57" name on "Applications" page
	Then "DynamicList57" list is displayed to user
	When User create static list with "StaticList6379" name on "Applications" page with following items
	| ItemName         |
	| ACD Display 3.4  |
	| Acrobat Reader 4 |
	Then "StaticList6379" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject4" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ApplicationsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ApplicationsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1  | ChangingToList2  | ApplicationsToAdd1                       | ApplicationsToAdd2                       |
	| All Applications | DynamicList57    | Applications to add (0 of 2129 selected) | Applications to add (0 of 39 selected)   |
	| StaticList6379   | All Applications | Applications to add (0 of 2 selected)    | Applications to add (0 of 2129 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| DEV50          |
	Then "92" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList37" name on "Users" page
	Then "DynamicList37" list is displayed to user
	When User create static list with "StaticList6329" name on "Users" page with following items
	| ItemName |
	| barbosaj |
	| clarkc   |
	Then "StaticList6329" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject5" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	When User selects "<Buckets>" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1 | ChangingToList2 | Buckets                                    | ObjectsToAdd1                      | ObjectsToAdd2                  |
	| All Users       | StaticList6329  | Clone evergreen buckets to project buckets | Users to add (0 of 41339 selected) | Users to add (0 of 2 selected) |
	| StaticList6329  | DynamicList37   | Use project buckets                        |Users to add (0 of 2 selected)     | Users to add (0 of 92 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then "<Rows>" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList58" name on "<ListName>" page
	Then "DynamicList58" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject8" in the Project Name field
	And User selects "<ProjectList>" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "<ScopeDetails>" tab in the Scope section on the Project details page
	And User selects "DynamicList58" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "<ScopeDetails>" tab in the Scope section on the Project details page
	And User selects "<AllList>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ListName | FilterName       | FilterValue | Rows | ProjectList | AllList     | ScopeChanges | ScopeDetails | ObjectsToAdd                         | ChangingToList | ObjectsToAdd1                     | ObjectsToAdd2                        |
	| Devices  | Operating System | Windows 8   | 28   | All Users   | All Devices | Devices      | Device Scope | Devices to add (0 of 16765 selected) | StaticList6429 | Devices to add (0 of 24 selected) | Devices to add (0 of 16765 selected) |
	| Users    | Domain           | CA          | 850  | All Mailbox | All Users   | Users        | User Scope   | Users to add (0 of 14747 selected)   | DynamicList17  | Users to add (0 of 0 selected)    | Users to add (0 of 14747 selected)   |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13297 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Version" filter where type is "Does not contain" with added column and following value:
	| Values            |
	| 97.1.0.0918(1031) |
	Then "1,741" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList17" name on "Applications" page
	Then "DynamicList17" list is displayed to user
	When User create static list with "StaticList6429" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "StaticList6429" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject9" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1  | ChangingToList2 | ObjectsToAdd1                            | ObjectsToAdd2                            |
	| All Applications | StaticList6429  | Applications to add (0 of 2081 selected) | Applications to add (0 of 2 selected)    |
	| StaticList6429   | DynamicList17   | Applications to add (0 of 2 selected)    | Applications to add (0 of 1612 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects @Not_Run
Scenario Outline: EvergreenJnr_ChangingMailboxScopeListToAnotherListForMailboxProject
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Mailbox Platform" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Exchange 2003      |
	Then "6" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList77" name on "Mailboxes" page
	Then "DynamicList77" list is displayed to user
	When User create static list with "StaticList1429" name on "Mailboxes" page with following items
	| ItemName                |
	| ZVF5144799@bclabs.local |
	| zunigamn@bclabs.local   |
	Then "StaticList1429" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxesProject3" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1 | ChangingToList2 | ObjectsToAdd1                          | ObjectsToAdd2                      |
	| All Mailboxes   | StaticList1429  | Mailboxes to add (0 of 14784 selected) | Mailboxes to add (0 of 2 selected) |
	| StaticList1429  | DynamicList77   | Mailboxes to add (0 of 2 selected)     | Mailboxes to add (0 of 6 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopePermissionsForMailboxProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11881" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11881" name is displayed correctly
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestName11881" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "Do not include users" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then User Scope checkboxes are disabled
	Then Application Scope tab is hidden
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "Include users associated to mailboxes" checkbox on the Project details page
	Then Scope List dropdown is active
	Then User Scope checkboxes are active
	Then Application Scope tab is displayed
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_ChangingApplicationScopePermissionsForMailboxProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12881" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestName12881" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Include applications" checkbox on the Project details page
	Then Scope List dropdown is active
	Then Application Scope checkboxes are active
	When User selects "Do not include applications" checkbox on the Project details page
	Then Scope List dropdown is disabled
	Then Application Scope checkboxes are disabled
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Delete_Newly_Created_Project @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_OnboardingMailboxesUsersApplicationsObjectsUsingUpdateAllChangesButton
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject65" in the Project Name field
	And User selects " All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	Then Project "TestProject65" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add
	And User selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects                            |
	| 02E0346DF7804F25835 (Gill, Donna)  |
	| 037AF4CF47C1452D8A4 (Vanetti, Joe) |
	#When User clicks "Applications" tab in the Project Scope Changes section
	#Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	#When User expands the object to add 
	#And User selects following Objects
	#| Objects                                          |
	#| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	#| Backburner (2.1.2.0)                             |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "4 objects queued for onboarding, 0 objects offboarded" text
	#Then "Applications to add (0 of 2079 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Mailboxes" tab in the Project Scope Changes section
	Then "Mailboxes to add (0 of 14782 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14745 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Delete_Newly_Created_List @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForMailboxProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList87" name on "Applications" page
	Then "DynamicList87" list is displayed to user
	When User create static list with "StaticList1529" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "StaticList1529" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "MailboxProject2" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When  User selects "Include applications" checkbox on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details

Examples:
	| ChangingToList1  | ChangingToList2 | ObjectsToAdd1                         | ObjectsToAdd2                         |
	| All Applications | StaticList1529  | Applications to add (0 of 0 selected) | Applications to add (0 of 0 selected) |
	| StaticList1529   | DynamicList87   | Applications to add (0 of 0 selected) | Applications to add (0 of 0 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13254 @Delete_Newly_Created_Team @Teams
Scenario: EvergreenJnr_AdminPage_AddingIndividualAndMembersFromAnotherTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	Then Counter shows "2,790" found rows
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam2" in the Team Name field
	And User enters "test" in the Team Description field
	When User selects "Add members from another team" in the Add Members dropdown
	And User selects following Objects
	| Objects                |
	| Migration Phase 3 Team |
	| Retail Team            |
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then "TRUE" value is displayed for Default column
	When User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User clicks on Actions button
	And User selects "Delete Team" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default team" text is displayed on the Admin page
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam22" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Default Team checkbox
	When User selects "Add individual members" in the Add Members dropdown
	And User selects following Objects
	| Objects           |
	| automation_admin1 |
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User enters "My Team" text in the Search field for "Team" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Team" column
	And User clicks "Team Settings" tab
	And User clicks Default Team checkbox
	And User clicks the "UPDATE TEAM" Action button
	Then Success message is displayed and contains "The team was successfully updated" text
	When User click on Back button
	When User enters "TestTeam2" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message is displayed and contains "The selected teams have been deleted, and their buckets reassigned" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13254 @DAS13421 @Delete_Newly_Created_Team @Teams @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingMembersToTheTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam3" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	When User selects "Team Members" tab on the Team details page
	When User clicks the "ADD MEMBERS" Action button
	And User adds following Objects from list
	| Objects           |
	| automation_admin1 |
	| automation_admin2 |
	| automation_admin3 |
	| eugene            |
	Then Success message is displayed and contains "The selected users have been added" text
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by "Username" column in ascending order on the Admin page
	When User click on "Username" column header on the Admin page
	Then data in table is sorted by "Username" column in descending order on the Admin page
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by "Full Name" column in ascending order on the Admin page
	When User click on "Full Name" column header on the Admin page
	Then data in table is sorted by "Full Name" column in descending order on the Admin page
	When User enters "Automation " text in the Search field for "Full Name" column
	Then Counter shows "3" found rows
	When User enters "automation_admin1" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User selects all rows on the grid
	Then Actions dropdown is displayed correctly
	When User removes selected members
	Then Success message is displayed and contains "The selected user has been removed" text
	When User enters "automation_admin2" text in the Search field for "Username" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Add to another team" in the Actions
	And User clicks the "CONTINUE" Action button
	And User selects "Team 1" team to add
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected user was added to team Team 1" text
	When User click on Back button
	And User enters "TestTeam3" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13421 @Delete_Newly_Created_Team @Teams @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingBucketsToTheTeam
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks the "CREATE TEAM" Action button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam4" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks newly created object link
	When User selects "Buckets" tab on the Team details page
	When User clicks the "ADD BUCKETS" Action button
	Then Add Buckets page is displayed to the user
	When User expands "Email Migration" project to add bucket
	And User adds following Objects from list
	| Objects   |
	| Glasgow   |
	| Frankfurt |
	Then Success message is displayed and contains "The selected buckets have been added" text
	Then There are no errors in the browser console
	When User clicks the "ADD BUCKETS" Action button
	When User expands "Windows 7 Migration (Computer Scheduled Project)" project to add bucket
	And User adds following Objects from list
	| Objects     |
	| Nottingham  |
	| Southampton |
	Then Success message is displayed and contains "The selected buckets have been added" text
	Then There are no errors in the browser console
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by "Bucket" column in ascending order on the Admin page
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by "Bucket" column in descending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in ascending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in descending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then color data in table is sorted by "Default" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in descending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in ascending order on the Admin page
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in descending order on the Admin page
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by "Mailboxes" column in ascending order on the Admin page
	When User have opened Column Settings for "Default" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	When User clicks "False" checkbox from String Filter on the Admin page
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Email Migration" checkbox from String Filter on the Admin page
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Glasgow" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "20" text in the Search field for "Devices" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters ">20" text in the Search field for "Users" column
	Then Counter shows "2" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "100" text in the Search field for "Mailboxes" column
	Then Counter shows "0" found rows
	When User clicks Reset Filters button on the Admin page
	Then There are no errors in the browser console
	When User enters "Nottingham" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Change Team" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Change Team page is displayed to the user
	When User selects "Team 10" in the Team dropdown
	And User clicks the "CHANGE" Action button
	Then Success message is displayed and contains "The selected bucket has been reassigned to the selected team" text
	Then There are no errors in the browser console
	When User click on Back button
	When User enters "TestTeam4" text in the Search field for "Team" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete Team" in the Actions
	And User clicks the "DELETE" Action button
	Then Reassign Buckets page is displayed to the user
	When User selects "Team 0" in the Select a team dropdown
	And User clicks the "DELETE TEAM" Action button
	Then Success message is displayed and contains "The selected team has been deleted, and their buckets reassigned" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_AddingAndDeletingPermissionsForMailboxProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12581" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestName12581" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14747 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User clicks "Other mailbox permissions" associated checkbox on the Project details page
	And User selects following Mailbox permissions
	| Permissions |
	| FullAccess  |
	| ChangeOwner |
	And User clicks "Mailbox folder permissions" associated checkbox on the Project details page
	And User selects following Mailbox folder permissions
	| Permissions      |
	| Author           |
	| AvailabilityOnly |
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| FullAccess       |
	| ChangeOwner      |
	| Author           |
	| AvailabilityOnly |
	When User clicks "Delegated mailboxes" associated checkbox on the Project details page
	And User clicks "Owned mailboxes" associated checkbox on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| FullAccess       |
	| ChangeOwner      |
	| Author           |
	| AvailabilityOnly |
	And following checkboxes are checked in the Scope section
	| Checkboxes          |
	| Owned mailboxes     |
	| Delegated mailboxes |
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14753 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User removes following Mailbox permissions
	| Permissions |
	| FullAccess  |
	| Author      |
	And User selects "Scope Changes" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Mailbox permissions are displayed to the user
	| Permissions      |
	| ChangeOwner      |
	| AvailabilityOnly |
	#And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Buckets
Scenario: EvergreenJnr_AdminPage_CreatingDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "TRUE" value is displayed for Default column
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket5" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User updates the Default Bucket checkbox state
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket5" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	When User enters "NewBucket5" in the Bucket Name field
	When User selects "I-Team" team in the Team dropdown on the Buckets page
	And User clicks the "UPDATE BUCKET" Action button
	Then Success message is displayed and contains "The NewBucket5 bucket has been updated" text
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User updates the Default Bucket checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "NewBucket5" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Buckets @DAS12939
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderOfBucketsAfterCreateOrUpdateOrDeleteAction
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	And User creates following buckets in Administration:
	| Buckets | Teams    |
	| 1ba     | Admin IT |
	| 2ab     | K-Team   |
	| aaa     | Admin IT |
	| aab     | I-Team   |
	| aba     | Admin IT |
	| waa     | IB Team  |
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User enters "1ba" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Bucket Settings" tab
	And User enters "a1ba" in the Bucket Name field
	And User clicks the "UPDATE BUCKET" Action button
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User deletes "aab" Bucket in the Administration
	And User clicks refresh button in the browser
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	And Delete following Buckets in the Administration:
	| Buckets    |
	| 2ab        |
	| a1ba       |
	| aaa        |
	| aba        |
	| waa        |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13420 @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingDevicesFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket6" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket6" bucket details is displayed to the user
	When User clicks "Devices" tab
	When User clicks the "ADD DEVICE" Action button
	When User clicks "Add from buckets" tab on the Buckets page
	When User adds "Unassigned" objects to bucket
	When User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	And There are no errors in the browser console
	Then data in table is sorted by "Hostname" column in ascending order by default on the Admin page
	Then Counter shows "17,225" found rows
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by "Hostname" column in ascending order on the Admin page
	When User click on "Hostname" column header on the Admin page
	Then data in table is sorted by "Hostname" column in descending order on the Admin page
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by "Type" column in ascending order on the Admin page
	When User click on "Type" column header on the Admin page
	Then data in table is sorted by "Type" column in descending order on the Admin page
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by "Operating System" column in ascending order on the Admin page
	When User click on "Operating System" column header on the Admin page
	Then data in table is sorted by "Operating System" column in descending order on the Admin page
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by "Owner Display Name" column in ascending order on the Admin page
	#When User click on "Owner Display Name" column header on the Admin page
	#Then data in table is sorted by "Owner Display Name" column in descending order on the Admin page
	When User enters "00KWQ4J3WKQM0G" text in the Search field for "Hostname" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Windows 2000" text in the Search field for "Operating System" column
	Then Counter shows "8" found rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Erin R. Lucero" text in the Search field for "Owner Display Name" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Laptop" checkbox from String Filter on the Admin page
	Then Counter shows "13,417" found rows
	When User clicks Reset Filters button on the Admin page
	When User selects all rows on the grid
	When User clicks on Actions button
	When User selects "Move To Another Bucket" in the Actions
	When User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	Then Delete "TestBucket6" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13253 @DAS13420 @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingUsersFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket7" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket7" bucket details is displayed to the user
	When User clicks "Users" tab
	When User clicks the "ADD USER" Action button
	When User clicks "Add from buckets" tab on the Buckets page
	When User adds "Unassigned" objects to bucket
	When User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And There are no errors in the browser console
	And There are no errors in the browser console
	Then data in table is sorted by "Username" column in ascending order by default on the Admin page
	#Then Counter shows "41,339" found rows
	#When User click on "Username" column header on the Admin page
	#Then data in table is sorted by "Username" column in ascending order on the Admin page
	#When User click on "Username" column header on the Admin page
	##Then data in table is sorted by "Username" column in descending order on the Admin page
	When User click on "Domain" column header on the Admin page
	Then data in table is sorted by "Domain" column in ascending order on the Admin page
	When User click on "Domain" column header on the Admin page
	Then data in table is sorted by "Domain" column in descending order on the Admin page
	#When User click on "Display Name" column header on the Admin page
	#Then data in table is sorted by "Display Name" column in ascending order on the Admin page
	#When User click on "Display Name" column header on the Admin page
	#Then data in table is sorted by "Display Name" column in descending order on the Admin page
	#When User click on "Distinguished Name" column header on the Admin page
	#Then data in table is sorted by "Distinguished Name" column in ascending order on the Admin page
	#When User click on "Distinguished Name" column header on the Admin page
	#Then data in table is sorted by "Distinguished Name" column in descending order on the Admin page
	When User enters "ZygmontKi" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "UK" text in the Search field for "Domain" column
	Then Counter shows "4,649" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Anitra" text in the Search field for "Display Name" column
	Then Counter shows "18" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Paula" text in the Search field for "Distinguished Name" column
	Then Counter shows "38" found rows
	When User clicks Reset Filters button on the Admin page
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Move To Another Bucket" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And Delete "TestBucket7" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13420 @Buckets @Not_Run
Scenario: EvergreenJnr_AdminPage_AddingMailboxesFromBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket8" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket8" bucket details is displayed to the user
	When User clicks "Mailboxes" tab
	When User clicks the "ADD MAILBOX" Action button
	When User clicks "Add from buckets" tab on the Buckets page
	When User adds "Unassigned" objects to bucket
	When User clicks the "ADD MAILBOXES" Action button
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	Then data in table is sorted by "Email Address (Primary)" column in ascending order by default on the Admin page
	Then Counter shows "14,784" found rows
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by "Email Address (Primary)" column in ascending order on the Admin page
	When User click on "Email Address (Primary)" column header on the Admin page
	Then data in table is sorted by "Email Address (Primary)" column in descending order on the Admin page
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by "Mailbox Platform" column in ascending order on the Admin page
	When User click on "Mailbox Platform" column header on the Admin page
	Then data in table is sorted by "Mailbox Platform" column in descending order on the Admin page
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by "Server Name" column in ascending order on the Admin page
	When User click on "Server Name" column header on the Admin page
	Then data in table is sorted by "Server Name" column in descending order on the Admin page
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by "Mailbox Type" column in ascending order on the Admin page
	When User click on "Mailbox Type" column header on the Admin page
	Then data in table is sorted by "Mailbox Type" column in descending order on the Admin page
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by "Owner Display Name" column in ascending order on the Admin page
	When User click on "Owner Display Name" column header on the Admin page
	Then data in table is sorted by "Owner Display Name" column in descending order on the Admin page
	When User enters "zoumasu" text in the Search field for "Email Address (Primary)" column
	Then Counter shows "1" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "dw-exch13" text in the Search field for "Server Name" column
	Then Counter shows "4,670" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "UserMailbox" text in the Search field for "Mailbox Type" column
	Then Counter shows "14,778" found rows
	When User clicks Reset Filters button on the Admin page
	And User enters "Rogelio" text in the Search field for "Owner Display Name" column
	Then Counter shows "8" found rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Mailbox Platform" column on the Admin page
	And User selects "Exchange 2013" checkbox from String Filter on the Admin page
	Then Counter shows "7,370" found rows
	When User clicks Reset Filters button on the Admin page
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Move To Another Bucket" in the Actions
	And User clicks the "CONTINUE" Action button
	Then Move To Another Bucket Page is displayed to the user
	When User moves selected objects to "Unassigned" bucket
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And There are no errors in the browser console
	And Delete "TestBucket8" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13205
Scenario: EvergreenJnr_AdminPage_CheckThatBannerDisplaysOnScopeDetailsPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User clicks the "CREATE PROJECT" Action button
	And User enters "TestName13205" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link
	Then User sees banner at the top of work area

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12997
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderOfDevicesAndUsersAndMailboxesListsOfParticularBucket
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	And User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then data in table is sorted by "Hostname" column in ascending order by default on the Admin page
	When User clicks "Users" tab
	Then data in table is sorted by "Username" column in ascending order by default on the Admin page
	When User clicks "Mailboxes" tab
	Then data in table is sorted by "Email Address (Primary)" column in ascending order by default on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12680 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_AddingRequestTypesAndCategories
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName18" in the Project Name field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "TestName18" Project
	Then Project with "TestName18" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name              | Description             | ObjectTypeString |
	| 18RequestTypeName | MailboxScheduledProject | Mailbox          |
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	And User create Category
	| Name              | Description          | ObjectTypeString |
	| 18MailboxCategory | UserScheduledProject | Mailbox          |
	Then Success message is displayed with "Category successfully created." text
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestName18" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName18" is displayed to user
	When User changes Request Type to "18RequestTypeName"
	And User changes Category to "18MailboxCategory"
	And User selects "Scope Details" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	#Then "18RequestTypeName" Request Type is displayed to the user
	#Then "18MailboxCategory" Category is displayed to the user
	Then "Mailboxes to add (0 of 14784 selected)" is displayed to the user in the Project Scope Changes section
	And "Mailboxes to remove (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And "Mailboxes 0/0" is displayed in the tab header on the Admin page
	When User expands the object to add
	And User selects following Objects
	| Objects                                            |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) |
	| 00DB4000EDD84951993@bclabs.local (CSC, SS)         |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "2 mailboxes will be added" text is displayed on the Admin page
	And "Mailboxes 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	And "Mailboxes to add (0 of 14782 selected)" is displayed to the user in the Project Scope Changes section
	And "[Default (Mailbox)]" Request Type is displayed to the user
	And "[None]" Category is displayed to the user
	And Add Objects panel is collapsed
	When User expands the object to add
	Then no items are selected

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12892 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyFilteredListObjectsAreUsedAsAScopeOfProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Operating System" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Windows Vista  |
	When User Add And "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Desktop        |
	Then "222" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList4811" name on "Devices" page
	Then "DynamicList4811" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject1982" in the Project Name field
	And User selects "DynamicList4811" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	When User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 222 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @UpdatingName @DAS13096 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameEditedInSeniorIsUpdatedInAdminTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13096" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "Project13096" Project
	Then Project with "Project13096" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User update Project Name on "Project13096 upd"
	Then Success message is displayed with "Project was successfully updated" text
	When User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	And created Project with "Project13096 upd" name is displayed correctly

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12776 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForDynamicList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "DynamicList5588" name on "Devices" page
	Then "DynamicList5588" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12776" in the Project Name field
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12776" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| SZ46M6IS71DPZ1 |
	And User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                          |
	| ACD252468 (Nicolas O. Mc Millan) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "1 device will be added, 1 user will be added" text is displayed on the Admin page
	Then Objects to add panel is disabled
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is disabled
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "UPDATE ALL CHANGES" Action button is disabled
	Then "UPDATE DEVICE CHANGES" Action button is disabled
	And "Devices to add (0 of 17224 selected)" is displayed to the user in the Project Scope Changes section
	Then Objects to add panel is active
	When User clicks "Users" tab in the Project Scope Changes section
	Then "UPDATE USER CHANGES" Action button is disabled
	And "Users to add (0 of 14630 selected)" is displayed to the user in the Project Scope Changes section
	Then Objects to add panel is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                    |
	| AAK881049 (Miguel W. Owen) |
	Then "UPDATE USER CHANGES" Action button is active
	Then "UPDATE ALL CHANGES" Action button is active
	When User clicks "Devices" tab in the Project Scope Changes section
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 00SH8162NAS524 |
	Then "UPDATE DEVICE CHANGES" Action button is active
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12776 @Delete_Newly_Created_Project @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatScopeChangesSelectionIsDisabledAfterClickUpdateForStaticList
	When User create static list with "StaticList12776" name on "Users" page with following items
	| ItemName            |
	| 00CFE13AAE104724AF5 |
	| 00BDBAEA57334C7C8F4 |
	| 000F977AC8824FE39B8 |
	Then "StaticList12776" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12777" in the Project Name field
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12777" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add 
	And User selects following Objects
	| Objects                                |
	| 00BDBAEA57334C7C8F4 (Basa, Rogelio)    |
	| 00CFE13AAE104724AF5 (Hardieway, Linda) |
	And User clicks the "UPDATE USER CHANGES" Action button
	Then Warning message with "2 users will be added" text is displayed on the Admin page
	Then Objects to add panel is disabled
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is disabled
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "UPDATE ALL CHANGES" Action button is disabled
	Then "UPDATE DEVICE CHANGES" Action button is disabled
	When User clicks "Users" tab in the Project Scope Changes section
	Then "UPDATE USER CHANGES" Action button is disabled
	And "Users to add (0 of 1 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Devices" tab in the Project Scope Changes section
	Then Objects to add panel is active
	When User clicks "Users" tab in the Project Scope Changes section
	Then Objects to add panel is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                             |
	| 000F977AC8824FE39B8 (Spruill, Shea) |
	Then "UPDATE USER CHANGES" Action button is active
	Then "UPDATE ALL CHANGES" Action button is active
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12949 @DAS12609 @Delete_Newly_Created_Project @Projects
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrder
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "project12949" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then Projects in filter dropdown are displayed in alphabetical order
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "project12949" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User clicks "Users" tab in the Project Scope Changes section
	When User expands the object to add
	And User selects following Objects
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	And User clicks the "UPDATE USER CHANGES" Action button
	Then Warning message with "3 users will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User clicks "Applications" tab in the Project Scope Changes section
	When User expands the object to add
	And User selects following Objects
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "3 applications will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User clicks "Users" tab in the Project Scope Changes section
	Then following objects were not found
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	When User clicks "Applications" tab in the Project Scope Changes section
	Then following objects were not found
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	When User selects "History" tab on the Project details page
	Then onboarded objects are displayed in the dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12755 @DAS12763 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1DevicesProject" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1DevicesProject" checkbox from String Filter on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "1DevicesProject" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then "1DevicesProject" is not displayed in the filter dropdown

@Evergreen @PMObject @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12965 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project12965" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "Project12965" name is displayed correctly
	And Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "Project12965" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "RED" color in the Application Scope tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                      |
	| ALS - Designing a Microsoft Windows 2000 Dir. Services eBook |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User selects "History" tab on the Project details page
	Then following Items are onboarded
	| Items                                                        |
	| ALS - Designing a Microsoft Windows 2000 Dir. Services eBook |
	When User enters "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook" text in the Search field for "Item" column
	And User clicks content from "Item" column
	Then "Project Object" page is displayed to the user
	And Colour of onboarded app is "Red"

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12496 @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemove
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "UsersProject2" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks newly created object link
	Then Project "UsersProject2" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	| 04FPR090BNW80E  |
	| 05LG3HCJLEDEMTR |
	And User clicks the "UPDATE DEVICE CHANGES" Action button
	Then Warning message with "4 devices will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "4 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Device Scope" tab in the Scope section on the Project details page
	When User selects "Do not include owned devices" checkbox on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	When User adds following Objects to the Project
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message with "0 object queued for onboarding, 2 objects offboarded" text is displayed on the Projects page
	When User selects "Queue" tab on the Project details page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Computer Object" checkbox from String Filter on the Admin page
	Then Counter shows "2" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12787 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedBucketsIsDisplayedForOnboardedObjectsInQueueAndHistory
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "UsersProject3" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "UsersProject3" Project
	Then Project with "UsersProject3" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Create Group" button
	And User create Group owned existing "Admin IT" Team
	| GroupName          |
	| UsersProject3Group |
	When User clicks "Create Group" button
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User enters "UsersProject3" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "UsersProject3" is displayed to user
	When user selects "UsersProject3Group" in the Bucket dropdown
	And User expands the object to add 
	And User selects following Objects
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	And User clicks the "UPDATE USER CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are onboarded
	| Items                                 |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	Then "UsersProject3Group" content is displayed in "Bucket" column
	When User selects "History" tab on the Project details page
	Then following Items are onboarded
	| Items                                 |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	And "UsersProject3Group" content is displayed in "Bucket" column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12763 @Delete_Newly_Created_Project @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_AdminPage_CheckDisplayingBucketsAfterCreationProjectsWithDifferentOptions
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "1Bucket12763" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "1Bucket12763" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects         |
	| 0405FHJHVG45U71 |
	| 2A6FHO2JSIMNAQ  |
	| 4AII611FFHAZXWG |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	When User click on Back button
	When User clicks the "CREATE BUCKET" Action button
	Then "Create Bucket" page should be displayed to the user
	When User enters "2Bucket12763" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "2Bucket12763" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks the "ADD DEVICE" Action button
	And User adds following Objects from list
	| Objects         |
	| 1ONC8ASZBNVUHC  |
	| 329YFQ9EYZASK5  |
	| 4U31ASACVADPDIF |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	When User click on Back button
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1Project12763" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1Project12763" checkbox from String Filter on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "2Project12763" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "2Project12763" checkbox from String Filter on the Admin page
	#Then Counter shows "3" found rows
	Then "Unassigned" text is displayed in the table content
	Then "1Bucket12763" text is displayed in the table content
	Then "2Bucket12763" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "3Project12763" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Use evergreen buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "Your project has been created" text
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User clicks "Select All" checkbox from String Filter on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	Then "3Project12763" is not displayed in the filter dropdown