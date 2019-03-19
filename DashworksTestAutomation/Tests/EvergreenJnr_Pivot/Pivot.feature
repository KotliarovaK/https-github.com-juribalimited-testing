Feature: Pivot
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

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS14188 @DAS14748 @DAS15682 @Not_Run
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
	Then Plus button is not displayed in the left-pinned column
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
	| Values                  |
	| All Users               |
	| Users with Device Count |
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then following Values are displayed in "Application Scope" drop-down on the Project details page:
	| Values             |
	| All Applications   |
	| 1803 Apps          |
	| Apps with a Vendor |
	And User remove list with "Pivot_DAS_14224" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13765 @DAS13833 @DAS13855
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

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS14206 @DAS14413 @DAS14748 @DAS13786 @DAS13869
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
	Then data in the table is sorted by "Common Name" column in ascending order by default for the Pivot
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

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14377 @DAS13864
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
	Then data in the column headers is sorted in correct order for the Pivot
	#Remove # after DAS-15230 fixed
	#Then color data in the left-pinned column is sorted in descending order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14378 @DAS13864 @DAS13786 @DAS13867 @DAS15376
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
	Then date in the column headers is sorted in correct order for the Pivot
	Then data in the table is sorted by "Hostname" column in ascending order by default for the Pivot
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	#DAS-15376
	#Then "(Owner Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS15376 @Not_Run
Scenario: EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForMailboxes
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups             |
	| MailboxEve: In Scope  |
	| MailboxEve: Readiness |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values                |
	| MailboxEve: Readiness |
	When User selects aggregate function "Severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "TRUE" left-pinned value on Pivot
	Then following values are displayed for "London" column on Pivot
	| Value1       | Value2       |
	| TRUE         | OUT OF SCOPE |
	| OUT OF SCOPE | OUT OF SCOPE |
	| PURPLE       | PURPLE       |
	| NONE         | NONE         |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555 @DAS13786 @DAS13771 @DAS15376
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForApplications
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Vendor      |
	| Application |
	And User selects the following Columns on Pivot:
	| Columns        |
	| Inventory Site |
	And User selects the following Values on Pivot:
	| Values                           |
	| ComputerSc: Target App Readiness |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Vendor" filter
	When User select "Equals" Operator value
	When User enters "Microsoft" text in Search field at selected Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "Severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "Microsoft" left-pinned value on Pivot
	Then following values are displayed for "TierA Site01" column on Pivot
	| Value1                                                     | Value2     |
	| Microsoft                                                  | BLUE       |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) | GREEN      |
	| 0036 - Microsoft Access 97 SR-2 English                    | LIGHT BLUE |
	| 0047 - Microsoft Access 97 SR-2 Francais                   | GREEN      |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Between" with following Date options and Associations:
	| StartDateInclusive | EndDateInclusive | Association                             |
	| 25 Apr 2018        | 02 May 2018      | Has used app                            |
	#DAS-15376
	#Then "(Vendor = Microsoft AND User Last Logon Date between (2018-04-25, 2018-05-02) ASSOCIATION = (has used app))" text is displayed in filter container

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555
Scenario: EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	| Floor     |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values                            |
	| Babel(Engl: Application Readiness |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Country" filter
	When User select "Equals" Operator value
	When User enters "USA" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "101 Hudson Street" left-pinned value on Pivot
	Then following values are displayed for "USA" column on Pivot
	| Value1            | Value2 |
	| 101 Hudson Street | BLUE   |
	| 20                | NONE   |
	| 21                | BLUE   |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14555
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForReadinessFieldForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns      |
	| Manufacturer |
	And User selects the following Values on Pivot:
	| Values          |
	| 1803: Readiness |
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "USA" left-pinned value on Pivot
	Then following values are displayed for "Asus" column on Pivot
	| Value1      | Value2 |
	| USA         | RED    |
	| Los Angeles | GREEN  |
	| San Diego   | RED    |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_ApplicationsLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForApplications
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Vendor      |
	| Application |
	And User selects the following Columns on Pivot:
	| Columns        |
	| Inventory Site |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Vendor" filter
	When User select "Equals" Operator value
	When User enters "Altera" text in Search field at selected Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "Altera" left-pinned value on Pivot
	Then following values are displayed for "SMS_GEN" column on Pivot
	| Value1                          | Value2 |
	| Altera                          | AMBER  |
	| Quartus II 2.0 Web Edition Full | GREEN  |
	| Quartus II 5.0                  | GREEN  |
	| Quartus II 5.0 SP2              | AMBER  |
	| Quartus II Programmer 4.0       | AMBER  |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_MailboxesLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForMailboxes
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| Import      |
	| Email Count |
	And User selects the following Columns on Pivot:
	| Columns |
	| City    |
	And User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "BCLABS-2007" left-pinned value on Pivot
	Then following values are displayed for "Empty" column on Pivot
	| Value1      | Value2         |
	| BCLABS-2007 | GREEN          |
	| 87          | GREEN          |
	| 86          | GREEN          |
	| 20          | GREEN          |
	| 9           | NOT APPLICABLE |
	| 3           | GREEN          |
	| 2           | GREEN          |
	| 0           | GREEN          |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_UsersLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	| Floor     |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Country" filter
	When User select "Equals" Operator value
	#Change Sctoland to Scotland
	When User enters "Sctoland" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	When User clicks the Pivot button
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "Exchange Tower" left-pinned value on Pivot
	Then following values are displayed for "Sctoland" column on Pivot
	| Value1         | Value2  |
	| Exchange Tower | UNKNOWN |
	| 2              | RED     |
	| 3              | RED     |
	| 4              | UNKNOWN |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13860 @DAS14556
Scenario: EvergreenJnr_DevicesLists_CheckThatSeverityAggregateFunctionAvailableForComplianceFieldForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Country   |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns |
	| Import  |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	When User selects aggregate function "severity" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User expanded "Empty" left-pinned value on Pivot
	Then following values are displayed for "A01 SMS (Spoof)" column on Pivot
	| Value1          | Value2 |
	| Empty           | AMBER  |
	| A01 SMS (Spoof) | AMBER  |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_ApplicationsLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForApplications
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Vendor    |
	And User selects the following Columns on Pivot:
	| Columns                                                    |
	| UserEvergr: Radiobutton Readiness Date Owner (Application) |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Vendor" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Not Applicable |
	| Started        |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_MailboxesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForMailboxes
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups        |
	| Evergreen Bucket |
	And User selects the following Columns on Pivot:
	| Columns                              |
	| EmailMigra: Infrastructure Readiness |
	And User selects the following Values on Pivot:
	| Values           |
	| Owner Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Evergreen Bucket" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName               |
	| Infrastructure Ready     |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_UsersLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| City      |
	And User selects the following Columns on Pivot:
	| Columns                                           |
	| Windows7Mi: Group User Radiobutton Readiness Only |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "City" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Not Applicable |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14422 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectReadinessTaskColumnsDisplayInCorrectOrderForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                                        |
	| UserEvergr: Dropdown Readiness Date (Computer) |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Not Applicable |
	| Started        |
	| Failed         |
	| Complete       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14423 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups           |
	| Organizational Unit |
	And User selects the following Columns on Pivot:
	| Columns                           |
	| Windows7Mi: Application Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Organizational Unit" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14423 @DAS15252
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectApplicationReadinessTaskColumnsDisplayInTheCorrectOrderForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                           |
	| Windows7Mi: Application Readiness |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS14424 @DAS13865 @DAS15252 @DAS13786 @DAS13823
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDeviceOwnerReadinessTaskColumnsDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns                                    |
	| Barry'sUse: Validate User Device Ownership |
	And User selects the following Values on Pivot:
	| Values                      |
	| 1803: Application Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then Empty value is displayed on the first place for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| Not Applicable |
	| Audit Failed   |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_ApplicationsLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForApplications
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Import    |
	And User selects the following Columns on Pivot:
	| Columns             |
	| UserEvergr: Stage 3 |
	And User selects the following Values on Pivot:
	| Values                |
	| DeviceSche: Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_MailboxesLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForMailboxes
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Language  |
	And User selects the following Columns on Pivot:
	| Columns               |
	| EmailMigra: Migration |
	And User selects the following Values on Pivot:
	| Values                |
	| EmailMigra: Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then data in the table is sorted by "Language" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_UsersLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Region    |
	And User selects the following Columns on Pivot:
	| Columns               |
	| EmailMigra: Migration |
	And User selects the following Values on Pivot:
	| Values     |
	| Compliance |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then data in the table is sorted by "Region" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14426
Scenario: EvergreenJnr_DevicesLists_CheckThatProjectStageColumnsDisplayInTheCorrectOrderForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Region    |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Babel(Engl: Initiation |
	And User selects the following Values on Pivot:
	| Values    |
	| CPU Count |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	Then data in the table is sorted by "Region" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14427
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
	Then data in the table is sorted by "Import" column in ascending order by default for the Pivot
	Then color data in the column headers is sorted in correct order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS14428 @DAS13865
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
	And data in the table is sorted by "City" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| GREEN          |
	| UNKNOWN        |
	| NOT APPLICABLE |

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_ApplicationsLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForApplications
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Vendor    |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values |
	| Import |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "<SortedColumn>" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| GREEN          |
	| AMBER          |
	| RED            |
	| UNKNOWN        |
	| NOT APPLICABLE |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_UsersLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForUsers
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Domain    |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values                |
	| UserEvergr: Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Domain" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| GREEN          |
	| AMBER          |
	| RED            |
	| UNKNOWN        |
	| NOT APPLICABLE |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14429
Scenario: EvergreenJnr_DevicesLists_CheckThatComplianceColumnsDisplayInTheCorrectOrderForDevices
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups      |
	| Inventory Site |
	And User selects the following Columns on Pivot:
	| Columns    |
	| Compliance |
	And User selects the following Values on Pivot:
	| Values          |
	| 1803: Readiness |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Inventory Site" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| GREEN      |
	| AMBER      |
	| RED        |
	| UNKNOWN    |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13865 @DAS14430
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
	And data in the table is sorted by "Hostname" column in ascending order by default for the Pivot
	Then Pivot column headers is displayed in following order:
	| ColumnName     |
	| GREEN          |
	| AMBER          |
	| RED            |
	| UNKNOWN        |
	| NOT APPLICABLE |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15139 @DAS13833 @DAS13843 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatThePivotPanelShowNoFiltersAppliedIfThatWereAppliedToTheCustomList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Application Compliance" filter is added to the list
	When User create dynamic list with "TestListForDAS15139" name on "Devices" page
	Then "TestListForDAS15139" list is displayed to user
	When User navigates to Pivot
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	When User clicks Close panel button
	Then Actions panel is not displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	When User navigates to the "All Devices" list
	Then Actions panel is not displayed to the user

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13844
Scenario: EvergreenJnr_DevicesList_CheckResetButtonOnPivot
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
	When User creates Pivot list with "PivotList_DAS_13844" name
	Then "PivotList_DAS_13844" list is displayed to user
	When User clicks the Pivot button
	#Then reset button on main panel is not displayed
	And User adds the following "Columns" on Pivot: 
	| Value      |
	| Owner City |
	Then reset button on main panel is displayed
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#2
	When User navigates to the "All Devices" list
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then "RUN PIVOT" Action button is active
	And "SAVE" Action button is disabled
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#And "SAVE" Action button is not displayed
	#3
	When User selects the following Row Groups on Pivot:
	| RowGroups |
	| Hostname  |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	#aggregate function?
	Then "RUN PIVOT" Action button is active
	And "SAVE" Action button is disabled
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And "SAVE" Action button is active
	When User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	#And "SAVE" Action button is not displayed
	#4
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS_13844_1" name
	Then "PivotList_DAS_13844_1" list is displayed to user
	When User clicks the Pivot button
	And User clicks reset button on main panel
	Then "ADD ROW GROUP" Action button is displayed
	And "ADD COLUMN" Action button is displayed
	And "ADD VALUE" Action button is displayed
	And "SAVE" Action button is disabled
	And "RUN PIVOT" Action button is disabled
	And User remove list with "PivotList_DAS_13844" name on "Devices" page
	And User remove list with "PivotList_DAS_13844_1" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13842
Scenario: EvergreenJnr_DevicesList_CheckThatPivotPanelIsDisplayedCorrectlyAfterClicksOnManagerButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	Then "Pivot" panel is displayed to the user
	When User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS13842" name
	Then "PivotList_DAS13842" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to the "PivotList_DAS13842" list
	Then "PivotList_DAS13842" list is displayed to user
	When User clicks Settings button in the list panel
	And User clicks Manage in the list panel
	Then "Dynamic Pivot Details" panel is displayed to the user
	And User remove list with "PivotList_DAS13842" name on "Devices" page

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13833 @DAS13846
Scenario: EvergreenJnr_DevicesList_CheckThatAddingColumnOnPivotIsWorksCorrectlyForFilteredList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Key" filter where type is "Equals" with added column and following value:
	| Values |
	| 4553   |
	Then "Device Key" filter is added to the list
	When User navigates to Pivot
	And User clicks the "ADD COLUMN" Action button
	Then "1" subcategories is displayed for "Selected Filters" category
	And "Device Key" subcategory is selected in Column panel
	When User adds the "Device Key" category on Pivot
	Then "Selected Filters" section is not displayed in the Columns panel
	And "Device Key" subcategory is selected in Column panel

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13119 @DAS13652 @DAS13637 @DAS13649
Scenario: EvergreenJnr_DevicesList_CheckThatPivotSubmenuIsDisplayedCorrectlyAfterClosingListsPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotList_DAS13652" name
	Then "PivotList_DAS13652" list is displayed to user
	When User closed list panel
	Then Dashboards sub menu is hidden on Dashboards page
	And "PivotList_DAS13652" list name is displayed correctly on top tools panel
	And "RUN PIVOT" Action button is displayed
	Then Export button is displayed
	When User open sub menu for "PivotList_DAS13652" list
	Then User sees Dashboards sub menu on Dashboards page
	And User remove list with "PivotList_DAS13652" name on "Devices" page

@Evergreen @AllLists @EvergreenJnr_Pivot @Pivot @DAS11103 @DAS11264 @DAS11360 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRemovingValueThroughTheChipsWorksCorrectly
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <ValuesForFilter>  |
	Then "<FilterName>" filter is added to the list
	When User create dynamic list with "<ListName>" name on "<PageName>" page
	Then "<ListName>" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	And User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	And User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks the "RUN PIVOT" Action button
	And User adds the following "Values" on Pivot: 
	| Value             |
	| <AdditionalValue> |
	Then "<Value>" chip for Value is displayed
	Then "<AdditionalValue>" chip for Value is displayed
	When User clicks close button for "<AdditionalValue>" chip
	Then "<AdditionalValue>" chip for Value is not displayed
	When User clicks Plus button for "Values" Pivot value
	When User enters "<AdditionalValue>" text in Search field at Columns Panel
	When User closed "Selected Columns" columns category
	When User closed "Selected Filters" columns category
	Then "<AdditionalValue>" subcategory is displayed for "<CategoryName>" category

Examples:
	| PageName     | RowGroup    | Column                            | Value          | AdditionalValue      | ListName                | FilterName             | ValuesForFilter | CategoryName     |
	| Devices      | Compliance  | Babel(Engl: Application Readiness | Last Seen Date | OS Branch            | Devices_List_11103      | Application Compliance | Red             | Operating System |
	| Users        | Compliance  | App Count (Entitled)              | Domain         | Dashworks First Seen | Users_List_11103        | Compliance             | Red             | User             |
	| Mailboxes    | Alias       | Owner City                        | Created Date   | Alias                | Mailboxes_List_11103    | Enabled                | TRUE            | Mailbox          |
	| Applications | Application | Evergreen Capacity Unit           | Vendor         | Application Owner    | Applications_List_11103 | Compliance             | Red             | Custom Fields    |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS11103 @DAS13819 @DAS13818 @DAS13817 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatAggregateFunctionContainsCorrectValues
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Values on Pivot:
	| Values     |
	| HDD Count  |
	Then following aggregate function are available in dropdown:
	| Option |
	| count  |
	| sum    |
	| min    |
	| max    |
	| avg    |
	When User clicks close button for "HDD Count" chip
	And User selects the following Values on Pivot:
	| Values     |
	| Build Date |
	Then following aggregate function are available in dropdown:
	| Option |
	| count  |
	| first  |
	| last   |
	When User clicks close button for "Build Date" chip
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	Then following aggregate function are available in dropdown:
	| Option |
	| count  |
	When User clicks close button for "Owner City" chip

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14372 @DAS14373
Scenario Outline: EvergreenJnr_DevicesList_CheckThatOperatingSystemPivotValueIsDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |
	| <RowGroups> |
	And User selects the following Columns on Pivot:
	| Columns   |
	| <Columns> |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "<RowGroups>" column in ascending order by default for the Pivot

Examples:
	| RowGroups              | Columns               |
	| Operating System       | Owner Compliance      |
	| Service Pack or Build  | Owner Compliance      |
	| Application Compliance | Operating System      |
	| Application Compliance | Service Pack or Build |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14372
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildRowGroupDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups             |
	| Operating System      |
	| Service Pack or Build |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Owner Compliance |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Operating System" column in ascending order by default for the Pivot

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13862 @DAS14373
Scenario: EvergreenJnr_DevicesList_CheckThatOperatingSystemAndServicePackOrBuildColumnDisplayInTheCorrectOrder
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns               |
	| Operating System      |
	| Service Pack or Build |
	And User selects the following Values on Pivot:
	| Values     |
	| Owner City |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And data in the table is sorted by "Application Compliance" column in ascending order by default for the Pivot

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13786 @DAS13868
Scenario: EvergreenJnr_UsersList_CheckThatNumericValueHasTheCorrectOrder
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Compliance |
	And User selects the following Columns on Pivot:
	| Columns     |
	| Group Count |
	And User selects the following Values on Pivot:
	| Values       |
	| Device Count |
	And User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	And numeric data in table is sorted by "Compliance" column in descending order for the Pivot

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374 @Not_Run
Scenario: EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups          |
	| EmailMigra: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	And Pivot left-pinned column content is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Targeted   |
	| Scheduled  |
	| Migrated   |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374 @DAS15376 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups          |
	| MigrationP: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	And Pivot left-pinned column content is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Scheduled  |
	| Migrated   |
	| Complete   |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" without added column and Date options
	| StartDateInclusive | EndDateInclusive |
	| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14374 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsRowGroup
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups          |
	| ComputerSc: Status |
	And User selects the following Columns on Pivot:
	| Columns |
	| Country |
	And User selects the following Values on Pivot:
	| Values |
	| City   |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	And Pivot left-pinned column content is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Scheduled  |
	| Migrated   |
	| Complete   |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns            |
	| ComputerSc: Status |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	Then Empty value is displayed on the first place for the Pivot column header
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Scheduled  |
	| Migrated   |
	| Complete   |

@Evergreen @Users @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns            |
	| UserEvergr: Status |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	Then Empty value is displayed on the first place for the Pivot column header
	Then Pivot column headers is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Targeted   |
	| Scheduled  |
	| Migrated   |
	| Complete   |

@Evergreen @Mailboxes @EvergreenJnr_Pivot @Pivot @DAS13863 @DAS14375 @Not_Run
Scenario: EvergreenJnr_MailboxesList_CheckSortedOrderForPivotProjectStatusAsColumn
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups |
	| Building  |
	And User selects the following Columns on Pivot:
	| Columns            |
	| EmailMigra: Status |
	And User selects the following Values on Pivot:
	| Values |
	| Region |
	And User clicks the "RUN PIVOT" Action button
	Then Empty value is displayed on the first place for the Pivot
	And Empty value is displayed on the first place for the Pivot column header
	And Pivot column headers is displayed in following order:
	| ColumnName |
	| Onboarded  |
	| Forecast   |
	| Targeted   |
	| Scheduled  |
	| Migrated   |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328 @DAS14246 @Not_Run
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_StingValues
	When User clicks "<List>" on the left-hand menu
	Then "<List>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	Then "General information field 1" is displayed at the top left corner on Pivot

Examples:
	| List         | AddValues   | CountAggregateFunctions |
	| Devices      | Owner City  | Count(Owner City)       |
	| Users        | Building    | Count(Building)         |
	| Applications | Application | Count(Application)      |
	| Mailboxes    | Building    | Count(Building)         |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328 @Not_Run
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_DateValues
	When User clicks "<List>" on the left-hand menu
	Then "<List>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "First" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<FirstAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Last" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<LastAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | AddValues                          | CountAggregateFunctions                   | FirstAggregateFunctions                   | LastAggregateFunctions                   |
	| Devices      | Build Date                         | Count(Build Date)                         | First(Build Date)                         | Last(Build Date)                         |
	| Users        | Last Logon Date                    | Count(Last Logon Date)                    | First(Last Logon Date)                    | Last(Last Logon Date)                    |
	| Applications | Windows7Mi: Technical Task3 (Date) | Count(Windows7Mi: Technical Task3 (Date)) | First(Windows7Mi: Technical Task3 (Date)) | Last(Windows7Mi: Technical Task3 (Date)) |
	| Mailboxes    | Created Date                       | Count(Created Date)                       | First(Created Date)                       | Last(Created Date)                       |

@Evergreen @Devices @EvergreenJnr_Pivot @Pivot @DAS15758 @DAS15328 @Not_Run
Scenario Outline: EvergreenJnr_Lists_CheckThatColumnsForAggregateFunctionsAreCapitalised_NumericValues
	When User clicks "<List>" on the left-hand menu
	Then "<List>" list should be displayed to the user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups               |
	| Evergreen Capacity Unit |
	And User selects the following Columns on Pivot:
	| Columns                     |
	| General information field 1 |
	When User selects the following Values on Pivot:
	| Values      |
	| <AddValues> |
	When User selects aggregate function "Count" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<CountAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Sum" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<SumAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Min" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<MinAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Max" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<MaxAggregateFunctions>" is displayed in the columns for aggregate functions
	When User selects aggregate function "Avg" on Pivot
	And User clicks the "RUN PIVOT" Action button
	Then "<AvgAggregateFunctions>" is displayed in the columns for aggregate functions

Examples:
	| List         | AddValues                | CountAggregateFunctions         | SumAggregateFunctions         | MinAggregateFunctions         | MaxAggregateFunctions         | AvgAggregateFunctions         |
	| Devices      | HDD Count                | Count(HDD Count)                | Sum(HDD Count)                | Min(HDD Count)                | Max(HDD Count)                | Avg(HDD Count)                |
	| Users        | Device Count             | Count(Device Count)             | Sum(Device Count)             | Min(Device Count)             | Max(Device Count)             | Avg(Device Count)             |
	| Applications | 1803: Current User Count | Count(1803: Current User Count) | Sum(1803: Current User Count) | Min(1803: Current User Count) | Max(1803: Current User Count) | Avg(1803: Current User Count) |
	| Mailboxes    | Associated Item Count    | Count(Associated Item Count)    | Sum(Associated Item Count)    | Min(Associated Item Count)    | Max(Associated Item Count)    | Avg(Associated Item Count)    |