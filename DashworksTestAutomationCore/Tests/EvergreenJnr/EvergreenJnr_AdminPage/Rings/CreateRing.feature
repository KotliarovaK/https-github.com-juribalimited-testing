﻿Feature: CreateRing
	Create Ring

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14901 @DAS16803 @DAS18351 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOneRingAddeddAfterMulticlickingCreateButton
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE EVERGREEN RING' button 
	When User enters 'OneRing' text to 'Ring name' textbox
	When User doubleclicks Create button on Create Ring page
	Then 'The ring has been created' text is displayed on inline success banner
	Then 'OneRing' content is displayed in the 'Ring' column
	When User enters "OneRing" text in the Search field for "Ring" column
	Then Rows counter contains "1" found row of all rows
	Then There are no errors in the browser console
	When User clicks 'CREATE EVERGREEN RING' button 
	When User enters 'OneRing' text to 'Ring name' textbox
	Then 'A ring already exists with this name' error message is displayed for 'Ring name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS21296 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenCreatingNewProjectRing
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| Project_21296 | All Mailboxes | None            | Standalone Project |
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE PROJECT RING' button 
	When User enters 'ProjectRing_21296' text to 'Ring name' textbox
	When User enters 'RingDescription' text to 'Description' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Filters button
	When User add "Project_21: Ring" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| ProjectRing_21296  |
	Then There are no errors in the browser console
	When User navigates to "Project_21296" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left submenu item
	When User selects 'ProjectRing_21296' in the 'Ring' dropdown
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS15397 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorDisplayedWhenCreatingRingsConsistently
	When Project created via API and opened
	| ProjectName     | Scope     | ProjectTemplate | Mode               |
	| NewProject15397 | All Users | None            | Standalone Project |
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters 'TestRing15397_1' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	When User enters "NewProject15397" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Rings' left menu item
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters 'TestRing15397_2' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then There are no errors in the browser console
	Then 'The ring has been created' text is displayed on inline success banner