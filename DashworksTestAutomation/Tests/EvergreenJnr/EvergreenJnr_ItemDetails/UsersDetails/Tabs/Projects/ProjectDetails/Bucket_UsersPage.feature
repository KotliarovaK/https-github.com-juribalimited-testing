Feature: Bucket_UsersPage
	Runs related tests for Bucket field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedDevices
	When User navigates to the 'User' details page for the item with '23726' ID
	Then Details page for 'QLL295118 (Nicole P. Braun)' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	Then 'MOVE' button is disabled on popup
	Then 'Select the bucket to move this user to. Select devices associated to this user to move at the same time.' text is displayed on popup
	Then following columns are displayed on the Item details page:
	| ColumnName |
	| Hostname   |
	| Owned      |
	| Bucket     |
	When User selects 'Group102' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to Group102' text is displayed on inline tip banner

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedDevices
	When User navigates to the 'User' details page for the item with '228' ID
	Then Details page for 'BGW6256640 (Talon Brochu)' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	When User selects 'Group111' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to Group111' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title  | Value    |
	| Bucket | Group111 |
	When User clicks on edit button for 'Bucket' field
	Then 'Bucket' column contains following content
	| Content  |
	| Group111 |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedMailboxes
	When User navigates to the 'User' details page for the item with '92682' ID
	Then Details page for '003F5D8E1A844B1FAA5 (Hunter, Melanie)' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	Then 'MOVE' button is disabled on popup
	Then 'Select the bucket to move this user to. Select mailboxes associated to this user to move at the same time.' text is displayed on popup
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owner Display Name |
	| Owned              |
	| Bucket             |
	When User selects 'A Group with AdminIT team' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to A Group with AdminIT team' text is displayed on inline tip banner

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS18227 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatBucketOnTheItemDetailsPageIsWorksCorrectlyForAssociatedMailboxes
	When User navigates to the 'User' details page for the item with '89891' ID
	Then Details page for '01DE1433D11E44E6A4A (Anderson, Nancy)' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	When User selects 'A Group with AdminIT team' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to A Group with AdminIT team' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title  | Value                     |
	| Bucket | A Group with AdminIT team |
	When User clicks on edit button for 'Bucket' field
	Then 'Bucket' column contains following content
	| Content                   |
	| A Group with AdminIT team |
	When User selects 'Unassigned' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup