@retry:1
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13849
Scenario: EvergreenJnr_DevicesList_CheckThatNoDuplicatedRowsDisplayInDeviceProjectsGridOnProjectsTabOfParticularDevice
	When User clicks "Devices" on the left-hand menu
	And User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then All data is unique in the 'Project' column

@Evergreen @ALlLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12765 @DAS12860
Scenario Outline: EvergreenJnr_AllLists_CheckThatBucketColumnIsDisplayedOnDetailsProjectsPages
	When User clicks "<PageName>" on the left-hand menu
	And User perform search by "<SearchTerm>"
	And User click content from "<Column>" column
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "<SubTabName>" sub-menu on the Details page
	Then "Bucket" column is displayed to the user

Examples:
	| PageName  | SearchTerm                       | Column        | SubTabName              |
	| Devices   | 001BAQXT6JWFPI                   | Hostname      | Owner Projects Summary  |
	| Users     | hurstbl                          | Username      | User Projects           |
	| Users     | hurstbl                          | Username      | Mailbox Project Summary |
	| Users     | ZZZ588323                        | Username      | Device Project Summary  |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address | Mailbox User Projects   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12292
Scenario: EvergreenJnr_DevicesList_CheckingThatInRangeOperatorWorkingCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User type "001PSUMZYOW581" in Global Search Field
	Then User clicks on "001PSUMZYOW581" search result
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User select In Range value with following date:
	| DateFrom    | DateTo      |
	| 22 May 2014 | 22 May 2018 |
	Then Rows counter contains "2" found row of all rows

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13335 @DAS14923 @DAS12963 @DAS16233 @Delete_Newly_Created_Bucket
Scenario: EvergreenJnr_DevicesList_CheckUpdatingDeviceBucketViaRelatedUserProjectSummaryWhenMailboxesSectionIsExpanded
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	And User clicks the "CREATE EVERGREEN BUCKET" Action button
	And User enters "AutoTestBucket_DAS_13335" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	And User clicks "Users" on the left-hand menu
	And User perform search by "AAG081456"
	And User click content from "Username" column
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	And User clicks on "New Bucket" dropdown
	And User select "AutoTestBucket_DAS_13335" value on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Devices"
	And User opens "Related Mailboxes" section on the Details Page
	And User clicks the "UPDATE" Action button
	And User clicks "Devices" on the left-hand menu
	And User perform search by "I55HL8MSBYK0VG"
	And User click content from "Hostname" column
	When User navigates to the "Projects" main-menu on the Details page
	Then User sees "AutoTestBucket_DAS_13335" Evergreen Bucket in Project Summary section on the Details Page
	And There are no errors in the browser console

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

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12805
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsersAndDevicesDistributionListsDoNotIncludeUnknownValues
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Microsoft DirectX 5 DDK"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	And User have opened Column Settings for "User" column in the Details Page table
	And User have select "Sort descending" option from column settings on the Details Page
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values
	When User navigates to the "Devices" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	And User have opened Column Settings for "Device" column in the Details Page table
	And User have select "Sort descending" option from column settings on the Details Page
	Then Content is present in the table on the Details Page
	And Rows do not have unknown values

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @DAS17093 @Delete_Newly_Created_Bucket
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
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	When User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0845467C65E5438D83E@bclabs.local"
	And User click content from "Email Address" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Bucket12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	
@Evergreen @AllLists @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Delete_Newly_Created_Capacity_Unit
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
	When User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "00DBB114BE1B41B0A38"
	And User click content from "Username" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0845467C65E5438D83E@bclabs.local"
	And User click content from "Email Address" column
	Then Details object page is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "CapacityUnit12883" link is displayed on the Details Page
	Then There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "[Unassigned]" value on the Details Page
	When User clicks the "UPDATE" Action button
	Then "Unassigned" link is displayed on the Details Page
	Then There are no errors in the browser console

@Evergreen @Applications @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13180
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDevicesUsersUsedQuantityMatchEachOtherOnApplicationTabAndApplicationDistributionTab
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Device Count (Used) |
	| User Count (Used)   |
	Then ColumnName is added to the list
	| ColumnName          |
	| Device Count (Used) |
	| User Count (Used)   |
	When User perform search by "Microsoft DirectX 5 DDK"
	Then "99" content is displayed in "Device Count (Used)" column
	And "98" content is displayed in "User Count (Used)" column
	When User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	And User closes Checkbox filter for "Used" column
	Then Rows counter shows "98" of "194" rows
	When User navigates to the "Devices" sub-menu on the Details page
	And User clicks String Filter button for "Used" column
	And User clicks "False" checkbox from String Filter on the Details Page
	And User clicks "Unknown" checkbox from String Filter on the Details Page
	Then Rows counter shows "99" of "173" rows

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13679 @DAS14216 @DAS14923 @DAS17093 @DAS17093 @DAS17236
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectSummarySectionIsDisplayedSuccessfully
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	When User clicks content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Evergreen Details" sub-menu on the Details page
	Then field with "Project Count" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Bucket" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Capacity Unit" text is displayed in expanded tab on the Details Page
	Then field with "Evergreen Ring" text is displayed in expanded tab on the Details Page
	And There are no errors in the browser console

Examples:
	| ListName  | ItemName                         | ColumnName    |
	| Devices   | 00HA7MKAVVFDAV                   | Hostname      |
	| Users     | 0072B088173449E3A93              | Username      |
	| Mailboxes | 000F977AC8824FE39B8@bclabs.local | Email Address |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14431
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNoConsoleErrorDisplayedAndMenuPositionStaysTheSameWhenSettingDeliveryDate
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	And User click content from "Application" column
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects" sub-menu on the Details page
	And User have opened Column Settings for "Delivery Date" column in the Details Page table
	And User clicks Filter button on the Column Settings panel
	And User remembers the date input position
	And User select criteria with following date:
	| Criteria  | Date     |
	| Not Equal | 23032018 |
	Then User checks that date input has same position
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyCellWorksInItemDetails
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
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
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI              | MSIFiles          | File Name      | setup_x86.msi |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users            | Users             | Username       | floresau      |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatCopyRowWorksInItemDetails
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<SearchTerm>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<TabName>" main-menu on the Details page
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied
	
Examples:
	| PageName     | SearchTerm                                              | ColumnName    | TabName      | SelectedColumn | TargetCell    | ExpectedData          |
	| Devices      | 30BGMTLBM9PTW5                                          | Hostname      | Applications | Application    | Access 95     | !should be scpecified |
	| Users        | svc_dashworks                                           | Username      | Groups       | Group          | Domain Admins | !should be scpecified |
	| Applications | Microsoft Office Visio 2000 Solutions - Custom Patterns | Application   | MSI          | File Name      | setup_x86.msi | !should be scpecified |
	| Mailboxes    | aaron.u.flores@dwlabs.local                             | Email Address | Users        | Username       | floresau      | !should be scpecified |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15133
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsSummaryRowCanBeCopied
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User performs right-click on "Advantage Data Architect" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data 'Advantage Data Architect\tUnknown\tExtended Systems\tGreen\tSMS_GEN\tUnknown\tTrue\tFalse\t\t\t5200\t75518\t10 Jan 2018' is copied

@Evergreen @UsersLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15522
Scenario: EvergreenJnr_UsersList_ChecksThatNoErrorsAreDisplayedAfterClickingThroughTheProjectNameFromObjectDetails
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "TON2490708"
	And User click content from "Username" column
	Then Details page for "TON2490708" item is displayed to the user
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Device Project Summary" sub-menu on the Details page
	When User clicks content from "Project" column
	Then "Project Object" page is displayed to the user

@Evergreen @DevicesLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14973
Scenario: EvergreenJnr_DevicesList_CheckDeviceTabUIOnTheDeviceDetails
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Details" main-menu on the Details page
	Then "Key" title matches the "9141" value
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16009
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsSummarySection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName  |
	| Application |
	| Vendor      |
	| Version     |
	| Compliance  |
	| Installed   |
	| Used        |
	| Entitled    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15951
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsAreDisplayedCorrectlyInApplicationsDetailSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Application" column is displayed to the user
	When User have opened Column Settings for "Vendor" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName           |
	| Vendor               |
	| Version              |
	| Compliance           |
	| Association          |
	| Advertisement        |
	| Collection           |
	| Program              |
	| Installed Date       |
	| Used By              |
	| Used Date            |
	| Used Duration (Mins) |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16067
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsInTheApplicationColumnAreLinksAndAfterClickingUserIsRedirectedCorrectApplication
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the "Applications" main-menu on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then table content is present
	When User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" item is displayed correctly

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16117 @DAS16222 @DAS16309
Scenario: EvergreenJnr_DevicesList_CheckThatReadinessValuesInDdlOnProjectsTabAreDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "0G0WTR5KN85N2X"
	And User click content from "Hostname" column
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Projects Summary" sub-menu on the Details page
	And User have opened Column Settings for "Project" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Path" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in descending order
	When User click on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in ascending order
	Then All text is not displayed for "Readiness" column in the String Filter

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16366 @DAS16246
Scenario: EvergreenJnr_DevicesList_CheckThatVerticalMenuIsUnfoldedCorrectlyOnMenuSubItems
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then "Details" tab-menu on the Details page is expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then "Projects" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Active Directory" main-menu on the Details page
	When User navigates to the "Active Directory" sub-menu on the Details page
	Then "Active Directory" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Summary       |
	| Owner Projects Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Tasks Disabled in Evergreen" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Project Details        |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	#Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	#Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	#Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	#Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	#Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	#Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	#Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	#Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	#Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16884
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	#Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	#Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	#Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	#Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	#Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	#Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	#Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	#Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	#Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS15345
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Programs" tab is displayed on left menu on the Details page and contains count of items
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Projects          |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	#Then "Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	Then "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSIFiles   |
	| AOK        |
	#================ checks counters ================#
	Then "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "AOK" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Distribution tab ================#
	Then "Distribution" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| Users      |
	| Devices    |
	| Groups     |
	| AD         |
	#================ checks counters ================#
	#Then "Users" tab is displayed on left menu on the Details page and contains count of items
	#Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "AD" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16885 @DAS17213
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInProjectMode
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	Then "Distribution" main-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Programs" tab is displayed on left menu on the Details page and contains count of items
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Project Details   |
	| Projects          |
	#================ checks counters ================#
	#Then "Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	Then "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSIFiles   |
	| AOK        |
	#================ checks counters ================#
	Then "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "AOK" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS16905
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Notes" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Audit History" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Email Addresses" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Mailbox Projects      |
	| Mailbox User Projects |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox User Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Unresolved Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	Then "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16906
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Email Addresses" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox User Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Unresolved Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	Then "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items

	#ready for 'orbit'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16322 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatActionPanelImplementedForItemDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User clicks on "Devices" navigation link
	Then "Devices" list should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User clicks on "Users" navigation link
	Then "Users" list should be displayed to the user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User clicks on "Applications" navigation link
	Then "Applications" list should be displayed to the user
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User clicks on "Mailboxes" navigation link
	Then "Mailboxes" list should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16719
Scenario: EvergreenJnr_UsersList_CheckThatDataIsDisplayedInHardwareSummaryTabForUserObjectDetailsPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "AAD1011948"
	When User click content from "Username" column
	Then Details page for "AAD1011948" item is displayed to the user
	When User navigates to the "Compliance" main-menu on the Details page
	When User navigates to the "Hardware Summary" sub-menu on the Details page
	Then element table is displayed on the Details page

#test for 'Nova'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16472 @DAS16469 @DAS15039 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatIconsForReadinessDdlOnRelatedTabAreDisplayed
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the "Related" main-menu on the Details page
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column on the Details Page
	Then "31 May 2019" content is displayed in the "Date" column
	When User clicks String Filter button for "Application Readiness" column
	Then appropriate colored filter icons are displayed for following colors:
	| Color                   |
	| OUT OF SCOPE            |
	| BLUE                    |
	| LIGHT BLUE              |
	| RED                     |
	| BROWN                   |
	| AMBER                   |
	| REALLY EXTREMELY ORANGE |
	| PURPLE                  |
	| GREEN                   |
	| GREY                    |
	| NONE                    |

#not fully ready on 'Nova'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15039 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatTheRelatedTabIsDisplayedCorrectlyWithTheCorrectElementsAndColumns
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the "Related" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Devices               |
	| Owner                 |
	| Owner Display         |
	| Linked By             |
	| Path                  |
	| Category              |
	| Status                |
	| Date                  |
	| Application Readiness |
	| Pre Migration         |
	| Post Migration        |
	| Migration             |
	| Email Controls        |
	| Communications        |
	And Links from "Device" column is displayed to the user on the Details Page
	And Links from "Owner" column is displayed to the user on the Details Page
	And Links from "Owner Display Name" column is displayed to the user on the Details Page
	And Links from "Linked By" column is displayed to the user on the Details Page
	And Links from "Path" column is NOT displayed to the user on the Details Page
	And Links from "Category" column is NOT displayed to the user on the Details Page
	And Links from "Status" column is NOT displayed to the user on the Details Page
	And Links from "Date" column is NOT displayed to the user on the Details Page
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column on the Details Page
	And User clicks "03ME2G7TIR4GBN" link on the Details Page
	Then Details page for "03ME2G7TIR4GBN" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	And User enters "ACG370114" text in the Search field for "Owner" column on the Details Page
	And User clicks "ACG370114" link on the Details Page
	Then Details page for "ACG370114 (James N. Snow)" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	And User enters "James N. Snow" text in the Search field for "Owner Display Name" column on the Details Page
	And User clicks "James N. Snow" link on the Details Page
	Then Details page for "ACG370114 (James N. Snow)" item is displayed correctly
	And User click back button in the browser
	And Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Related" main-menu on the Details page
	#Not ready for 'nova'
	#When User enters "ACG370114" text in the Search field for "Linked By" column on the Details Page
	#When User clicks "ACG370114" link on the Details Page
	#Then Details page for "ACG370114" item is displayed correctly

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17219 @DAS17254
Scenario: EvergreenJnr_MailboxesList_CheckThatUsersTabIsDisplayedWithCorrectColumnsOnMailboxesDetailsPageForProjectMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "000F977AC8824FE39B8@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "000F977AC8824FE39B8@bclabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Username              |
	| Display Name          |
	| Readiness             |
	| Owner                 |
	| Domain                |
	| Path                  |
	| Category              |
	| Application Readiness |
	#Ann.Ilchenko 7/05/19: ready for "orbit" release (remove hash when it comes to automation server) --> DAS17254
	##| Stage 1               |
	##| Stage 2               |
	##| Stage 3               |
	##| Stage Z               |
	##And "GREEN" content is displayed for "Stage 1" column
	##And "AMBER" content is displayed for "Stage 2" column
	##And "RED" content is displayed for "Stage 3" column
	##And "GREY" content is displayed for "Stage Z" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17218
Scenario: EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZZP911429"
	And User click content from "Username" column
	Then Details page for "ZZP911429" item is displayed to the user
	When User navigates to the "Devices" main-menu on the Details page
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Owner Display Name |
	| Operating System   |
	| Compliance         |
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Hostname              |
	| Device Type           |
	| Owner                 |
	| Owner Display Name    |
	| Operating System      |
	| Readiness             |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage 1               |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15552 @DAS16921
Scenario: EvergreenJnr_AllLists_CheckThatTopBarInEvergreenModeIsDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems     |
	| Overall Compliance  |
	| App Compliance      |
	| Hardware Compliance |
	#=====================================================================================#
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems       |
	| Overall Compliance    |
	| User App Compliance   |
	| Hardware Compliance   |
	| Device App Compliance |
	#=====================================================================================#
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	And following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems    |
	| Overall Compliance |
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	And No one Compliance items are displayed for the User in Top bar on the Item details page

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14975 @DAS15333 @DAS16762 @DAS17166
Scenario: EvergreenJnr_AllLists_CheckThatTopBarInProjectModeIsDisplayedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	#=====================================================================================#
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	And User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	#=====================================================================================#
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	And User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User switches to the "Computer Scheduled Test (Jo)" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| App Readiness     |
	| Task Readiness    |
	| Workflow          |
	#=====================================================================================#
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then following Compliance items are displayed in Top bar on the Item details page:
	| ComplianceItems   |
	| Overall Readiness |
	| Task Readiness    |
	| Workflow          |
	
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15913
Scenario: EvergreenJnr_DevicesList_CheckThatUnknownValuesAreNotDisplayedOnLevelOfGroupedRows
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	And User clicks Group By button on the Details page and selects "Vendor" value
	Then "UNKNOWN" content is not displayed in the grid on the Item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16859
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
	| Fields            |
	| Object ID         |
	| Team              |
	| Capacity Unit     |
	| Bucket            |
	| Ring              |
	| Self Service URL  |
	| Overall Readiness |
	| Path              |
	| Category          |
	| Tags              |
	| Device Owner      |

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16858 @DAS17160 @DAS17325
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
	| Team             |
	| Capacity Unit    |
	| Bucket           |
	| Ring             |
	| Self Service URL |
	| Readiness        |
	| Path             |
	| Category         |
	| Tags             |
	| Primary Device   |
	| Language         |

	#added hash because of the DAS17239 bug 6/25/2019
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16861 @DAS17158 @Not_Run_DAS17239
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
	| Team                |
	| Capacity Unit       |
	| Overall Readiness   |
	| App Readiness       |
	| Primary App         |
	| App Rationalisation |
	| Target App          |
	| Hide From End Users |
	| Path                |
	| Category            |
	| Tags                |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16829 @DAS16957
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
	| Fields            |
	| Object ID         |
	| Capacity Unit     |
	| Bucket            |
	| Ring              |
	| Self Service URL  |
	| Overall Readiness |
	| Path              |
	| Category          |
	| Tags              |
	| Mailbox Owner     |
	| Language          |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17087
Scenario: EvergreenJnr_MailboxesList_ChecksThatUsersAreReloadedAfterSelectingAProjectOnTheMailboxDetailsPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abel.y.hanson@dwlabs.local"
	And User click content from "Email Address" column
	Then Details page for "abel.y.hanson@dwlabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	Then "7" rows found label displays on Details Page
	And "Administrator" content is displayed in "Username" column
	When User switches to the "Email Migration" project in the Top bar on Item details page
	Then "1" rows found label displays on Details Page
	And "hansonay" content is displayed in "Username" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17086
Scenario: EvergreenJnr_DevicesList_ChecksThatUserDetailsIsOpenedCorrectlyWithSameKeyAndUserValues
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	And User clicks "Nicole P. Braun" link on the Details Page
	Then Details page for "QLL295118 (Nicole P. Braun)" item is displayed to the user
	And "Key" title matches the "23726" value

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17007
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

	#added hash because of the DAS17005 bug 6/19/2019
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16698 @DAS17005 @DAS15347 @DAS16668 @DAS16903 @DAS16907 @DAS16857
Scenario Outline: EvergreenJnr_AllLists_CheckThatProjectsInTheTopBarOnItemDetailsPageAreDisplayedInAlphabeticalOrder
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User clicks by Project Switcher in the Top bar on Item details page
	#Then Project Switcher in the Top bar on Item details page is open
	#When User clicks by Project Switcher in the Top bar on Item details page
	#Then Project Switcher in the Top bar on Item details page is closed
	Then projects on the Project Switcher panel are displayed in alphabetical order
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	Then Project Switcher in the Top bar on Item details page is closed
	When User clicks by Project Switcher in the Top bar on Item details page
	Then projects on the Project Switcher panel are displayed in alphabetical order

Examples:
	| PageName     | ColumnName    | ItemName                         | ProjectName                        |
	| Devices      | Hostname      | 001BAQXT6JWFPI                   | Devices Evergreen Capacity Project |
	| Users        | Username      | ACG370114                        | User Evergreen Capacity Project    |
	| Applications | Application   | 7zip                             | Computer Scheduled Test (Jo)       |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local | Mailbox Evergreen Capacity Project |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInEvergreenMode
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User navigates to the "<SubMenu>" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title      | Value   |
	| Compliance | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems    | ColorName |
	| Overall Compliance | <Value>   |

Examples:
	| PageName     | ColumnName  | ItemName       | SubMenu      | Value   |
	| Devices      | Hostname    | 001BAQXT6JWFPI | Device Owner | RED     |
	| Users        | Username    | ACG370114      | User         | RED     |
	| Applications | Application | 7zip           | Application  | UNKNOWN |

	#added 'not_run' tag because of the DAS17160 bug 
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16857 @Not_Run_DAS17160
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplianceInKeyValueTableMatchesTheOverallComplianceFromTopBarInProjectMode
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title   | Value   |
	| <Title> | <Value> |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | <Value>   |

Examples:
	| PageName     | ColumnName    | ItemName                         | Title             | Value | ProjectName                        |
	| Devices      | Hostname      | 001BAQXT6JWFPI                   | Overall Readiness | GREY  | Devices Evergreen Capacity Project |
	| Users        | Username      | ACG370114                        | Readiness         | GREY  | User Evergreen Capacity Project    |
	| Applications | Application   | 7zip                             | Overall Readiness | GREY  | Devices Evergreen Capacity Project |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local | Overall Readiness | NONE  | Mailbox Evergreen Capacity Project |

#ready for 'orbit' release
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17002 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatReadinessValuesIsDisplayedAccordingToHavocBigDataProject
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACD Display 3.4"
	And User click content from "Application" column
	Then Details page for "ACD Display 3.4" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	When User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	Then following content is displayed on the Details Page
	| Title             | Value |
	| Overall Readiness | RED   |
	| App Readiness     | RED   |
	Then following Compliance items with appropriate colors are displayed in Top bar on the Item details page:
	| ComplianceItems   | ColorName |
	| Overall Readiness | RED       |
	| App Readiness     | RED       |