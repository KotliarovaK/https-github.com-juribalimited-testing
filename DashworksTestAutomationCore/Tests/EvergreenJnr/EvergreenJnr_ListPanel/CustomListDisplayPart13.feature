Feature: CustomListDisplayPart13
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListPanel @DAS13122 @DAS13125 @DAS13126 @DAS13123 @DAS13127 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForDynamicList
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user
	When User clicks on '<Column>' column header
	When User create dynamic list with "<ListName1>" name on "<ListType>" page
	Then "<ListName1>" list is displayed to user
	When User clicks 'Set default' option in cogmenu for '<ListName1>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName1>' list should be displayed to the user
	When User clicks on '<Column>' column header
	When User create dynamic list with "<ListName2>" name on "<ListType>" page
	Then "<ListName2>" list is displayed to user
	When User clicks 'Set default' option in cogmenu for '<ListName2>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName2>' list should be displayed to the user
	When User clicks 'Remove default' option in cogmenu for '<ListName2>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user

Examples:
	| ListType | ListTitle   | Column   | ListName1      | ListName2      |
	| Devices  | All Devices | Hostname | DeviceDefault1 | DeviceDefault2 |
	| Users    | All Users   | Username | UserDefault1   | UserDefault2   |

@Evergreen @AllLists @EvergreenJnr_ListPanel @DAS13122 @DAS13125 @DAS13126 @DAS13123 @DAS13127 @DAS13135 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatDefaultListOptionWorksForStaticList
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user
	When User create static list with "<ListName1>" name on "<ListType>" page with following items
	| ItemName   |
	| <ItemName> |
	Then "<ListName1>" list is displayed to user
	When User clicks 'Set default' option in cogmenu for '<ListName1>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName1>' list should be displayed to the user
	When User create dynamic list with "<ListName2>" name on "<ListType>" page
	Then "<ListName2>" list is displayed to user
	When User clicks 'Set default' option in cogmenu for '<ListName2>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListName2>' list should be displayed to the user
	When User clicks 'Remove default' option in cogmenu for '<ListName2>' list
	When User clicks '<ListType>' on the left-hand menu
	Then '<ListTitle>' list should be displayed to the user

Examples:
	| ListType     | ListTitle        | ListName1           | ListName2           | ItemName                                        |
	| Applications | All Applications | ApplicationDefault1 | ApplicationDefault2 | Microsoft SDK Update February 2003 (5.2.3790.0) |
	| Mailboxes    | All Mailboxes    | MailboxDefault1     | MailboxDefault2     | 000F977AC8824FE39B8@bclabs.local                |

@Evergreen @AllLists @EvergreenJnr_ListPanel @DAS13129 @DAS13130 @Cleanup
Scenario: EvergreenJnr_Devices_CheckThatDefaultListOptionInDetailsPanelWorks
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DeviceListToTestDefault" name on "Devices" page
	Then "DeviceListToTestDefault" list is displayed to user
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User selects state 'true' for 'Default List' checkbox
	When User clicks 'Devices' on the left-hand menu
	Then 'DeviceListToTestDefault' list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @DAS13185 @Cleanup
Scenario: EvergreenJnr_Devices_CheckThatNewUserHasNoDefaultListSet
	When User create new User via API
	| Username | Email | FullName | Password  | Roles                 |
	| DAS13129 | Value | FN13129  | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password  |
	| DAS13129 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @DAS13136 @Cleanup
Scenario: EvergreenJnr_Devices_CheckDefaultListIsResetIfItWasNoLongerAvalaible
	When User create new User via API
	| Username   | Email | FullName   | Password  | Roles                 |
	| DAS13136_1 | Value | FN_13136_1 | m!gration | Project Administrator |
	| DAS13136_2 | Value | FN_13136_2 | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13136_1 | m!gration |
	When User clicks 'Users' on the left-hand menu
	When User clicks on 'Username' column header
	When User create dynamic list with "DAS13136forShare" name on "Users" page
	Then "DAS13136forShare" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13136_2 | m!gration |
	When User clicks 'Users' on the left-hand menu
	When User clicks 'Set default' option in cogmenu for 'DAS13136forShare' list
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13136_1 | m!gration |
	When User clicks 'Users' on the left-hand menu
	When User clicks 'Delete' option in cogmenu for 'DAS13136forShare' list
	When User confirms list removing
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13136_2 | m!gration |
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user