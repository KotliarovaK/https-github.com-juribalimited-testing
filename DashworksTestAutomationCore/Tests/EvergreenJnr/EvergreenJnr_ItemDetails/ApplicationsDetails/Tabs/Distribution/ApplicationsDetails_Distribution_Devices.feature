Feature: ApplicationsDetails_Distribution_Devices
	Runs related tests for Distribution > Devices sab tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17230
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDisabledDistributionSectionCantBeEnteredByUsingTheBackButtonInTheBrowser
	When User navigates to the 'Application' details page for 'ACD Display 3.4' item
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Devices' left submenu item
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	Then User click back button in the browser
	Then 'Distribution' left menu item is expanded
	Then 'Evergreen' content is displayed in 'Item Details Project' dropdown

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12805
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsersAndDevicesDistributionListsDoNotIncludeUnknownValues
	When User navigates to the 'Application' details page for 'Microsoft DirectX 5 DDK' item
	Then Details page for 'Microsoft DirectX 5 DDK' item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Users' left submenu item
	When User checks following checkboxes in the filter dropdown menu for the 'Used' column:
	| checkboxes |
	| False      |
	And User opens 'User' column settings
	And User selects 'Sort descending' option from column settings
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values
	When User navigates to the 'Devices' left submenu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Used' column:
	| checkboxes |
	| False      |
	And User opens 'Device' column settings
	And User selects 'Sort descending' option from column settings
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values