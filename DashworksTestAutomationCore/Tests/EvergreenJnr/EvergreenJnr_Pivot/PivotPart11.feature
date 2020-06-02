Feature: PivotPart11
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14325
Scenario: EvergreenJnr_ApplicationsList_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User clicks "ADD ROW GROUP" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                   |
	| Criticality                     |
	| Evergreen Capacity Unit         |
	| Evergreen Rationalisation       |
	| Evergreen Target App Compliance |
	| Evergreen Target App Key        |
	| Evergreen Target App Name       |
	| Evergreen Target App Vendor     |
	| Evergreen Target App Version    |
	| Hide From End Users             |
	| In Catalog                      |
	When User clicks Close Add Item icon in Pivot panel
	When User clicks "ADD COLUMN" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                   |
	| Criticality                     |
	| Evergreen Capacity Unit         |
	| Evergreen Rationalisation       |
	| Evergreen Target App Compliance |
	| Evergreen Target App Key        |
	| Evergreen Target App Name       |
	| Evergreen Target App Vendor     |
	| Evergreen Target App Version    |
	| Hide From End Users             |
	| In Catalog                      |
	When User clicks Close Add Item icon in Pivot panel
	When User clicks "ADD VALUE" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User collapses 'Selected Columns' category
	When User collapses 'Suggested' category
	When User expands 'Evergreen' category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                   |
	| Criticality                     |
	| Evergreen Capacity Unit         |
	| Evergreen Rationalisation       |
	| Evergreen Target App Compliance |
	| Evergreen Target App Key        |
	| Evergreen Target App Name       |
	| Evergreen Target App Vendor     |
	| Evergreen Target App Version    |
	| Hide From End Users             |
	| In Catalog                      |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14188 @DAS14748 @DAS15682
Scenario Outline: EvergreenJnr_AllLists_ChecksThatColumnsCanBeAddedAfterRunningPivot
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
	Then Plus button is not displayed in the left-pinned column
	When User navigates to the "<Link>" list
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| <ColumnToBeAdded> |
	Then ColumnName is added to the list
	| ColumnName        |
	| <ColumnToBeAdded> |

Examples:
	| ListName     | RowGroup    | Column                      | Value          | Link             | ColumnToBeAdded |
	| Devices      | Compliance  | 2004: Application Readiness | Last Seen Date | All Devices      | Build Date      |
	| Users        | Compliance  | App Count (Entitled)        | Domain         | All Users        | Common Name     |
	| Mailboxes    | Alias       | Owner City                  | Created Date   | All Mailboxes    | Alias           |
	| Applications | Application | Evergreen Capacity Unit     | Vendor         | All Applications | Application Key |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13747
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckBoxRemovedFromFilterPanelWhenUsingNewPivot
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
	When User clicks the Filters button
	When User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed

Examples:
	| ListName     | RowGroup    | Column                            | Value           | FilterName      | CategoryName |
	| Devices      | Hostname    | DeviceSche: Bucket                | Building        | Boot Up Date    | Device       |
	| Users        | Common Name | UserSchedu: Application Readiness | Cost Centre     | Description     | User         |
	| Mailboxes    | Alias       | Department Name                   | Country         | Display Name    | Mailbox      |
	| Applications | Vendor      | 2004: Category                    | Application Key | Application Key | Application  |