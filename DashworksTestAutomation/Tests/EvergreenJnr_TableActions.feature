#@retry:3
Feature: EvergreenJnr_TableActions
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

@Evergreen @TableActions @Applications @DAS-10734
Scenario: Evergreen Jnr_Applications add custom column action
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have selected following options and clicks save button
	| SelectedOptionName  |
	| A Star Packages     |
	| Add Category column |
	Then "Windows7Mi: Category" filter is added to the list
	Then FilterData is displayed for apropriate column
	| FilterData      |
	| A Star Packages |
	| A Star Packages |
	| A Star Packages |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Users @DAS-10612
Scenario: Evergreen Jnr_Users check sort by Date functionality
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

@Evergreen @TableActions @Devices @DAS-10966
Scenario: Evergreen Jnr_Users check that 500 error page is not displayed after removeng column
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
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User is removed "Boot Up Date" column by Column panel
	Then "Devices" list should be displayed to the user
	When User is removed column by URL
	| ColumnName                   | Url                                                                                                                         |
	| Windows7Mi: Date & Time Task | evergreen/#/devices?$select=hostname,chassisCategory,oSCategory,ownerDisplayName&$orderby=project_task_1_9950_2_Task%20desc |
	Then "Devices" list should be displayed to the user
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Boot Up Date |
	Then ColumnName is added to the list
	| ColumnName   |
	| Boot Up Date |
	When User is removed column by URL
	| ColumnName   | Url                                                                                                  |
	| Boot Up Date | evergreen/#/devices?$listid=3&$select=hostname,chassisCategory,oSCategory,ownerDisplayName,buildDate |
	When User is removed custom list with "TestList" name
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
