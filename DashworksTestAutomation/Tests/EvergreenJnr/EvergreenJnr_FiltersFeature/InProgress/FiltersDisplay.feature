﻿Feature: FiltersDisplay
	Runs Dynamic Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS10781 @DAS11507
Scenario: EvergreenJnr_ApplicationsList_CheckThatGroupAndTeamRelatedFiltersIsNotPresentedInTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Group" filter is not presented in the filters list
	Then "Windows7Mi: Group Key" filter is not presented in the filters list
	Then "Windows7Mi: Team" filter is not presented in the filters list
	Then "Windows7Mi: Team Key" filter is not presented in the filters list

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS10771 @DAS10972 @DAS14748
Scenario Outline: EvergreenJnr_AllLists_CheckThatNoneOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then Save to New Custom List element is displayed
	When User click Edit button for "<FilterName>" filter
	Then User changes filter type to "Does not equal"
	Then Save to New Custom List element is displayed
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then Save to New Custom List element is displayed
	When User Add And "<NewFilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Red                |
	When User Add And "<NewFilterName>" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Amber              |
	Then Save to New Custom List element is displayed
	When User have reset all filters
	Then Save to New Custom List element is NOT displayed

	Examples:
		| PageName     | FilterName           | NewFilterName    |
		| Devices      | Windows7Mi: Category | Compliance       |
		| Users        | UserSchedu: Category | Compliance       |
		| Applications | Havoc(BigD: Category | Compliance       |
		| Mailboxes    | EmailMigra: Category | Owner Compliance |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsFilterIsContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11187 @DAS13376
Scenario Outline: EvergreenJnr_DevicesList_CheckThatCustomFiltersAreContainsAllExpectedAssociations
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "<FilterName>" filter from "Application Custom Fields" category
	Then Associations is displayed in the filter
		| Associations                   |
		| Used on device                 |
		| Entitled to device             |
		| Installed on device            |
		| Used by device's owner         |
		| Entitled to device's owner     |
		| Not used on device             |
		| Not entitled to device         |
		| Not installed on device        |
		| Not used by device's owner     |
		| Not entitled to device's owner |

	Examples:
		| FilterName                  |
		| App field 1                 |
		| App field 2                 |
		| Application Owner           |
		| General information field 1 |
		| General information field 2 |
		| General information field 3 |
		| General information field 4 |
		| General information field 5 |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatFilterCategoriesAreClosedAfterClearingAFilterSearchValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And User enters "date" text in Search field at Filters Panel
	Then Minimize buttons are displayed for all category in Filters panel
	When User clears search textbox in Filters panel
	Then Maximize buttons are displayed for all category in Filters panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11552 @DAS12207 @DAS12639
Scenario: EvergreenJnr_DevicesList_CheckThatRelevantDataSetBeDisplayedAfterEditingFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then message 'No devices found' is displayed to the user
	When User click Edit button for "Compliance" filter
	And User closes "Empty" Chip item in the Filter panel
	When User change selected checkboxes:
		| Option | State |
		| Green  | true  |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11088
Scenario Outline: EvergreenJnr_AllLists_CheckThatConsoleErrorsAreNotDisplayedForDateFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then There are no errors in the browser console

	Examples:
		| ListName     | FilterName                                                                     |
		| Devices      | Build Date                                                                     |
		| Devices      | Owner Last Logon Date                                                          |
		| Devices      | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task |
		| Users        | Barry'sUse: Project Dates \ Scheduled Date                                     |
		| Applications | UserSchedu: Three \ Date App Req A                                             |
		| Mailboxes    | Created Date                                                                   |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS11831
Scenario: EvergreenJnr_MailboxesList_CheckThatResultCounterDoesNotDisappearAfterDeletingTheCharactersInEmailMigraTeamFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Team" filter where type is "Equals" without added column and following value:
		| Values |
		| 55     |
	Then "50 of 55 shown" results are displayed in the Filter panel
	When User deletes one character from the Search field
	Then "50" of all shown label displays in the Filter panel

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS12100
Scenario: EvergreenJnr_DevicesList_CheckThatMailboxOwnerFilterCategoryIsNotDisplayedOnDeviceList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Mailbox Owner" section is not displayed in the Filter panel

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11466
Scenario: EvergreenJnr_DevicesList_CheckingThatVendorFilterIsDisplayedInApplicationCategory
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Vendor" filter from "Application" category
	Then setting section for "Application Vendor" filter is loaded

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12940 @DAS13201 @DAS14325
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketAndCapacityUnitSubcategoriesPlacedInEvergreenCategoryInFiltersPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Evergreen" section is displayed in the Filter panel
	When User closes "Suggested" filter category
	And User expands "Evergreen" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories           |
		| Evergreen Bucket        |
		| Evergreen Capacity Unit |
		| Evergreen Ring          |

	Examples:
		| ListName  |
		| Devices   |
		| Users     |
		| Mailboxes |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS13201 @DAS14325 @DAS14325 @DAS19309
Scenario: EvergreenJnr_ApplicationsList_CheckThatCapacityUnitSubcategoryPlacedInEvergreenCategoryInFiltersPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Evergreen" section is displayed in the Filter panel
	When User closes "Suggested" filter category
	And User expands "Evergreen" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                   |
		| Criticality                     |
		| Evergreen Capacity Unit         |
		| Evergreen Rationalisation       |
		| Evergreen Target App            |
		| Evergreen Target App Compliance |
		| Evergreen Target App Key        |
		| Evergreen Target App Name       |
		| Evergreen Target App Vendor     |
		| Evergreen Target App Version    |
		| Hide from End Users             |
		| In Catalog                      |

#'archived' tag was added, because "Evergreen" option in "Mode" dropdown is not available now.
@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @Projects @Cleanup @DAS13201 @archived
Scenario: EvergreenJnr_AllLists_CheckThatParticularProjectCapacityUnitFilterShowsProperItems
	When User clicks 'Admin' on the left-hand menu
	And User clicks 'CREATE PROJECT' button
	And User enters '13201' text to 'Project Name' textbox
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	When User selects 'Evergreen' in the 'Mode' dropdown
	When User clicks 'CREATE' button
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "DeviceSche: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
		| checkboxes              |
		| Project Capacity Unit 1 |
		| Project Capacity Unit 2 |
		| Unassigned              |
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "UserEvergr: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
		| checkboxes                |
		| Evergreen Capacity Unit 1 |
		| Evergreen Capacity Unit 2 |
		| Evergreen Capacity Unit 3 |
		| Unassigned                |
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "13201: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
		| checkboxes |
		| Unassigned |
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "DeviceSche: Capacity Unit" filter
	Then Following checkboxes are available for current opened filter:
		| checkboxes              |
		| Project Capacity Unit 1 |
		| Project Capacity Unit 2 |
		| Unassigned              |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12940
Scenario: EvergreenJnr_AllLists_CheckThatDeletedBucketIsNotAvailableInEvergreenBucketFilter
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	And User clicks 'CREATE EVERGREEN BUCKET' button
	And User enters 'Bucket_DAS12940_to_be_deleted' text to 'Bucket Name' textbox
	When User selects 'Admin IT' option from 'Team' autocomplete
	And User clicks 'CREATE' button
	And User select "Bucket" rows in the grid
		| SelectedRowsName              |
		| Bucket_DAS12940_to_be_deleted |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Bucket" filter
	Then "Bucket_DAS12940_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13201 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatDeletedCapacityUnitIsNotAvailableInEvergreenCapacityUnitFilter
	When User creates new Capacity Unit via api
		| Name                                 | Description | IsDefault |
		| Capacity_Unit_DAS13201_to_be_deleted | 13201       | false     |
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
		| SelectedRowsName                     |
		| Capacity_Unit_DAS13201_to_be_deleted |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	And User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Evergreen Capacity Unit" filter
	Then "Capacity_Unit_DAS13201_to_be_deleted" checkbox is not available for current opened filter

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS13183
Scenario: EvergreenJnr_UsersList_CheckThatApplicationManufacturerFilterChangedToApplicationVendor
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then "Application Manufacturer" filter is not presented in the filters list
	And "Application Vendor" filter is presented in the filters list

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS9820 @DAS13296 @DAS14629 @DAS14659 @DAS14629
Scenario: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxFiltersAvailableUnderUserCategoryInFiltersPanelOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "User" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                 |
		| Common Name                   |
		| Compliance                    |
		| Dashworks First Seen          |
		| Description                   |
		| Device Application Compliance |
		| Device Count                  |
		| Device Hardware Compliance    |
		| Directory Type                |
		| Email Address                 |
		| Enabled                       |
		| Given Name                    |
		| Group Count                   |
		| GUID                          |
		| Home Directory                |
		| Home Drive                    |
		| Last Logon Date               |
		| Mailbox Count (Access)        |
		| Mailbox Count (Owned)         |
		| Organizational Unit           |
		| Parent Distinguished Name     |
		| Primary Device                |
		| SID                           |
		| Surname                       |
		| User (Saved List)             |
		| User Application Compliance   |
		| User Key                      |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13182
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddNewOptionAvailableAfterClickOnAllOptionInListsPanelWhileFiltersSectionExpanded
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When User navigates to the "<LinkName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And Add New button is displayed on the Filter panel

	Examples:
		| ListName     | LinkName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13391 @DAS15776
Scenario Outline: EvergreenJnr_AllLists_CheckThatSelectedColumnsSectionIsExpandedByDefaultInFiltersPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then User sees "Suggested" section expanded by default in Filters panel

	Examples:
		| ListName     |
		| Devices      |
		| Users        |
		| Applications |
		| Mailboxes    |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12793 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheValueInTheFiltersPanelIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
		| SelectedValues | Association     |
		| AAD1011948     | Entitled to app |
	Then "4" rows are displayed in the agGrid
	When User create dynamic list with "UsersFilterList" name on "Applications" page
	Then "UsersFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User" filter
	Then "FR\AAD1011948 (Pinabel Cinq-Mars)" value is displayed in the filter info
	And There are no errors in the browser console
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12819 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheUserDescriptionFieldIsNotDisplayedForEmptyNotEmptyOptions
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Contains" with following Value and Association:
		| Values | Association     |
		| Aw     | Entitled to app |
	Then "3" rows are displayed in the agGrid
	When User create dynamic list with "UsersDescriptionFilterList" name on "Applications" page
	Then "UsersDescriptionFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User " filter
	And User select "Empty" Operator value
	Then User Description field is not displayed
	When User select "Not empty" Operator value
	Then User Description field is not displayed

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13383 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatColorsInReadinessFilterAreDisplayedCorrectlyAfterSavingList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Babel(Engl: Readiness" filter where type is "Equals" with added column and Lookup option
		| SelectedValues |
		| Red            |
		| Amber          |
	And User creates 'CheckColors13383' dynamic list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Babel(Engl: Readiness" filter
	Then color for following values are displayed correctly:
		| Color |
		| Red   |
		| Amber |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS12547
Scenario: EvergreenJnr_MailboxesList_CheckThatOwnerFloorValuesAreSortedInTheFilterBlock
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Floor" filter
	When User clicks in search field in the Filter block
	Then the values are displayed for "OwnerFloor" filter on "Mailboxes" page in the following order:
		| Value |
		| Empty |
		| 0     |
		| 1     |
		| 2     |
		| 3     |
		| 4     |
		| 5     |
		| 6     |
		| 11    |
		| 12    |
		| 18    |
		| 19    |
		| 20    |
		| 21    |
		| 25    |
		| 26    |
		| 49    |
		| 51    |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS15625
Scenario: EvergreenJnr_DevicesList_CheckThatTaskSlotHasEmptyAndNotEmptyOperators
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
		| ColumnName                                  |
		| 1803: Pre-Migration \ Scheduled Date (Slot) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "1803: Pre-Migration \ Scheduled Date (Slot)" filter
	And User select "Equals" Operator value
	And User enters "Empty" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then Column '1803: Pre-Migration \ Scheduled Date (Slot)' with no data displayed

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_DevicesList_CheckStageNameInTheFiltestForDevicesLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                                        |
		| DeviceSche: Stage 1 \ Completed Date                 |
		| DeviceSche: Stage 1 \ Completed Date (Slot)          |
		| DeviceSche: Stage 1 \ Forecast Date                  |
		| DeviceSche: Stage 1 \ Forecast Date (Slot)           |
		| DeviceSche: Stage 1 \ Group Task                     |
		| DeviceSche: Stage 1 \ Group Task (Date)              |
		| DeviceSche: Stage 1 \ Group Task (Slot)              |
		| DeviceSche: Stage 1 \ Migrated Date                  |
		| DeviceSche: Stage 1 \ Migrated Date (Slot)           |
		| DeviceSche: Stage 1 \ Scheduled Date                 |
		| DeviceSche: Stage 1 \ Scheduled Date (Slot)          |
		| DeviceSche: Stage 1 \ Target Date                    |
		| DeviceSche: Stage 1 \ Target Date (Slot)             |
		| DeviceSche: Stage 2 \ radiobutton task               |
		| DeviceSche: Stage 2 \ radiobutton task w/date        |
		| DeviceSche: Stage 2 \ radiobutton task w/date (Date) |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_UsersList_CheckStageNameInTheFiltestForUsersLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                               |
		| DeviceSche: Stage 2 \ user DDL task         |
		| DeviceSche: Stage 2 \ user radiobutton task |
		| DeviceSche: Stage 2 \ user text task        |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_ApplicationsList_CheckStageNameInTheFiltestForApplicationsLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: DeviceSche" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                              |
		| DeviceSche: Stage 2 \ app date task        |
		| DeviceSche: Stage 2 \ app radiobutton task |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS15899
Scenario: EvergreenJnr_MailboxesList_CheckStageNameInTheFiltestForMailboxesLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Project Tasks: MailboxEve" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                              |
		| MailboxEve: 1 \ Completed                  |
		| MailboxEve: 1 \ Completed (Slot)           |
		| MailboxEve: 1 \ Forecast                   |
		| MailboxEve: 1 \ Forecast (Slot)            |
		| MailboxEve: 1 \ Migrated                   |
		| MailboxEve: 1 \ Migrated (Slot)            |
		| MailboxEve: 1 \ Scheduled - mailbox        |
		| MailboxEve: 1 \ Scheduled - mailbox (Slot) |
		| MailboxEve: 1 \ Target                     |
		| MailboxEve: 1 \ Target (Slot)              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS16426
Scenario: EvergreenJnr_ApplicationsList_CheckTooltipsForUpdateButtonWhenDateFieldIsEmpty
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "User Dashworks First Seen" filter
	And User select "Equals" Operator value
	Then 'ADD' button has tooltip with 'You must enter a date' text
	When User select "Between" Operator value
	Then 'ADD' button has tooltip with 'You must enter a start date' text
	When User select "Empty" Operator value
	Then 'ADD' button has tooltip with 'Complete all fields before saving this filter' text
	When User select "Not empty" Operator value
	Then 'ADD' button has tooltip with 'Complete all fields before saving this filter' text

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS16845
Scenario: EvergreenJnr_MailboxesList_CheckThatApplicationReadinessSubCategoryIsMissingForProjectOfMailboxesLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "readiness" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories         |
		| EmailMigra: Readiness |
	Then the following subcategories are NOT displayed for Filters categories:
		| Subcategories                     |
		| EmailMigra: Application Readiness |

@Evergreen @Devices @Evergreen_FiltersFeature @FilterFunctionality @DAS16071
Scenario: EvergreenJnr_DevicesList_CheckThatStatusFilterAvailableOptionsList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Status" filter
	And User clicks in search field in the Filter block
	Then Following checkboxes are available for current opened filter:
		| checkboxes    |
		| Not Onboarded |
		| Onboarded     |
		| Forecast      |
		| Targeted      |
		| Scheduled     |
		| Migrated      |
		| Complete      |
		| Offboarded    |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17579
Scenario: EvergreenJnr_ApplicationsList_CheckUserPostalCodeOptionsDisplaying
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "User Postal Code" filter
	Then following operator options available:
		| operator            |
		| Equals              |
		| Does not equal      |
		| Contains            |
		| Does not contain    |
		| Begins with         |
		| Does not begin with |
		| Ends with           |
		| Does not end with   |
		| Empty               |
		| Not empty           |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194 @DAS17743
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerFilterCategoryHasCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Device Owner" text in Search field at Filters Panel
	And User closes all filters categories
	And User expands "Device Owner" filter category
	Then the following Filters subcategories are presented for open category:
		| Subcategories                          |
		| Device Owner (Saved List)              |
		| Device Owner                           |
		| Device Owner Common Name               |
		| Device Owner Compliance                |
		| Device Owner Compliance                |
		| Device Owner Description               |
		| Device Owner Directory Type            |
		| Device Owner Display Name              |
		| Device Owner Distinguished Name        |
		| Device Owner Domain                    |
		| Device Owner Email Address             |
		| Device Owner Enabled                   |
		| Device Owner Given Name                |
		| Device Owner GUID                      |
		| Device Owner Home Directory            |
		| Device Owner Home Drive                |
		| Device Owner Key                       |
		| Device Owner Last Logon Date           |
		| Device Owner Organizational Unit       |
		| Device Owner Parent Distinguished Name |
		| Device Owner SID                       |
		| Device Owner Surname                   |
		| Device Owner Username                  |
	When User collapses 'Device Owner' category
	And User expands "Device Owner Location" filter category
	Then the following Filters subcategories are presented for open category:
		| Subcategories              |
		| Device Owner Building      |
		| Device Owner City          |
		| Device Owner Country       |
		| Device Owner Floor         |
		| Device Owner Region        |
		| Device Owner Location Name |
		| Device Owner Postal Code   |
		| Device Owner State/County  |
	When User collapses 'Device Owner Location' category
	And User expands "Device Owner Organisation" filter category
	Then the following Filters subcategories are presented for open category:
		| Subcategories                     |
		| Device Owner Cost Centre          |
		| Device Owner Department Code      |
		| Device Owner Department           |
		| Device Owner Department Full Path |
		| Device Owner Department Level 1   |
		| Device Owner Department Level 2   |
		| Device Owner Department Level 3   |
		| Device Owner Department Level 4   |
		| Device Owner Department Level 5   |
		| Device Owner Department Level 6   |
		| Device Owner Department Level 7   |
		| Device Owner Department Name      |
	When User collapses 'Device Owner Organisation' category
	And User expands "Device Owner Custom Fields" filter category
	Then the following Filters subcategories are presented for open category:
		| Subcategories                            |
		| Device Owner General information field 1 |
		| Device Owner General information field 2 |
		| Device Owner General information field 3 |
		| Device Owner General information field 4 |
		| Device Owner General information field 5 |
		| Device Owner Telephone                   |
		| Device Owner User Field 1                |
		| Device Owner User Field 2                |
		| Device Owner Zip Code                    |
	When User clears search textbox in Filters panel
	And User enters "Device Owner R" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories       |
		| Device Owner Region |
	When User clears search textbox in Filters panel
	And User enters "Device Owner S" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories        |
		| Device Owner SID     |
		| Device Owner Surname |
	When User clears search textbox in Filters panel
	And User enters "Device Owner U" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories         |
		| Device Owner Username |
	When User clears search textbox in Filters panel
	And User enters "Device Owner D" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories           |
		| Device Owner Department |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerCustomFieldsFilterCategoryHasCorrectSubcategories
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Device Owner General information field" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories                            |
		| Device Owner General information field 1 |
		| Device Owner General information field 2 |
		| Device Owner General information field 3 |
		| Device Owner General information field 4 |
		| Device Owner General information field 5 |
	When User clears search textbox in Filters panel
	And User enters "Device Owner Telephone" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories          |
		| Device Owner Telephone |
	When User clears search textbox in Filters panel
	And User enters "Device Owner User Field" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories             |
		| Device Owner User Field 1 |
		| Device Owner User Field 2 |
	When User clears search textbox in Filters panel
	And User enters "Device Owner Zip Code" text in Search field at Filters Panel
	Then the following Filters subcategories are presented for open category:
		| Subcategories         |
		| Device Owner Zip Code |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS15194 @DAS16485
Scenario: EvergreenJnr_ApplicationsList_CheckThatDeviceOwnerCustomItemHasCorrectFilterOptions
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And user select "Device Owner Zip Code" filter
	And User select "Does not equal" Operator value
	And User select "Contains" Operator value
	And User select "Does not contain" Operator value
	And User select "egins with" Operator value
	And User select "Does not begin with" Operator value
	And User select "Ends with" Operator value
	And User select "Does not end with" Operator value
	And User select "Empty" Operator value
	And User select "Not empty" Operator value

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17588
Scenario: EvergreenJnr_ApplicationsList_CheckAutomationsCategoryOrder
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	Then Category Automations displayed before projects categories

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS17727 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOrderOfFiltersInDeviceHardwareCategory
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User closes "Suggested" filter category
	And User expands "Device Hardware" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                       |
		| Device CPU Architecture             |
		| Device CPU Speed (GHz)              |
		| Device Format                       |
		| Device HDD Total Size (GB)          |
		| Device IP Address                   |
		| Device IP v6 Address                |
		| Device Manufacturer                 |
		| Device Memory (GB)                  |
		| Device Model                        |
		| Device Target Drive Free Space (GB) |
		| Device TPM Enabled                  |
		| Device TPM Version                  |
		| Device Type                         |
		| Device Virtual Machine Host         |

@Evergreen @Devices @Users @Applications @Mailboxes @FiltersDisplay @ColumnsDisplay @DAS17943
Scenario Outline: EvergreenJnr_AdminPage_CheckThaSearchfieldHasProperPlaceholderForFiltersAndColumns
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Filter Searchfield placeholder is 'Search filters'
	When User clicks the Columns button
	Then Columns Searchfield placeholder is 'Search columns'

	Examples:
		| PageName     | ListName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18375
Scenario: EvergreenJnr_DevicesList_CheckAppearanceOfComplianceValuesInTheFilterBlock
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Compliance" filter
	Then the values are displayed for "applicationCompliance" filter on "Devices" page in the following order:
		| Value   |
		| Empty   |
		| Unknown |
		| Red     |
		| Amber   |
		| Green   |
		| None    |
	When User clicks in search field in the Filter block
	Then No ring icon displayed for Empty item in Lookup

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS18150
Scenario: EvergreenJnr_DevicesList_CheckThatFilterSubcategoriesAreSortedByCaseInsensitiveAlphabetOrder
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Operating System" column by Column panel
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User closes "Suggested" filter category
	When User expands "Operating System" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories         |
		| Operating System      |
		| OS Architecture       |
		| OS Branch             |
		| OS Full Name          |
		| OS Servicing State    |
		| OS Version Number     |
		| Service Pack or Build |
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User closes "Suggested" filter category
	When User expands "Device Operating System" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories                |
		| Device Operating System      |
		| Device OS Architecture       |
		| Device OS Branch             |
		| Device OS Full Name          |
		| Device OS Servicing State    |
		| Device OS Version Number     |
		| Device Service Pack or Build |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS16814
Scenario Outline: EvergreenJnr_AllLists_CheckThatCorrectScopedProjectAppearsForStatusFilter
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListHeader>' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Status" text in Search field at Filters Panel
	And User moves to the end of categories list
	Then the following Filters categories are presented in Filter panel:
		| Subcategories |
		| <Project>     |

	Examples:
		| ListName     | ListHeader       | Project             |
		| Applications | All Applications | Project: zDeviceAut |
		| Users        | All Users        | Project: zDeviceAut |
		| Devices      | All Devices      | Project: zUserAutom |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS18367
Scenario Outline: EvergreenJnr_DevicesList_CheckThatThereIsNoEmptyOptionInDeviceAndApplicationSavedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	When User enters "Empty" text in Search field at selected Lookup Filter
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                     |
		| Device (Saved List)      |
		| Application (Saved List) |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS18367
Scenario: EvergreenJnr_DevicesList_CheckThatThereIsNoEmptyOptionInProjectSpecificSavedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "1803: Owner (Saved List)" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS18367
Scenario Outline: EvergreenJnr_UsersList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                     |
		| User (Saved List)        |
		| Application (Saved List) |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS18367
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                      |
		| Application (Saved List)  |
		| Device (Saved List)       |
		| Device Owner (Saved List) |
		| User (Saved List)         |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS18367
Scenario: EvergreenJnr_MailboxesList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "Mailbox (Saved List)" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS18065
Scenario: EvergreenJnr_DevicesList_CheckThatThereIsNoTooltipsForChipsInFilterPanel
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Hostname" filter
	When User select "Equals" Operator value
	When User enters "Text1" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then following chips value displayed for 'Hostname' textbox
		| ChipValue |
		| Text1     |
	Then tooltip is not displayed for 'Text1' chip of 'Hostname' textbox
	When User enters "Text2" text in Search field at selected Filter
	When User clicks Add button for input filter value
	When User enters "Text3" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then following chips value displayed for 'Hostname' textbox
		| ChipValue |
		| Text1     |
		| Text2     |
		| 1 more    |
	Then tooltip is not displayed for '1 more' chip of 'Hostname' textbox

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS19348
Scenario: EvergreenJnr_MailboxesList_CheckThatNewRecipientTypeColumnDisplayedCorrectly
	When User clicks 'Mailboxes' on the left-hand menu
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
		| ColumnName     |
		| Recipient Type |
	Then ColumnName is added to the list
		| ColumnName     |
		| Recipient Type |
	When User clicks the Filters button
	When User add "Recipient Type" filter where type is "Does not equal" without added column and "Empty" Lookup option
	Then "Recipient Type" filter is added to the list
	Then Column headers are displayed in high contrast
	Then Text content of 'Recipient Type' column is displayed in High Contrast
	#translation
	When User language is changed to "Test Language" via API
	Then grid headers are displayed in the following order
		| ColumnName |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |
		| [9999999]  |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS18759 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewGroupsFilterIsDisplayedCorrectly
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User closes "Suggested" filter category
	Then Category with counter is displayed on Filter panel
		| Category | Number |
		| Group    | 8      |
	When User expands "Group" filter category
	Then the following Filters subcategories are displayed for open category:
		| Subcategories      |
		| Group              |
		| Group Description  |
		| Group Display Name |
		| Group Domain       |
		| Group Member Count |
		| Group Name         |
		| Group Type         |
		| Group Username     |
	When user select "Group" filter
	Then "50 of 4510 shown" results are displayed in the Filter panel
	When User enters "AU\GAPP-A0121127" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User enters "AU\GAPP-A012116D" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User enters "AU\GAPP-A01211A7" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	Then following chips value displayed for 'Search' textbox
		| ChipValue        |
		| AU\GAPP-A0121127 |
		| AU\GAPP-A012116D |
		| 1 more           |
	#SZ: should be uncommented after adding Member placeholder
	#When User selects 'Not a member' in the 'Member' dropdown
	When User clicks 'ADD' button
	Then There are no errors in the browser console
	When User create dynamic list with "GroupList18759" name on "Devices" page
	Then "GroupList18759" list is displayed to user

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS19773
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoUnknownOptionAvailableForDeviceFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Device" filter
	When User enters "Unknown" text in Search field at selected Lookup Filter
	Then No options are displayed for selected Lookup Filter