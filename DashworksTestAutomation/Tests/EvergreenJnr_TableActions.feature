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
Scenario: Evergreen Jnr_ApplicationsList_Add Custom Column Action
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then FilterData is displayed for apropriate column
	| FilterData      |
	| A Star Packages |
	| A Star Packages |
	| A Star Packages |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10612
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

@Evergreen @TableActions @Users @DAS-10612
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
	
@Evergreen @TableActions @Applications @DAS-10612
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

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in default list
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
	When User click on 'Boot Up Date' column header
	When User is removed "Boot Up Date" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User click on 'Windows7Mi: Date & Time Task' column header
	When User is removed column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
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
	When User click on 'Build Date' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User is removed "Build Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Build Date |
	When User click on 'Boot Up Date' column header
	When User is removed column by URL
	| ColumnName   |
	| Boot Up Date |
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User update current custom list
	When User is removed custom list with "TestList" name
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing multiple sorted column in default list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	Then ColumnName is added to the list
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User sort table by multiple columns
	| ColumnName                   |
	| Boot Up Date                 |
	| Windows7Mi: Date & Time Task |
	| Build Date                   |
	When User is removed "Boot Up Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in descenting order
	When User is removed column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then data in table is sorted by 'Build Date' column in descenting order
		When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing multiple sorted column in custom list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
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
	When User sort table by multiple columns
	| ColumnName                   |
	| Boot Up Date                 |
	| Build Date                   |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User is removed "Build Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Build Date |
	Then data in table is sorted by 'Boot Up Date' column in ascending order
	When User is removed column by URL
	| ColumnName   |
	| Boot Up Date |
	When User update current custom list
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User is removed custom list with "TestList" name
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in default list throw filters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When user select "Directory Type" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User is removed "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User is removed column by URL
	| ColumnName     |
	| Directory Type |
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is removed from the list
	| ColumnName     |
	| Directory Type |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Directory Type" filter is added to the list
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10966 @DAS-10973
Scenario: Evergreen Jnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in custom list throw filters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Directory Type" filter
	When User have created filter with "true" column checkbox and following options:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User is removed "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User is removed column by URL
	| ColumnName     |
	| Directory Type |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then ColumnName is removed from the list
	| ColumnName     |
	| Directory Type |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Directory Type" filter is added to the list
	When User update current custom list
	When User is removed custom list with "TestList" name
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-10584
Scenario: Evergreen Jnr_ApplicationsList_Check category heading when all columns from category are added
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User add all Columns from specific category
	| CategoryName |
	| Application  |
	Then "0" subcategories is displayed for "Application" category
	#Maximize/Minimize button is still displayed even category is empty. This is known issue
	#Because of this below assertion is commented
	#Then Maximize or Minimize button is not displayed for "Applications" category
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-11003
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when deleting a filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "false" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have removed "Windows7Mi: Category" filter
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @TableActions @Devices @DAS-11003
Scenario: Evergreen Jnr_DevicesList_Check that custom list creation block is not displayed when reseting a filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	When User have created filter with "false" column checkbox and following options:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out