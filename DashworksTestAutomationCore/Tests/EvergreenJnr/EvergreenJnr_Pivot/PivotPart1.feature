Feature: PivotPart1
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14224 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFilter
	When User clicks '<PageNameForPivot>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	When User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	When User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	Then "<PivotName>" list is displayed to user
	When User clicks '<PageNameForFilter>' on the left-hand menu
	Then '<PageLabelForFilter>' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "<FilterName>" filter
	Then "<PivotName>" list is not displayed for Saved List filter

Examples:
	| PageNameForPivot | RowGroups  | Columns        | Values               | PivotName                     | PageNameForFilter | PageLabelForFilter | FilterName               |
	| Applications     | Compliance | 2004: Category | Vendor               | Pivot_Applications_List_14224 | Devices           | All Devices        | Application (Saved List) |
	| Users            | Enabled    | Cost Centre    | Department Full Path | Pivot_User_List_14224         | Applications      | All Applications   | User (Saved List)        |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14325
Scenario Outline: EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories
	When User clicks '<ListName>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User clicks "ADD ROW GROUP" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |
	When User clicks Close Add Item icon in Pivot panel
	When User clicks "ADD COLUMN" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |
	When User clicks Close Add Item icon in Pivot panel
	When User clicks "ADD VALUE" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13747 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckBoxRemovedFromFilterPanelWhenUsingSavedPivot
	When User clicks '<ListName>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	When User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	When User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	When User clicks '<ListName>' on the left-hand menu
	When User enters "<PivotName>" text in Search field at List Panel
	When User navigates to the "<PivotName>" list
	When User clicks the Filters button
	When User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed

Examples:
	| ListName     | RowGroup    | Column                      | Value          | PivotName                     | FilterName      | CategoryName |
	| Devices      | Compliance  | 2004: Application Readiness | Last Seen Date | Pivot_Devices_List_13747      | Boot Up Date    | Device       |
	| Users        | Compliance  | App Count (Entitled)        | Domain         | Pivot_Users_List_13747        | Description     | User         |
	| Mailboxes    | Alias       | Owner City                  | Created Date   | Pivot_Mailboxes_List_13747    | Display Name    | Mailbox      |
	| Applications | Application | Evergreen Capacity Unit     | Vendor         | Pivot_Applications_List_13747 | Application Key | Application  |