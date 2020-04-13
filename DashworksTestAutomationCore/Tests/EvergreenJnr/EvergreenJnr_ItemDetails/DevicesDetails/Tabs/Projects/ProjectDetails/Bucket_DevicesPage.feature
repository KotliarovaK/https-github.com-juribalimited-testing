Feature: Bucket_DevicesPage
	Runs related tests for Bucket field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedUsers
	When User navigates to the 'Device' details page for '02M88BG4P29EEM' item
	Then Details page for '02M88BG4P29EEM' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	Then 'MOVE' button is disabled on popup
	Then 'Select the bucket to move this device to. Select users associated to this device to move at the same time.' text is displayed on popup
	Then following columns are displayed on the Item details page:
	| ColumnName    |
	| Username      |
	| Display Name  |
	| Domain        |
	| Owner         |
	| Bucket        |
	When User selects 'Group10' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to Group10' text is displayed on inline tip banner

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedUsers
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	When User selects 'Evergreen Bucket 2' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to Evergreen Bucket 2' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title  | Value              |
	| Bucket | Evergreen Bucket 2 |
	When User clicks on edit button for 'Bucket' field
	Then 'Bucket' column contains following content
	| Content            |
	| Evergreen Bucket 2 |
	When User selects 'Unassigned' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18227 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatValueForBucketIsChangingSuccessfullyForUserWithSpecificAccess
	When User create new User via API
	| Username        | Email | FullName | Password  | Roles                                                                                                                        |
	| UserDAS18227454 | Value | DAS18227 | m!gration | Project Application Object Editor, Project Computer Object Editor, Project Mailbox Object Editor, Project User Object Editor |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username        | Password  |
	| UserDAS18227454 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#--Devices--#
	When User navigates to the 'Device' details page for the item with '5123' ID
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Bucket' field is not displayed
		#--Users--#
	When User navigates to the 'User' details page for the item with '89891' ID
	Then Details page for '01DE1433D11E44E6A4A (Anderson, Nancy)' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Bucket' field is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectsTab @DAS19985 @DAS20088
Scenario: EvergreenJnr_DevicesList_CheckThatSlideToggleWorksCorrectlyForTheBucketPopUp
	When User navigates to the 'Device' details page for '32UIH1IBLQ050JY' item
	Then Details page for '32UIH1IBLQ050JY' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	When User deselect all rows on the grid
	Then 'FQT1418241' content is displayed in the 'Username' column
	When User checks 'Show only selected items' slide toggle
	Then 'FQT1418241' content is not displayed in the 'Username' column