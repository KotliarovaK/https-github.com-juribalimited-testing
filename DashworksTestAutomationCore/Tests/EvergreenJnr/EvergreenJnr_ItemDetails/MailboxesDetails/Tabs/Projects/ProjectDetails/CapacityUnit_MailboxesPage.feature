Feature: CapacityUnit_MailboxesPage
	Runs related tests for Capacity Unit fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19538 @Cleanup @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_MailboxesList_CheckThatValueForCapacityUnitIsChangingSuccessfully
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project                            |
	| cu_DAS19538_4 | DAS19538    | false     | Mailbox Evergreen Capacity Project |
	When User navigates to the 'Mailbox' details page for '013DA2178AB4444CAF2@bclabs.local' item
	Then Details page for '013DA2178AB4444CAF2@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then 'MOVE' button is disabled on popup
	When User selects 'cu_DAS19538_4' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to cu_DAS19538_4' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_4 |
	When User navigates to the 'User' details page for the item with '93160' ID
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_4 |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19175 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatColumnsForCapacityUnitIsDisplayedCorrectly
	When User navigates to the 'Mailbox' details page for '0141713E5CF84ADE907@bclabs.local' item
	Then Details page for '0141713E5CF84ADE907@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	When User checks 'Show only selected items' slide toggle
	Then following columns are displayed on the Item details page:
	| ColumnName    |
	| Username      |
	| Display Name  |
	| Domain        |
	| Owner         |
	| Capacity Unit |
	| Bucket        |