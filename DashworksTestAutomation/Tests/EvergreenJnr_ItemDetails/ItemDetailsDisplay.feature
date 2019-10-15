@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12386 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatHyperlinkForKeyColumnsIsRedirectedToTheRelevantDetailsPage
	When User add following columns using URL to the "<PageName>" page:
	| ColumnName |
	| <Column>   |
	Then Content is present in the newly added column
	| ColumnName |
	| <Column>   |
	When User perform search by "<ItemName>"
	When User click content from "<Column>" column
	Then Details page for "<ItemName>" item is displayed to the user
	And URL is "<URLpart>"

Examples:
	| PageName     | Column          | ItemName                         | URLpart                                         |
	| Devices      | Device Key      | 00KLL9S8NRF0X6                   | evergreen/#/device/8892/details/device          |
	| Users        | User Key        | 0072B088173449E3A93              | evergreen/#/user/85167/details/user             |
	| Applications | Application Key | ACDSee for Windows 95            | evergreen/#/application/312/details/application |
	| Mailboxes    | Mailbox Key     | 01BC4B0500344065B61@bclabs.local | evergreen/#/mailbox/45374/details/mailbox       |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyCellWorksInItemDetails
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the '<MainTabName>' left menu item
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples:
	| PageName    | SearchTerm                                              | MainTabName      | SubTabName        | SelectedColumn | TargetCell    |
	| Device      | 30BGMTLBM9PTW5                                          | Applications     | Evergreen Summary | Application    | Access 95     |
	| User        | svc_dashworks                                           | Active Directory | Groups            | Group          | Domain Users  |
	| Application | Microsoft Office Visio 2000 Solutions - Custom Patterns | MSI              | MSI Files         | File Name      | setup_x86.msi |
	| Mailbox     | aaron.u.flores@dwlabs.local                             | Users            | Users             | Username       | floresau      |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedMainTab
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the '<MainTabName>' left menu item
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName | SearchTerm          | MainTabName      | SubTabName        | TargetCell   | ExpectedData                                                     |
	| Device   | 30BGMTLBM9PTW5      | Applications     | Evergreen Summary | Access 95    | Access 95   Microsoft      Green   True   Unknown   True         |
	| User     | 003F5D8E1A844B1FAA5 | Active Directory | Groups            | Domain Users | Domain Users   BCLABS   Global Security Group   All domain users |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedSabTab
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName    | SearchTerm             | MainTabName | SubTabName      | TargetCell | ExpectedData                         |
	| Application | ACD Display 3.4        | Details     | Programs        | Install    | Install   setup.exe /q               |
	| Mailbox     | Zurong.Wu@bclabs.local | Details     | Email Addresses | SMTP       | SMTP   Zurong.Wu@bclabs.local   True |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15133
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsSummaryRowCanBeCopied
	When User navigates to the 'Device' details page for '00BDM1JUR8IF419' item
	When User navigates to the 'Applications' left menu item
	When User performs right-click on "egcs-objc" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'egcs-objc   Red Hat   1.1.2   Red   Unknown   True   False' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16067 DAS18535
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsInTheApplicationColumnAreLinksAndAfterClickingUserIsRedirectedCorrectApplication
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	When User navigates to the 'Applications' left menu item
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then table content is present
	When User enters "Microsoft Internet Explorer" text in the Search field for "Application" column
	When User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed correctly

	#upd Ann.Ilchenko 7.11.19: ready for 'radiant'(?)
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16322 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatActionPanelImplementedForItemDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then "ADD USERS" Action button is displayed
	Then Actions drop-down is displayed on the Item Details page
	When User clicks Actions button on the Item Details page
	When User clicks "Remove" button in Actions drop-down on the Item Details page
	Then "REMOVE" Action button is displayed 

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16338
Scenario: EvergreenJnr_DevicesList_CheckThatCrumbTrailElementInTheHeaderOfThePageIsDisplayed
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User clicks on "Devices" navigation link
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User clicks on "Users" navigation link
	Then 'All Users' list should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User clicks on "Applications" navigation link
	Then 'All Applications' list should be displayed to the user
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User clicks on "Mailboxes" navigation link
	Then 'All Mailboxes' list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17086
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsOpenedCorrectlyWithSameKeyAndUserValues
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User clicks "Nicole P. Braun" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data  |
	| Key   | 23726 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17300
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsSimilarOnGridAndDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then 'QLL295118' content is displayed in the 'Username' column
	And 'US-E' content is displayed in the 'Domain' column
	And 'Nicole P. Braun' content is displayed in the 'Display Name' column
	And 'QLL295118.Users.Jersey City.US-E.local' content is displayed in the 'Distinguished Name' column
	When User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And User verifies data in the fields on details page
	| Field              | Data                                   |
	| Username           | QLL295118                              |
	| Domain             | US-E                                   |
	| Display Name       | Nicole P. Braun                        |
	| Distinguished Name | QLL295118.Users.Jersey City.US-E.local |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17813
Scenario: EvergreenJnr_UsersList_CheckThatToolTipForMailboxPermissionOnMailboxPermissionsTabOnUserObjectPageIsDisplayedCorrectly
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User navigates to the 'Mailboxes' left menu item
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	When User enters "Exchange 2007" text in the Search field for "Mailbox Platform" column
	Then "FullAccess" content is displayed in "Permission" column
	And "FullAccess" tooltip displayed in "Permission" column