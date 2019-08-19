Feature: ItemDetailsContent_ActionsWithFields
	Runs Item Details Content Actions With Fields related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14941 @DAS12963
Scenario: EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks content of Evergreen Ring in Project Summary section on the Details Page
	And User clicks New Ring ddl in popup of Project Summary section on the Details Page
	Then Rings ddl contains data on Project Summary section of the Details Page
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12690 @DAS14923
Scenario: EvergreenJnr_DevicesList_CheckThatLinksInDeviceDetailsAreRedirectedToTheRelevantUserDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001PSUMZYOW581"
	And User click content from "Hostname" column
	When User navigates to the "Details" main-menu on the Details page
	When User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "Tricia G. Huang" link on the Details Page
	Then Details page for "LFA418191 (Tricia G. Huang)" item is displayed to the user

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13341 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatTextInKeyValueGridsIsSelectableOnDetailsPage
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<MainTabName>" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	And User selects "<KeyToBeSelected>" text from key value grid on the Details Page
	Then "<KeyToBeSelected>" text selected from key value grid on the Details Page
	When User selects "<ValueToBeSelected>" text from key value grid on the Details Page
	Then "<ValueToBeSelected>" text selected from key value grid on the Details Page

Examples:
	| PageName     | SearchTerm                       | ColumnName    | MainTabName   | SubTabName    | KeyToBeSelected | ValueToBeSelected   |
	| Devices      | 02C80G8RFTPA9E                   | Hostname      | Specification | Specification | Manufacturer    | FES0798481167       |
	| Devices      | 05PFM2OWVCSCZ1                   | Hostname      | Details       | Device        | Hostname        | 05PFM2OWVCSCZ1      |
	| Users        | 03714167684E45F7A8F              | Username      | Details       | User          | Username        | 03714167684E45F7A8F |
	| Applications | Adobe Acrobat Reader 5.0         | Application   | Details       | Application   | Vendor          | Adobe               |
	| Mailboxes    | 06D7AE4F161F4A3AA7F@bclabs.local | Email Address | Details       | Mailbox       | Alias           | 06D7AE4F161F4A3AA7F |

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
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "Joel T. Hartman"
	And User click content from "Email Address" column
	When User navigates to the "Details" main-menu on the Details page
	When User navigates to the "Mailbox Owner" sub-menu on the Details page
	And User clicks "hartmajt" link on the Details Page
	Then Details object page is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17180
Scenario: EvergreenJnr_DevicesList_CheckThatTheLinkCanBeOpenedAndTheLinkHasARightFormatWithAProjectIdAtTheEnd
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	And User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And URL contains "user/23726/details/user"
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	And User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Device Owner" sub-menu on the Details page
	And User clicks "QLL295118" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	And URL contains "user/23726/details/user?$projectId=43"
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	When User navigates to the "Applications" main-menu on the Details page
	And User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed to the user
	And "Havoc (Big Data)" project is selected in the Top bar on Item details page
	And URL contains "application/373/details/application?$projectId=43"

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @DAS17093 @Cleanup
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenBucketFieldInTheProjectsResumeWorksCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "Bucket12883" in the "Bucket Name" field
	And User selects "My Team" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	#============================================================================#
		#go to Devices page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "01ERDGD48UDQKE"
	And User click content from "Hostname" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	And User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	And User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0845467C65E5438D83E@bclabs.local"
	And User click content from "Email Address" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	
@Evergreen @AllLists @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Cleanup
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenCapacityUnitFieldInTheProjectsResumeWorksCorrectly
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| CapacityUnit12883 | Devices     | false     |
	#============================================================================#
		#go to Devices page
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "ZZNKKYW97AL4VS"
	And User click content from "Hostname" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0845467C65E5438D83E@bclabs.local"
	And User click content from "Email Address" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	And User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13679 @DAS14216 @DAS14923 @DAS17093 @DAS17093 @DAS17236
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectSummarySectionIsDisplayedSuccessfully
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User clicks content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Evergreen Details" sub-menu on the Details page
	Then field with "Project Count" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Bucket" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Capacity Unit" text is displayed in expanded tab on the Details Page
	And field with "Evergreen Ring" text is displayed in expanded tab on the Details Page
	And There are no errors in the browser console

Examples:
	| ListName  | ItemName                         | ColumnName    |
	| Devices   | 00HA7MKAVVFDAV                   | Hostname      |
	| Users     | 0072B088173449E3A93              | Username      |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address |

@Evergreen @DevicesLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14973
Scenario: EvergreenJnr_DevicesList_CheckDeviceTabUIOnTheDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Details" main-menu on the Details page
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00OMQQXWA1DRI6"
	And User click content from "Hostname" column
	Then Details page for "00OMQQXWA1DRI6" item is displayed to the user
	When User navigates to the "Active Directory" main-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields                          |
	| Directory Type                  |
	| Domain                          |
	| Fully Distinguished Object Name |
	| Common Name                     |
	| Display Name                    |
	| Description                     |
	Then "00OMQQXWA1DRI6" content is displayed in "Common Name" field on Item Details page

	#Ann.Ilchenko 8/15/19: will be ready on 'quasar'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16859 @DAS17645 @DAS17785 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForDeviceObjects
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
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

	#Ann.Ilchenko 8/15/19: will be ready on 'quasar'
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16858 @DAS17160 @DAS17325 @DAS17645 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForUserObjects
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
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

	#Ann.Ilchenko 8/15/19: will be ready on 'quasar'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16861 @DAS17158 @DAS17239 @DAS17645 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForApplicationObjects
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	And User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields              |
	| Object ID           |
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

	#Ann.Ilchenko 8/15/19: will be ready on 'quasar'
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16957 @DAS17645 @DAS17785 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectDetailsDefaultViewIsDisplayedCorrectlyForMailboxObjects
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00A5B910A1004CF5AC4@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00A5B910A1004CF5AC4@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following fields are displayed in the open section:
	| Fields           |
	| Object ID        |
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then field with "Self Service URL" text is not displayed in expanded tab on the Details Page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then field with "Self Service URL" text is displayed in expanded tab on the Details Page
	Then following content is displayed on the Details Page
	| Title    | Value   |
	| Language | English |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11510
Scenario: EvergreenJnr_DevicesList_CheckThatLastLogoffDateFieldIsNotDisplayedAtTheDeviceOwnerBlockOfDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Details" main-menu on the Details page
	And User navigates to the "Device Owner" sub-menu on the Details page
	Then field with "Last Logoff Date" text is not displayed in expanded tab on the Details Page