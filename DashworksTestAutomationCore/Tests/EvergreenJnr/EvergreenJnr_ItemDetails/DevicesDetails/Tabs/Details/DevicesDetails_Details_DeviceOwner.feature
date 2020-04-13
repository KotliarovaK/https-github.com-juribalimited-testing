Feature: DevicesDetails_Details_DeviceOwner
	Runs related tests for Details > Device Owner tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS14923
Scenario: EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	And User clicks "Tricia G. Huang" link on the Details Page
	Then Details page for 'LFA418191 (Tricia G. Huang)' item is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17180
Scenario: EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEnd
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	And User clicks "QLL295118" link on the Details Page
	Then Details page for 'QLL295118 (Nicole P. Braun)' item is displayed to the user
	And URL contains 'user/23726/details/user'
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Details' left menu item
	And User navigates to the 'Device Owner' left submenu item
	And User clicks "QLL295118" link on the Details Page
	Then Details page for 'QLL295118 (Nicole P. Braun)' item is displayed to the user
	Then 'Havoc (Big Data)' content is displayed in 'Item Details Project' dropdown
	And URL contains 'user/23726/details/user?$projectId=43'
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	Then 'Havoc (Big Data)' content is displayed in 'Item Details Project' dropdown
	When User navigates to the 'Applications' left menu item
	And User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for 'Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs' item is displayed to the user
	Then 'Havoc (Big Data)' content is displayed in 'Item Details Project' dropdown
	And URL contains 'application/373/details/application?$projectId=43'