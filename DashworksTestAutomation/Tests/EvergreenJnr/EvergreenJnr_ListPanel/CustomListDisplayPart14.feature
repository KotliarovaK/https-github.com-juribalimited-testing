Feature: CustomListDisplayPart14
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @DAS13184 @Cleanup
Scenario: EvergreenJnr_Devices_CheckDefaultListIsResetIfItWasNoLongerAvalaibleAndSetAgainIfAccessed
	When User create new User via API
	| Username   | Email | FullName   | Password  | Roles                 |
	| DAS13184_1 | Value | FN_13184_1 | m!gration | Project Administrator |
	| DAS13184_2 | Value | FN_13184_2 | m!gration | Project Administrator |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	When User clicks on 'Hostname' column header
	When User create dynamic list with "DAS13184forShare" name on "Devices" page
	Then "DAS13184forShare" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_2 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	When User clicks 'Set default' option in cogmenu for 'DAS13184forShare' list
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	When User clicks 'Manage' option in cogmenu for 'DAS13184forShare' list
	When User clicks the Permissions button
	When User selects 'Private' in the 'Sharing' dropdown
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_2 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_1 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	When User clicks 'Manage' option in cogmenu for 'DAS13184forShare' list
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username   | Password  |
	| DAS13184_2 | m!gration |
	When User clicks 'Devices' on the left-hand menu
	Then 'DAS13184forShare' list should be displayed to the user