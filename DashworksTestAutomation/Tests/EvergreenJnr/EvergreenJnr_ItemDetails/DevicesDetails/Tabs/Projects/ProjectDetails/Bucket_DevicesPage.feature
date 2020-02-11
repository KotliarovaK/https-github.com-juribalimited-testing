Feature: Bucket_DevicesPage
	Runs related tests for Bucket field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227
Scenario: EvergreenJnr_DevicesList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectly
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
Scenario: EvergreenJnr_DevicesList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectly
	When User creates new Bucket via api
	| Name                       | TeamName | IsDefault |
	| ItemDetailsBucket_DAS18227 | Admin IT | false     |
	When User navigates to the 'Device' details page for '02M88BG4P29EEM' item
	Then Details page for '02M88BG4P29EEM' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	When User selects 'ItemDetailsBucket_DAS18227' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to ItemDetailsBucket_DAS18227' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title  | Value                      |
	| Bucket | ItemDetailsBucket_DAS18227 |
	When User clicks on edit button for 'Bucket' field
	Then 'Bucket' column contains following content
	| Content                    |
	| ItemDetailsBucket_DAS18227 |