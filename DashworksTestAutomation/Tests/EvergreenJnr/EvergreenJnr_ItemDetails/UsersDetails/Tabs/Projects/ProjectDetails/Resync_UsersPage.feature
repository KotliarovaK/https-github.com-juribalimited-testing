Feature: Resync_UsersPage
	Runs Resync related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @Resync @DAS18035
Scenario: EvergreenJnr_UsersList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnUsersPage
	When User navigates to the 'User' details page for 'ZUF3029607' item
	Then Details page for 'ZUF3029607' item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button 
	Then popup is displayed to User
	Then 'Resync apps' checkbox is checked
	Then 'Resync name' checkbox is checked
	When User clicks 'RESYNC' button on popup
	Then 'User successfully resynced' text is displayed on inline success banner