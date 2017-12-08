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
	When User have create "Display Name" filter with "Equals" options and following value:
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
	When User have create "Windows7Mi: Hide from End Users" filter with "Equals" options and following value:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User have create "Windows7Mi: Hide from End Users" filter with "Equals" options and following value:
	| SelectedCheckboxes |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide from End Users" filter
	When User have create "Windows7Mi: Hide from End Users" filter with "Equals" options and following value:
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
	When user select "Windows7Mi: Category" filter
	When User have created "Equals" filter with column and following options:
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
	When User have create "Application" filter with "Equals" options and following value:
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
	When User have create "<FilterName>" filter with "Contains" options and following value:
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


@Evergreen @AllLists @EvergreenJnr_FilterFeature @FilterFunctionality @DAS-10977
Scenario Outline: EvergreenJnr_AllLists_Check that filter is restored correctly after leaving the page and going back via the browse "back" button
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter 
	And User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<FilterName>" filter is added to the list
	Then "<RowsCount>" rows are displayed in the agGrid
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	Then "<RowsCount>" rows are displayed in the agGrid
	Then "<FilterName>" filter is added to the list

Examples: 
	| ListName     | FilterName                      | FilterValue    | RowsCount | ColumnName    | ObjectName                                |
	| Devices      | Babel(Engl: Category            | None           | 62        | Hostname      | 01COJATLYVAR7A6                           |
	| Devices      | Barry'sUse: In Scope            | FALSE          | 15,896    | Hostname      | 00BDM1JUR8IF419                           |
	| Devices      | ComputerSc: Request Type        | Request Type A | 132       | Hostname      | 46DIQRWG3BM6K9Z                           |
	| Applications | Havoc(BigD: Hide from End Users | UNKNOWN        | 1,156     | Application   | Microsoft Silverlight 2 SDK (2.0.31005.0) |
	| Applications | MigrationP: Core Application    | FALSE          | 220       | Application   | Quartus II Programmer 4.0                 |
	| Mailboxes    | EmailMigra: Device Type         | Not Identified | 80        | Email Address | alex.cristea@juriba.com                   |