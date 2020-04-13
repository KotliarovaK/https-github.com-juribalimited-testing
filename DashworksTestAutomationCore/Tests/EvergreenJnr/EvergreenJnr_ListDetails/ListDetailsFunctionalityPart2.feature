Feature: ListDetailsFunctionalityPart2
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDetailsButtonIsDisabledForDefaultLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	Then List details button is disabled

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS11951 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForDynamicLists
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User create dynamic list with "TestListCED2D6" name on "<PageName>" page
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then "TestListCED2D6" name is displayed in list details panel
	Then 'Favourite List' checkbox is unchecked
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	Then 'Private' content is displayed in 'Sharing' dropdown

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS10880 @DAS12152 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckDefaultOptionsInListDetailsForStaticLists
	When User create static list with "Static List TestName" name on "<PageName>" page with following items
	| ItemName |
	|          |
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then "Static List TestName" name is displayed in list details panel
	Then 'Favourite List' checkbox is unchecked
	When User clicks the Permissions button
	Then current user is selected in 'Owner' autocomplete
	Then 'Private' content is displayed in 'Sharing' dropdown

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS11493 @DAS11951 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatActiveListIsRefreshedOnListDetailsPanel
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in ascending order
	When User creates 'TestListE11493' dynamic list
	Then "TestListE11493" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Automation Admin 1' option from 'Owner' autocomplete
	When User clicks 'ACCEPT' button on inline tip banner
	Then List details button is disabled
	Then list with "TestListE11493" name is not displayed
	Then 'All <PageName>' list should be displayed to the user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |