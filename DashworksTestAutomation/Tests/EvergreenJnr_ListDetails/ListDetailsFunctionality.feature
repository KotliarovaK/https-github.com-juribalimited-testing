@retry:1
Feature: ListDetailsFunctionality
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestList12CA0D" name on "<PageName>" page
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestList12CA0D" list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "Static List TestName" list
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
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestList80EA23" list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "Static List TestName" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as favorite
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "Static List TestName" list
	When User navigates to the "Static List TestName" list
	Then Star icon is not displayed for "Static List TestName" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as unfavorite
	Then Star icon is not displayed for "Static List TestName" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "Static List TestName" list

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
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestListCED2D6" list
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
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "Static List TestName" list
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
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with " 2" name
	Then Warning message with "List Name should be unique" is displayed

	Examples: 
	| PageName     | Columnname    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12029 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoAbilityToCreateTheSameNamedListsUsingTheSpaceCharacterForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "2" name
	Then "2" list is displayed to user
	When User navigates to the "<ListToNavigate>" list
	When User clicks the Actions button
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
	When User create custom list with "TestList1262B7" name
	Then "TestList1262B7" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList   | Association        |
	| TestList1262B7 | Entitled to device |
	Then "Application" filter is added to the list
	When User create custom list with "TestList186851" name
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
	Then no Warning message is displayed in the lists panel

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12190 @DAS12204 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatTwoDependencyAreDisplayedInTheDependentsBlock
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User click on 'Application' column header
	And User create custom list with "Application1" name
	Then "Application1" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList | Association        |
	| Application1 | Entitled to device |
	Then "Application" filter is added to the list
	When User create custom list with "Device1" name
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
	Then Dependants section is collapsed by default
	When User expand Dependants section
	Then "NewDevice" list is displayed in the Dependants section
	And "Device1" list is displayed in the Dependants section

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12169 @DAS12286 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AllLists_CheckThatListDoesNotExistErrorWhenViewingDependentList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create custom list with "Adobe Apps" name
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
	When User create custom list with "Devices with Adobe" name
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
	And no Warning message is displayed in the lists panel