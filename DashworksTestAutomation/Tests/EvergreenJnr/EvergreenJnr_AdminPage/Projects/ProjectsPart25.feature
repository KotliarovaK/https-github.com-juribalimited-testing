Feature: ProjectsPart25
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17699
Scenario Outline: EvergreenJnr_AdminPage_CheckSavingOfChangesOnScopeDetailsPageForDeviceAndMailboxProjects
	When User navigates to "<ProjectName>" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the '<tab1>' tab on Project Scope Changes page
	When User selects '<List1>' in the 'User Scope' dropdown with wait
	When User navigates to the '<tab2>' tab on Project Scope Changes page
	When User selects '<List2>' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the '<tab1>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List1>" value
	When User navigates to the '<tab2>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List2>" value

Examples:
	| ProjectName                        | tab1       | List1                   | tab2              | List2              |
	| 1803 Rollout                       | User Scope | Users with Device Count | Application Scope | Apps with a Vendor |
	| Mailbox Evergreen Capacity Project | User Scope | Users with Device Count | Application Scope | Apps with a Vendor |

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
	| User Evergreen Capacity Project | Device Scope | 1803 Rollout | Application Scope | Apps with a Vendor |

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
	| 1803 Rollout                       | Device Scope  |
	| User Evergreen Capacity Project    | User Scope    |
	| Mailbox Evergreen Capacity Project | Mailbox Scope |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18100 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Import Type" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18100_3" name on "Devices" page
	Then "ListForDAS18100_3" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '18100Project' text to 'Project Name' textbox
	When User selects 'ListForDAS18100_3' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User enters "18100Project" text in the Search field for "Project" column