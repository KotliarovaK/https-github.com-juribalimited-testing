Feature: Functionality
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @Evergreen_FiltersFeature @FiltersFunctionality @DAS-10612
Scenario: EvergreenJnr_UsersList_Check that 500 error is not returned for filter with special charecter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
	| Values               |
	| Jeremiah S. O'Connor |
	Then "Display Name" filter is added to the list
	And "2" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersFunctionality @DAS-10639
Scenario: EvergreenJnr_ApplicationsList_Check 500 error is not returned for boolean filter with Unknown option
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User add "Windows7Mi: Hide from End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "1,156" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-10734
Scenario: EvergreenJnr_ApplicationsList_Check that add column checkbox works currectly
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then table data is filtred correctly
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11166 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_Check that filter is restored after going back to the list again
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                       |
	| Microsoft Office 97, Professional Edition    |
	| Microsoft Office 97, Developer Edition Tools |
	| Microsoft Office 97, Standard Edition        |
	Then "Application" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info
	When User navigates to the "All Applications" list
	Then "Applications" list should be displayed to the user
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-11042
Scenario Outline: EvergreenJnr_AllLists_Check that primary column is displayed after adding a filter with column
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Contains" with added column and following value:
	| Values        |
	| <FilterValue> |
	Then "<FilterName>" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |

Examples: 
	| ListName     | FilterName              | FilterValue | ColumnName    |
	| Devices      | Hostname                | 00          | Hostname      |
	| Applications | Application             | adobe       | Application   |
	| Users        | Username                | aa          | Username      |
	| Mailboxes    | Email Address (Primary) | ale         | Email Address |

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-11042
Scenario: EvergreenJnr_Devices_Check that Add column checkbox is checked after saving filter in a new list
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-11042
Scenario: EvergreenJnr_Devices_Check that Add column checkbox is checked after saving a filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Devices @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-11042
Scenario: EvergreenJnr_Devices_Check that Add column checkbox is unchecked after saving a filter and removing a column
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	When User clicks the Columns button
	When User is removed "Compliance" column by Column panel
	When User clicks the Filters button
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is unchecked
	And "Add Column" checkbox is disabled

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-10977
Scenario Outline: EvergreenJnr_AllLists_Check that filter is restored correctly after leaving the page and going back via the browse "back" button for checkboxes filters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                      | FilterValue    | RowsCount | ColumnName    | ObjectName                                | Text                                       |
	| Devices      | Babel(Engl: Category            | None           | 62        | Hostname      | 01COJATLYVAR7A6                           | Babel(Engl: Category is None               |
	| Devices      | Barry'sUse: In Scope            | FALSE          | 15,896    | Hostname      | 00BDM1JUR8IF419                           | Barry'sUse: In Scope is false              |
	| Devices      | ComputerSc: Request Type        | Request Type A | 132       | Hostname      | 46DIQRWG3BM6K9Z                           | ComputerSc: Request Type is Request Type A |
	| Applications | Havoc(BigD: Hide from End Users | UNKNOWN        | 1,156     | Application   | Microsoft Silverlight 2 SDK (2.0.31005.0) | Havoc(BigD: Hide from End Users is Unknown |
	| Applications | MigrationP: Core Application    | FALSE          | 220       | Application   | Quartus II Programmer 4.0                 | MigrationP: Core Application is false      |
	| Mailboxes    | EmailMigra: Device Type         | Not Identified | 80        | Email Address | alex.cristea@juriba.com                   | EmailMigra: Device Type is Not Identified  |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-10977
Scenario Outline: EvergreenJnr_AllLists_Check that filter is restored correctly after leaving the page and going back via the browse "back" button for lookup filters
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	When User have created "Equals" Lookup filter with column and "<FilterValue>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	Then "<Text>" is displayed in added filter info

Examples: 
	| ListName     | FilterName                       | FilterValue      | RowsCount | ColumnName    | ObjectName              | Text                                            |
	| Applications | Barry'sUse: Target App           | Python 2.2a4 (1) | 1         | Application   | Python 2.2a4            | Barry'sUse: Target App is Python 2.2a4 (1)      |
	| Mailboxes    | EmailMigra: BT/QMM Switch Status | Not Started      | 80        | Email Address | alex.cristea@juriba.com | EmailMigra: BT/QMM Switch Status is Not Started |

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-10977
Scenario: EvergreenJnr_AllLists_Check that filter is restored correctly after leaving the page and going back via the browse "back" button for values filters
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                    |
	| Microsoft Office 97, Professional Edition |
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info
	Then "5" rows are displayed in the agGrid
	When User perform search by "Microsoft Office 97, Professional Edition"
	And User click content from "Application" column
	Then User click back button in the browser
	Then "5" rows are displayed in the agGrid
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info

@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-10977 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_Check that filter is restored correctly after leaving the page and going back via the browse "back" button for list filters
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Application Key |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "Equals" with SelectedList list and following Association:
	| SelectedList | Association        |
	| TestList     | Not used on device |
	Then "Application in list TestList is not used on device" is displayed in added filter info
	Then "17,095" rows are displayed in the agGrid
	When User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	Then User click back button in the browser
	Then "17,095" rows are displayed in the agGrid
	Then "Application in list TestList is not used on device" is displayed in added filter info
