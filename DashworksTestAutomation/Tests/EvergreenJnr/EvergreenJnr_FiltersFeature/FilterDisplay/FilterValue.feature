Feature: FilterValue
	Runs filtered value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

 @Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13383 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatColorsInReadinessFilterAreDisplayedCorrectlyAfterSavingList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Readiness" filter where type is "Equals" with added column and Lookup option
		| SelectedValues |
		| Blocked        |
		| Amber          |
	And User creates 'CheckColors13383' dynamic list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "2004: Readiness" filter
	Then color for following values are displayed correctly:
		| Color   |
		| Blocked |
		| Amber   |

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
		| 2004: Pre-Migration \ Scheduled Date (Slot) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "2004: Pre-Migration \ Scheduled Date (Slot)" filter
	And User select "Equals" Operator value
	And User enters "Empty" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then Column '2004: Pre-Migration \ Scheduled Date (Slot)' with no data displayed

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
	When User selects "2004: Owner (Saved List)" filter from "Saved List" category
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