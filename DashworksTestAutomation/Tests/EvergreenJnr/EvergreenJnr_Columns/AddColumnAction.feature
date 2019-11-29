﻿Feature: AddColumnAction
	Runs Add column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns @AddColumnAction @DAS10665
Scenario: EvergreenJnr_DevicesList_AddTheDeviceKeyColumnToTheDevicesList
	When User add following columns using URL to the "Devices" page:
	| ColumnName          |
	| Device Key          |
	Then Content is present in the newly added column
	| ColumnName          |
	| Device Key          |

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS11452
Scenario: EvergreenJnr_MailboxesList_CheckThat500ErrorIsNotDisplayedAfterSortingForSelectedColumn
	When User add following columns using URL to the "Mailboxes" page:
	| ColumnName                 |
	| Owner Department Full Path |
	When User clicks on 'Owner Department Full Path' column header
	Then data in table is sorted by 'Owner Department Full Path' column in ascending order
	And 'All Mailboxes' list should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS11576
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatMaxReceiveSizeAndMaxSendSizeColumnIsDisplayedAfterSelectingOnFilterPanel 
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	Then "<FilterName>" filter is added to the list
	Then ColumnName is added to the list
	| ColumnName   |
	| <FilterName> |

Examples:
	| FilterName            |
	| Max Receive Size (MB) |
	| Max Send Size (MB)    |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS11689 @DAS12780
Scenario Outline: EvergreenJnr_AllLists_CheckThatTableIsFullyLoadedAfterAddingTheColumns
	When User add following columns using URL to the "<ListName>" page:
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| UserSchedu: Readiness             |
	Then Content is present in the newly added column
	| ColumnName                        |
	| Windows7Mi: Application Readiness |
	| UserSchedu: Readiness             |
	Then full list content is displayed to the user
	Then There are no errors in the browser console

Examples:
	| ListName     |
	| Applications |
	| Devices      |

@Evergreen @Applications @EvergreenJnr_Columns @AddColumnAction @DAS10997 @DAS12026 @DAS12156 @DAS12780
Scenario Outline: EvergreenJnr_Applications_CheckThatConsoleErrorsAreNotDisplayedForImages
	When User add following columns using URL to the "Applications" page:
	| ColumnName   |
	| <ColumnName> |
	Then There are no errors in the browser console

Examples:
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |
	| Windows7Mi: Application Readiness       |
	| Windows7Mi: Core Application            |
	| Windows7Mi: Hide from End Users         |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS11871
Scenario Outline: EvergreenJnr_AllLists_CheckThatConsoleErrorsAreNotDisplayedAfterSortingUserScheduReadinessIDColumn
	When User add following columns using URL to the "<ListName>" page:
	| ColumnName               |
	| UserSchedu: Readiness ID |
	When User clicks on 'UserSchedu: Readiness ID' column header
	Then Content is present in the newly added column
	| ColumnName               |
	| UserSchedu: Readiness ID |
	When User clicks on 'UserSchedu: Readiness ID' column header
	Then numeric data in table is sorted by 'UserSchedu: Readiness ID' column in descending order
	Then full list content is displayed to the user
	Then There are no errors in the browser console

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |

@Evergreen @Applications @EvergreenJnr_Columns @AddColumnAction @DAS11649 @DAS12199
Scenario: EvergreenJnr_ApplicationsLists_CheckThatNoDataIsDisplayedInTheApplicationRationalisationColumn
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Application Rationalisation" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "Windows7Mi: Application Rationalisation" filter is added to the list
	When User add "Windows7Mi: In Scope" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks on 'Windows7Mi: In Scope' column header
	And User clicks on 'Windows7Mi: In Scope' column header
	When User clicks the Filters button
	Then data in table is sorted by 'Windows7Mi: In Scope' column in ascending order
	Then Content is empty in the column
	| ColumnName                              |
	| Windows7Mi: Application Rationalisation |

@Evergreen @Mailboxes @EvergreenJnr_Columns @AddColumnAction @DAS11839
Scenario: EvergreenJnr_MailboxesLists_CheckThatTheLowestValueOfUserCountColumnIsNull
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| User Count |
	Then ColumnName is added to the list
	| ColumnName |
	| User Count |
	When User clicks on 'User Count' column header
	When User clicks on 'User Count' column header
	Then numeric data in table is sorted by 'User Count' column in ascending order
	Then Lowest value of "User Count" column is null

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS12194 @DAS12220
Scenario Outline: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedAfterAddingComplianceDataToLists
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	| Red                |
	| Amber              |
	| Green              |
	| Empty              |
	Then "<FilterName>" filter is added to the list
	When User clicks the Filters button
	And User clicks on '<ColumnHeader>' column header
	Then color data is sorted by '<ColumnHeader>' column in ascending order
	When User clicks on '<ColumnHeader>' column header
	Then color data is sorted by '<ColumnHeader>' column in descending order

Examples:
	| ListName     | FilterName       | ColumnHeader     |
	| Devices      | Compliance       | Compliance       |
	| Devices      | Owner Compliance | Owner Compliance |
	| Users        | Compliance       | Compliance       |
	| Applications | Compliance       | Compliance       |
	| Mailboxes    | Owner Compliance | Owner Compliance |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS12500 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatObjectKeyColumnsContainCorrectLinks
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |
	Then Links from "<ColumnName>" column is displayed to the user
	When User click content from "<ColumnName>" column
	Then Details object page is displayed to the user

Examples:
	| ListName     | ColumnName      |
	| Devices      | Device Key      |
	| Users        | User Key        |
	| Applications | Application Key |
	| Mailboxes    | Mailbox Key     |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS12940
Scenario Outline: EvergreenJnr_AllLists_CheckThatEvergreenBucketColumnCanBeAddedToTheGrid
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Evergreen Bucket |
	Then ColumnName is added to the list
	| ColumnName       |
	| Evergreen Bucket |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS13201
Scenario Outline: EvergreenJnr_AllLists_CheckThatEvergreenCapacityUnitColumnCanBeAddedToTheGrid
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName              |
	| Evergreen Capacity Unit |
	Then ColumnName is added to the list
	| ColumnName              |
	| Evergreen Capacity Unit |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |
	| Applications |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS9820 @DAS13296
Scenario: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxColumnsCanBeUsedOnUsersPage
	When User clicks 'Users' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName              |
	| Device Count            |
	| Group Count             |
	| Mailbox Count (Access)  |
	#| Mailbox Count (Owned) |
	Then ColumnName is added to the list
	| ColumnName              |
	| Device Count            |
	| Group Count             |
	| Mailbox Count (Access)  |
	#| Mailbox Count (Owned) |

@Evergreen @Devices @EvergreenJnr_Columns @AddColumnAction @DAS13024
Scenario: EvergreenJnr_DevicesList_ChecksThatGridIsDisplayedCorrectlyAfterAddingDeviceOwnerLdapAndComputerAdObjectLdapAttributeColumnToTheDevicesList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName             |
	| Owner accountexpires   |
	| frscomputerreferencebl |
	Then ColumnName is added to the list
	| ColumnName             |
	| Owner accountexpires   |
	| frscomputerreferencebl |
	And "17,279" rows are displayed in the agGrid
	And full list content is displayed to the user
	And There are no errors in the browser console
	And table content is present

@Evergreen @Mailboxes @EvergreenJnr_Columns @RemoveColumn @AddColumnAction @DAS12910
Scenario: EvergreenJnr_MailboxesList_ChecksThatNewlyAddedColumnIsDisplayedCorrectlyAfterAddingEmailMigraReadinessFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Owner Display Name" column by Column panel
	And User removes "Mailbox Type" column by Column panel
	And User removes "Mail Server" column by Column panel
	And User removes "Mailbox Platform" column by Column panel
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Blue           |
	| Light Blue     |
	Then Content is present in the newly added column
	| ColumnName            |
	| EmailMigra: Readiness |
	And full list content is displayed to the user
	And There are no errors in the browser console
	And Add And button is displayed on the Filter panel
	When User selects And "EmailMigra: Readiness" filter where type is "Equals" with added column and Lookup option:
	| SelectedValues |
	| Out Of Scope   |
	And User clicks 'CANCEL' button 
	Then Add And button is displayed on the Filter panel

@Evergreen @AllLists @EvergreenJnr_Columns @AddColumnAction @DAS12481
Scenario Outline: EvergreenJnr_AllLists_CheckThatStateCountyAndPostalCodeColumnsAreDisplayed
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| State/County |
	| Postal Code  |
	Then ColumnName is added to the list
	| ColumnName   |
	| State/County |
	| Postal Code  |
	When User clicks on 'State/County' column header
	Then data in table is sorted by 'State/County' column in ascending order
	When User clicks on 'State/County' column header
	Then data in table is sorted by 'State/County' column in descending order
	When User clicks on 'Postal Code' column header
	Then data in table is sorted by 'Postal Code' column in ascending order
	When User clicks on 'Postal Code' column header
	Then data in table is sorted by 'Postal Code' column in descending order

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Mailboxes    |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @DAS15807
Scenario: EvergreenJnr_UsersList_CheckThatLanguageColumnIsDisplayedOnTheUserList
	When User clicks 'Users' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Windows7Mi: Language |
	Then ColumnName is added to the list
	| ColumnName           |
	| Windows7Mi: Language |
	When User clicks on 'Windows7Mi: Language' column header
	When User clicks on 'Windows7Mi: Language' column header
	Then 'English' content is displayed in the 'Windows7Mi: Language' column

@Evergreen @Mailboxes @Users @EvergreenJnr_Columns @AddColumnAction @DAS16716
Scenario Outline: EvergreenJnr_AllList_CheckThatSortingByEvergreenRingColumnWorks
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName     |
	| Evergreen Ring |
	And User clicks on 'Evergreen Ring' column header
	Then data in table is sorted by 'Evergreen Ring' column in ascending order
	When User clicks on 'Evergreen Ring' column header
	Then data in table is sorted by 'Evergreen Ring' column in descending order

	Examples:
	| ListName     |
	| Users        |
	| Mailboxes    |

@Evergreen @AllLists @EvergreenJnr_Columns @FilterFunctionality @DAS16912
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplinceNoneOptionIsTranslated
	When User add following columns using URL to the "<ListName>" page:
	| ColumnName   |
	| <FilterName> |
	And User clicks the Filters button
	And User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>               |
	And User language is changed to "Deutsch" via API
	And User clicks refresh button in the browser
	Then '<TranslatedFilterValue>' content is displayed in the '<TranslatedColumnName>' column

Examples: 
	| ListName     | FilterName                    | FilterValue | TranslatedColumnName        | TranslatedFilterValue |
	| Devices      | Application Compliance        | None        | Anwendungskonformität       | KEINE                 |
	| Users        | Device Application Compliance | Red         | Geräteanwendungskonformität | ROT                   |
	| Applications | Compliance                    | Green       | Konformität                 | GRÜN                  |
	| Mailboxes    | Owner Compliance              | Unknown     | Konformität des Inhabers    | UNBEKANNT             |

@Evergreen @Users @EvergreenJnr_Columns @AddColumnAction @DAS17945
Scenario: EvergreenJnr_UsersList_ChecksThatApplicationReadinessColumnIsDisplayedCorrectlyForUsersList
	When User clicks 'Users' on the left-hand menu
	When User add following columns using URL to the "Users" page:
	| ColumnName                        |
	| Barry'sUse: Application Readiness |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Barry'sUse: In Scope" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then Content is present in the newly added column
	| ColumnName                        |
	| Barry'sUse: Application Readiness |
	Then Color data displayed with correct color for 'Barry'sUse: Application Readiness' column
	Then 'Ignore' tooltip is displayed for 'IGNORE' content in the 'Barry'sUse: Application Readiness' column

@Evergreen @Devices @EvergreenJnr_Columns @AddColumnAction @DAS16364
Scenario: EvergreenJnr_Devices_CheckOrderByStatusColumnSorting
	When User clicks 'Devices' on the left-hand menu
	And User add following columns using URL to the "Devices" page:
	| ColumnName   |
	| 1803: Status |
	When User clicks on '1803: Status' column header
	Then 'Not Onboarded' content is displayed in the '1803: Status' column
	When User clicks on '1803: Status' column header
	Then 'Offboarded' content is displayed in the '1803: Status' column

@Evergreen @Applications @EvergreenJnr_Columns @AddColumnAction @DAS18762 @Not_Ready
#Waiting for 'Sticky Compliance' column
Scenario: EvergreenJnr_Applications_CheckStickyComplianceColumnDisplaying
	When User clicks 'Applications' on the left-hand menu
	And User add following columns using URL to the "Applications" page:
	| ColumnName        |
	| Sticky Compliance |
	When User create dynamic list with "DAS18762_List" name on "Applications" page
	Then "DAS18762_List" list is displayed to user
	When User clicks on 'Sticky Compliance' column header
	When User clicks on 'Sticky Compliance' column header
	Then 'IGNORE' content is displayed in the 'Sticky Compliance' column