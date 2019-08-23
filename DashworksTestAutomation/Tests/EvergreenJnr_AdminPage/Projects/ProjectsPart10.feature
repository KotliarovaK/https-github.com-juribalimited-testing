Feature: ProjectsPart10
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects @TEST
Scenario Outline: EvergreenJnr_ChangingApplicationsScopeListToAnotherList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList57" name on "Applications" page
	Then "DynamicList57" list is displayed to user
	When User create static list with "StaticList6379" name on "Applications" page with following items
	| ItemName         |
	| ACD Display 3.4  |
	| Acrobat Reader 4 |
	Then "StaticList6379" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| DevicesProject4 | All Devices | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ApplicationsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ApplicationsToAdd2>" is displayed to the user in the Project Scope Changes section
	#Then There are no errors in the browser console

Examples:
	| ChangingToList1  | ChangingToList2  | ApplicationsToAdd1                       | ApplicationsToAdd2                       |
	| All Applications | DynamicList57    | Applications to add (0 of 2129 selected) | Applications to add (0 of 39 selected)   |
	| StaticList6379   | All Applications | Applications to add (0 of 2 selected)    | Applications to add (0 of 2129 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13973 @Cleanup @Projects @TEST
Scenario Outline: EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| DEV50          |
	Then "92" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList37" name on "Users" page
	Then "DynamicList37" list is displayed to user
	When User create static list with "StaticList6329" name on "Users" page with following items
	| ItemName |
	| barbosaj |
	| clarkc   |
	Then "StaticList6329" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName     | Scope     | ProjectTemplate | Mode   |
	| DevicesProject5 | All Users | None            | <Mode> |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1 | ChangingToList2 | Mode                            | ObjectsToAdd1                      | ObjectsToAdd2                   |
	| All Users       | StaticList6329  | Clone from Evergreen to Project | Users to add (0 of 41339 selected) | Users to add (0 of 2 selected)  |
	| StaticList6329  | DynamicList37   | Standalone Project              | Users to add (0 of 2 selected)     | Users to add (0 of 92 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects @TEST
Scenario Outline: EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then "<Rows>" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList58" name on "<ListName>" page
	Then "DynamicList58" list is displayed to user
	When Project created via API and opened
	| ProjectName     | Scope         | ProjectTemplate | Mode               |
	| DevicesProject8 | <ProjectList> | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "<ScopeDetails>" tab in the Scope section on the Project details page
	And User selects "DynamicList58" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "<ScopeDetails>" tab in the Scope section on the Project details page
	And User selects "<AllList>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "<ScopeChanges>" tab in the Project Scope Changes section
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ListName | FilterName       | FilterValue | Rows | ProjectList   | AllList     | ScopeChanges | ScopeDetails | ObjectsToAdd                         | ChangingToList | ObjectsToAdd1                     | ObjectsToAdd2                        |
	| Devices  | Operating System | Windows 8   | 28   | All Users     | All Devices | Devices      | Device Scope | Devices to add (0 of 16819 selected) | StaticList6429 | Devices to add (0 of 24 selected) | Devices to add (0 of 16819 selected) |
	| Users    | Domain           | CA          | 850  | All Mailboxes | All Users   | Users        | User Scope   | Users to add (0 of 14747 selected)   | DynamicList17  | Users to add (0 of 0 selected)    | Users to add (0 of 14747 selected)   |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13297 @Cleanup @Projects @TEST
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Version" filter where type is "Does not contain" with added column and following value:
	| Values            |
	| 97.1.0.0918(1031) |
	Then "1,741" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList17" name on "Applications" page
	Then "DynamicList17" list is displayed to user
	When User create static list with "StaticList6429" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "StaticList6429" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName     | Scope     | ProjectTemplate | Mode               |
	| DevicesProject9 | All Users | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList1>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "<ChangingToList2>" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| ChangingToList1  | ChangingToList2 | ObjectsToAdd1                            | ObjectsToAdd2                            |
	| All Applications | StaticList6429  | Applications to add (0 of 2081 selected) | Applications to add (0 of 2 selected)    |
	| StaticList6429   | DynamicList17   | Applications to add (0 of 2 selected)    | Applications to add (0 of 1612 selected) |