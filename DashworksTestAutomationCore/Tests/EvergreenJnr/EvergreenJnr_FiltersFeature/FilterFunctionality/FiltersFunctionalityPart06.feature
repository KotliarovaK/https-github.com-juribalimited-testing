Feature: FiltersFunctionalityPart06
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	When User clicks the Filters button
	And User create dynamic list with "DynamicList4116" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association        |
	| DynamicList4116 | Entitled to device |
	Then "123" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12875
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Surname" filter where type is "Equals" with following Value and Association:
	| Values       | Association     |
	| Cotuand      | Entitled to app |
	| Courtemanche |                 |
	When User click Edit button for "User " filter
	Then There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FiltersFeature @FiltersFunctionality @DAS12167 @DAS12056 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNoConsoleErrorIsDisplayedAfterAddingUserSavedListFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" without added column and following value:
	| Values     |
	| YOG2259571 |
	When User create dynamic list with "YOG2259571 Users" name on "Users" page
	Then "YOG2259571 Users" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association     |
	| YOG2259571 Users | Entitled to app |
	Then "4" rows are displayed in the agGrid
	Then "Any User in list YOG2259571 Users entitled to app" is displayed in added filter info
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12181 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatNoErrorIsDisplayedAfterAddingAdvancedFilterForUsernameAndApplicationSavedList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList8546" name
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Username" filter where type is "Contains" with following Value and Association:
	| Values | Association                            |
	| Bob    | Has used app                           |
	| Bob    | Entitled to app                        |
	| Bob    | Owns a device which app was used on    |
	| Bob    | Owns a device which app is entitled to |
	When User create dynamic list with "UsersBob" name on "Applications" page
	Then "UsersBob" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "User (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association                         |
	| StaticList8546 | Has used app                        |
	| StaticList8546 | Entitled to app                     |
	| StaticList8546 | Owns a device which app was used on |
	Then "5" rows are displayed in the agGrid
	Then There are no errors in the browser console
