﻿Feature: RemoveColumn
	Runs Remove column related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in custom list
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
	Then "TestList" list is displayed to user
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
	When User removes "Build Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Build Date |
	When User click on 'Boot Up Date' column header
	When User removes column by URL
	| ColumnName   |
	| Boot Up Date |
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing multiple sorted column in custom list
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
	Then "TestList" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
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
	When User removes "Build Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName |
	| Build Date |
	Then data in table is sorted by 'Boot Up Date' column in ascending order
	When User removes column by URL
	| ColumnName   |
	| Boot Up Date |
	When User update current custom list
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in custom list throw filters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Directory Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User removes "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User removes column by URL
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

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in default list
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
	When User removes "Boot Up Date" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	When User click on 'Windows7Mi: Date & Time Task' column header
	When User removes column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing multiple sorted column in default list
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
	When User removes "Boot Up Date" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName   |
	| Boot Up Date |
	Then data in table is sorted by 'Windows7Mi: Date & Time Task' column in descending order
	When User removes column by URL
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName                   |
	| Windows7Mi: Date & Time Task |
	Then data in table is sorted by 'Build Date' column in descending order

@Evergreen @Devices @EvergreenJnr_Columns @RemoveColumn @DAS-10966 @DAS-10973
Scenario: EvergreenJnr_DevicesList_Check that 500 error page is not displayed after removing sorted column in default list throw filters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| None                |
	Then "Windows7Mi: Category" filter is added to the list
	When User add "Directory Type" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| Generic             |
	Then "Directory Type" filter is added to the list
	When User click on 'Windows7Mi: Category' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	Then User is expand "Selected Columns" columns category
	When User removes "Windows7Mi: Category" column by Column panel
	Then "Devices" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName           |
	| Windows7Mi: Category |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Category" filter is added to the list
	When User click on 'Directory Type' column header
	When User removes column by URL
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

@Evergreen @Users @EvergreenJnr_Columns @RemoveColumn @DAS-10973
Scenario: Evergreen Users List Check that 500 error page is not displayed after removing sorted column
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |
	Then ColumnName is added to the list
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |
	When User click on 'Last Logon Date' column header
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Last Logon Date" column by Column panel
	When User removes "Home Drive" column by Column panel
	Then "Users" list should be displayed to the user
	Then ColumnName is removed from the list
	| ColumnName      |
	| Last Logon Date |
	| Home Drive      |