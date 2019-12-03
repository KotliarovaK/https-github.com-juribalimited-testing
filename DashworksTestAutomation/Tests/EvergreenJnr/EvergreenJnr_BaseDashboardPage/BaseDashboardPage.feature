﻿@retry:1
Feature: BaseDashboardPage
	Runs Base Dashboard Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11656
Scenario Outline: EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	And Appropriate header font weight is displayed
	Then 'v5.4.4.0' Application version is displayed in the left-hand menu

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11618
Scenario Outline: EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	And The first cell of the table matches to default sorting "<ListName>" list
	And data in the table is sorted by "<ColumnName>" column in ascending order by default

Examples: 
	| ListName     | ColumnName    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS14700
Scenario Outline: EvergreenJnr_AllList_CheckDefaultColumnsDisplayingWhenUsingAllLink
	When User clicks '<ListName>' on the left-hand menu
	And User navigates to the "<AllItems>" list
	Then grid headers are displayed in the following order
	| ColumnName |
	| <Column1>  |
	| <Column2>  |
	| <Column3>  |
	| <Column4>  |
	| <Column5>  |

Examples: 
	| ListName     | AllItems         | Column1       | Column2          | Column3          | Column4            | Column5            |
	| Devices      | All Devices      | Hostname      | Device Type      | Operating System | Owner Display Name |                    |
	| Users        | All Users        | Username      | Domain           | Display Name     | Distinguished Name |                    |
	| Applications | All Applications | Application   | Vendor           | Version          |                    |                    |
	| Mailboxes    | All Mailboxes    | Email Address | Mailbox Platform | Mail Server      | Mailbox Type       | Owner Display Name |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11988 @DAS10972
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveListFunctionIsAvailableAfterSortingColumns
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Save to New Custom List element is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Save to New Custom List element is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Save to New Custom List element is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Save to New Custom List element is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User clicks on '<ColumnName>' column header
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName    | AddSortOrders    |
	| Devices      | Hostname      | Device Type      |
	| Users        | Username      | Domain           |
	| Applications | Application   | Vendor           |
	| Mailboxes    | Email Address | Mailbox Platform |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11895
Scenario: EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetweenMainTabs
	When User quickly navigate to 'Devices' on the left-hand menu
	And User quickly navigate to 'Users' on the left-hand menu
	And User quickly navigate to 'Applications' on the left-hand menu
	And User quickly navigate to 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS13766 @DAS14183 Not_Run
Scenario Outline: EvergreenJnr_AllList_CheckPositionOfContextMenuInGrid
	When User clicks '<ListName>' on the left-hand menu
	When User right clicks on '<CellText>' cell from '<ColumnName>' column
	#TODO update the next step in the same way as the step above.
	Then User sees context menu placed near "<CellText>" cell in the grid

Examples: 
	| ListName     | CellText                         | ColumnName    |
	| Devices      | 001PSUMZYOW581                   | Hostname      |
	| Users        | Spruill, Shea                    | Username      |
	| Applications | 11.2.5388.0                      | Application   |
	| Mailboxes    | 002B5DC7D4D34D5C895@bclabs.local | Email Address |

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174
Scenario: EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName            |
	| Owner Cost Centre     |
	| ComputerSc: In Scope  |
	| Windows7Mi: Object ID |
	Then "Cost Centre" column is added to URL on "Devices" page
	And "ComputerSc: In Scope" column is added to URL on "Devices" page
	And "Windows7Mi: Object ID" column is added to URL on "Devices" page
	When User clicks on 'Owner Cost Centre' column header
	Then data in table is sorted by 'Owner Cost Centre' column in ascending order
	And Ascending order sorted on "Owner Cost Centre" column is displayed in URL
	When User navigates to the "All Devices" list
	Then default URL is displayed on "Devices" page

@Evergreen @Users @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174 @DAS13001 @DAS16300 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingFilters
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" column is added to URL on "Users" page
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Green              |
	Then Appropriate filter is added to URL
	When User navigates to the "All Users" list
	Then default URL is displayed on "Users" page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Application Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Amber              |
	Then Appropriate filter is added to URL

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11641
Scenario: EvergreenJnr_DevicesList_CheckThatActionsDetailsColumnsFiltersButtonsAreNotClickableWhenOpenedNotificationsAndUserProfilesDropdownBlocks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks Account Profile dropdown
	Then Account Profile menu is displayed correctly
	When User click User Notifications button
	Then Notifications message is displayed correctly

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS10972 @DAS12602 @Cleanup
Scenario Outline: EvergreenJnr_AllList_CheckThatEditListFunctionIsAvailableAfterSortingColumns
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName  |
	| <AddColumn> |
	And User create dynamic list with "DynamicList1" name on "<ListName>" page
	And User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Edit List menu is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User clicks on '<ColumnName>' column header
	Then Edit List menu is not displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList1" name
	And User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Edit List menu is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User clicks on '<ColumnName>' column header

Examples:
	| ListName     | ColumnName    | AddSortOrders    | AddColumn                |
	| Devices      | Hostname      | Device Type      | ComputerSc: Readiness ID |
	| Users        | Username      | Domain           | UserSchedu: Readiness ID |
	| Applications | Application   | Vendor           | UserSchedu: Readiness ID |
	| Mailboxes    | Email Address | Mailbox Platform | EmailMigra: Readiness ID |

#'not_run' was added until 'DAS16961' bug is fixed
@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11693 @DAS12867 @DAS12999 @DAS14189 @DAS16961 @Projects @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatToolTipIsDisplayedWithCreateProjectButtonFromAnUnsavedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User clicks 'Create' dropdown
	Then tooltip is displayed with "This list must be saved before using it to create a project" text for Create Project button
	And Create Project button is disabled on the Base Dashboard Page

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS14189 @Projects
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheCorrectCreateMenuOptionsAreDisplayedForEachObjectListType
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	And Create button is displayed
	And User sees that 'Create' dropdown contains following options:
	| Options |
	| PROJECT |
	| PIVOT   |

Examples:
	| ListName     | 
	| Devices      | 
	| Users        | 
	| Mailboxes    | 

@Evergreen @Applications @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS14189 @Projects
Scenario: EvergreenJnr_ApplicationList_CheckThatTheCorrectCreateMenuOptionsAreDisplayedForApplicationPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	And Create button is displayed
	And User sees that 'Create' dropdown contains following options:
	| Options |
	| PIVOT   |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12337
Scenario Outline: EvergreenJnr_AllLists_CheckThatEmptyLinkIsDisplayedIfThereAreNoData
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	And Empty link is displayed for first row in the "<ColumnName>" column

Examples:
	| ListName     | ColumnName    |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @Widgets @DAS15444 @Cleanup @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectMessageIsDisplayedBeforeDeletingListWhichHasDependencies
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DynamicList15444" name on "Devices" page
	Then "DynamicList15444" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	When User enters 'Project_DAS15444' text to 'Project Name' textbox
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click Delete button for custom list with "DynamicList15444" name
	Then ""DynamicList15444" list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	When User clicks 'Dashboards' on the left-hand menu
	When User clicks 'CREATE DASHBOARD' button 
	And User creates new Dashboard with "Dashboard for DAS15444" name
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title                | List             | MaxRows | MaxColumns |
	| List       | Widget_For_ DAS15444 | DynamicList15444 | 10      | 10         |
	Then "Widget_For_ DAS15444" Widget is displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click Delete button for custom list with "DynamicList15444" name
	Then ""DynamicList15444" list is used by 1 project and 1 dashboard, do you wish to proceed?" message is displayed in the lists panel

@Evergreen @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS16558 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatFullPpageWith403ErrorIsDisplayedCorrectly
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	When User creates new clear User
	| Username | FullName      | Password | ConfirmPassword | Roles                 |
	| DAS16558 | DAS16558_User | 1234qwer | 1234qwer        | Project Administrator |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS16558 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then error page with '403' status code and 'You are not authorized to view this page, speak to your Dashworks administrator' error message is displayed
	When User clicks 'Admin' hidden left-hand menu
	Then error page with '403' status code and 'You are not authorized to view this page, speak to your Dashworks administrator' error message is displayed
	When User clicks 'Devices' hidden left-hand menu
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS16558" User

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @DAS17140 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatRequestHasSpecificParameterWhenNavigatingIntoList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Migration Type Capacity" list
	Then Columnmetadata request contains ArchivedItem parameter