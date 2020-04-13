Feature: ListDetailsFunctionalityPart5
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS12791 @DAS12952 @DAS14222 @DAS15551 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticLists
	When User create static list with "Application12075" name on "Applications" page with following items
	| ItemName                  |
	| Python 2.2a4              |
	| Quartus II Programmer 4.0 |
	| Multi Edit 9 Client       |
	Then table content is present
	Then "3" rows are displayed in the agGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association    |
	| Application12075 | Used on device |
	And User create dynamic list with "Devices12075" name on "Devices" page
	And User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "Application12075" list
	Then "Application12075" list is displayed to user
	When User clicks 'Delete' option in cogmenu for 'Application12075' list
	Then "Application12075" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User clicks 'Delete' option in cogmenu for 'Application12075' list
	When User confirms list removing
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices12075" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	And message 'This list could not be processed, it may refer to a list with errors' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS12791 @DAS12952 @DAS14222 @DAS15551 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLists
	When User create static list with "Application3_12075" name on "Applications" page with following items
	| ItemName                                        |
	| Microsoft SDK Update February 2003 (5.2.3790.0) |
	| Quartus II Programmer 4.0                       |
	| Mindreef SOAPscope 4.0                          |
	Then "Application3_12075" list is displayed to user
	And table content is present
	And "3" rows are displayed in the agGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList       | Association    |
	| Application3_12075 | Used on device |
	And User create dynamic list with "Devices3_12075" name on "Devices" page
	Then "Devices3_12075" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList       | Association        |
	| Application3_12075 | Entitled to device |
	And User create dynamic list with "Devices4_12075" name on "Devices" page
	Then "Devices4_12075" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "Application3_12075" list
	Then "Application3_12075" list is displayed to user
	When User clicks 'Delete' option in cogmenu for 'Application3_12075' list
	Then "Application3_12075" list "list is used by 2 lists, do you wish to proceed?" message is displayed in the list panel
	When User clicks 'Delete' option in cogmenu for 'Application3_12075' list
	When User confirms list removing
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices3_12075" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	And message 'This list could not be processed, it may refer to a list with errors' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS14222 @DAS15551 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependenciesLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "Application4" name on "Applications" page
	And User add following columns using URL to the "Applications" page:
	| ColumnName |
	| Compliance |
	And User create dynamic list with "Application5" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association    |
	| Application4 | Used on device |
	| Application5 | Used on device |
	And User create dynamic list with "Devices15551" name on "Devices" page
	And User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "Application4" list
	Then "Application4" list is displayed to user
	When User clicks 'Delete' option in cogmenu for 'Application4' list
	Then "Application4" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User clicks 'Delete' option in cogmenu for 'Application4' list
	When User confirms list removing
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices15551" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] or Application5 used on device" is displayed in added filter info

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12536 @DAS12791 @DAS12952 @Cleanup
Scenario: EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicAndStaticLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "DynamicList2569" name on "Users" page
	Then "DynamicList2569" list is displayed to user
	When User navigates to the "All Users" list
	And User create static list with "StaticList2584" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	| 002B5DC7D4D34D5C895 |
	Then "StaticList2584" list is displayed to user
	And table content is present
	And "2" rows are displayed in the agGrid
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User clicks Delete list button
	And User navigates to the "DynamicList2569" list
	Then inline success banner is not displayed
	When User clicks the List Details button
	Then Details panel is displayed to the user
	And no Warning message is displayed in the list details panel