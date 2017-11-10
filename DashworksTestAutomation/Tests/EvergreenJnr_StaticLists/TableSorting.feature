Feature: TableSorting
	Runs Evergreen Table actions related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @TableSorting @DAS-10612
Scenario: Evergreen Jnr_DevicesList_Check Sort By Date Functionality
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	Then ColumnName is added to the list
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Windows XP     | 15,153       |
	When User click on 'Boot Up Date' column header
	Then data in table is sorted by 'Boot Up Date' column in descenting order
	When User click on 'Boot Up Date' column header
	Then data in table is sorted by 'Boot Up Date' column in ascending order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in descenting order
	When User click on 'Windows7Mi: Date & Time Task' column header
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in ascending order
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @TableSorting @DAS-10612
Scenario: Evergreen Jnr_ApplicationsList_Check Sort By Date Functionality
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| Barry'sUse: Package Delivery Date |
	Then ColumnName is added to the list
	| ColumnName                        |
	| Barry'sUse: Package Delivery Date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Software       | 142          |
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then data in table is sorted by 'Barry'sUse: Package Delivery Date' column in descenting order
	When User click on 'Barry'sUse: Package Delivery Date' column header
	Then data in table is sorted by 'Barry'sUse: Package Delivery Date' column in ascending order
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
	
@Evergreen @TableActions @Mailboxes @DAS-10612
Scenario: Evergreen Jnr_MailboxesList_Check Sort By Date Functionality
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| Created Date               |
	| EmailMigra: Scheduled date |
	Then ColumnName is added to the list
	| ColumnName                 |
	| Created Date               |
	| EmailMigra: Scheduled date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Sonja            | 4          |
	When User click on 'Created Date' column header
	Then data in table is sorted by 'Created Date' column in descenting order
	When User click on 'Created Date' column header
	Then data in table is sorted by 'Created Date' column in ascending order
	When User click on 'EmailMigra: Scheduled date' column header
	Then data in table is sorted by 'EmailMigra: Scheduled date' column in descenting order
	When User click on 'EmailMigra: Scheduled date' column header
	Then data in table is sorted by 'EmailMigra: Scheduled date' column in ascending order
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @TableSorting @DAS-10612
Scenario: Evergreen Jnr_UsersList_Check Sort By Date Functionality
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                |
	| Last Logon Date           |
	| MigrationP: Migrated Date |
	Then ColumnName is added to the list
	| ColumnName                |
	| Last Logon Date           |
	| MigrationP: Migrated Date |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Tim            | 140          |
	When User click on 'Last Logon Date' column header
	Then data in table is sorted by 'Last Logon Date' column in descenting order
	When User click on 'Last Logon Date' column header
	Then data in table is sorted by 'Last Logon Date' column in ascending order
	When User click on 'MigrationP: Migrated Date' column header
	Then data in table is sorted by 'MigrationP: Migrated Date' column in descenting order
	When User click on 'MigrationP: Migrated Date' column header
	Then data in table is sorted by 'MigrationP: Migrated Date' column in ascending order
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @QueryStrings @Users @Mailboxes @Devices @Applications @TableSorting @DAS-10598
Scenario: Evergreen Jnr_QueryString_SortByKeys
Runs Evergreen URL query strings which include being sorted by object key columns.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
	| Sort by device key              | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName,monitorCount,videoCardCount,computerKey&$orderby=computerKey%20desc                                                                                                                                                                                                                                                                                                                 |
	| Sort by user key                | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName,objectKey&$orderby=objectKey%20desc                                                                                                                                                                                                                                                                                                                                        |
	| Sort by application key         | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion,packageKey&$orderby=packageKey%20asc                                                                                                                                                                                                                                                                                                                                                 |
	| Sort by mailbox key             | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName,mailboxKey&$orderby=mailboxKey%20asc                                                                                                                                                                                                                                                                                                                     |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @QueryStrings @Users @Mailboxes @Devices @Applications @TableSorting
Scenario: Evergreen Jnr_QueryString_AllLists
Runs Evergreen URL query strings for the 4 default all lists.
	When Evergreen QueryStringURL is entered for Simple QueryType
	| QueryType                       | QueryStringURL                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
	| All Devices                     | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName                                                                                                                                                                                                                                                                                                                                                                                     |
	| All Users                       | evergreen/#/users?$select=username,directoryName,displayName,fullyDistinguishedObjectName                                                                                                                                                                                                                                                                                                                                                                            |
	| All Applications                | evergreen/#/applications?$select=packageName,packageManufacturer,packageVersion                                                                                                                                                                                                                                                                                                                                                                                      |
	| All Mailboxes                   | evergreen/#/mailboxes?$select=principalEmailAddress,mailboxPlatform,serverName,mailboxType,ownerDisplayName                                                                                                                                                                                                                                                                                                                                                          |
	Then agGrid Main Object List is returned with data
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
