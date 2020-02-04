Feature: ProjectsPart6
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12336 @DAS12745 @DAS13199 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedAfterAddingObjectsOnTheProjectScopeChangesTab
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestName12336 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects
	And User selects all objects to the Project
	Then "Devices to add (17279 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	Then "Devices to add (0 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User enters '111' text to 'Search' textbox
	And User selects all objects to the Project
	Then "Devices to add (5 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	And User expands multiselect and selects following Objects
	| Objects        |
	| CWOFD11103CVDP |
	| 111OPUSGKFG5GT |
	Then "Devices to add (2 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Scope Details' left menu item
	Then inline info banner is not displayed
	Then inline success banner is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12891 @DAS12894 @DAS13254 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCancelButtonIsDisplayedWithCorrectColourOnAdminPage
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestName12891 | All Devices | None            | Standalone Project |
	And User click on Back button
	When User enters "TestName12891" text in the Search field for "Project" column
	And User selects all rows on the grid
	Then 'Actions' dropdown is displayed
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then User sees Cancel button in banner
	And Cancel button is displayed with correctly color
	When User clicks 'DELETE' button on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11701 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatTheFilterSearchIsNotCaseSensitive
	When Project created via API and opened
	| ProjectName              | Scope       | ProjectTemplate | Mode               |
	| TESTNAME_capital letters | All Devices | None            | Standalone Project |
	And User click on Back button
	When User enters "TESTNAME_capital letters" text in the Search field for "Project" column
	Then 'TESTNAME_capital letters' content is displayed in the 'Project' column
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| testname_small letters | All Devices | None            | Standalone Project |
	And User click on Back button
	When User enters "testname_small letters" text in the Search field for "Project" column
	Then 'testname_small letters' content is displayed in the 'Project' column
	When User enters "TestName" text in the Search field for "Project" column
	Then 'testname_small letters' content is displayed in the 'Project' column
	Then 'TESTNAME_capital letters' content is displayed in the 'Project' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12680 @DAS12157 @DAS13014 @Cleanup @Cleanup @Projects
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
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DevicesProject' text to 'Project Name' textbox
	And User selects 'StaticList6527' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'DevicesProject' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects 
	When User selects following Objects from the expandable multiselect
	| Objects         |
	| 00BDM1JUR8IF419 |
	| 011PLA470S0B9DJ |
	Then "Devices to add (2 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Scope Details' left menu item
	When User selects 'StaticList6528' in the 'Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	#Then "Devices to remove (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	And Add Objects panel is collapsed