@retry:1
Feature: Search
	Runs Search related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS10704 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_CheckThatQuickSearchResetWhenMovingBetweenLists
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Build Date |
	When User create dynamic list with "TestList7BA11B" name on "Devices" page
	Then "TestList7BA11B" list is displayed to user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	When User navigates to the "All Devices" list
	Then Search field is empty

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS10704
Scenario: EvergreenJnr_DevicesList_CheckThatQuickSearchDoesntTriggersNewListMenu
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then Save to New Custom List element is NOT displayed

@Evergreen @Devices @Applications @Users @Mailboxes @EvergreenJnr_Search @Search @DAS10580 @DAS10667 @DAS10624
Scenario: EvergreenJnr_AllLists_CheckSearchFilterAndTableContentDuringNavigationBetweenPages
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And "17,225" rows are displayed in the agGrid
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	And "41,335" rows are displayed in the agGrid
	And Search field is empty
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 59           |
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	And "2,223" rows are displayed in the agGrid
	And Search field is empty
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Python          | 7           |
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	And "14,784" rows are displayed in the agGrid
	And Search field is empty
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 44           |
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And "17,225" rows are displayed in the agGrid
	And Search field is empty

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS12206 @DAS10475
Scenario: EvergreenJnr_DevicesList_SearchTests
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria      | NumberOfRows |
	| Véronique Duplessis | 1            |
	| Virtual             | 1,996        |
	| Windows Vista       | 475          |
	| O'Connor            | 13           |
	| @demo.juriba.com    | 16,717       |
	| 192.168.6           | 5,100        |
	| RED                 | 9,238        |
	| 0JIE                | 1            |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11012 @DAS12206
Scenario: EvergreenJnr_DevicesList_ClearingSearchReturnsTheFullDataSet
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Mary           | 17           |
	Then URL is "http://automation.corp.juriba.com/evergreen/#/devices"
	And Clearing the agGrid Search Box
	Then "17,225" rows are displayed in the agGrid
	Then URL is "http://automation.corp.juriba.com/evergreen/#/devices"

@Evergreen @Users @EvergreenJnr_Search @Search @DAS11012 @DAS12206
Scenario: EvergreenJnr_UsersList_ClearingSearchReturnsTheFullDataSet
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Luc            | 138          |
	Then URL is "http://automation.corp.juriba.com/evergreen/#/users"
	And Clearing the agGrid Search Box
	Then "41,335" rows are displayed in the agGrid
	Then URL is "http://automation.corp.juriba.com/evergreen/#/users"

@Evergreen @Devices @EvergreenJnr_Search @Search
Scenario: EvergreenJnr_DevicesList_Search_NoDevicesFound
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Compliance          |
	| Owner Email Address |
	| IP Address          |
	Then User enters invalid SearchCriteria into the agGrid Search Box and "No devices found" message is displayed
	| SearchCriteria    |
	| 0281Z793OLLLDU66  |
	| Xavier Beaule     |
	| BLUE              |
	| Virtuals          |
	| Windows 2001      |
	| 192.168.7         |
	| demo.juriba.co.uk |
	| 67#               |
	| #12               |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350
Scenario: EvergreenJnr_DevicesList_Search_CheckThatGlobalSearchFieldHaveAResetButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "CheckTheResetButton" in Global Search Field
	Then reset button in Global Search field is displayed

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350
Scenario: EvergreenJnr_DevicesList_Search_CheckThatTableSearchFieldHaveAResetButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "CheckTheResetButton"
	Then reset button in Table Search field is displayed

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350
Scenario: EvergreenJnr_DevicesList_Search_CheckThatSearchFieldHaveResetButtonAtFilterPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User enters "CheckTheResetButton" text in Search field at Filters Panel
	Then reset button in Search field at selected Panel is displayed

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350
Scenario: EvergreenJnr_DevicesList_Search_CheckThatSearchFieldHaveResetButtonAtColumnPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User enters "CheckTheResetButton" text in Search field at Columns Panel
	Then reset button in Search field at selected Panel is displayed
	 
@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350
Scenario: EvergreenJnr_DevicesList_Search_CheckThatMultiSelectFilterSearchFieldHaveResetButton 
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Import" filter
	And User enters "CheckTheResetButton" text in Search field at selected Lookup Filter
	Then reset button in Search field at selected Filter is displayed

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11350 @DAS11951 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Search_CheckThatSearchFieldHaveResetButtonAtListPanel 
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestListDED759" name on "Devices" page
	When User enters "CheckTheResetButton" text in Search field at List Panel
	Then reset button in Search field at List Panel is displayed

@Evergreen @AllLists @EvergreenJnr_Search @Search @DAS11495 @DAS10972
Scenario Outline: EvergreenJnr_AllLists_Search_CheckThat500ErrorMessageIsNotDisplayedAfterEnteringTheSpecificCharacters
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User type "[^abc]" in Global Search Field
	Then "<PageName>" list should be displayed to the user

Examples: 
	| PageName     |
	| Devices      |
	| Users        |
	| Applications |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_Search @Search @DAS11511
Scenario Outline: EvergreenJnr_AllLists_Search_CheckThatTableSearchIsWorkingCorrectly
	When User add following columns using URL to the "<PageName>" page:
	| ColumnName   |
	| <ColumnName> |
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria   | NumberOfRows   |
	| <SearchCriteria> | <NumberOfRows> |

Examples: 
	| PageName     | ColumnName                                      | SearchCriteria                              | NumberOfRows |
	| Devices      | Compliance                                      | GREEN                                       | 100          |
	| Devices      | Windows7Mi: Readiness                           | OUT OF SCOPE                                | 5,118        |
	| Devices      | Windows7Mi: Group Computer Rag Radio Date Owner | Not Applicable                              | 5,161        |
	| Applications | Import Type                                     | Altiris 6                                   | 31           |
	| Users        | Department                                      | The Last Department With A Really Lond Name | 10           |

@Evergreen @Applications @EvergreenJnr_Search @Search @DAS11511
Scenario: EvergreenJnr_ApplicationsLists_Search_CheckThatTableSearchIsWorkingCorrectlyForApplicationColumn
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Zune           | 3            |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11664
Scenario: EvergreenJnr_DevicesLists_Search_CheckThatTableSearchWorksCorrectlyForOwnerDisplayNameColumn
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName       |
	| Hostname         |
	| Device Type      |
	| Operating System |
	Then ColumnName is removed from the list
	| ColumnName       |
	| Hostname         |
	| Device Type      |
	| Operating System |
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Anna           | 119          |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11664
Scenario: EvergreenJnr_DevicesLists_Search_CheckThatTableSearchWorksCorrectlyForOwnerUsernameColumn
	When User add following columns using URL to the "Devices" page:
	| ColumnName     |
	| Owner Username |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName       |
	| Hostname         |
	| Device Type      |
	| Operating System |
	|Owner Display Name|
	Then ColumnName is removed from the list
	| ColumnName       |
	| Hostname         |
	| Device Type      |
	| Operating System |
	|Owner Display Name|
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| TON249         | 1            |

@Evergreen @Users @EvergreenJnr_Search @Search @DAS11664
Scenario: EvergreenJnr_UsersLists_Search_CheckThatTableSearchWorksCorrectlyForDisplayNameColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName         |
	| Username           |
	| Domain             |
	| Distinguished Name |
	Then ColumnName is removed from the list
	| ColumnName         |
	| Username           |
	| Domain             |
	| Distinguished Name |
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Hunter         | 26           |

@Evergreen @Mailboxes @EvergreenJnr_Search @Search @DAS11664
Scenario: EvergreenJnr_MailboxesLists_Search_CheckThatTableSearchWorksCorrectlyForOwnerDisplayNameColumn
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName       |
	| Email Address    |
	| Mailbox Platform |
	| Mail Server      |
	| Mailbox Type     |
	Then ColumnName is removed from the list
	| ColumnName       |
	| Email Address    |
	| Mailbox Platform |
	| Mail Server      |
	| Mailbox Type     |
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 43           |

@Evergreen @Mailboxes @EvergreenJnr_Search @Search @DAS11664
Scenario: EvergreenJnr_MailboxesLists_Search_CheckThatTableSearchWorksCorrectlyForOwnerUsernameColumn
	When User add following columns using URL to the "Mailboxes" page:
	| ColumnName     |
	| Owner Username |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes ColumnName column by Column panel
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	Then ColumnName is removed from the list
	| ColumnName         |
	| Email Address      |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| 00B            | 16           |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11663
Scenario: EvergreenJnr_DevicesLists_Search_CheckThatRowCountIsNotDisplayedWhenNoObjectsAreFoundAfterUsingAgGrid
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	And User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Example        |              |

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11706
Scenario: EvergreenJnr_DevicesLists_Search_CheckThatValidationForSpecialCharactersInSearchEverythingAndSearchTableFieldsIsPresented
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "%%%" in Global Search Field
	Then "No results found" message is displayed below Global Search field
	Then User enters invalid SearchCriteria into the agGrid Search Box and "No devices found" message is displayed
	| SearchCriteria |
	| %%%            |