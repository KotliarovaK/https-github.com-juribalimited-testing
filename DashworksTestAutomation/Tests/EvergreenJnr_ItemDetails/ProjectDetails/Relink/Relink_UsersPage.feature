Feature: Relink_UsersPage
	Runs Relink related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO This test is in progress. Update the test when there will be more details.
@Evergreen @Users @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnUsersPage
	When User navigates to the 'User' details page for 'ZZR457072' item
	Then Details page for "ZZR457072" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RELINK" Action button
	Then Dialog Pop-up is displayed on the Item Details page
	Then 'Resync apps' checkbox is checked in Dialog Pop-up
	Then 'Resync name' checkbox is checked in Dialog Pop-up
	When User clicks the "RELINK" Action button
	Then Warning message with "This object will be relinked to the selected Evergreen object in this project" text is displayed on the Project Details Page
	When User clicks the "RELINK" Action button
	Then Success message is displayed and contains "ZZR457072 successfully relinked" text