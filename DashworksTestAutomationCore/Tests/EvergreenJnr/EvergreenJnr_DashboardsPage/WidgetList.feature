Feature: WidgetList
	Runs tests for List Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15432 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsAreDisplayedWhenCreateListWidgetWithStaticList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static_List_15432" name
	And Dashboard with 'Dashboard for DAS15432' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15432 | Static_List_15432 | 500     | 10         |
	Then 'Widget_For_DAS15432' Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15413 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDataFromTheWidgetMatchesTheOriginalDynamicLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                  |
	| Windows7Mi: Rationalisation |
	Then ColumnName is added to the list
	| ColumnName                  |
	| Windows7Mi: Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values    |
	| Microsoft |
	When User waits for '3' seconds
	When User create dynamic list with "TestList_DAS15413" name on "Applications" page
	Then "TestList_DAS15413" list is displayed to user
	When Dashboard with 'Dashboard for DAS15413' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15413 | TestList_DAS15413 | 500     | 10         |
	Then 'Widget_For_DAS15413' Widget is displayed to the user
	Then following content is displayed in the 'Vendor' column for Widget
	| Values    |
	| Microsoft |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17814 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThahtArchivedObjectsShouldNotBeLinkedToObjectDetailsFromListWidgetsClickThrough
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User create dynamic list with "List17814" name on "Devices" page
	When Dashboard with 'Dashboard for DAS17814' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User creates new Widget
	| WidgetType | Title             | List      | MaxRows | MaxColumns |
	| List       | WidgetForDAS17814 | List17814 | 10      | 10         |
	Then 'WidgetForDAS17814' Widget is displayed to the user
	And There are no links placed in 'WidgetForDAS17814' Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnListWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	And User clicks Save button on the list panel
	And User create dynamic list with "ListForDAS16167" name on "Devices" page
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with 'DAS16167_Dashboard' name created via API and opened
	When User checks 'Edit mode' slide toggle
	And User clicks 'ADD WIDGET' button 
	And User adds new Widget
	| WidgetType | Title             | List            |
	| List       | WidgetForDAS16167 | ListForDAS16167 |
	Then Widget Preview is displayed to the user
	And 'This list does not contain any rows' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16167' Widget is displayed to the user
	And 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS18634 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoConsoleErrorDisplayedWhenSlectingWidgetTypeValue
	When Dashboard with 'TestDashboardForDAS18634' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User selects 'Card' in the 'WidgetType' dropdown
	Then There are no errors in the browser console
	When User selects 'List' in the 'WidgetType' dropdown
	Then There are no errors in the browser console