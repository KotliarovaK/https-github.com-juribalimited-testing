Feature: ProjectsPart25
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17699 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckSavingOfChangesOnScopeDetailsPageForProjects
	When Project created via API and opened
	| ProjectName   | Scope  | ProjectTemplate | Mode               |
	| <ProjectName> | <List> | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	When User selects '<UserScope>' in the 'User Scope' dropdown with wait
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User checks 'Include applications' radio button
	When User selects 'Apps with a Vendor' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<UserScope>" value
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "Apps with a Vendor" value

Examples: 
	| ProjectName            | List          | UserScope               |
	| ProjectDevice_17699    | All Devices   | Users with Device Count |
	| ProjectMailboxes_17699 | All Mailboxes | Users with Device Count |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17699 @DAS18943
Scenario Outline: EvergreenJnr_AdminPage_CheckSavingOfChangesOnScopeDetailsPageForUserProject
	When User navigates to "<ProjectName>" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the '<tab1>' tab on Project Scope Changes page
	And User selects '<List1>' in the 'Device Scope' dropdown with wait
	And User navigates to the '<tab2>' tab on Project Scope Changes page
	And User selects '<List2>' in the 'Application Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Scope Details' left menu item
	When User navigates to the '<tab1>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List1>" value
	When User navigates to the '<tab2>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List2>" value

Examples:
	| ProjectName                     | tab1         | List1        | tab2              | List2              |
	| User Evergreen Capacity Project | Device Scope | 2004 Rollout | Application Scope | Apps with a Vendor |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17967
Scenario: EvergreenJnr_AdminPage_CheckNoConsoleErrorDisplayedWhenUsingGroupByFilter
	When User clicks 'Admin' on the left-hand menu
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Project    | true  |
	And User selects all rows on the grid
	Then There are no errors in the browser console
	When User selects all rows on the grid
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS16842
Scenario Outline: EvergreenJnr_AdminPage_CheckCorrectListTooltipDisplayingInScopeDetailsPage
	When User navigates to "<ProjectName>" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Details' left menu item
	And User navigates to the '<tab>' tab on Project Scope Changes page
	Then All items in the 'Scope' dropdown have icons
	Then All icon items in the 'Scope' dropdown have any of tooltip
	| tooltip |
	| System  |
	| Private |
	| Shared  |

Examples:
	| ProjectName                        | tab           |
	| 2004 Rollout                       | Device Scope  |
	| User Evergreen Capacity Project    | User Scope    |
	| Mailbox Evergreen Capacity Project | Mailbox Scope |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18100 @DAS19348 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	When User add "<Filter>" filter where type is "<Operator>" with added column and Lookup option
    | SelectedValues |
	When User clicks Save button on the list panel
	When User create dynamic list with "<SavedList>" name on "<ListType>" page
	Then "<SavedList>" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	When User selects '<SavedList>' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User enters "<ProjectName>" text in the Search field for "Project" column

Examples:
	| ListType  | ListName      | Filter         | Operator  | SavedList         | ProjectName  |
	| Devices   | All Devices   | Import Type    | Not empty | ListForDAS18100_3 | 18100Project |
	| Mailboxes | All Mailboxes | Recipient Type | Not empty | ListForDAS19348_1 | 19348Project |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS16844 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatInformationMessageDisplayedForCreateProjectFormWhenArchivedItemsIncluded
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User sets includes archived devices in 'true'
	Then table content is present
	When User create dynamic list with "ProjectListForDas16844" name on "Devices" page
	When User selects 'Project' in the 'Create' dropdown
	Then 'This list may contain archived devices which will not be onboarded' information message is displayed for 'Scope' field