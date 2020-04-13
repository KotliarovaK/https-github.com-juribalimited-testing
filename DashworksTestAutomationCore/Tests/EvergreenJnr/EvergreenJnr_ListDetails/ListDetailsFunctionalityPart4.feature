Feature: ListDetailsFunctionalityPart4
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#AnnI. 2/11/20: 
	#I decided to wait for Marina's answer.
	#Maybe this can be applied to the new panel.
	#Should be removed or updated??
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12190 @DAS12204 @DAS13207 @DAS14963 @Cleanup @archived
Scenario: EvergreenJnr_AllLists_CheckThatTwoDependencyAreDisplayedInTheDependentsBlock
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	When User create dynamic list with "Application1" name on "Applications" page
	Then "Application1" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association        |
	| Application1 | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "Device1" name on "Devices" page
	Then "Device1" list is displayed to user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Build Date |
	Then ColumnName is added to the list
	| ColumnName |
	| Build Date |
	When User selects 'SAVE AS NEW DYNAMIC LIST' option from Save menu and creates 'NewDevice' list
	Then "NewDevice" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "Application1" list
	Then "Application1" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'Application1' list
	Then Details panel is displayed to the user
	And Dependants section is collapsed by default
	When User expand Dependants section
	Then "NewDevice" list is displayed in the Dependants section
	And "Device1" list is displayed in the Dependants section

	#AnnI. 2/11/20: 
	#I decided to wait for Marina's answer.
	#Maybe this can be applied to the new panel.
	#Should be removed or updated??
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12169 @DAS12286 @DAS12192 @DAS12623 @DAS12687 @DAS14963 @Cleanup @archived
Scenario: EvergreenJnr_AllLists_CheckThatListDoesNotExistErrorWhenViewingDependentList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Adobe Apps" name on "Applications" page
	Then "Adobe Apps" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'Adobe Apps' list
	Then Details panel is displayed to the user
	When User closes Permissions section in the list panel
	Then tooltip is displayed with "Open" text for Permissions section
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association        |
	| Adobe Apps   | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "Devices with Adobe" name on "Devices" page
	Then "Devices with Adobe" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "Adobe Apps" list
	Then "Adobe Apps" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'Adobe Apps' list
	Then Details panel is displayed to the user
	Then tooltip is displayed with "Open" text for Dependants section
	When User expand Dependants section
	Then Dependants section is displayed to the user
	When User clicks "Devices with Adobe" list in the Dependants section
	Then "Devices with Adobe" list is displayed to user
	And "This list does not exist or you do not have access to it" message is not displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12192 @DAS14963 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatListPanelDoesNotExistErrorWhenViewingDependentList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	When User create dynamic list with "A1" name on "Applications" page
	Then "A1" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association        |
	| A1           | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "D1" name on "Devices" page
	Then "D1" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "A1" list
	Then "A1" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'A1' list
	Then Details panel is displayed to the user
	When User expand Dependants section
	Then Dependants section is displayed to the user
	When User clicks "D1" list in the Dependants section
	Then "D1" list is displayed to user
	And "This list does not exist or you do not have access to it" message is not displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12874 @DAS14222 @DAS15551 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesDynamicLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "<ListName1>" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association   |
	| <ListName1>  | <Association> |
	When User create dynamic list with "<ListName2>" name on "Devices" page
	And User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "<ListName1>" list
	Then "<ListName1>" list is displayed to user
	When User clicks 'Delete' option in cogmenu for '<ListName1>' list
	Then Delete and Cancel buttons are available in the warning message
	When User clicks Cancel button in the warning message
	Then inline tip banner is not displayed
	And "<ListName1>" list is displayed to user
	When User clicks 'Delete' option in cogmenu for '<ListName1>' list
	Then "<ListName1>" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User clicks 'Delete' option in cogmenu for '<ListName1>' list
	When User confirms list removing
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "<ListName2>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "<FilterInfoText>" is displayed in added filter info

Examples: 
	| ListName1    | ListName2 | Association                | FilterInfoText                                                      |
	| Application1 | Devices1  | Used on device             | Any Application in list [List not found] used on device             |
	| Application2 | Devices2  | Used by device's owner     | Any Application in list [List not found] used by device's owner     |
	| Application3 | Devices3  | Not used by device's owner | Any Application in list [List not found] not used by device's owner |