﻿Feature: DeleteRings
	Delete Rings

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14867 @DAS15417 @DAS16694 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenDeletingRing
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Rings' left menu item
	And User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User type "TestRing" Name in the "Ring name" field on the 'Windows 7 Migration (Computer Scheduled Project)' Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| TestRing         |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected ring has been deleted" text
	And There are no errors in the browser console