Feature: OutsideUsage
	Run Self Service related tests in whole project 

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20791 @DAS20918 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckApplicationSelfServiceColumns
	When User create static list with "DAS_20791" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20791_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name         | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20791_SS | 20791_SI          | true    | true                | DAS_20791 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                  | ShowInSelfService |
	| AOC Name      | 2004 Rollout | Do not allow owner to be changed | true              |
	#When User navigates to End User landing page with '20791_1_SI' Self Service Identifier
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                           |
	| 20791_SI: Welcome Page Status        |
	| 20791_SI: Welcome Page Status Date   |
	| 20791_SI: Thank You Page Status      |
	| 20791_SI: Thank You Page Status Date |
	| 20791_SI: Self Service Link          |
	When User clicks on '20791_SI: Welcome Page Status' column header
	Then '20791_SI: Welcome Page Status' column contains following content
	| Content    |
	| Not viewed |
	| Not viewed |
	When User clicks on '20791_SI: Welcome Page Status Date' column header
	Then '20791_SI: Welcome Page Status Date' column contains following content
	| Content |
	|         |
	When User clicks on '20791_SI: Thank You Page Status' column header
	Then '20791_SI: Thank You Page Status' column contains following content
	| Content    |
	| Not viewed |
	| Not viewed |
	When User scroll right to the '20791_SI: Self Service Link' column
	When User clicks on '20791_SI: Thank You Page Status Date' column header
	Then '20791_SI: Thank You Page Status Date' column contains following content
	| Content |
	|         |
	When User clicks on '20791_SI: Self Service Link' column header
	Then '20791_SI: Self Service Link' column contains following content
	| Content                                                                                                       |
	| https://master.corp.juriba.com/evergreen/#/selfservice/20791_SI?ObjectId=0007AD15-8C65-4E6A-841E-F45E3CD99C49 |
	| https://master.corp.juriba.com/evergreen/#/selfservice/20791_SI?ObjectId=00445C1C-05F0-4738-A2B0-AA53E7E7CAF9 |
	When User create dynamic list with "20791List" name on "Applications" page
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20073 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckApplicationSelfServiceFilters
	When User creates Self Service via API and open it
	| Name         | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope            |
	| DAS_20073_SS | 20073_SI          | true    | true                | All Applications |
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User add "20073_SI: Welcome Page Status" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not viewed         |
	Then "20073_SI: Welcome Page Status" filter is added to the list
	When User Add And "20073_SI: Welcome Page Status Date" filter where type is "Empty" with added column and following value:
	| Values |
	|        |
	Then "20073_SI: Welcome Page Status Date" filter is added to the list
	When User Add And "20073_SI: Thank You Page Status" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "20073_SI: Thank You Page Status" filter is added to the list
	When User Add And "20073_SI: Thank You Page Status Date" filter where type is "Does not equal" with added column and following value:
	| Values     |
	| 1 Apr 2020 |
	Then "20073_SI: Thank You Page Status Date" filter is added to the list
	When User create dynamic list with "List20073" name on "Applications" page
	Then "List20073" list is displayed to user
	And There are no errors in the browser console
	When User scroll right to the '20791_SI: Self Service Link' column
	Then '20791_SI: Welcome Page Status' column contains following content
	| Content    |
	| Not viewed |
	| Not viewed |
	Then '20791_SI: Welcome Page Status Date' column contains following content
	| Content |
	|         |
	Then '20791_SI: Thank You Page Status' column contains following content
	| Content |
	| Not viewed |
	| Not viewed |
	Then '20791_SI: Thank You Page Status Date' column contains following content
	| Content |
	|         |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21232 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceHasCompletedStatus
	When Project created via API and opened
	| ProjectName | Scope     | ProjectTemplate | Mode               |
	| 21232_Proj  | All Users | None            | Standalone Project |
	And User onboard objects to '21232_Proj' project
	| ApplicationObjects |
	| VSCmdShell         |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Queue' left menu item
	And User waits until Queue disappears
	And User resync 'Application' objects for '21232_Proj' project
	| Values     |
	| VSCmdShell |
	And User create static list with "21232_UserList" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	And User create static list with "21232_AppList" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	And User creates Self Service via API and open it
	| Name     | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope         |
	| 21232_SS | 21232_SI          | true    | true                | 21232_AppList |
	And User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName | OwnerPermission                | UserScope      |
	| AOC Name      | 21232_Proj  | Allow owner to be removed only | 21232_UserList |
	And User clicks 'Applications' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                      |
	| 21232_SI: Welcome Page Status   |
	| 21232_SI: Thank You Page Status |
	And User perform search by "VSCmdShell"
	Then Content in the '21232_SI: Welcome Page Status' column is equal to
	| Content    |
	| Not viewed |
	And Content in the '21232_SI: Thank You Page Status' column is equal to
	| Content    |
	| Not viewed |
	When User navigates to End User landing page with '21232_SI' Self Service Identifier
	And User clicks on 'Remove Owner' button on end user Self Service page
	And User clicks on 'Continue' button on end user Self Service page
	And User navigate to Evergreen URL
	And User clicks 'Applications' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName                      |
	| 21232_SI: Welcome Page Status   |
	| 21232_SI: Thank You Page Status |
	And User perform search by "VSCmdShell"
	Then Content in the '21232_SI: Welcome Page Status' column is equal to
	| Content   |
	| Completed |
	And Content in the '21232_SI: Thank You Page Status' column is equal to
	| Content   |
	| Completed |