Feature: Categories
	Runs Filter Categories related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

@Evergreen @Devices @EvergreenJnr_Search @Search @DAS11466
Scenario: EvergreenJnr_DevicesList_CheckingThatVendorFilterIsDisplayedInApplicationCategory
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Vendor" filter from "Application" category
	Then setting section for "Application Vendor" filter is loaded

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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS12100
Scenario: EvergreenJnr_DevicesList_CheckThatMailboxOwnerFilterCategoryIsNotDisplayedOnDeviceList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	Then "Mailbox Owner" section is not displayed in the Filter panel

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
		| Hide From End Users             |
		| In Catalog                      |

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
		| Organisational Unit           |
		| Parent Distinguished Name     |
		| Primary Device                |
		| SID                           |
		| Surname                       |
		| User (Saved List)             |
		| User Application Compliance   |
		| User Key                      |

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
		| Device Owner Organisational Unit       |
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

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_DevicesList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 12     |
	| Project Owner: Windows7Mi  | 12     |
	| Project Tasks: Windows7Mi  | 91     |
	| Project Stages: Windows7Mi | 7      |
	| Project: UserEvergr        | 11     |
	| Project Owner: UserEvergr  | 12     |
	| Project Tasks: UserEvergr  | 12     |
	| Project Stages: UserEvergr | 1      |
	And Category is not displayed in the Filter panel
	| Category                   |
	| Project: EmailMigra        |
	| Project Tasks: EmailMigra  |
	| Project Stages: EmailMigra |

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_UsersList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 11     |
	| Project Tasks: Windows7Mi  | 79     |
	| Project Stages: Windows7Mi | 6      |
	| Project: UserEvergr        | 12     |
	| Project Tasks: UserEvergr  | 26     |
	| Project Stages: UserEvergr | 2      |
	| Project: EmailMigra        | 11     |
	| Project Tasks: EmailMigra  | 9      |
	| Project Stages: EmailMigra | 3      |

@Evergreen @Applicatios @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_ApplicationsList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: Windows7Mi        | 23     |
	#| Project User: Windows7Mi   | 12     |
	#| Project Device: Windows7Mi | 13     |
	| Project Tasks: Windows7Mi  | 24     |
	| Project Stages: Windows7Mi | 2      |
	| Project: UserEvergr        | 23     |
	#| Project User: UserEvergr   | 12     |
	#| Project Device: UserEvergr | 13     |
	| Project Tasks: UserEvergr  | 14     |
	| Project Stages: UserEvergr  | 1      |
	| Project: EmailMigra        | 23     |
	#| Project User: EmailMigra   | 12     |
	| Project Tasks: EmailMigra  | 5      |
	| Project Stages: EmailMigra | 1      |

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14969 @archived
Scenario: EvergreenJnr_MailboxesList_ChecksThatFilterPanelDoesHaveAndNotHaveListedCategories
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Category with counter is displayed on Filter panel
	| Category                   | Number |
	| Project: EmailMigra        | 11     |
	| Project Tasks: EmailMigra  | 54     |
	| Project Stages: EmailMigra | 6      |
	| Project: MailboxEve        | 11     |
	| Project Tasks: MailboxEve  | 15     |
	And Category is not displayed in the Filter panel
	| Category                   |
	| Project: Windows7Mi        |
	| Project Tasks: Windows7Mi  |
	| Project Stages: Windows7Mi |
	| Project: UserEvergr        |
	| Project Tasks: UserEvergr  |
	| Project Stages:UserEvergr  |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_DevicesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: 1803       | 1      |
	| Project Rings: Babel(Engl | 1      |
	| Project Rings: ComputerSc | 1      |
	| Project Rings: DeviceSche | 1      |
	| Project Rings: Havoc(BigD | 1      |
	| Project Rings: ICSP       | 1      |
	| Project Rings: prK        | 1      |
	| Project Rings: Windows101 | 1      |
	| Project Rings: Windows102 | 1      |
	| Project Rings: Windows10T | 1      |
	| Project Rings: Windows10U | 1      |
	| Project Rings: Windows7Mi | 1      |

@Evergreen @Users @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_UsersList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: Barry'sUse | 1      |
	| Project Rings: UserEvergr | 1      |
	| Project Rings: UserSched2 | 1      |
	| Project Rings: UserSchedu | 1      |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_MailboxesList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category                  | Number |
	| Evergreen                 | 1      |
	| Project Rings: EmailMigra | 1      |
	| Project Rings: MailboxEve | 1      |

@Evergreen @Applications @Evergreen_FiltersFeature @FilterFunctionality @DAS15140
Scenario: EvergreenJnr_ApplicationsList_ChecksThatOnlyRingsCategoryOfSameTypeProjectAreAvailableInPanel
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "ring" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category            | Number |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17411
Scenario Outline: EvergreenJnr_Lists_CheckThatProjectNameIsNotDisplayedForNotDevicesList
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Columns button
	And User enters "Windows7Mi: Name" text in Search field at Columns Panel
	Then Category with counter is displayed on Columns panel
	| Category            | Number |

	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User enters "Windows7Mi: Name" text in Search field at Filters Panel
	Then Category with counter is displayed on Filter panel
	| Category            | Number |

Examples: 
	| ListName		| 
	| Applications	| 
	| Mailboxes		| 
	| Users			|

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS13183
Scenario: EvergreenJnr_UsersList_CheckThatApplicationManufacturerFilterChangedToApplicationVendor
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	Then "Application Manufacturer" filter is not presented in the filters list
	And "Application Vendor" filter is presented in the filters list