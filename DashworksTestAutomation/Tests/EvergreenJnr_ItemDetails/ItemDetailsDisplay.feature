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
	When User clicks "<PageName>" on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples:
	| PageName     | SearchTerm                                              | ColumnName    | MainTabName      | SubTabName        | SelectedColumn | TargetCell    |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications     | Evergreen Summary | Application    | Access 95     |
	| Users        | svc_dashworks                                           | Username      | Active Directory | Groups            | Group          | Domain Admins |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI              | MSI Files         | File Name      | setup_x86.msi |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users            | Users             | Username       | floresau      |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedMainTab
	When User clicks "<PageName>" on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName | SearchTerm          | ColumnName | MainTabName      | SubTabName        | TargetCell   | ExpectedData                                                    |
	| Devices  | 30BGMTLBM9PTW5      | Hostname   | Applications     | Evergreen Summary | Access 95    | Access 95   Microsoft   Unknown   Green   True   Unknown   True |
	| Users    | 003F5D8E1A844B1FAA5 | Username   | Active Directory | Groups            | Domain Users | Domain Users   DWLABS   Global Security Group   All domain users|

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetailsOnSelectedSabTab
	When User clicks "<PageName>" on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName     | SearchTerm             | ColumnName    | MainTabName | SubTabName      | TargetCell | ExpectedData                         |
	| Applications | ACD Display 3.4        | Application   | Details     | Programs        | Install    | Install   setup.exe /q               |
	| Mailboxes    | Zurong.Wu@bclabs.local | Email Address | Details     | Email Addresses | SMTP       | SMTP   Zurong.Wu@bclabs.local   True |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15133
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsSummaryRowCanBeCopied
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User performs right-click on "egcs-objc" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'egcs-objc   Red Hat   1.1.2   Red   Unknown   True   False' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16067
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsInTheApplicationColumnAreLinksAndAfterClickingUserIsRedirectedCorrectApplication
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then table content is present
	When User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed correctly

	#upd Ann.Ilchenko 7.11.19: ready for 'pulsar'(?)
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16322 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatActionPanelImplementedForItemDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then "ADD USERS" Action button is displayed
	Then Actions drop-down is displayed on the Item Details page
	When User clicks Actions button on the Item Details page
	When User clicks "Remove" button in Actions drop-down on the Item Details page
	Then "REMOVE" Action button is displayed 

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16338
Scenario: EvergreenJnr_DevicesList_CheckThatCrumbTrailElementInTheHeaderOfThePageIsDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User clicks on "Devices" navigation link
	Then "All Devices" list should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User clicks on "Users" navigation link
	Then "All Users" list should be displayed to the user
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User clicks on "Applications" navigation link
	Then "All Applications" list should be displayed to the user
	When User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User clicks on "Mailboxes" navigation link
	Then "All Mailboxes" list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17086
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsOpenedCorrectlyWithSameKeyAndUserValues
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	And User clicks "Nicole P. Braun" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And User verifies data in the fields on details page
	| Field | Data  |
	| Key   | 23726 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17300
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsSimilarOnGridAndDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
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

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17373
Scenario: EvergreenJnr_ApplicationsList_CheckThatLoadingIndicatorAppearsInTheSamePlace
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "Adobe Acrobat Update"
	And User click content from "Application" column
	Then Details page for "Adobe Acrobat Update" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Details" main-menu on the Details page
	Then Loading indicator appears in the same place when switching between main-menu

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17813
Scenario: EvergreenJnr_UsersList_CheckThatToolTipForMailboxPermissionOnMailboxPermissionsTabOnUserObjectPageIsDisplayedCorrectly
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User navigates to the "Mailboxes" main-menu on the Details page
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	When User enters "Exchange 2007" text in the Search field for "Mailbox Platform" column
	Then "FullAccess" content is displayed in "Permission" column
	And "FullAccess" tooltip displayed in "Permission" column