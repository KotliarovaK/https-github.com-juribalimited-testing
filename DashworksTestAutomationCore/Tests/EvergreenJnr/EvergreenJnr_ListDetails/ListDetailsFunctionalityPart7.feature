Feature: ListDetailsFunctionalityPart7
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12580 @Cleanup
Scenario: EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanelAfterListCreation
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Dashworks First Seen" filter where type is "Empty" with added column and following value:
	| Values |
	|        |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	And User removes "Vendor" column by Column panel
	And User removes "Version" column by Column panel
	And User creates 'TestList5478' dynamic list
	Then Save and Cancel buttons are not displayed on the list panel
	And "TestList5478" list is displayed to user

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12629 @Cleanup
Scenario: EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	When User create dynamic list with "DynamicListFirst" name on "Applications" page
	Then "DynamicListFirst" list is displayed to user
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Vendor' column header
	When User create dynamic list with "DynamicListSecond5684" name on "Applications" page
	Then "DynamicListSecond5684" list is displayed to user
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	When User create static list with "StaticList7844AT" name on "Applications" page with following items
	| ItemName |
	|          |
	Then "StaticList7844AT" list is displayed to user
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	When User navigates to the "DynamicListFirst" list
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	When User navigates to the "DynamicListSecond5684" list
	When User clicks the Permissions button
	When User selects 'Automation Admin 1' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	When User navigates to the "DynamicListFirst" list
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS13066 @DAS15561 @DAS15569 @DAS16403 @DAS16407 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchingBetweenTabsWhileAddUserFormIsOpen
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "DynamicList13066" name on "Applications" page
	Then "DynamicList13066" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	Then 'Specific users / teams' content is displayed in 'Sharing' dropdown
	When User clicks 'group_add' icon
	When User selects '2004 Team' option from 'Team' autocomplete
	Then 'ADD TEAM' button is disabled
	When User clicks 'CANCEL' button
	When User clicks 'group_add' icon
	When User selects '2004 Team' option from 'Team' autocomplete
	When User clicks 'CANCEL' button 
	When User clicks 'person_add' icon
	Then form container is displayed to the user
	When User selects 'Administrator' option from 'User' autocomplete
	When User clicks 'CANCEL' button 
	When User clicks 'person_add' icon
	When User selects 'Administrator' option from 'User' autocomplete
	When User selects 'Edit' in the 'Permission' dropdown
	And User clicks 'ADD USER' button
	When User clicks Close panel button
	When User clicks the Permissions button
	Then There are no errors in the browser console
	And "Admin" Sharing user is displayed correctly
	And form container is not displayed to the user
	When User clicks 'person_add' icon
	And User clicks 'CANCEL' button 
	Then User list for sharing is not displayed
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS13029 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDetailsPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "ATList13029" name on "Devices" page
	Then "ATList13029" list is displayed to user
	When User clicks the Permissions button
	Then 'Owner' autocomplete options are sorted in the alphabetical order