@retry:1
Feature: BaseDashboardPage
	Runs Base Dashboard Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11656
Scenario Outline: EvergreenJnr_AllList_CheckThatColumnHeaderFontWidthConformsToDesign
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	And Appropriate header font weight is displayed
	Then "v5.3.2.0" Application version is displayed

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11618
Scenario Outline: EvergreenJnr_AllList_CheckDefaultSortOrderOnTheLists
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
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
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to the "<AllItems>" list
	Then Column is displayed in following order:
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
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Save to New Custom List element is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Save to New Custom List element is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Save to New Custom List element is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Save to New Custom List element is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User click on '<ColumnName>' column header
	Then Save to New Custom List element is NOT displayed

Examples:
	| ListName     | ColumnName    | AddSortOrders    |
	| Devices      | Hostname      | Device Type      |
	| Users        | Username      | Domain           |
	| Applications | Application   | Vendor           |
	| Mailboxes    | Email Address | Mailbox Platform |

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11895
Scenario: EvergreenJnr_AllList_CheckThatNoConsoleErrorsAreDisplayedAfterQuicklyNavigateBetweenMainTabs
	When User quickly navigate to "Devices" on the left-hand menu
	And User quickly navigate to "Users" on the left-hand menu
	And User quickly navigate to "Applications" on the left-hand menu
	And User quickly navigate to "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS13766 @DAS14183
Scenario Outline: EvergreenJnr_AllList_CheckPositionOfContextMenuInGrid
	When User clicks "<ListName>" on the left-hand menu
	And User performs right-click on "<CellText>" cell in the grid
	Then User sees context menu placed near "<CellText>" cell in the grid

Examples: 
	| ListName     | CellText                         |
	| Devices      | 001PSUMZYOW581                   |
	| Users        | Spruill, Shea                    |
	| Applications | 11.2.5388.0                      |
	| Mailboxes    | 002B5DC7D4D34D5C895@bclabs.local |

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174
Scenario: EvergreenJnr_DevicesList_CheckThatURLsAreUpdatedAfterAddingSortingAndColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User click on 'Owner Cost Centre' column header
	Then data in table is sorted by 'Owner Cost Centre' column in ascending order
	And Ascending order sorted on "Owner Cost Centre" column is displayed in URL
	When User navigates to the "All Devices" list
	Then default URL is displayed on "Devices" page

@Evergreen @Users @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12174 @DAS13001
Scenario: EvergreenJnr_UsersList_CheckThatURLsAreUpdatedAfterAddingFilters
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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
	When User add "MigrationP: Readiness" filter where type is "Equals" with added column and "Blue" Lookup option
	Then Appropriate filter is added to URL

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11641
Scenario: EvergreenJnr_DevicesList_CheckThatActionsDetailsColumnsFiltersButtonsAreNotClickableWhenOpenedNotificationsAndUserProfilesDropdownBlocks
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Account Profile dropdown
	Then Account Profile menu is displayed correctly
	When User click User Notifications button
	Then Notifications message is displayed correctly

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS10972 @DAS12602 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllList_CheckThatEditListFunctionIsAvailableAfterSortingColumns
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName  |
	| <AddColumn> |
	And User create dynamic list with "DynamicList1" name on "<ListName>" page
	And User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Edit List menu is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Edit List menu is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User click on '<ColumnName>' column header
	Then Edit List menu is not displayed
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList1" name
	And User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in ascending order
	And Edit List menu is displayed
	When User click on '<AddSortOrders>' column header
	Then data in table is sorted by '<AddSortOrders>' column in descending order
	And Edit List menu is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	And Edit List menu is displayed
	When User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order
	When User click on '<ColumnName>' column header

Examples:
	| ListName     | ColumnName    | AddSortOrders    | AddColumn                |
	| Devices      | Hostname      | Device Type      | ComputerSc: Readiness ID |
	| Users        | Username      | Domain           | UserSchedu: Readiness ID |
	| Applications | Application   | Vendor           | UserSchedu: Readiness ID |
	| Mailboxes    | Email Address | Mailbox Platform | EmailMigra: Readiness ID |

@Evergreen @Devices @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS11693 @DAS12867 @DAS12999 @DAS14189 @Projects
Scenario: EvergreenJnr_DevicesList_CheckThatToolTipIsDisplayedWithCreateProjectButtonFromAnUnsavedList
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User clicks Create button on the Base Dashboard Page
	Then tooltip is displayed with "This list must be saved before using it to create a project" text for Create Project button
	And Create Project button is disabled on the Base Dashboard Page

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS14189 @Projects
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheCorrectCreateMenuOptionsAreDisplayedForEachObjectListType
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	Then Create button is displayed
	When User clicks Create button on the Base Dashboard Page
	Then "Project" button is displayed on the Base Dashboard Page
	And "Pivot" button is displayed on the Base Dashboard Page

Examples:
	| ListName     | 
	| Devices      | 
	| Users        | 
	| Mailboxes    | 

@Evergreen @Applications @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS14189 @Projects
Scenario: EvergreenJnr_ApplicationList_CheckThatTheCorrectCreateMenuOptionsAreDisplayedForApplicationPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	And Create button is displayed
	When User clicks Create button on the Base Dashboard Page
	Then "Pivot" button is displayed on the Base Dashboard Page

@Evergreen @AllLists @EvergreenJnr_BaseDashboardPage @BaseDashboardPage @DAS12337
Scenario Outline: EvergreenJnr_AllLists_CheckThatEmptyLinkIsDisplayedIfThereAreNoData
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	And Empty link is displayed for first row in the "<ColumnName>" column

Examples:
	| ListName     | ColumnName    |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |
