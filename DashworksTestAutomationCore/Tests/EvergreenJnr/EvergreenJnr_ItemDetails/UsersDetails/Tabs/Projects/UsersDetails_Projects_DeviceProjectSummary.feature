Feature: UsersDetails_Projects_DeviceProjectSummary
	Runs related tests for Projects > Device Project Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @UsersLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15522
Scenario: EvergreenJnr_UsersList_ChecksThatNoErrorsAreDisplayedAfterClickingThroughTheProjectNameFromObjectDetails
	When User navigates to the 'User' details page for 'TON2490708' item
	Then Details page for 'TON2490708' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Device Project Summary' left submenu item
	When User enters "K-group" text in the Search field for "Bucket" column
	And User clicks "00BDM1JUR8IF419" link on the Details Page
	Then "Project Object" page is displayed to the user