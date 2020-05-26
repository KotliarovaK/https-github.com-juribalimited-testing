Feature: WidgetList
	Runs tests for List Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15432 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsAreDisplayedWhenCreateListWidgetWithStaticList
	When User clicks 'Users' on the left-hand menu
	When User clicks the Actions button
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "Static_List_15432" name
	When Dashboard with 'Dashboard_15432' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15432 | Static_List_15432 | 500     | 10         |
	Then 'Widget_For_DAS15432' Widget is displayed to the user
	Then There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15413 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatDataFromTheWidgetMatchesTheOriginalDynamicLists
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                  |
	| Windows7Mi: Rationalisation |
	Then ColumnName is added to the list
	| ColumnName                  |
	| Windows7Mi: Rationalisation |
	When User clicks the Filters button
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values    |
	| Microsoft |
	When User waits for '3' seconds
	When User create dynamic list with "TestList_DAS15413" name on "Applications" page
	Then "TestList_DAS15413" list is displayed to user
	When Dashboard with 'Dashboard_15413' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15413 | TestList_DAS15413 | 500     | 10         |
	Then 'Widget_For_DAS15413' Widget is displayed to the user
	Then following content is displayed in the 'Vendor' column for Widget
	| Values    |
	| Microsoft |

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS17814 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThahtArchivedObjectsShouldNotBeLinkedToObjectDetailsFromListWidgetsClickThrough
	When User clicks 'Devices' on the left-hand menu
	When User sets includes archived devices in 'true'
	When User create dynamic list with "List17814" name on "Devices" page
	When Dashboard with 'Dashboard_17814' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List      | MaxRows | MaxColumns |
	| List       | WidgetForDAS17814 | List17814 | 10      | 10         |
	Then 'WidgetForDAS17814' Widget is displayed to the user
	Then There are no links placed in 'WidgetForDAS17814' Widget

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS16167 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCorrectMessageIsShownOnListWidgetsIfTheSourceListHasNoRows
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Display Name" filter where type is "Equals" with added column and following value:
	| Values |
	| ZZZZ   |
	When User create dynamic list with "ListForDAS16167" name on "Devices" page
	Then "ListForDAS16167" list is displayed to user
	When Dashboard with 'Dashboard_16167' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User adds new Widget
	| WidgetType | Title             | List            |
	| List       | WidgetForDAS16167 | ListForDAS16167 |
	Then Widget Preview is displayed to the user
	Then 'This list does not contain any rows' message is displayed in Preview
	When User clicks 'CREATE' button 
	Then 'WidgetForDAS16167' Widget is displayed to the user
	Then 'This list does not contain any rows' message is displayed in 'WidgetForDAS16167' widget