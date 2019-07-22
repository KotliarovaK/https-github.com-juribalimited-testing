Feature: ListDetailsFunctionalityPart7
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12580 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsLists_CheckThatTheSaveButtonIsNotDisplayedOnTheListPanelAfterListCreation
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	And User create custom list with "TestList5478" name
	Then Save and Cancel buttons are not displayed on the list panel
	And "TestList5478" list is displayed to user

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12629 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsLists_CheckThatListOwnerOfDynamicListIsDisplayedCorrectly
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	When User create dynamic list with "DynamicListFirst" name on "Applications" page
	Then "DynamicListFirst" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	Then current user is selected as a owner of a list
	When User navigates to the "All Applications" list
	Then "Applications" list should be displayed to the user
	When User click on 'Vendor' column header
	When User create dynamic list with "DynamicListSecond" name on "Applications" page
	Then "DynamicListSecond" list is displayed to user
	When User clicks the List Details button
	Then current user is selected as a owner of a list
	When User create static list with "StaticList7844" name on "Applications" page with following items
	| ItemName |
	|          |
	Then "StaticList7844" list is displayed to user
	When User clicks the List Details button
	Then current user is selected as a owner of a list
	When User navigates to the "DynamicListFirst" list
	When User clicks the List Details button
	Then current user is selected as a owner of a list
	When User navigates to the "DynamicListSecond" list
	When User clicks the List Details button
	Then current user is selected as a owner of a list
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	When User navigates to the "DynamicListFirst" list
	When User clicks the List Details button
	Then current user is selected as a owner of a list

@Evergreen @Applications @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS13066 @DAS15561 @DAS15569 @DAS16403 @DAS16407 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_ChecksThatListDetailsIsLoadedCorrectlyAfterSwitchingBetweenTabsWhileAddUserFormIsOpen
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	And User create dynamic list with "DynamicList13066" name on "Applications" page
	Then "DynamicList13066" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Specific users / teams" sharing option
	Then "Specific users / teams" sharing option is selected
	When User clicks the "ADD TEAM" Action button
	When User selects the "1803 Team" team for sharing
	Then "ADD TEAM" Action button is disabled
	When User clicks the "CANCEL" Action button
	When User clicks the "ADD TEAM" Action button
	When User selects the "1803 Team" team for sharing
	When User clicks the "CANCEL" Action button
	When User clicks the "ADD USER" Action button
	Then form container is displayed to the user
	When User selects the "Administrator" user for sharing
	When User clicks the "CANCEL" Action button
	And User clicks the "ADD USER" Action button
	When User selects the "Administrator" user for sharing
	When User select "Edit" in Select Access dropdown
	And User clicks the "ADD USER" Action button
	And User clicks the "ADD USER" Action button
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	And There are no errors in the browser console
	And "Admin" Sharing user is displayed correctly
	And form container is not displayed to the user
	When User clicks the "ADD USER" Action button
	And User clicks the "CANCEL" Action button
	Then User list for sharing is not displayed
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS13029 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_ChecksThatOwnersIsDisplayedInAlphabeticalOrderOnListDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "List13029" name on "Devices" page
	Then "List13029" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User clears Owner field on List Details panel
	Then Owners is displayed in alphabetical order