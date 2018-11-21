@retry:1
Feature: TableSorting
	Runs Table Sorting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_DevicesList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Devices" page:
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Windows XP     | 15,152       |
	When User click on 'Boot Up Date' column header
	Then date in table is sorted by 'Boot Up Date' column in descending order
	When User click on 'Boot Up Date' column header
	Then date in table is sorted by 'Boot Up Date' column in ascending order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then date in table is sorted by 'Windows7Mi: Date & Time Task' column in descending order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then date in table is sorted by 'Windows7Mi: Date & Time Task' column in ascending order

@Evergreen @Applications @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Applications" page:
	| ColumnName                        |
	| Barry'sUse: Package Delivery Date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Software       | 94           |
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then date in table is sorted by 'Barry'sUse: Package Delivery Date' column in descending order
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then date in table is sorted by 'Barry'sUse: Package Delivery Date' column in ascending order
	
@Evergreen @Mailboxes @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_MailboxesList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Mailboxes" page:
	| ColumnName                 |
	| Created Date               |
	| EmailMigra: Scheduled date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Office         | 38           |
	When User click on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in descending order
	When User click on 'Created Date' column header
	Then date in table is sorted by 'Created Date' column in ascending order
	When User click on 'EmailMigra: Scheduled date' column header
	Then date in table is sorted by 'EmailMigra: Scheduled date' column in descending order
	When User click on 'EmailMigra: Scheduled date' column header
	Then date in table is sorted by 'EmailMigra: Scheduled date' column in ascending order

@Evergreen @Users @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_UsersList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Users" page:
	| ColumnName                |
	| Last Logon Date           |
	| MigrationP: Migrated Date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Tim            | 147          |
	When User click on 'Last Logon Date' column header
	Then date in table is sorted by 'Last Logon Date' column in descending order
	When User click on 'Last Logon Date' column header
	Then date in table is sorted by 'Last Logon Date' column in ascending order
	When User click on 'MigrationP: Migrated Date' column header
	Then date in table is sorted by 'MigrationP: Migrated Date' column in descending order
	When User click on 'MigrationP: Migrated Date' column header
	Then date in table is sorted by 'MigrationP: Migrated Date' column in ascending order

@Evergreen @Devices @EvergreenJnr_GridActions @TableSorting @DAS11568
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Owner Compliance |
	Then "17,225" rows are displayed in the agGrid
	When User click on 'Owner Compliance' column header
	Then color data is sorted by 'Owner Compliance' column in ascending order
	Then "17,225" rows are displayed in the agGrid
	
@Evergreen @AllLists @EvergreenJnr_GridActions @TableSorting @DAS11951
Scenario Outline: EvergreenJnr_AllList_CheckThatTheDataInTheTablesAreSortedAppropriate
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order

	Examples: 
	| ListName     | ColumnName         |
	| Devices      | Hostname           |
	| Users        | Domain             |
	| Applications | Version            |
	| Mailboxes    | Owner Display Name |

@Evergreen @AllLists @EvergreenJnr_GridActions @TableSorting @DAS12545 @DAS14287 @Delete_Newly_Created_List @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatSortingIsSavedForNewSavedList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |
	When User click on '<ColumnName>' column header
	Then numeric data in table is sorted by '<ColumnName>' column in descending order
	When User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	When User navigates to the "<AllListName>" list
	Then "<ListName>" list should be displayed to the user
	When User navigates to the "<DynamicListName>" list
	Then "<DynamicListName>" list is displayed to user
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |
	Then numeric data in table is sorted by '<ColumnName>' column in descending order
	Then Edit List menu is not displayed

Examples: 
	| ListName     | ColumnName             | AllListName      | DynamicListName |
	| Devices      | ComputerSc: Team ID    | All Devices      | DynamicList4857 |
	| Users        | Windows7Mi: Team ID    | All Users        | DynamicList1857 |
	| Applications | ComputerSc: Project ID | All Applications | DynamicList2857 |
	| Mailboxes    | EmailMigra: Team ID    | All Mailboxes    | DynamicList3857 |