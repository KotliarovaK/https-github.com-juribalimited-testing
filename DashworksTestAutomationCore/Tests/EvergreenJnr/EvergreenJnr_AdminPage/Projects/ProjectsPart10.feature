﻿Feature: ProjectsPart10
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationsScopeListToAnotherList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "39" rows are displayed in the agGrid
	When User create dynamic list with "<FirstListName>" name on "Applications" page
	Then "<FirstListName>" list is displayed to user
	When User create static list with "<SecondListName>" name on "Applications" page with following items
	| ItemName         |
	| ACD Display 3.4  |
	| Acrobat Reader 4 |
	Then "<SecondListName>" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| <ProjectName> | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects '<ChangingToList1>' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ApplicationsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects '<ChangingToList2>' in the 'Application Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ApplicationsToAdd2>" is displayed to the user in the Project Scope Changes section
	#Then There are no errors in the browser console

Examples:
	| FirstListName   | SecondListName   | ProjectName       | ChangingToList1  | ChangingToList2  | ApplicationsToAdd1                       | ApplicationsToAdd2                       |
	| FirstDAS12999_1 | SecondDAS12999_1 | ProjectDAS12999_1 | All Applications | FirstDAS12999_1  | Applications to add (0 of 2129 selected) | Applications to add (0 of 39 selected)   |
	| FirstDAS12999_2 | SecondDAS12999_2 | ProjectDAS12999_2 | SecondDAS12999_2 | All Applications | Applications to add (0 of 2 selected)    | Applications to add (0 of 2129 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13973 @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingUsersScopeListToAnotherListForUserProject
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Domain" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| DEV50          |
	Then "92" rows are displayed in the agGrid
	When User create dynamic list with "<FirstListName>" name on "Users" page
	Then "<FirstListName>" list is displayed to user
	When User create static list with "<SecondListName>" name on "Users" page with following items
	| ItemName |
	| barbosaj |
	| clarkc   |
	Then "<SecondListName>" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode   |
	| <ProjectName> | All Users | None            | <Mode> |
	And User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left submenu item
	Then "Users to add (0 of 41339 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	And User selects '<ChangingToList1>' in the 'Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	And User selects '<ChangingToList2>' in the 'Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| FirstListName    | SecondListName    | ProjectName    | ChangingToList1   | ChangingToList2   | Mode                            | ObjectsToAdd1                      | ObjectsToAdd2                   |
	| FirstList13973_1 | SecondList13973_1 | Project13973_1 | All Users         | SecondList13973_1 | Clone from Evergreen to Project | Users to add (0 of 41339 selected) | Users to add (0 of 3 selected)  |
	| FirstList13973_2 | SecondList13973_2 | Project13973_2 | SecondList13973_2 | FirstList13973_2  | Standalone Project              | Users to add (0 of 3 selected)     | Users to add (0 of 95 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS18943 @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_ChangingDynamicListToAllListForUserAndMailboxProjects
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then "<Rows>" rows are displayed in the agGrid
	When User create dynamic list with "<DymamicList>" name on "<ListName>" page
	Then "<DymamicList>" list is displayed to user
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| <ProjectName> | <ProjectList> | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the '<ScopeChanges>' tab on Project Scope Changes page
	Then "<ObjectsToAdd>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the '<ScopeDetails>' tab on Project Scope Changes page
	And User selects '<DymamicList>' in the '<ScopeDetails>' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the '<ScopeChanges>' tab on Project Scope Changes page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the '<ScopeDetails>' tab on Project Scope Changes page
	And User selects '<AllList>' in the '<ScopeDetails>' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the '<ScopeChanges>' tab on Project Scope Changes page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| DymamicList | ProjectName    | ListName | FilterName       | FilterValue | Rows | ProjectList   | AllList     | ScopeChanges | ScopeDetails | ObjectsToAdd                         | ObjectsToAdd1                     | ObjectsToAdd2                        |
	| List18943_1 | Project18943_1 | Devices  | Operating System | Windows 8   | 28   | All Users     | All Devices | Devices      | Device Scope | Devices to add (0 of 16819 selected) | Devices to add (0 of 24 selected) | Devices to add (0 of 16819 selected) |
	| List18943_2 | Project18943_2 | Users    | Domain           | CA          | 850  | All Mailboxes | All Users   | Users        | User Scope   | Users to add (0 of 14757 selected)   | Users to add (0 of 0 selected)    | Users to add (0 of 14757 selected)   |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13297 @Cleanup @Projects
Scenario Outline: EvergreenJnr_ChangingApplicationScopeListToAnotherListForUserProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Version" filter where type is "Does not contain" with added column and following value:
	| Values            |
	| 97.1.0.0918(1031) |
	Then "1,741" rows are displayed in the agGrid
	When User create dynamic list with "<FirstListName>" name on "Applications" page
	Then "<FirstListName>" list is displayed to user
	When User create static list with "<SecondListName>" name on "Applications" page with following items
	| ItemName             |
	| WMI Tools            |
	| Windows Live Toolbar |
	Then "<SecondListName>" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| <ProjectName> | All Users | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects '<ChangingToList1>' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects '<ChangingToList2>' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| FirstListName    | SecondListName    | ProjectName    | ChangingToList1   | ChangingToList2   |  ObjectsToAdd1                           | ObjectsToAdd2                            |
	| FirstList13297_1 | SecondList13297_1 | Project13297_1 | All Applications  | SecondList13297_1 | Applications to add (0 of 2081 selected) | Applications to add (0 of 2 selected)    |
	| FirstList13297_2 | SecondList13297_2 | Project13297_2 | SecondList13297_2 | FirstList13297_2  | Applications to add (0 of 2 selected)    | Applications to add (0 of 1612 selected) |