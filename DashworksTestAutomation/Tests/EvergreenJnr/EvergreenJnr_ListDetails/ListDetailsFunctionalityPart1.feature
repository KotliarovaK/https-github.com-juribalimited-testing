﻿Feature: ListDetailsFunctionalityPar1
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @DAS12624 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForDynamicLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestList12CA0D" name on "<PageName>" page
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User changes list name to "RenamedList"
	Then "RenamedList" name is displayed in list details panel
	Then Edit List menu is not displayed
	When User checks 'Favorite List' checkbox
	Then Edit List menu is not displayed
	When User clicks the Permissions button
	Then Permissions panel is displayed to the user
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then Edit List menu is not displayed
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then "RenamedList" list is displayed to user
	When User clicks the Permissions button
	Then Permissions panel is displayed to the user
	When User selects 'Automation Admin 1' in the 'Owner' dropdown
	When User clicks 'ACCEPT' button on inline tip banner

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @DAS12602 @DAS12624 @DAS16866 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForStaticLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static List TestName" name
	And User clicks the List Details button
	Then Details panel is displayed to the user
	When User changes list name to "RenamedList"
	Then "RenamedList" name is displayed in list details panel
	And Edit List menu is not displayed
	When User checks 'Favorite List' checkbox
	Then Edit List menu is not displayed
	When User clicks the Permissions button
	Then Permissions panel is displayed to the user
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then Edit List menu is not displayed
	When User selects 'Automation Admin 1' in the 'Owner' dropdown
	When User clicks 'ACCEPT' button on inline tip banner
	Then Edit List menu is not displayed

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForDynamicLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestList80EA23" name on "<PageName>" page
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User checks 'Favorite List' checkbox
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "TestList80EA23" list
	When User navigates to the "TestList80EA23" list
	Then Star icon is displayed for "TestList80EA23" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User unchecks 'Favorite List' checkbox
	Then Star icon is not displayed for "TestList80EA23" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "TestList80EA23" list

Examples: 
	| PageName     | Columnname    | ListToNavigate   |
	| Devices      | Hostname      | All Devices      |
	| Users        | Username      | All Users        |
	| Applications | Application   | All Applications |
	| Mailboxes    | Email Address | All Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @DAS12555 @DAS12602 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatFavoriteAListWorkingCorrectlyForStaticLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "Static List TestName36" name
	And User clicks the List Details button
	Then Details panel is displayed to the user
	When User checks 'Favorite List' checkbox
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is displayed for "Static List TestName36" list
	When User navigates to the "Static List TestName36" list
	Then Star icon is displayed for "Static List TestName36" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User unchecks 'Favorite List' checkbox
	Then Star icon is not displayed for "Static List TestName36" list
	When User navigates to the "<ListToNavigate>" list
	Then Star icon is not displayed for "Static List TestName36" list

Examples: 
	| PageName     | ListToNavigate   |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |
	| Mailboxes    | All Mailboxes    |