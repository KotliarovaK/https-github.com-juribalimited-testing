﻿Feature: ListDetailsFunctionalityPart3
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11648 @DAS12947
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultListsAfterChangingALanguage
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Preferences" page on Account details
	And User changes language to "English US"
	And User clicks the "UPDATE" Action button
	And User clicks '<PageName>' on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	And List details button is disabled

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForDynamicList
	When User clicks '<PageName>' on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create custom list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	And User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create custom list with " 2" name
	Then Warning message with "List Name should be unique" is displayed

	Examples: 
	| PageName     | ColumnName    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @DAS12555 @DAS12602 @DAS12966 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForStaticLists
	When User clicks '<PageName>' on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with " 2" name
	Then Warning message with "List Name should be unique" is displayed

	Examples:
	| PageName     | ListToNavigate   |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |
	| Mailboxes    | All Mailboxes    |
	
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12208 @DAS12684 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatWarningMessageIsNotDisplayedInTheListPanelAfterViewingDependentList
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles |
	| 2User2   | User2    | 1234qwer | 1234qwer        |       |
	Then Success message is displayed
	When User navigate to Dashworks User Site link
	And User navigate to Evergreen link
	And User clicks 'Applications' on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User create dynamic list with "TestApplicationsList12208" name on "Applications" page
	Then "TestApplicationsList12208" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can see" sharing option
	Then "Everyone can see" sharing option is selected
	When User clicks 'Devices' on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList              | Association        |
	| TestApplicationsList12208 | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "TestDevicesList12208" name on "Devices" page
	Then "TestDevicesList12208" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	Then "Everyone can edit" sharing option is selected
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| 2User2   | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User navigates to the "TestApplicationsList12208" list
	Then "TestApplicationsList12208" list is displayed to user
	And no Warning message is displayed in the lists panel
	When User clicks the List Details button
	Then List details panel is displayed to the user
	And User open the Dependents component
	And dependent "TestDevicesList12208" list is displayed
	When User navigates to the dependent "TestDevicesList12208" list
	Then "TestDevicesList12208" list is displayed to user
	And no Warning message is displayed in the lists panel
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "2User2" User