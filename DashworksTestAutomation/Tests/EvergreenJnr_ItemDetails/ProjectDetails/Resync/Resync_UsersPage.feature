Feature: Resync_UsersPage
	Runs Resync related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ready on the 'radiant' server
@Evergreen @Users @EvergreenJnr_ItemDetails @Resync @DAS18035 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnUsersPage
	When User navigates to the 'User' details page for 'ZUF3029607' item
	Then Details page for "ZUF3029607" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	When User clicks the "RESYNC" Action button
	Then Dialog Pop-up is displayed for User
	Then 'Resync apps' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User clicks the "RESYNC" Action button
	Then Success message is displayed and contains "User successfully resynced" text