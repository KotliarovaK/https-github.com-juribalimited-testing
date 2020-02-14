Feature: ProjectDetails_UsersPage
	Runs related tests for Project Details tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19978
Scenario: EvergreenJnr_UsersList_CheckThatTheProjectDetailsPageOpensAfterClickingOnThePrimaryDeviceLinkOnTheUsersPage
	When User navigates to the 'User' details page for 'KSD3827534' item
	Then Details page for 'KSD3827534' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks "01COJATLYVAR7A6" link on the Details Page
	Then Details page for '01COJATLYVAR7A6' item is displayed to the user
	Then 'Havoc (Big Data)' content is displayed in 'Item Details Project' dropdown