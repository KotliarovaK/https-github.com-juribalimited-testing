﻿Feature: ItemDetails_CopyActions
	Runs Copy Actions related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetails_CopyActions @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyCellWorksInItemDetails
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the '<MainTabName>' left menu item
	When User navigates to the '<SubTabName>' left submenu item
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
	And User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples:
	| PageName    | SearchTerm                                              | MainTabName      | SubTabName        | ColumnName  | TargetCell    |
	| Device      | 30BGMTLBM9PTW5                                          | Applications     | Evergreen Summary | Application | Access 95     |
	| User        | svc_dashworks                                           | Active Directory | Groups            | Group       | Domain Users  |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | MSI              | MSI Files         | File Name   | setup_x86.msi |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Users            | Users             | Username    | floresau      |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetails_CopyActions @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedMainTab
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the '<MainTabName>' left menu item
	When User navigates to the '<SubTabName>' left submenu item
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName | SearchTerm          | MainTabName      | SubTabName        | TargetCell   | ColumnName  | ExpectedData                                                     |
	| Device   | 30BGMTLBM9PTW5      | Applications     | Evergreen Summary | Access 95    | Application | Access 95   Microsoft      Green   True   Unknown   True         |
	| User     | 003F5D8E1A844B1FAA5 | Active Directory | Groups            | Domain Users | Group       | Domain Users   BCLABS   Global Security Group   All domain users |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetails_CopyActions @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedSabTab
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the '<SubTabName>' left submenu item
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName    | SearchTerm             | SubTabName      | TargetCell | ColumnName | ExpectedData                         |
	| Application | ACD Display 3.4        | Programs        | Install    | Program    | Install   setup.exe /q               |
	| Mailbox     | Zurong.Wu@bclabs.local | Email Addresses | SMTP       | Type       | SMTP   Zurong.Wu@bclabs.local   True |

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedMainMenu
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then '<KeyToBeSelected>' text is highlighted
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then '<ValueToBeSelected>' text is highlighted

Examples:
	| PageName    | SearchTerm               | MainTabName   | KeyToBeSelected | ValueToBeSelected |
	| Device      | 02C80G8RFTPA9E           | Specification | Manufacturer    | FES0798481167     |
	| Device      | 05PFM2OWVCSCZ1           | Details       | Hostname        | 05PFM2OWVCSCZ1    |
	| User        | 03714167684E45F7A8F      | User          | Domain          | BCLABS            |
	| Application | Adobe Acrobat Reader 5.0 | Details       | Vendor          | Adobe             |

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenu
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for '<SearchTerm>' item is displayed to the user
	When User navigates to the '<SubTabName>' left submenu item
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then '<KeyToBeSelected>' text is highlighted
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then '<ValueToBeSelected>' text is highlighted

Examples:
	| PageName | SearchTerm                       | SubTabName | KeyToBeSelected | ValueToBeSelected   |
	| Device   | 05PFM2OWVCSCZ1                   | Device     | Hostname        | 05PFM2OWVCSCZ1      |
	| User     | 03714167684E45F7A8F              | User       | Domain          | BCLABS              |
	| Mailbox  | 06D7AE4F161F4A3AA7F@bclabs.local | Mailbox    | Alias           | 06D7AE4F161F4A3AA7F |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @archived
Scenario: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	When User selects "Description" text from key value grid on the Details Page
	Then 'Description' text is highlighted
	When User selects "Unknown" text from key value grid on the Details Page
	Then 'Unknown' text is highlighted