Feature: DevicesDetails_Users
	Runs related tests for Users tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#upd Ann.Ilchenko 10/25/19: will be ready in the future
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16322 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatActionPanelImplementedForItemDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then 'ADD USERS' button is displayed
	Then 'Actions' dropdown is displayed
	When User selects 'Remove' in the 'Actions' dropdown
	Then 'REMOVE' button is displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17086
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsOpenedCorrectlyWithSameKeyAndUserValues
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User clicks "Nicole P. Braun" link on the Details Page
	Then Details page for 'QLL295118 (Nicole P. Braun)' item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data  |
	| Key   | 23726 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17300
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsSimilarOnGridAndDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then 'QLL295118' content is displayed in the 'Username' column
	And 'US-E' content is displayed in the 'Domain' column
	And 'Nicole P. Braun' content is displayed in the 'Display Name' column
	And 'QLL295118.Users.Jersey City.US-E.local' content is displayed in the 'Distinguished Name' column
	When User clicks "QLL295118" link on the Details Page
	Then Details page for 'QLL295118 (Nicole P. Braun)' item is displayed to the user
	And User verifies data in the fields on details page
	| Field              | Data                                   |
	| Username           | QLL295118                              |
	| Domain             | US-E                                   |
	| Display Name       | Nicole P. Braun                        |
	| Distinguished Name | QLL295118.Users.Jersey City.US-E.local |