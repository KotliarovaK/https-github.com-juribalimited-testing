Feature: CheckingExistingFields
	Runs Item Details Checking Existing Fields related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15889 @DAS16378
Scenario: EvergreenJnr_DevicesList_CheckThatCommonNameFieldIsDisplayedInTheComputerAdObjectSection
	When User navigates to the 'Device' details page for '00OMQQXWA1DRI6' item
	Then Details page for '00OMQQXWA1DRI6' item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	Then following fields are displayed in the open section:
	| Fields                          |
	| Directory Type                  |
	| Domain                          |
	| Fully Distinguished Object Name |
	| Common Name                     |
	| Display Name                    |
	| Description                     |
	Then following content is displayed on the Details Page
	| Title       | Value          |
	| Common Name | 00OMQQXWA1DRI6 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16859 @DAS17645 @DAS17785 @DAS17809 @DAS18095 @DAS18011 @DAS17810
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForDeviceObjects
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then "Windows 7 Migration (Computer Scheduled Project)" project is selected in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#Ann.I 11/14/19: hidden for Spectrum (DAS-18877)
	#| App Owner        |
	| Device Owner     |
	| Readiness        |
	| Path             |
	| Team             |
	| Bucket           |
	| Capacity Unit    |
	| Ring             |
	| Category         |
	| Self Service URL |
	| Tags             |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16858 @DAS17160 @DAS17325 @DAS17645 @DAS17809 @DAS18095 @DAS18011 @DAS17810
Scenario: EvergreenJnr_UsersList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForUserObjects
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#Ann.I 11/14/19: hidden for Spectrum (DAS-18877)
	#| App Owner        |
	| Primary Device   |
	| Readiness        |
	| Path             |
	| Team             |
	| Bucket           |
	| Capacity Unit    |
	| Ring             |
	| Category         |
	| Self Service URL |
	| Language         |
	| Tags             |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16861 @DAS17158 @DAS17239 @DAS17645 @DAS17809 @DAS18095 @DAS18011 @DAS17810
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForApplicationObjects
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following fields are displayed in the open section:
	| Fields              |
	| Object ID           |
	| Name                |
	| App Owner           |
	| Readiness           |
	| App Readiness       |
	| App Rationalisation |
	| Target App          |
	| Primary App         |
	| Hide From End Users |
	| Path                |
	| Team                |
	| Capacity Unit       |
	| Category            |
	| Tags                |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16957 @DAS17645 @DAS17785 @DAS17809 @DAS18095 @DAS18011 @DAS17810
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForMailboxObjects
	When User navigates to the 'Mailbox' details page for '00A5B910A1004CF5AC4@bclabs.local' item
	Then Details page for '00A5B910A1004CF5AC4@bclabs.local' item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#Ann.I 11/14/19: hidden for Spectrum (DAS-18877)
	#| App Owner        |
	| Mailbox Owner    |
	| Readiness        |
	| Path             |
	| Team             |
	| Bucket           |
	| Capacity Unit    |
	| Ring             |
	| Category         |
	| Self Service URL |
	| Language         |
	| Tags             |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11510
Scenario: EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	Then field with "Last Logoff Date" text is not displayed in expanded tab on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17775
Scenario: EvergreenJnr_MailboxesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheMailboxOwnerBlockOfDeviceDetails
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.loca' item is displayed to the user
	When User navigates to the 'Mailbox Owner' left submenu item
	Then field with "Last Logoff Date" text is not displayed in expanded tab on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17735
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsANotAppearInConsoleWhenNavigatingToTheMaterialTableOnObjectDetails
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Details' left menu item
	And User navigates to the 'Device' left submenu item
	Then following fields are displayed in the open section:
	| Fields                    |
	| Key                       |
	| Hostname                  |
	| Source                    |
	| Source Type               |
	| Inventory Site            |
	| Dashworks First Seen Date |
	Then There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18162 @DAS17394
Scenario Outline: EvergreenJnr_AllLists_CheckThatDomainFieldIsDisplayedOnSelectedPages
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for '<ItemName>' item is displayed to the user
	When User navigates to the '<SubTabName>' left submenu item
	Then following fields are displayed in the open section:
	| Fields                    |
	| Key                       |
	| Directory Type            |
	| Domain                    |
	| Username                  |
	| Common Name               |
	| Distinguished Name        |
	| Display Name              |
	| SID                       |
	| GUID                      |
	| Last Logon Date           |
	| Compliance                |
	| Enabled                   |
	| Parent Distinguished Name |
	| Given Name                |
	| Surname                   |
	| Description               |
	| Home Drive                |
	| Home Directory            |
	| Email Address             |

Examples: 
	| PageName    | ItemName                | SubTabName        |
	| Device      | 00YTY8U3ZYP2WT          | Device Owner      |
	| User        | 013DA2178AB4444CAF2     | User              |
	#Ann.Ilchenko 10/24/19: delete the hash when Lena will update the gold data.
	#| Application | Acrobat Reader 6.0.1    | Application Owner |
	| Mailbox     | ZGF0027767@bclabs.local | Mailbox Owner     |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983 @DAS11926 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the '<SubMenuName>' left submenu item
	Then Empty rows are displayed if the data is unknown

Examples:
	| PageName  | SelectedName                     | ColumnName    | SubMenuName             |
	| Devices   | 00K4CEEQ737BA4L                  | Hostname      | Department and Location |
	| Users     | $231000-3AC04R8AR431             | Username      | Department and Location |
	| Mailboxes | aaron.u.flores@dwlabs.local      | Email Address | Department and Location |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox                 |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13679 @DAS14216 @DAS14923 @DAS17093 @DAS17093 @DAS17236
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectSummarySectionIsDisplayedSuccessfully
	When User navigates to the '<ListName>' details page for '<ItemName>' item
	Then Details page for '<ItemName>' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following fields are displayed in the open section:
	| Fields                  |
	| Project Count           |
	| Evergreen Bucket        |
	| Evergreen Capacity Unit |
	| Evergreen Ring          |
	And There are no errors in the browser console

Examples:
	| ListName | ItemName                         |
	| Device   | 00HA7MKAVVFDAV                   |
	| User     | 0072B088173449E3A93              |
	| Mailbox  | 000F977AC8824FE39B8@bclabs.local |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18423
Scenario: EvergreenJnr_DevicesList_CheckThatSpecificationTabForDevicesWithDeviceTypeOtherIsDisplayedCorrectly
	When User navigates to the 'Device' details page for '2B35YERQEMAYHYUE' item
	Then Details page for '2B35YERQEMAYHYUE' item is displayed to the user
	When User navigates to the 'Specification' left menu item
	Then following fields are displayed in the open section:
	| Fields                       |
	| Manufacturer                 |
	| Model                        |
	| Device Type                  |
	| Device Format                |
	| OS Full Name                 |
	| Operating System             |
	| OS Version Number            |
	| OS Architecture              |
	| Service Pack or Build        |
	| OS Branch                    |
	| OS Servicing State           |
	| Serial Number                |
	| First Seen Date              |
	| Last Seen Date               |
	| Build Date                   |
	| Boot Up Date                 |
	| Warranty Date                |
	| Memory (GB)                  |
	| HDD Count                    |
	| HDD Total Size (GB)          |
	| Target Drive Free Space (GB) |
	| BIOS Manufacturer            |
	| BIOS Name                    |
	| BIOS Version                 |
	| Secure Boot Enabled          |
	| TPM Enabled                  |
	| TPM Version                  |
	Then There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18850
Scenario: EvergreenJnr_ApplicationsList_ChecksThatFieldsAreDisplayedCorrectlyForEvergreenDetailsTab
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following fields are displayed in the open section:
	| Fields                  |
	| Project Count           |
	| Evergreen Capacity Unit |
	| In Catalog              |
	| Criticality             |
	| Rationalisation         |
	| Hide From End User      |