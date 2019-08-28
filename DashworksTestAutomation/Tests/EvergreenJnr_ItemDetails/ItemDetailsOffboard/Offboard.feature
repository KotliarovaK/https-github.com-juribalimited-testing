﻿Feature: Offboard
	Runs Offboard related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 8/27/19: ready on 'quasar';
@Evergreen @Applications @EvergreenJnr_ItemDetails @Offboard @DAS17919 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "Technical Information Sampler: January 2003"
	And User click content from "Application" column
	Then Details page for "Technical Information Sampler: January 2003" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "OFFBOARD" Action button
	Then Warning message is displayed and contains 'This application will be offboarded, this cannot be undone' text on Item Details page
	When User clicks 'OFFBOARD' button in the warning message on Item Details page
	Then Success message is displayed and contains 'The application was successfully queued for offboarding from User Evergreen Capacity Project' text on Item Details page

	#Ann.Ilchenko 8/28/19: ready on 'quasar';
@Evergreen @_AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17843 @DAS17926 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "OFFBOARD" Action button
	Then Offboard Pop-up is displayed on the Item Details page
	When User clicks 'OFFBOARD' button in the Offboard Pop-up on the Item Details page
	Then Warning message is displayed and contains 'The selected objects will be offboarded, this cannot be undone' text on Item Details page
	When User clicks 'OFFBOARD' button in the Offboard Pop-up on the Item Details page
	#going to check the object state
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User clicks "Scope" tab
	When User selects "History" tab on the Project details page
	When User enters "<ItemName>" text in the Search field for "Item" column
	Then "<ItemName>" content is displayed in "Item" column

Examples: 
	| PageName  | LoadedPage    | ItemName            | ColumnName    | ProjectName                        |
	| Devices   | All Devices   | 063X2ZOB8V3GUY      | Hostname      | I-Computer Scheduled Project       |
	| Users     | All Users     | 0088FC8A50DD4344B92 | Username      | I-Computer Scheduled Project       |
	| Mailboxes | All Mailboxes | 06A573B6200A4A10BC2 | Email Address | Mailbox Evergreen Capacity Project |