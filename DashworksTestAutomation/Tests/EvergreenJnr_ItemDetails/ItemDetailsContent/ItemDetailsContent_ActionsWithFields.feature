Feature: ItemDetailsContent_ActionsWithFields
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
	When User navigates to the 'Device Owner' left submenu item
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
	| PageName    | SearchTerm               | MainTabName   | KeyToBeSelected | ValueToBeSelected |
	| Device      | 02C80G8RFTPA9E           | Specification | Manufacturer    | FES0798481167     |
	| Device      | 05PFM2OWVCSCZ1           | Details       | Hostname        | 05PFM2OWVCSCZ1    |
	| User        | 03714167684E45F7A8F      | User          | Domain          | BCLABS            |
	| Application | Adobe Acrobat Reader 5.0 | Details       | Vendor          | Adobe             |

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPageOnSelectedSubMenu
	When User navigates to the '<PageName>' details page for '<SearchTerm>' item
	Then Details page for "<SearchTerm>" item is displayed to the user
	When User navigates to the '<SubTabName>' left submenu item
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then "<KeyToBeSelected>" text selected from key value grid on the Details Page
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then "<ValueToBeSelected>" text selected from key value grid on the Details Page

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
	Then "Description" text selected from key value grid on the Details Page
	When User selects "Unknown" text from key value grid on the Details Page
	Then "Unknown" text selected from key value grid on the Details Page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS12321 @DAS14923
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksInMailboxDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User navigates to the 'Mailbox' details page for 'hartmajt@bclabs.local' item
	Then Details page for "hartmajt@bclabs.local" item is displayed to the user
	When User navigates to the 'Mailbox Owner' left submenu item
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17180
Scenario: EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEnd
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Device Owner' left submenu item
	And User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And URL contains "user/23726/details/user"
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the 'Details' left menu item
	And User navigates to the 'Device Owner' left submenu item
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

#TODO: Ann.Ilchenko 9/4/19: remove 'not_ready' tag when the gold data arrives at the automation server
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17768 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks on 'USE ME FOR AUTOMATION(MAIL SCHDLD)' cell from 'Project' column
	Then Page with 'USE ME FOR AUTOMATION(MAIL SCHDLD)' header is displayed to user
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
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title    | Value  |
	| Language | German |