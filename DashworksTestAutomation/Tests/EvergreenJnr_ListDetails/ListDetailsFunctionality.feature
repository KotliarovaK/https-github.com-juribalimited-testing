@retry:1
Feature: ListDetailsFunctionality
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestList" list
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestList" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as favorite
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "TestList" list
	When User navigates to the "TestList" list
	Then Star icon is not displayed for "TestList" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User mark list as unfavorite
	Then Star icon is not displayed for "TestList" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "TestList" list

Examples: 
	| PageName     | Columnname    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "TestList" name
	#Workaround for DAS-11570. Remove after fix
	#And User navigates to the "TestList" list
	When User clicks the List Details button
	Then List details panel is displayed to the user
	Then "TestList" name is displayed in list details panel
	Then List is NOT marked as favorite
	Then current user is selected as a owner of a list
	Then "Private" sharing option is selected

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists
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

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11493 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User select "Automation Admin 1" as a Owner of a list
	And User click Accept button in List Details panel
	Then List details button is disabled
	And list with "TestList" name is removed
	And "<PageName>" list should be displayed to the user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

	
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11721
Scenario Outline: EvergreenJnr_AllLists_CheckThatGroupIconsAreDisplayedForAllPages
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ObjectName>"
	When User click content from "<ColumnName>" column
	Then Group Icon for "" page is displayed 
	
	Examples: 
	| PageName     | ObjectName                                                 | Columnname    |
	| Devices      | 001BAQXT6JWFPI                                             | Hostname      |
	| Users        | $231000-3AC04R8AR431 (Exchange Online-ApplicationAccount)  | Username      |
	| Applications | "WPF/E" (codename) Community Technology Preview (Feb 2007) | Application   |
	| Mailboxes    | 000F977AC8824FE39B8@bclabs.local                           | Email Address |