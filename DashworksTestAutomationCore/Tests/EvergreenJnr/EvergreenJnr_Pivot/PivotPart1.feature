Feature: PivotPart1
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14224 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFilter
	When User clicks '<PageNameForPivot>' on the left-hand menu
	Then '<PageLabelForPivot>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	Then "<PivotName>" list is displayed to user
	When User clicks '<PageNameForFilter>' on the left-hand menu
	Then '<PageLabelForFilter>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And user select "<FilterName>" filter
	Then "<PivotName>" list is not displayed for Saved List filter

Examples:
	| PageNameForPivot | PageLabelForPivot | RowGroups  | Columns         | Values               | PivotName                     | PageNameForFilter | PageLabelForFilter | FilterName               |
	| Applications     | All Applications  | Compliance | Application Key | Vendor               | Pivot_Applications_List_14224 | Devices           | All Devices        | Application (Saved List) |
	| Users            | All Users         | Enabled    | Cost Centre     | Department Full Path | Pivot_User_List_14224         | Applications      | All Applications   | User (Saved List)        |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14325
Scenario Outline: EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User clicks "ADD ROW GROUP" button in Pivot panel
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
	And User clicks "ADD COLUMN" button in Pivot panel
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
	And User clicks "ADD VALUE" button in Pivot panel
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

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14325
Scenario: EvergreenJnr_ApplicationsList_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User clicks "ADD ROW GROUP" button in Pivot panel
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
	And User clicks "ADD COLUMN" button in Pivot panel
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
	And User clicks "ADD VALUE" button in Pivot panel
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
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	Then Plus button is not displayed in the left-pinned column
	When User navigates to the "<Link>" list
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
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
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User clicks the Filters button
	And User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed

Examples:
	| ListName     | RowGroup    | Column                            | Value           | FilterName      | CategoryName |
	| Devices      | Hostname    | DeviceSche: Bucket                | Building        | Boot Up Date    | Device       |
	| Users        | Common Name | UserSchedu: Application Readiness | Cost Centre     | Description     | User         |
	| Mailboxes    | Alias       | Department Name                   | Country         | Display Name    | Mailbox      |
	| Applications | Vendor      | 2004: Category                    | Application Key | Application Key | Application  |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13747 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckBoxRemovedFromFilterPanelWhenUsingSavedPivot
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Pivot' in the 'Create' dropdown
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	And User clicks '<ListName>' on the left-hand menu
	When User enters "<PivotName>" text in Search field at List Panel
	And User navigates to the "<PivotName>" list
	And User clicks the Filters button
	And User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed

Examples:
	| ListName     | RowGroup    | Column                      | Value          | PivotName                     | FilterName      | CategoryName |
	| Devices      | Compliance  | 2004: Application Readiness | Last Seen Date | Pivot_Devices_List_13747      | Boot Up Date    | Device       |
	| Users        | Compliance  | App Count (Entitled)        | Domain         | Pivot_Users_List_13747        | Description     | User         |
	| Mailboxes    | Alias       | Owner City                  | Created Date   | Pivot_Mailboxes_List_13747    | Display Name    | Mailbox      |
	| Applications | Application | Evergreen Capacity Unit     | Vendor         | Pivot_Applications_List_13747 | Application Key | Application  |