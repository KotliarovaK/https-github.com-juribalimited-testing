Feature: ItemDetailsContent_ActionsWithFields
	Runs Item Details Content Actions With Fields related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11478 @DAS11477 @DAS11476 @DAS11510 @API
Scenario Outline: EvergreenJnr_AllLists_CheckStateOfSelectedFieldOnDetailsTabOnAPI
	When I perform test request to the "<PageName>" API and get "<ItemName>" item summary for "<SectionName>" section
	Then "<FieldName>" field display state is "<DisplayState>" on Details tab API

Examples:
	| PageName  | ItemName                      | SectionName  | FieldName         | DisplayState |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Mailbox Database  | True         |
	| Mailboxes | alfredo.m.daniel@dwlabs.local | Mailbox      | Cloud Mail Server | False        |
	| Mailboxes | alex.cristea@juriba.com       | Mailbox      | Mail Server       | False        |
	| Devices   | 001BAQXT6JWFPI                | Device Owner | Last Logoff Date  | False        |

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

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17274 @API
Scenario: EvergreenJnr_UserList_CheckThatDataDepartmentAndLocationTabIsDisplayedCorrectly
	When I perform test request to the "Users" API and get "002B5DC7D4D34D5C895" item summary for "Department and Location" section
	Then following fields are displayed with next state on Details tab API
	| FieldName            | DisplayState |
	| Department Name      | True         |
	| Department Full Path | True         |
	| Department Code      | True         |
	| Cost Centre          | True         |
	| Location Name        | True         |
	| Region               | True         |
	| Country              | True         |
	| City                 | True         |
	| Building Name        | True         |
	| Floor                | True         |
	| Address 1            | True         |
	| Address 2            | True         |
	| Address 3            | True         |
	| Address 4            | True         |
	| State/County         | True         |
	| Postal Code          | True         |