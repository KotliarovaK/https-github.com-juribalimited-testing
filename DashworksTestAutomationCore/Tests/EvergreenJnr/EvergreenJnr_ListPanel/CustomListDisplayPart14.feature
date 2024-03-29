﻿Feature: CustomListDisplayPart14
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

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS19901 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThaProjectCanBeCreatedBasedOnDynamicListWithInScopeColumn
	When User add following columns using URL to the "Devices" page:
	| ColumnName     |
	| 2004: In Scope |
	Then Save to New Custom List element is displayed
	When User creates 'List19901' dynamic list
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Projects' header is displayed to user
	When User enters 'TestProjectFor19901' text to 'Project Name' textbox
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	Then There are no errors in the browser console

@Evergreen @Mailboxes @EvergreenJnr_ListPanel @CustomListDisplay @DAS20597 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckDuplicatedListDisplayedInListPanel
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	When User clicks on 'Email Address' column header
	And User create dynamic list with "TestList" name on "Mailboxes" page
	Then "TestList" list is displayed to user
	When User clicks 'Duplicate' option in cogmenu for 'TestList' list
	Then "TestList2" list is displayed to user
	When User navigates to the "TestList2" list
	Then 'TestList2' list should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ListPanel @CustomListDisplay @DAS20817 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatPinInformationIsNotRememberedAfterSwitchingBetweenLists
	When User clicks 'Applications' on the left-hand menu
	When User opens 'Version' column settings
	When User selects 'Pin right' option from column settings
	Then 'Version' column is 'Right' Pinned
	When User navigates to the "2004 Apps" list
	Then URL is 'evergreen/#/applications?$listid=37'
	When User navigates to the "App Readiness Columns & Filters" list
	Then URL is 'evergreen/#/applications?$listid=59'
	When User navigates to the "All Applications" list
	Then URL is 'evergreen/#/applications'

@Evergreen @Applications @EvergreenJnr_ListPanel @CustomListDisplay @DAS20817 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatPinInformationIsNotRememberedAfterSwitchingBetweenSavedLists
	When User clicks 'Applications' on the left-hand menu
	When User opens 'Version' column settings
	When User selects 'Pin right' option from column settings
	Then 'Version' column is 'Right' Pinned
	When User create dynamic list with "List_DAS20817" name on "Applications" page
	Then "List_DAS20817" list is displayed to user
	When User navigates to the "All Applications" list
	Then URL is 'evergreen/#/applications'
