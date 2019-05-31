Feature: WidgetList
	Runs tests for List Widgets creation or editing

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15432 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoErrorsAreDisplayedWhenCreateListWidgetWithStaticList
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "Static_List_15432" name
	And Dashboard with "Dashboard for DAS15432" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15432 | Static_List_15432 | 500     | 10         |
	Then "Widget_For_DAS15432" Widget is displayed to the user
	And There are no errors in the browser console

@Evergreen @EvergreenJnr_DashboardsPage @Widgets @DAS15413 @Delete_Newly_Created_List @Delete_Newly_Created_Dashboard
Scenario: EvergreenJnr_DashboardsPage_CheckThatDataFromTheWidgetMatchesTheOriginalDynamicLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                        |
	| 1803: Application Rationalisation |
	Then ColumnName is added to the list
	| ColumnName                        |
	| 1803: Application Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values    |
	| Microsoft |
	When User create dynamic list with "TestList_DAS15413" name on "Applications" page
	Then "TestList_DAS15413" list is displayed to user
	When Dashboard with "Dashboard for DAS15413" name created via API and opened
	And User clicks Edit mode trigger on Dashboards page
	And User clicks the "ADD WIDGET" Action button
	And User creates new Widget
	| WidgetType | Title               | List              | MaxRows | MaxColumns |
	| List       | Widget_For_DAS15413 | TestList_DAS15413 | 500     | 10         |
	Then "Widget_For_DAS15413" Widget is displayed to the user
	Then following content is displayed in the "Vendor" column for Widget
	| Values                |
	| Microsoft Corporation |

