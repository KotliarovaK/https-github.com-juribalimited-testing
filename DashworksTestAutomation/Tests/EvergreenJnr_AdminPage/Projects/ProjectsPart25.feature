Feature: ProjectsPart25
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17699
Scenario Outline: EvergreenJnr_AdminPage_CheckSavingOfChangesOnScopeDetailsPageForDeviceAndMailboxProjects
	When User navigates to "<ProjectName>" project details
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the '<tab1>' tab on Project Scope Changes page
	And User selects '<List1>' in the 'User Scope' dropdown with wait
	And User navigates to the '<tab2>' tab on Project Scope Changes page
	And User selects '<List2>' in the 'Application Scope' dropdown with wait
	And User selects "Scope Changes" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	When User navigates to the '<tab1>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List1>" value
	When User navigates to the '<tab2>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List2>" value

Examples:
	| ProjectName                        | tab1         | List1                             | tab2              | List2     |
	| 1803 Rollout                       | User Scope   | Users Readiness Columns & Filters | Application Scope | 1803 Apps |
	| Mailbox Evergreen Capacity Project | User Scope   | Users Readiness Columns & Filters | Application Scope | 1803 Apps |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17699
Scenario Outline: EvergreenJnr_AdminPage_CheckSavingOfChangesOnScopeDetailsPageForUserProject
	When User navigates to "<ProjectName>" project details
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the '<tab1>' tab on Project Scope Changes page
	And User selects '<List1>' in the 'Device Scope' dropdown with wait
	And User navigates to the '<tab2>' tab on Project Scope Changes page
	And User selects '<List2>' in the 'Application Scope' dropdown with wait
	And User selects "Scope Changes" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	When User navigates to the '<tab1>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List1>" value
	When User navigates to the '<tab2>' tab on Project Scope Changes page
	Then Scope List dropdown displayed with "<List2>" value

Examples:
	| ProjectName                        | tab1         | List1                             | tab2              | List2     |
	| User Evergreen Capacity Project    | Device Scope | 1803 Rollout                      | Application Scope | 1803 Apps |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS17967
Scenario: EvergreenJnr_AdminPage_CheckNoConsoleErrorDisplayedWhenUsingGroupByFilter
	When User clicks 'Admin' on the left-hand menu
	When User clicks Group By button on the Admin page and selects "Project" value
	And User selects all rows on the grid
	Then There are no errors in the browser console
	When User selects all rows on the grid
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS16842
Scenario Outline: EvergreenJnr_AdminPage_CheckCorrectListTooltipDisplayingInScopeDetailsPage
	When User navigates to "<ProjectName>" project details
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Details" tab on the Project details page
	And User navigates to the '<tab>' tab on Project Scope Changes page
	When User clicks 'Scope' dropdown
	Then User sees all lists displayed with icon in List dropdown
	Then User sees all lists icon displayed with tooltip in List dropdown

Examples:
	| ProjectName                        | tab           |
	| 1803 Rollout                       | Device Scope  |
	| User Evergreen Capacity Project    | User Scope    |
	| Mailbox Evergreen Capacity Project | Mailbox Scope |