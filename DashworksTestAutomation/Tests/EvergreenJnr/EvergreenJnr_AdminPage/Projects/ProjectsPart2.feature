Feature: ProjectsPart2
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12236 @DAS12999 @DAS13199 @DAS13408 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedAfterUpdatingProjectScopeChanges
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| TestProject5 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject5' header is displayed to user
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User checks 'Entitled to the device owner' checkbox
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect to add objects 
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects                     |
	| 20040610sqlserverck (1.0.0) |
	| 7zip                        |
	| ACDSee 4.0 (4.0.0)          |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '3 applications will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	And "Applications to add (0 of 2126 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items               |
	| 20040610sqlserverck |
	| 7zip                |
	| ACDSee 4.0          |
	Then '' content is displayed in the 'Bucket' column
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items               |
	| 20040610sqlserverck |
	| 7zip                |
	| ACDSee 4.0          |
	Then '' content is displayed in the 'Bucket' column
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12333 @DAS12999 @Cleanup @Projects
Scenario: EvergreenJnr_ChecksThatDeviceScopeDDLIsDisabledWhenDoNotIncludeOwnedDevicesIsSelected
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'Rainbow' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'Rainbow' header is displayed to user
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then Scope List dropdown is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12751 @DAS12747 @DAS12999 @DAS12645 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedCheckboxIsSelectedAfterSwitchingBetweenTabs
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestProject13 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject13' header is displayed to user
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then 'UPDATE ALL CHANGES' button is disabled
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| 00HA7MKAVVFDAV |
	Then 'UPDATE ALL CHANGES' button is not disabled
	And "Devices to add (1 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects from the expandable multiselect
	| Objects                   |
	| AAH0343264 (Luc Gauthier) |
	And User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect to add objects 
	Then following items are still selected
	And "Devices to add (1 of 17279 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12387 @DAS12757 @DAS12999 @DAS13199 @Cleanup @Project_Creation_and_Scope @Projects @Do_Not_Run_With_Projects
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardingOfObjectsIsProceedForScopedProjects
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| DDPPProject14 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	When User expands multiselect and selects following Objects
	| Objects        |
	| 0317IPQGQBVAQV |
	| 00I0COBFWHOF27 |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects                       |
	| AAG081456 (Melanie Z. Fowler) |
	| AAH0343264 (Luc Gauthier)     |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User click on Back button
	And Project created via API and opened
	| ProjectName  | Scope     | ProjectTemplate | Mode               |
	| NewProject15 | All Users | None            | Standalone Project |
	Then Page with 'NewProject15' header is displayed to user
	Then inline success banner is not displayed
	Then inline success banner is not displayed
	When User click on Back button
	Then data in table is sorted by 'Project' column in ascending order by default
	When User enters "NewProject15" text in the Search field for "Project" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page
	When User unchecks following checkboxes in the filter dropdown menu for the 'Active' column:
	| checkboxes |
	| True       |
	Then Rows counter contains "0" found row of all rows
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Type" column on the Admin page
	And User selects "Device scoped" checkbox from String Filter on the Admin page
	Then 'NewProject15' content is displayed in the 'Project' column
	When User clicks Reset Filters button on the Admin page 
	And User enters "DDPP" text in the Search field for "Short Name" column
	Then Rows counter contains "1" found row of all rows
	When User clicks Reset Filters button on the Admin page 
	And User opens 'Project' column settings
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