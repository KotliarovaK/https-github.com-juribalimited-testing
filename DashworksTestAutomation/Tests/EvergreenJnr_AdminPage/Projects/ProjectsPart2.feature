Feature: ProjectsPart2
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12236 @DAS12999 @DAS13199 @DAS13408 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedAfterUpdatingProjectScopeChanges
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| TestProject5 | All Devices | None            | Standalone Project |
	Then Project "TestProject5" is displayed to user
	When User selects "Scope" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User clicks "Entitled to the device owner" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Applications' left menu item in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User expands the object to add 
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects                     |
	| 20040610sqlserverck (1.0.0) |
	| 7zip                        |
	| ACDSee 4.0 (4.0.0)          |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "3 applications will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	And "Applications to add (0 of 2126 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items               |
	| 20040610sqlserverck |
	| 7zip                |
	| ACDSee 4.0          |
	Then "" content is displayed in "Bucket" column
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items               |
	| 20040610sqlserverck |
	| 7zip                |
	| ACDSee 4.0          |
	Then "" content is displayed in "Bucket" column
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12333 @DAS12999 @Cleanup @Projects @TEST
Scenario: EvergreenJnr_ChecksThatDeviceScopeDDLIsDisabledWhenDoNotIncludeOwnedDevicesIsSelected
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Rainbow" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Rainbow" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12751 @DAS12747 @DAS12999 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedCheckboxIsSelectedAfterSwitchingBetweenTabs
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestProject13 | All Devices | None            | Standalone Project |
	Then Project "TestProject13" is displayed to user
	When User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Devices' left menu item in the Project Scope Changes section
	Then Update Project buttons is disabled
	When User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects        |
	| 00HA7MKAVVFDAV |
	Then Update Project button is active
	And "Devices to add (1 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' left menu item in the Project Scope Changes section
	When User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects                   |
	| AAH0343264 (Luc Gauthier) |
	And User navigates to the 'Devices' left menu item in the Project Scope Changes section
	When User expands the object to add 
	Then following items are still selected
	And "Devices to add (1 of 17279 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12387 @DAS12757 @DAS12999 @DAS13199 @Cleanup @Project_Creation_and_Scope @Projects @Do_Not_Run_With_Projects @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardingOfObjectsIsProceedForScopedProjects
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| DDPPProject14 | All Devices | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	When User adds following Objects to the Project
	| Objects        |
	| 0317IPQGQBVAQV |
	| 00I0COBFWHOF27 |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User navigates to the 'Users' left menu item in the Project Scope Changes section
	And User adds following Objects to the Project
	| Objects                       |
	| AAG081456 (Melanie Z. Fowler) |
	| AAH0343264 (Luc Gauthier)     |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	When User click on Back button	
	And Project created via API and opened
	| ProjectName  | Scope     | ProjectTemplate | Mode               |
	| NewProject15 | All Users | None            | Standalone Project |
	Then Project "NewProject15" is displayed to user
	And Success message is not displayed on the Admin page
	When User click on Back button
	Then data in table is sorted by "Project" column in ascending order by default on the Admin page
	When User enters "NewProject15" text in the Search field for "Project" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Active" column on the Admin page
	And User clicks "True" checkbox from boolean filter on the Admin page
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Type" column on the Admin page
	And User selects "Device scoped" checkbox from String Filter on the Admin page
	Then 'NewProject15' content is displayed in the 'Project' column
	When User clicks Reset Filters button on the Admin page 
	And User enters "DDPP" text in the Search field for "Short Name" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page 
	And User have opened Column Settings for "Project" column
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
	When User enters "0" text in the Search field for "Project ID" column
	Then Rows counter contains "0" found row of all rows