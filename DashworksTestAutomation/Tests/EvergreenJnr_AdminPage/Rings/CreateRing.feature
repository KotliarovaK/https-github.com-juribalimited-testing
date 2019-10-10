Feature: CreateRing
	Create Ring

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14901 @DAS16803 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOneRingAddeddAfterMulticlickingCreateButton
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Rings' left menu item
	And User clicks 'CREATE EVERGREEN RING' button 
	And User enters 'OneRing' text to 'Ring name' textbox
	And User doubleclicks Create button on Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	And 'OneRing' content is displayed in the 'Ring' column
	When User enters "OneRing" text in the Search field for "Ring" column
	Then Rows counter contains "1" found row of all rows
	And There are no errors in the browser console
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| OneRing          |
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS15397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenCreatingRingsConsistently
	When Project created via API and opened
	| ProjectName     | Scope     | ProjectTemplate | Mode               |
	| NewProject15397 | All Users | None            | Standalone Project |
	And User navigates to the 'Rings' left menu item
	And User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User type "TestRing15397_1" Name in the "Ring name" field on the 'NewProject15397' Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "NewProject15397" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Rings' left menu item
	And User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User type "TestRing15397_2" Name in the "Ring name" field on the 'NewProject15397' Project details page
	And User clicks Create button on the Create Ring page
	Then There are no errors in the browser console
	And Success message is displayed and contains "The ring has been created" text
