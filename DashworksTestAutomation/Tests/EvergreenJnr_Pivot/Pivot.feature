﻿Feature: Pivot
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14224
Scenario Outline: EvergreenJnr_AllLists_ChecksThatPivotsAreNotShownInTheListToSelectAsAnAdvancedFilter
	When User clicks "<PageNameForPivot>" on the left-hand menu
	Then "<PageNameForPivot>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	Then "<PivotName>" list is displayed to user
	When User clicks "<PageNameForFilter>" on the left-hand menu
	Then "<PageNameForFilter>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And user select "<FilterName>" filter
	Then "<PivotName>" list is not displayed for Saved List filter
	And User remove list with "<PivotName>" name on "<PageNameForPivot>" page

Examples:
	| PageNameForPivot | RowGroups  | Columns         | Values               | PivotName                     | PageNameForFilter | FilterName               |
	| Applications     | Compliance | Application Key | Vendor               | Pivot_Applications_List_14224 | Devices           | Application (Saved List) |
	| Users            | Enabled    | Cost Centre     | Department Full Path | Pivot_User_List_14224         | Applications      | User (Saved List)        |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14325
Scenario Outline: EvergreenJnr_AllLists_ChecksThatGroupsColumnsAndValuesContainEvergreenCatagoryWithCorrectSubcategories
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to Pivot
	And User clicks "ADD ROW GROUP" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |
	When User clicks Close Add Item icon in Pivot panel
	And User clicks "ADD COLUMN" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |
	When User clicks Close Add Item icon in Pivot panel
	And User clicks "ADD VALUE" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
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
	When User clicks "Applications" on the left-hand menu
	And User navigates to Pivot
	And User clicks "ADD ROW GROUP" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Capacity Unit |
	When User clicks Close Add Item icon in Pivot panel
	And User clicks "ADD COLUMN" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Capacity Unit |
	When User clicks Close Add Item icon in Pivot panel
	And User clicks "ADD VALUE" button in Pivot panel
	Then User sees "Evergreen" category in Pivot panel
	When User closed "Selected Columns" columns category
	And User is expand "Evergreen" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories           |
	| Evergreen Capacity Unit |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14188 @DAS14748 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_ChecksThatColumnsCanBeAddedAfterRunningPivot
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User clicks "<Link>" link in Lists panel
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| <ColumnToBeAdded> |
	Then ColumnName is added to the list
	| ColumnName        |
	| <ColumnToBeAdded> |

Examples:
	| ListName     | RowGroup    | Column                            | Value          | Link             | ColumnToBeAdded |
	| Devices      | Compliance  | Babel(Engl: Application Readiness | Last Seen Date | All Devices      | Build Date      |
	| Users        | Compliance  | App Count (Entitled)              | Domain         | All Users        | Common Name     |
	| Mailboxes    | Alias       | Owner City                        | Created Date   | All Mailboxes    | Alias           |
	| Applications | Application | Evergreen Capacity Unit           | Vendor         | All Applications | Application Key |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13747
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckBoxRemovedFromFilterPanelWhenUsingNewPivot
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User clicks the Filters button
	And User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed

Examples:
	| ListName     | RowGroup    | Column                            | Value           | FilterName      | CategoryName |
	| Devices      | Hostname    | DeviceSche: Bucket                | Building        | Boot Up Date    | Device       |
	| Users        | Common Name | UserSchedu: Application Readiness | Cost Centre     | Description     | User         |
	| Mailboxes    | Alias       | Department Name                   | Country         | Display Name    | Mailbox      |
	| Applications | Vendor      | Babel(Engl: Category              | Application Key | Application Key | Application  |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13747
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckBoxRemovedFromFilterPanelWhenUsingSavedPivot
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	And User clicks "<ListName>" on the left-hand menu
	And User navigates to the "<PivotName>" list
	And User clicks the Filters button
	And User selects "<FilterName>" filter from "<CategoryName>" category
	Then "Add column" checkbox is not displayed
	And User remove list with "<PivotName>" name on "<ListName>" page

Examples:
	| ListName     | RowGroup    | Column                            | Value          | PivotName                     | FilterName      | CategoryName |
	| Devices      | Compliance  | Babel(Engl: Application Readiness | Last Seen Date | Pivot_Devices_List_13747      | Boot Up Date    | Device       |
	| Users        | Compliance  | App Count (Entitled)              | Domain         | Pivot_Users_List_13747        | Description     | User         |
	| Mailboxes    | Alias       | Owner City                        | Created Date   | Pivot_Mailboxes_List_13747    | Display Name    | Mailbox      |
	| Applications | Application | Evergreen Capacity Unit           | Vendor         | Pivot_Applications_List_13747 | Application Key | Application  |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @Projects @DAS14224 @DAS14413 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotsAreNotShownInTheListToSelectOnScopeChangesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values      |
	| Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS_14224" name
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Pivot_Project_14224" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the "Device Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "Scope" drop-down on the Project details page:
	| Values       |
	| All Devices  |
	| 1803 Rollout |
	When User navigates to the "User Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "User Scope" drop-down on the Project details page:
	| Values    |
	| All Users |
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "Application Scope" drop-down on the Project details page:
	| Values           |
	| All Applications |
	And User remove list with "Pivot_DAS_14224" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13765
Scenario: EvergreenJnr_DevicesList_ChecksThatPivotTableDisplayedCorrectlyAfterRemovingColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	| Description |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User removes "Description" Column for Pivot
	Then Save button is inactive for Pivot list
	And No pivot generated message is displayed

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @DAS14413 @DAS14748
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnSelectedPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	Then reset button on main panel is displayed
	When User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS_14206" name
	Then "Pivot_DAS_14206" list is displayed to user
	When User navigates to the "All Users" list
	And User navigates to Pivot
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active
	And User remove list with "Pivot_DAS_14206" name on "Users" page

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206
Scenario: EvergreenJnr_UsersList_ChecksThatUserCanCreateOneMorePivotOnCreatedList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "Dynamic_List_DAS14206" name on "Users" page
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User navigates to the "All Users" list
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	And User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_14206" name
	Then "PivotList_DAS_14206" list is displayed to user
	When User navigates to the "Dynamic_List_DAS14206" list
	Then "Dynamic_List_DAS14206" list is displayed to user
	When User navigates to Pivot
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active
	When User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Common Name |
	And User selects the following Values on Pivot:
	| Values   |
	| Building |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User clicks the "SAVE" Action button
	Then Pivot Name field is empty
	And User remove list with "Dynamic_List_DAS14206" name on "Users" page
	And User remove list with "PivotList_DAS_14206" name on "Users" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14413
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnResetButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	Then reset button on main panel is displayed
	When User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	| Description |
	Then reset button on main panel is displayed
	When User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	Then reset button on main panel is displayed
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User removes "City" Column for Pivot
	And User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	And User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is active
	And "ADD COLUMN" Action button is active
	And "ADD VALUE" Action button is active

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14379 @DAS11291 @DAS14745
Scenario: EvergreenJnr_DevicesList_ChecksTooltipsOnPivot
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User clicks the "ADD ROW GROUP" Action button
	When "Compliance" value is entered into the search box and the selection is clicked on Pivot
	Then "DONE" Action button have tooltip with "Confirm changes" text
	Then back button on Pivot panel have tooltip with "Close" text
	When User clicks the "DONE" Action button
	And User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then "Row Groups" plus button have tooltip with "Add row group" text
	And "Columns" plus button have tooltip with "Add column" text
	And "Values" plus button have tooltip with "Add value" text
	And close button for "City" chip have tooltip with "Delete this item" text
	And "City" chip have tooltip with "City" text

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14377 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatTaskValuesAsRowGroupsAreDisplayedInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups                             |
	| MigrationP: Computer Owner Idenitfied |
	And User selects the following Columns on Pivot:
	| Columns     |
	| City        |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then numeric data in table is sorted by "Empty" column in descending order for the Pivot
	Then numeric data in table is sorted by "Belfast" column in descending order for the Pivot
	Then numeric data in table is sorted by "Cardiff" column in descending order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14378 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatTaskValuesAsPivotColumnsAreDisplayedInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns                 |
	| Windows7Mi: Target Date |
	And User selects the following Values on Pivot:
	| Values            |
	| Owner Cost Centre |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then numeric data in table is sorted by " " column in descending order for the Pivot

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatSeverityAggregateFunctionAvailableForReadinessField
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed

Examples:
	| ListName     | RowGroups        | Columns               | Values                      |
	| Devices      | Compliance       | UserEvergr: Readiness | 1803: Application Readiness |
	| Users        | Compliance       | EmailMigra: Readiness | 1803: Application Readiness |
	| Mailboxes    | Owner Compliance | EmailMigra: Readiness | MailboxEve: Readiness       |
	| Applications | Compliance       | EmailMigra: Readiness | 1803: Application Readiness |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14556 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatSeverityAggregateFunctionAvailableForComplianceField
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed

Examples:
	| ListName     | RowGroups | Columns          | Values                      |
	| Devices      | Hostname  | Compliance       | 1803: Application Readiness |
	| Users        | Domain    | Compliance       | 1803: Application Readiness |
	| Mailboxes    | Alias     | Owner Compliance | MailboxEve: Readiness       |
	| Applications | Import    | Compliance       | 1803: Application Readiness |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14422 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrder
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add sort column
	Then numeric data in table is sorted by "<SortedColumn>" column in descending order for the Pivot

Examples:
	| ListName     | RowGroups | Columns                                                    | Values           | SortedColumn |
	| Devices      | Import    | UserEvergr: Dropdown Readiness Date (Computer)             | Compliance       |              |
	| Users        | Enabled   | Windows7Mi: Group User Radiobutton Readiness Only          | Compliance       |              |
	| Mailboxes    | Enabled   | EmailMigra: Infrastructure Readiness                       | Owner Compliance |              |
	| Applications | Vendor    | UserEvergr: Radiobutton Readiness Date Owner (Application) | Compliance       |              |

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14423 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrder
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add sort column
	Then numeric data in table is sorted by "<SortedColumn>" column in descending order for the Pivot

Examples:
	| ListName | RowGroups | Columns                           | Values     | SortedColumn |
	| Devices  | Import    | Windows7Mi: Application Readiness | Compliance |              |
	| Users    | Domain    | Windows7Mi: Application Readiness | Compliance |              |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14424 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| DeviceSche: Owner Readiness |
	And User selects the following Values on Pivot:
	| Values                      |
	| 1803: Application Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add column name
	Then numeric data in table is sorted by " " column in descending order for the Pivot

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14426 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrder
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add sort column
	Then numeric data in table is sorted by "<SortedColumn>" column in descending order for the Pivot

Examples:
	| ListName     | RowGroups | Columns                | Values                | SortedColumn |
	| Devices      | Region    | Babel(Engl: Initiation | CPU Count             |              |
	| Users        | Region    | EmailMigra: Migration  | Compliance            |              |
	| Mailboxes    | Language  | EmailMigra: Migration  | EmailMigra: Readiness |              |
	| Applications | Import    | UserEvergr: Stage 3    | DeviceSche: Readiness |              |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14427 @Not_Run
Scenario: EvergreenJnr_ApplicationsList_CheckThatApplicationTargetAppReadinessColumnsDisplayInTheCorrectOrder
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                    |
	| 1803: Target App Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add column name
	Then numeric data in table is sorted by " " column in descending order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS14428 @Not_Run
Scenario: EvergreenJnr_MailboxesList_CheckThatMailboxOwnerComplianceColumnsDisplayInTheCorrectOrder
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values                |
	| EmailMigra: Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add column name
	Then numeric data in table is sorted by "Empty" column in descending order for the Pivot

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14429 @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceColumnsDisplayInTheCorrectOrder
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values   |
	| <Values> |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add sort column
	Then numeric data in table is sorted by "<SortedColumn>" column in descending order for the Pivot

Examples:
	| ListName     | RowGroups     | Columns    | Values                | SortedColumn |
	| Devices      | Purchase Date | Compliance | 1803: Readiness       |              |
	| Users        | Domain        | Compliance | UserEvergr: Readiness |              |
	| Applications | Vendor        | Compliance | Import                |              |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14430 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatDeviceOwnerComplianceColumnsDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	#Add column name
	Then numeric data in table is sorted by "Empty" column in descending order for the Pivot