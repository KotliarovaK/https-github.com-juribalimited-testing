Feature: ItemDetailsContent_ActionsWithField|
	Runs Item Details Content Actions With Fields related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14941 @DAS12963
Scenario: EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Projects' left menu item
	And User clicks content of Evergreen Ring in Project Summary section on the Details Page
	And User clicks New Ring ddl in popup of Project Summary section on the Details Page
	Then Rings ddl contains data on Project Summary section of the Details Page
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS14923
Scenario: EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for "001PSUMZYOW581" item is displayed to the user
	When User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "Tricia G. Huang" link on the Details Page
	Then Details page for "LFA418191 (Tricia G. Huang)" item is displayed to the user

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedMainMenu
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for "<SearchTerm>" item is displayed to the user
	When User navigates to the '<MainTabName>' left menu item
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then "<KeyToBeSelected>" text selected from key value grid on the Details Page
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then "<ValueToBeSelected>" text selected from key value grid on the Details Page

Examples:
	| PageName    | SearchTerm               | MainTabName   | KeyToBeSelected | ValueToBeSelected   |
	| Device      | 02C80G8RFTPA9E           | Specification | Manufacturer    | FES0798481167       |
	| Device      | 05PFM2OWVCSCZ1           | Details       | Hostname        | 05PFM2OWVCSCZ1      |
	| User        | 03714167684E45F7A8F      | Details       | Username        | 03714167684E45F7A8F |
	| Application | Adobe Acrobat Reader 5.0 | Details       | Vendor          | Adobe               |

	@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenu
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for "<SearchTerm>" item is displayed to the user
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then "<KeyToBeSelected>" text selected from key value grid on the Details Page
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then "<ValueToBeSelected>" text selected from key value grid on the Details Page

Examples:
	| PageName | SearchTerm                       | SubTabName | KeyToBeSelected | ValueToBeSelected   |
	| Device   | 05PFM2OWVCSCZ1                   | Device     | Hostname        | 05PFM2OWVCSCZ1      |
	| User     | 03714167684E45F7A8F              | User       | Username        | 03714167684E45F7A8F |
	| Mailbox  | 06D7AE4F161F4A3AA7F@bclabs.local | Mailbox    | Alias           | 06D7AE4F161F4A3AA7F |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @archived
Scenario: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnGroupDetailsPage
	When User type "NL00G001" in Global Search Field
	Then User clicks on "NL00G001" search result
	When User selects "Description" text from key value grid on the Details Page
	Then "Description" text selected from key value grid on the Details Page
	When User selects "Unknown" text from key value grid on the Details Page
	Then "Unknown" text selected from key value grid on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS12321 @DAS14923
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User navigates to the 'Mailbox' details page for 'hartmajt@bclabs.local' item
	Then Details page for "hartmajt@bclabs.local" item is displayed to the user
	When User navigates to the "Mailbox Owner" sub-menu on the Details page
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17180
Scenario: EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEnd
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And URL contains "user/23726/details/user"
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Details' left menu item
	And User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	And URL contains "user/23726/details/user?$projectId=43"
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	When User navigates to the 'Applications' left menu item
	And User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	And URL contains "application/373/details/application?$projectId=43"

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @DAS17093 @Cleanup
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenBucketFieldInTheProjectsResumeWorksCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks 'CREATE EVERGREEN BUCKET' button 
	Then Page with 'Create Evergreen Bucket' subheader is displayed to user
	When User enters "Bucket12883" in the "Bucket Name" field
	And User selects "My Team" team in the Team dropdown on the Buckets page
	And User clicks 'CREATE' button 
	Then Success message is displayed and contains "The bucket has been created" text
	#============================================================================#
		#go to Devices page
	When User navigates to the 'Device' details page for '01ERDGD48UDQKE' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	And User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	
	#Ann.Ilchenko 8/30/19: Question about link change speed (for "Capacity Unit")
@Evergreen @AllLists @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Cleanup @Not_Run
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenCapacityUnitFieldInTheProjectsResumeWorksCorrectly
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| CapacityUnit12883 | Devices     | false     |
	#============================================================================#
		#go to Devices page
	When User navigates to the 'Device' details page for 'ZZNKKYW97AL4VS' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details object page is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13679 @DAS14216 @DAS14923 @DAS17093 @DAS17093 @DAS17236
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectSummarySectionIsDisplayedSuccessfully
	When User navigates to the '<ListName>' details page for '<ItemName>' item
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Evergreen Details" sub-menu on the Details page
	Then field with "Project Count" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Bucket" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Capacity Unit" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Ring" text is displayed in expanded tab on the Details Page
	And There are no errors in the browser console

Examples:
	| ListName | ItemName                         |
	| Device   | 00HA7MKAVVFDAV                   |
	| User     | 0072B088173449E3A93              |
	| Mailbox  | 000F977AC8824FE39B8@bclabs.local |

@Evergreen @DevicesLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14973
Scenario: EvergreenJnr_DevicesList_CheckDeviceTabUIOnTheDeviceDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Details' left menu item
	Then User verifies data in the fields on details page
	| Field | Data |
	| Key   | 9141 |
	Then following content is displayed on the Details Page
	| Title                     | Value           |
	| Hostname                  | 001BAQXT6JWFPI  |
	| Source                    | A01 SMS (Spoof) |
	| Source Type               | SMS/SCCM 2007   |
	| Inventory Site            | A01             |
	Then empty value is displayed for "Dashworks First Seen Date" field on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15889 @DAS16378
Scenario: EvergreenJnr_DevicesList_CheckThatCommonNameFieldIsDisplayedInTheComputerAdObjectSection
	When User navigates to the 'Device' details page for '00OMQQXWA1DRI6' item
	Then Details page for "00OMQQXWA1DRI6" item is displayed to the user
	When User navigates to the 'Active Directory' left menu item
	Then following fields are displayed in the open section:
	| Fields                          |
	| Directory Type                  |
	| Domain                          |
	| Fully Distinguished Object Name |
	| Common Name                     |
	| Display Name                    |
	| Description                     |
	Then "00OMQQXWA1DRI6" content is displayed in "Common Name" field on Item Details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16859 @DAS17645 @DAS17785 @DAS17809 @DAS18095 @DAS18011 @DAS17810
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForDeviceObjects
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then "Windows 7 Migration (Computer Scheduled Project)" project is selected in the Top bar on Item details page
	When User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#This is not ready on 'automation' server. Ready for 'radiant' (see DAS17810)
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
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#This is not ready on 'automation' server. Ready for 'radiant' (see DAS17810)
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
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
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
	Then Details page for "00A5B910A1004CF5AC4@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
	| Name             |
	#This is not ready on 'automation' server. Ready for 'radiant' (see DAS17810)
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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17007 @DAS17768 @DAS17768
Scenario: EvergreenJnr_AllLists_CheckThatSelfServiceUrlIsNotDisplayedOnObjectDetailsPageEvenWhenItsDisabledInProjectManagement
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then field with "Self Service URL" text is not displayed in expanded tab on the Details Page
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then field with "Self Service URL" text is displayed in expanded tab on the Details Page
	Then following content is displayed on the Details Page
	| Title    | Value   |
	| Language | English |

	#TODO: Ann.Ilchenko 9/4/19: remove 'not_ready' tag when the gold data arrives at the automation server
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17768 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks on 'USE ME FOR AUTOMATION(MAIL SCHDLD)' cell from 'Project' column
	Then Project "USE ME FOR AUTOMATION(MAIL SCHDLD)" is displayed to user
	When User navigates to the 'Details' left menu item
	And User clicks 'ADD LANGUAGE' button 
	And User selects "German" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Email Address" column
	Then Details page for "06BB714696274AC895A@bclabs.local" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title    | Value  |
	| Language | German |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11510
Scenario: EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Device Owner" sub-menu on the Details page
	Then field with "Last Logoff Date" text is not displayed in expanded tab on the Details Page

#Ann.Ilchenko 9/20/19: remove 'not_ready' tag when 'radiant' will be ready
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17775 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheMailboxOwnerBlockOfDeviceDetails
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for "000F977AC8824FE39B8@bclabs.loca" item is displayed to the user
	When User navigates to the "Mailbox Owner" sub-menu on the Details page
	Then field with "Last Logoff Date" text is not displayed in expanded tab on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17735
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsANotAppearInConsoleWhenNavigatingToTheMaterialTableOnObjectDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Details' left menu item
	And User navigates to the "Device" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields                    |
	| Key                       |
	| Hostname                  |
	| Source                    |
	| Source Type               |
	| Inventory Site            |
	| Dashworks First Seen Date |
	Then There are no errors in the browser console

	#Ann.Ilchenko 9/24/19: will be ready after completion Zion Sprint 34
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18162 @DAS17394 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatDomainFieldIsDisplayedOnSelectedPages
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the "<SubTabName>" sub-menu on the Details page
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
	| Application | Acrobat Reader 6.0.1    | Application Owner |
	| Mailbox     | ZGF0027767@bclabs.local | Mailbox Owner     |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11983 @DAS11926 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatRowsInTheTableAreEmptyIfTheDataIsUnknown
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<SelectedName>"
	And User click content from "<ColumnName>" column
	And User navigates to the "<SubMenuName>" sub-menu on the Details page
	Then Empty rows are displayed if the data is unknown

Examples:
	| PageName  | SelectedName                     | ColumnName    | SubMenuName             |
	| Devices   | 00K4CEEQ737BA4L                  | Hostname      | Department and Location |
	| Users     | $231000-3AC04R8AR431             | Username      | Department and Location |
	| Mailboxes | aaron.u.flores@dwlabs.local      | Email Address | Department and Location |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox                 |