@retry:1
Feature: ListDetailsFunctionality
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Delete_Newly_Created_List @Not_Run
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
	When User is closed List Details panel
	Then "RenamedList" list is displayed to user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @Delete_Newly_Created_List @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User changes list name to "RenamedList"
	Then "RenamedList" name is displayed in list details panel
	When User is closed List Details panel
	Then "RenamedList" list is displayed to user

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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @Delete_Newly_Created_List @Not_Run
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName36" name
	When User clicks the List Details button
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
	When User create dynamic list with "TestListE3A207" name on "<PageName>" page
	Then "TestListE3A207" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then List details button is disabled
	And list with "TestListE3A207" name is removed
	And "<PageName>" list should be displayed to the user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11648
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultListsAfterChangingALanguage
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Preferences" page on Account details
	And User changes language to "English US"
	And User clicks Update button on Preferences page
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @DAS12555 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with " 2" name
	Then Warning message with "List Name should be unique" is displayed

	Examples: 
	| PageName     | ListToNavigate   |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |
	| Mailboxes    | All Mailboxes    |
	
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12208 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatWarningMessageIsNotDisplayedInTheListPanelAfterViewingDependentList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	When User create dynamic list with "TestList1262B7" name on "Applications" page
	Then "TestList1262B7" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList   | Association        |
	| TestList1262B7 | Entitled to device |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList186851" name on "Devices" page
	Then "TestList186851" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Everyone can edit" sharing option
	Then "Everyone can edit" sharing option is selected
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList186851" list
	Then "TestList186851" list is displayed to user
	And no Warning message is displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12190 @DAS12204 @Delete_Newly_Created_List
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
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association        |
	| Application1 | Entitled to device |
	Then "Application" filter is added to the list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12169 @DAS12286 @DAS12192 @DAS12623 @Delete_Newly_Created_List @Not_Run
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
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association        |
	| Adobe Apps   | Entitled to device |
	Then "Application" filter is added to the list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10713 @DAS12192 @Delete_Newly_Created_List @Not_Run
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
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association        |
	| A1           | Entitled to device |
	Then "Application" filter is added to the list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesDynamicLists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	And User create dynamic list with "Application1" name on "Applications" page
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association    |
	| Application1 | Used on device |
	When User create dynamic list with "Devices1" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application1" list
	Then "Application1" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then Delete and Cancel buttons are available in the warning message
	When User clicks Cancel button in the warning message
	Then no Warning message is displayed in the lists panel
	And "Application1" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application1" list "list has 1 list(s) that are dependent on it, and will be permanently deleted" message is displayed in the list panel
	When User removes custom list with "Application1" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices1" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Application in list [List not found] used on device" is displayed in added filter info
	And message 'No devices found' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesStaticLists
	When User create static list with "Application2" name on "Applications" page with following items
	| ItemName                  |
	| Python 2.2a4              |
	| Quartus II Programmer 4.0 |
	| Multi Edit 9 Client       |
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association    |
	| Application2 | Used on device |
	And User create dynamic list with "Devices2" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application2" list
	Then "Application2" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application2" list "list has 1 list(s) that are dependent on it, and will be permanently deleted" message is displayed in the list panel
	When User removes custom list with "Application2" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices2" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application in list [List not found] used on device" is displayed in added filter info
	And message 'No devices found' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckDisplayingListDeletionWarningMessageForDependenciesLists
	When User create static list with "Application3" name on "Applications" page with following items
	| ItemName                                        |
	| Microsoft SDK Update February 2003 (5.2.3790.0) |
	| Quartus II Programmer 4.0                       |
	| Mindreef SOAPscope 4.0                          |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association    |
	| Application3 | Used on device |
	And User create dynamic list with "Devices3" name on "Devices" page
	And User navigates to the "All Devices" list
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association        |
	| Application3 | Entitled to device |
	And User create dynamic list with "Devices4" name on "Devices" page
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to the "Application3" list
	Then "Application3" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "Application3" list "list has 2 list(s) that are dependent on it, and will be permanently deleted" message is displayed in the list panel
	When User removes custom list with "Application3" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices3" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application in list [List not found] used on device" is displayed in added filter info
	And message 'No devices found' is displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12075 @DAS12578 @Delete_Newly_Created_List
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
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
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
	Then "Application4" list "list has 1 list(s) that are dependent on it, and will be permanently deleted" message is displayed in the list panel
	When User removes custom list with "Application4" name
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "Devices4" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application in list [List not found] or Application5 used on device" is displayed in added filter info

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12536 @Delete_Newly_Created_List
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

@Evergreen @Users @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12535 @Delete_Newly_Created_List
Scenario: EvergreenJnr_Users_CheckThatListDetailsPanelIsDisplayedAfterSelectingManageFromListPanelMenu
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
	When User navigates to the "All Mailboxes" list
	And User clicks Settings button for "DynamicList4557" list
	And User clicks Manage in the list panel
	Then "DynamicList4557" list is displayed to user
	And List details panel is displayed to the user
	When User navigates to the "StaticList2845" list
	Then "StaticList2845" list is displayed to user
	When User clicks Settings button in the list panel
	And User clicks Manage in the list panel
	Then "StaticList2845" list is displayed to user
	And List details panel is displayed to the user