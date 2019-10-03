﻿Feature: Relink_UsersPage
	Runs Relink related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Users @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnUsersPage
	When User navigates to the 'User' details page for 'ZZR457072' item
	Then Details page for "ZZR457072" item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title | Value     |
	| Name  | ZZR457072 |
	When User clicks 'RELINK' button 
	Then Dialog Pop-up is displayed for User
	Then 'Resync apps' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User enters 'dsf' in the 'User' autocomplete field and selects 'DSF4350513' value
	Then User selects state 'true' for 'Resync apps' checkbox
	And User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks 'RELINK' button in Dialog Pop-up
	Then Success message is displayed and contains "User successfully relinked" text
	Then Details page for "DSF4350513" item is displayed to the user
	Then following content is displayed on the Details Page
	| Title | Value     |
	| Name  | ZZR457072 |
	When User clicks 'RESYNC' button 
	When User clicks 'RESYNC' button in Dialog Pop-up
	Then Success message is displayed and contains "User successfully resynced" text
	Then following content is displayed on the Details Page
	| Title | Value      |
	| Name  | DSF4350513 |
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "11" rows found label displays on Details Page 