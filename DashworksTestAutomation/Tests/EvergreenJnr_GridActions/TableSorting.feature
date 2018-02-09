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
	Then data in table is sorted by 'Boot Up Date' column in descending order
	When User click on 'Boot Up Date' column header
	Then data in table is sorted by 'Boot Up Date' column in ascending order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in descending order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in ascending order

@Evergreen @Applications @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_ApplicationsList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Applications" page:
	| ColumnName                        |
	| Barry'sUse: Package Delivery Date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Software       | 94           |
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then data in table is sorted by 'Barry'sUse: Package Delivery Date' column in descending order
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then data in table is sorted by 'Barry'sUse: Package Delivery Date' column in ascending order
	
@Evergreen @Mailboxes @EvergreenJnr_GridActions @TableSorting @DAS10612
Scenario: EvergreenJnr_MailboxesList_CheckSortByDateFunctionality
	When User add following columns using URL to the "Mailboxes" page:
	| ColumnName                 |
	| Created Date               |
	| EmailMigra: Scheduled date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Sonja          | 1            |
	When User click on 'Created Date' column header
	Then data in table is sorted by 'Created Date' column in descending order
	When User click on 'Created Date' column header
	Then data in table is sorted by 'Created Date' column in ascending order
	When User click on 'EmailMigra: Scheduled date' column header
	Then data in table is sorted by 'EmailMigra: Scheduled date' column in descending order
	When User click on 'EmailMigra: Scheduled date' column header
	Then data in table is sorted by 'EmailMigra: Scheduled date' column in ascending order

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
	Then data in table is sorted by 'Last Logon Date' column in descending order
	When User click on 'Last Logon Date' column header
	Then data in table is sorted by 'Last Logon Date' column in ascending order
	When User click on 'MigrationP: Migrated Date' column header
	Then data in table is sorted by 'MigrationP: Migrated Date' column in descending order
	When User click on 'MigrationP: Migrated Date' column header
	Then data in table is sorted by 'MigrationP: Migrated Date' column in ascending order

@Evergreen @Devices @EvergreenJnr_GridActions @TableSorting @DAS11568
Scenario: EvergreenJnr_DevicesList_CheckThat500ErrorIsNotDisplayedWhenSortingOwnerComplianceColumnOnDevicesList
	When User add following columns using URL to the ""Devices" page:
	| ColumnName       |
	| Owner Compliance |
	Then "17,225" rows are displayed in the agGrid
	When User click on 'Owner Compliance' column header
	Then data in table is sorted by 'Owner Compliance' column in ascending order
	Then "17,225" rows are displayed in the agGrid