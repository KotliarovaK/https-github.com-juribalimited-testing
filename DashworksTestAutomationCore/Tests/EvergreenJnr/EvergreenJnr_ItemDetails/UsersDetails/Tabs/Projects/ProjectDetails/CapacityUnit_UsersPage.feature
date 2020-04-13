Feature: CapacityUnit_UsersPage
	Runs related tests for Capacity Unit fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19538 @Cleanup @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_UsersList_CheckThatValueForCapacityUnitIsChangingSuccessfully
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project                         |
	| cu_DAS19538_2 | DAS19538    | false     | User Evergreen Capacity Project |
	When User navigates to the 'User' details page for '0088FC8A50DD4344B92' item
	Then Details page for '0088FC8A50DD4344B92' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then 'MOVE' button is disabled on popup
	When User selects 'cu_DAS19538_2' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'User successfully moved to cu_DAS19538_2' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_2 |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19378
Scenario: EvergreenJnr_UsersList_CheckThatCheckboxesForAssociatedObjectsAredisplayedInChangeCapacityPopup
	When User navigates to the 'User' details page for the item with '537' ID
	Then Details page for 'CVS3269200' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then select all rows checkbox is checked
	When User deselect all rows on the grid
	Then select all rows checkbox is unchecked
	When User selects all rows on the grid
	Then select all rows checkbox is checked
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 01BQIYGGUW5PRP6  |
	Then select all rows checkbox is unchecked
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 01BQIYGGUW5PRP6  |
	Then select all rows checkbox is checked

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19846 @Cleanup @Set_Default_Capacity_Unit @Universe
Scenario: EvergreenJnr_UsersList_CheckThatTheAssociatedDevicesAreMovedToTheSelectedCapacityUnitInTheMoveCapacityUnitModalPopup
	When User creates new Capacity Unit via api
	| Name           | Description | IsDefault | Project                         |
	| zen_DAS19846_1 | DAS19846    | false     | User Evergreen Capacity Project |
	When User navigates to the 'User' details page for the item with '17815' ID
	Then Details page for 'AKK984561 (Erik Q. Chan)' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	When User selects 'zen_DAS19846_1' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to zen_DAS19846_1' text is displayed on inline success banner
	When User clicks on edit button for 'Capacity Unit' field
	Then 'zen_DAS19846_1' content is displayed in the 'Capacity Unit' column

@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19175 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatColumnsForCapacityUnitIsDisplayedCorrectly
	When User navigates to the 'User' details page for '0137C8E69921432992B' item
	Then Details page for '0137C8E69921432992B' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	When User clicks following checkboxes from Column Settings panel for the 'Owned' column:
	| checkboxes         |
	| Owner Display Name |
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owned              |
	| Capacity Unit      |
	| Bucket             |