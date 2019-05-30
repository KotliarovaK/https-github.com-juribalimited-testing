﻿@retry:0
Feature: ListDetailsFunctionality
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @DAS12624 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestList12CA0D" name on "<PageName>" page
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User changes list name to "RenamedList"
	Then "RenamedList" name is displayed in list details panel
	Then Edit List menu is not displayed
	When User mark list as favorite
	Then Star icon is active in list details panel
	Then Edit List menu is not displayed
	When User select "Everyone can edit" sharing option
	Then Edit List menu is not displayed
	Then "RenamedList" list is displayed to user
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then Edit List menu is not displayed

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @DAS12602 @DAS12624 @DAS16866 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "Static List TestName" name
	And User clicks the List Details button
	Then List details panel is displayed to the user
	When User changes list name to "RenamedList"
	Then "RenamedList" name is displayed in list details panel
	And Edit List menu is not displayed
	When User mark list as favorite
	Then Star icon is active in list details panel
	And Edit List menu is not displayed
	When User select "Everyone can edit" sharing option
	Then Edit List menu is not displayed
	And "RenamedList" list is displayed to user
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then Edit List menu is not displayed

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestList80EA23" name on "<PageName>" page
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as favorite
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "TestList80EA23" list
	When User navigates to the "TestList80EA23" list
	Then Star icon is not displayed for "TestList80EA23" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as unfavorite
	Then Star icon is not displayed for "TestList80EA23" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "TestList80EA23" list

Examples: 
	| PageName     | Columnname    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @DAS12602 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "Static List TestName36" name
	And User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as favorite
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "Static List TestName36" list
	When User navigates to the "Static List TestName36" list
	Then Star icon is not displayed for "Static List TestName36" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as unfavorite
	Then Star icon is not displayed for "Static List TestName36" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "Static List TestName36" list

Examples: 
	| PageName     | ListToNavigate   |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |
	| Mailboxes    | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	Then List details button is disabled

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestListCED2D6" name on "<PageName>" page
	When User clicks the List Details button
	Then List details panel is displayed to the user
	Then "TestListCED2D6" name is displayed in list details panel
	Then List is NOT marked as favorite
	Then current user is selected as a owner of a list
	Then "Private" sharing option is selected

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists
	When User create static list with "Static List TestName" name on "<PageName>" page with following items
	| ItemName |
	|          |
	When User clicks the List Details button
	Then List details panel is displayed to the user
	Then "Static List TestName" name is displayed in list details panel
	Then List is NOT marked as favorite
	Then current user is selected as a owner of a list
	Then "Private" sharing option is selected

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11493 @DAS11951 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "TestListE11493" name
	Then "TestListE11493" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then List details button is disabled
	And list with "TestListE11493" name is not displayed
	And "<PageName>" list should be displayed to the user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11648 @DAS12947
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultListsAfterChangingALanguage
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Preferences" page on Account details
	And User changes language to "English US"
	And User clicks the "UPDATE" Action button
	And User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	And List details button is disabled

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForDynamicList
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create custom list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	And User click on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order
	When User create custom list with " 2" name
	Then Warning message with "List Name should be unique" is displayed

	Examples: 
	| PageName     | ColumnName    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @DAS12555 @DAS12602 @DAS12966 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
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
	
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12208 @DAS12684 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatWarningMessageIsNotDisplayedInTheListPanelAfterViewingDependentList
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles |
	| 2User2   | User2    | 1234qwer | 1234qwer        |       |
	Then Success message is displayed
	When User navigate to Dashworks User Site link
	And User navigate to Evergreen link
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12190 @DAS12204 @DAS13207 @DAS14963 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatTwoDependencyAreDisplayedInTheDependentsBlock
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	When User create dynamic list with "Application1" name on "Applications" page
	Then "Application1" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	And User save changes in list with "NewDevice" name
	And "NewDevice" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application1" list
	Then "Application1" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then List details panel is displayed to the user
	And Dependants section is collapsed by default
	When User expand Dependants section
	Then "NewDevice" list is displayed in the Dependants section
	And "Device1" list is displayed in the Dependants section

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12169 @DAS12286 @DAS12192 @DAS12623 @DAS12687 @DAS14963 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatListDoesNotExistErrorWhenViewingDependentList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Adobe Apps" name on "Applications" page
	Then "Adobe Apps" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then List details panel is displayed to the user
	When User closes Permissions section in the list panel
	Then tooltip is displayed with "Open" text for Permissions section
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association        |
	| Adobe Apps   | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "Devices with Adobe" name on "Devices" page
	Then "Devices with Adobe" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Adobe Apps" list
	Then "Adobe Apps" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then List details panel is displayed to the user
	Then tooltip is displayed with "Open" text for Dependants section
	When User expand Dependants section
	Then Dependants section is displayed to the user
	When User clicks "Devices with Adobe" list in the Dependants section
	Then "Devices with Adobe" list is displayed to user
	And "This list does not exist or you do not have access to it" message is not displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12192 @DAS14963 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatListPanelDoesNotExistErrorWhenViewingDependentList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	When User create dynamic list with "A1" name on "Applications" page
	Then "A1" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association        |
	| A1           | Entitled to device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "D1" name on "Devices" page
	Then "D1" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "A1" list
	Then "A1" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then List details panel is displayed to the user
	When User expand Dependants section
	Then Dependants section is displayed to the user
	When User clicks "D1" list in the Dependants section
	Then "D1" list is displayed to user
	And "This list does not exist or you do not have access to it" message is not displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12874 @DAS14222 @DAS15551 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesDynamicLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	And User create dynamic list with "<ListName1>" name on "Applications" page
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association   |
	| <ListName1>  | <Association> |
	When User create dynamic list with "<ListName2>" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "<ListName1>" list
	Then "<ListName1>" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then Delete and Cancel buttons are available in the warning message
	When User clicks Cancel button in the warning message
	Then no Warning message is displayed in the lists panel
	And "<ListName1>" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "<ListName1>" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User removes custom list with "<ListName1>" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "<ListName2>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "<FilterInfoText>" is displayed in added filter info

Examples: 
	| ListName1    | ListName2 | Association                | FilterInfoText                                                      |
	| Application1 | Devices1  | Used on device             | Any Application in list [List not found] used on device             |
	| Application2 | Devices2  | Used by device's owner     | Any Application in list [List not found] used by device's owner     |
	| Application3 | Devices3  | Not used by device's owner | Any Application in list [List not found] not used by device's owner |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS12791 @DAS12952 @DAS14222 @DAS15551 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticLists
	When User create static list with "Application12075" name on "Applications" page with following items
	| ItemName                  |
	| Python 2.2a4              |
	| Quartus II Programmer 4.0 |
	| Multi Edit 9 Client       |
	Then table content is present
	Then "3" rows are displayed in the agGrid
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList     | Association    |
	| Application12075 | Used on device |
	And User create dynamic list with "Devices12075" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application12075" list
	Then "Application12075" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application12075" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User removes custom list with "Application12075" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices12075" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	And message 'No devices found' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS12791 @DAS12952 @DAS14222 @DAS15551 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLists
	When User create static list with "Application3_12075" name on "Applications" page with following items
	| ItemName                                        |
	| Microsoft SDK Update February 2003 (5.2.3790.0) |
	| Quartus II Programmer 4.0                       |
	| Mindreef SOAPscope 4.0                          |
	Then "Application3_12075" list is displayed to user
	And table content is present
	And "3" rows are displayed in the agGrid
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList       | Association    |
	| Application3_12075 | Used on device |
	And User create dynamic list with "Devices3_12075" name on "Devices" page
	Then "Devices3_12075" list is displayed to user
	When User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList       | Association        |
	| Application3_12075 | Entitled to device |
	And User create dynamic list with "Devices4_12075" name on "Devices" page
	Then "Devices4_12075" list is displayed to user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application3_12075" list
	Then "Application3_12075" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application3_12075" list "list is used by 2 lists, do you wish to proceed?" message is displayed in the list panel
	When User removes custom list with "Application3_12075" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices3_12075" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	And message 'No devices found' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @DAS14222 @DAS15551 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForTwoDependenciesLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	And User create dynamic list with "Application4" name on "Applications" page
	And User add following columns using URL to the "Applications" page:
	| ColumnName |
	| Compliance |
	And User create dynamic list with "Application5" name on "Applications" page
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList | Association    |
	| Application4 | Used on device |
	| Application5 | Used on device |
	And User create dynamic list with "Devices4" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application4" list
	Then "Application4" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application4" list "list is used by 1 list, do you wish to proceed?" message is displayed in the list panel
	When User removes custom list with "Application4" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices4" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] or Application5 used on device" is displayed in added filter info

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12536 @DAS12791 @DAS12952 @Delete_Newly_Created_List
Scenario: EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicAndStaticLists
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
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
	Then List details panel is displayed to the user
	When User clicks Delete List button on the List Details panel
	And User navigates to the "DynamicList2569" list
	Then no Warning message is displayed in the lists panel
	When User clicks the List Details button
	Then List details panel is displayed to the user
	And no Warning message is displayed in the list details panel

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12536 @Delete_Newly_Created_List
Scenario: EvergreenJnr_Users_CheckThatListDeletionWarningMessageIsNotDisplayedAfterDeletingAnotherListForDynamicLists
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	Then data in table is sorted by 'Username' column in ascending order
	When User create dynamic list with "DynamicList4587" name on "Users" page
	Then "DynamicList4587" list is displayed to user
	When User navigates to the "All Users" list
	And User click on 'Domain' column header
	Then data in table is sorted by 'Domain' column in ascending order
	When User create dynamic list with "DynamicList4781" name on "Users" page
	Then "DynamicList4781" list is displayed to user
	When User removes custom list with "DynamicList4781" name
	And User navigates to the "DynamicList4587" list
	Then no Warning message is displayed in the lists panel
	When User clicks the List Details button
	Then List details panel is displayed to the user
	And no Warning message is displayed in the list details panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11498 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsPanelDisplaysIfItWasOpenedFromManageMenu
	When User clicks "<PageName>" on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "<ListName>" name
	Then "<ListName>" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then List details panel is displayed to the user

Examples:
	| PageName     | ListName              |
	| Devices      | Devices DAS11498      |
	| Users        | Users DAS11498        |
	| Applications | Applications DAS11498 |
	| Mailboxes    | Mailboxes DAS11498    |

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12535 @DAS12791 @DAS12952 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_CheckThatListDetailsPanelIsDisplayedAfterSelectingManageFromListPanelMenu
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User click on 'Email Address' column header
	When User create dynamic list with "DynamicList4557" name on "Mailboxes" page
	Then "DynamicList4557" list is displayed to user
	When User create static list with "StaticList2845" name on "Mailboxes" page with following items
	| ItemName                         |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	Then "StaticList2845" list is displayed to user
	And table content is present
	And "2" rows are displayed in the agGrid
	When User navigates to the "All Mailboxes" list
	And User clicks Settings button for "DynamicList4557" list
	And User clicks Manage in the list panel
	Then "DynamicList4557" list is displayed to user
	And List details panel is displayed to the user
	When User navigates to the "StaticList2845" list
	Then "StaticList2845" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Manage in the list panel
	Then "StaticList2845" list is displayed to user
	And List details panel is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12967
Scenario Outline: EvergreenJnr_AllLists_CheckThatAllRowsDisplayedOnGridWhenCreatingStaticListAfterSearch
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "<ListName>" name
	Then "<RowsCount>" rows are displayed in the agGrid
	And Static list grid has "<RowsCount>" rows
	When User clicks the Columns button
	And User adds columns to the list
	| ColumnName  |
	| <AddColumn> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And Static list grid still has "<RowsCount>" rows

Examples: 
	| PageName     | SearchTerm       | ListName                           | AddColumn                | RowsCount |
	| Applications | microsoft server | Applications Static List DAS-12967 | UserSchedu: Readiness ID | 29        |
	| Users        | Peterson         | Users Static List DAS-12967        | Compliance               | 28        |
	| Devices      | aba              | Devices Static List DAS-12967      | BIOS Name                | 19        |
	| Mailboxes    | ab1              | Mailboxes Static List DAS-12967    | Alias                    | 14        |

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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User performs right-click on "<TargetCell>" cell in the grid
	Then User sees context menu with next options
	| OptionsName        |
	| Copy cell          |
	| Copy row           |
	| Open in new tab    |
	| Open in new window | 
	When User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied
	When User clicks refresh button in the browser
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	And User performs right-click on "<TargetCell>" cell in the grid
	Then User sees context menu with next options
	| OptionsName        |
	| Copy cell          |
	| Copy row           |
	| Copy selected rows |
	| Open in new tab    |
	| Open in new window | 
	When User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow                             |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        |


@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow                             | ExpectedData                                                                                                              |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | \t00HA7MKAVVFDAV\tLaptop\tWindows XP\tKris C. Herman                                                                      |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | \t$6BE000-SUDQ9614UVO8\tBCLABS\tExchange Online-ApplicationAccount\tExchange Online-ApplicationAccount.Users.bclabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | \t0004 - Adobe Acrobat Reader 5.0.5 Francais\tAdobe\t5.0.5                                                                |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | \t000F977AC8824FE39B8@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tSpruill, Shea                                  |
	

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow1>   |
	| <SelectedRow2>   |
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy selected rows' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow1                            | SelectedRow2                     | ExpectedData                                                                                                                                                                                             |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | 001PSUMZYOW581                   | \t001BAQXT6JWFPI\tDesktop\tWindows XP\tNicole P. Braun \t001PSUMZYOW581\tLaptop\tWindows XP\tTricia G. Huang                                                                                               |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | 002B5DC7D4D34D5C895              | \t000F977AC8824FE39B8\tBCLABS\tSpruill, Shea\tSpruill\\, Shea.Employees.Birmingham.UK.bclabs.local \t002B5DC7D4D34D5C895\tDWLABS\tCollor, Christopher\tCollor\\, Christopher.Users.Birmingham.dwlabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | 20040610sqlserverck              | \t0036 - Microsoft Access 97 SR-2 English\tMicrosoft\t8.0 \t20040610sqlserverck\tMicrosoft\t1.0.0                                                                                                          |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | 0072B088173449E3A93@bclabs.local | \t002B5DC7D4D34D5C895@bclabs.local\tExchange 2013\tbc-exch13\tUserMailbox\tCollor, Christopher \t0072B088173449E3A93@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tRegister, Donna                  |