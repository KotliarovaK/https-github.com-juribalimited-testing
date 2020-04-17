Feature: OutsideUsage
	Run Self Service related tests in whole project 

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20791 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_CheckApplicationSelfServiceColumns
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
	| 20791_SI: Link                       |
	When User clicks on '20791_SI: Welcome Page Status' column header
	Then '20791_SI: Welcome Page Status' column contains following content
	| Content                |
	| Page not viewed        |
	| Page not viewed        |
	When User clicks on '20791_SI: Welcome Page Status Date' column header
	Then '20791_SI: Welcome Page Status Date' column contains following content
	| Content |
	|         |
	When User clicks on '20791_SI: Thank You Page Status' column header
	Then '20791_SI: Thank You Page Status' column contains following content
	| Content                |
	| Page not viewed        |
	| Page not viewed        |
	When User scroll right to the '20791_SI: Link' column
	When User clicks on '20791_SI: Thank You Page Status Date' column header
	Then '20791_SI: Thank You Page Status Date' column contains following content
	| Content |
	|         |
	When User clicks on '20791_SI: Link' column header
	Then '20791_SI: Link' column contains following content
	| Content                                                 |
	| /20791_SI?ObjectId=0007AD15-8C65-4E6A-841E-F45E3CD99C49 |
	| /20791_SI?ObjectId=00445C1C-05F0-4738-A2B0-AA53E7E7CAF9 |