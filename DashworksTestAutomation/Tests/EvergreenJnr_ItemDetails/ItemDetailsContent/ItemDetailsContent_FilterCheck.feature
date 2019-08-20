Feature: ItemDetailsContent_FilterCheck
	Runs Item Details Content Filter Check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then "OUT OF SCOPE" content is displayed in the "Readiness" column
	Then "TRUE" content is displayed in the "Owner" column
	Then "NONE" content is displayed in the "Application Readiness" column
	Then "GREY" content is displayed in the "Pre-Migration" column
	Then "GREY" content is displayed in the "Migration" column
	Then "" content is displayed in the "Email Controls" column
	Then "GREY" content is displayed in the "Communication" column
	When User clicks String Filter button for "Readiness" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| OUT OF SCOPE |
	When User closes Checkbox filter for "Readiness" column
	When User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	When User clicks String Filter button for "Application Readiness" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| NONE   |
	When User closes Checkbox filter for "Application Readiness" column
	When User clicks String Filter button for "Pre-Migration" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |
	When User closes Checkbox filter for "Pre-Migration" column
	When User clicks String Filter button for "Migration" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |
	When User closes Checkbox filter for "Migration" column
	When User clicks String Filter button for "Communication" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column on the Details Page
	Then "GREEN" content is displayed in the "Compliance" column
	Then "TRUE" content is displayed in the "Installed" column
	Then "UNKNOWN" content is displayed in the "Used" column
	Then "TRUE" content is displayed in the "Entitled" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compliance" column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Used" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Used" column
	When User clicks String Filter button for "Entitled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Entitled" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenDetailOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Detail" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column on the Details Page
	Then "GREEN" content is displayed in the "Compliance" column
	And Content is displayed in the "Advertisement" column
	| Content           |
	| Advert - A0123BFF |
	| Advert - A0123BFF |
	And Content is displayed in the "Collection" column
	| Content             |
	| Collection A011618A |
	| Collection A011618A |
	And Content is displayed in the "Program" column
	| Content |
	| Install |
	| Install |
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compliance" column
	When User clicks String Filter button for "Association" column
	Then following String Values are displayed in the filter on the Details Page
	| Values    |
	| Installed |
	| Entitled  |
	When User closes Checkbox filter for "Association" column
	When User clicks String Filter button for "Advertisement" column
	Then following String Values are displayed in the filter on the Details Page
	| Values            |
	| Advert - A0123493 |
	| Advert - A0123BFF |
	| Advert - A01267E3 |
	| Advert - A0126E99 |
	| Advert - A012A5EB |
	When User closes Checkbox filter for "Advertisement" column
	When User clicks String Filter button for "Collection" column
	Then following String Values are displayed in the filter on the Details Page
	| Values              |
	| Collection A011166A |
	| Collection A0114711 |
	| Collection A011618A |
	| Collection A011A360 |
	| Collection A011EB46 |
	When User closes Checkbox filter for "Collection" column
	When User clicks String Filter button for "Program" column
	Then following String Values are displayed in the filter on the Details Page
	| Values  |
	| Install |
	When User closes Checkbox filter for "Program" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabAdvertisementsOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Advertisements" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column on the Details Page
	Then "TierA Site01" content is displayed in the "Site" column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Collections" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Collection A01131CA" text in the Search field for "Collection" column on the Details Page
	Then "SMS/SCCM 2007" content is displayed in the "Source Type" column
	Then "A01 SMS (Spoof)" content is displayed in the "Source" column
	Then "TierA Site01" content is displayed in the "Site" column
	When User clicks String Filter button for "Source Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values        |
	| SMS/SCCM 2007 |
	When User closes Checkbox filter for "Source Type" column
	When User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values          |
	| A01 SMS (Spoof) |
	When User closes Checkbox filter for "Source" column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabHardwareRulesOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00RUUMAH9OZN9A"
	And User click content from "Hostname" column
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the "Compliance" main-menu on the Details page
	And User navigates to the "Hardware Rules" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then "AMBER" content is displayed in the "Compliance" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabApplicationIssuesOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the "Compliance" main-menu on the Details page
	And User navigates to the "Application Issues" sub-menu on the Details page
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" text in the Search field for "Application" column on the Details Page
	Then "TierA Site01" content is displayed in the "Site" column
	Then "TRUE" content is displayed in the "Installed" column
	Then "RED" content is displayed in the "Compliance" column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| RED    |
	When User closes Checkbox filter for "Compliance" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForActiveDirectoryTabGroupsOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZWS705179"
	And User click content from "Username" column
	Then Details page for "ZWS705179 (Derick I. Thomas)" item is displayed to the user
	When User navigates to the "Active Directory" main-menu on the Details page
	Then "US-W" content is displayed in the "Domain" column
	Then "Global Security Group" content is displayed in the "Type" column
	When User navigates to the "Groups" sub-menu on the Details page
	And User have opened Column Settings for "Group" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| US-W   |
	When User closes Checkbox filter for "Domain" column
	And User clicks String Filter button for "Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values                |
	| Global Security Group |
	When User closes Checkbox filter for "Type" column
	And User clicks String Filter button for "Directory Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| Active Directory |
	When User closes Checkbox filter for "Directory Type" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "allanj"
	And User click content from "Username" column
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Summary" sub-menu on the Details page
	Then "JuribaDEV50" content is displayed in the "Site" column
	And "UNKNOWN" content is displayed in the "Installed" column
	And "UNKNOWN" content is displayed in the "Used" column
	And "TRUE" content is displayed in the "Entitled" column
	And "FALSE" content is displayed in the "Entitled To Device" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values  |
	| UNKNOWN |
	When User closes Checkbox filter for "Compliance" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column
	And User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Installed" column
	And User clicks String Filter button for "Used" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Used" column
	And User clicks String Filter button for "Entitled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Entitled" column
	And User clicks String Filter button for "Entitled To Device" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| False  |
	When User closes Checkbox filter for "Entitled To Device" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenDetailOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "allanj"
	And User click content from "Username" column
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "UNKNOWN" content is displayed in the "Compliance" column
	And "JuribaDEV50" content is displayed in the "Site" column
	And "Entitled" content is displayed in the "Association Type" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values  |
	| UNKNOWN |
	When User closes Checkbox filter for "Compliance" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column
	And User clicks String Filter button for "Association Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values   |
	| Entitled |
	When User closes Checkbox filter for "Association Type" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabAdvertisementsOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "allanj"
	And User click content from "Username" column
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Advertisements" sub-menu on the Details page
	Then "JuribaDEV50" content is displayed in the "Site" column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "allanj"
	And User click content from "Username" column
	Then Details page for "allanj (Jo Allan)" item is displayed to the user
	When User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Collections" sub-menu on the Details page
	Then "SMS/SCCM 2007" content is displayed in the "Source Type" column
	And "DC1 SMS (DEV50)" content is displayed in the "Source" column
	And "JuribaDEV50" content is displayed in the "Site" column
	When User clicks String Filter button for "Source Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values        |
	| SMS/SCCM 2007 |
	When User closes Checkbox filter for "Source Type" column
	And User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values          |
	| DC1 SMS (DEV50) |
	When User closes Checkbox filter for "Source" column
	And User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values      |
	| JuribaDEV50 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMailboxesTabOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "02BE025D56CF4899889"
	And User click content from "Username" column
	Then Details page for "02BE025D56CF4899889 (Wegemer, Susan)" item is displayed to the user
	When User navigates to the "Mailboxes" main-menu on the Details page
	And User navigates to the "Mailboxes" sub-menu on the Details page
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then "TRUE" content is displayed in the "Owner" column
	When User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	And User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then "FullAccess" content is displayed in the "Permission" column
	When User clicks String Filter button for "Permission" column
	Then following String Values are displayed in the filter on the Details Page
	| Values         |
	| FullAccess     |
	| ReadPermission |
	When User closes Checkbox filter for "Permission" column

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_UsersList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ZWS705179"
	And User click content from "Username" column
	Then Details page for "ZWS705179 (Derick I. Thomas)" item is displayed to the user
	When User navigates to the "Compliance" main-menu on the Details page
	And User navigates to the "Hardware Rules" sub-menu on the Details page
	Then "AMBER" content is displayed in the "Compliance" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column
	And User navigates to the "Application Issues" sub-menu on the Details page
	And User have opened Column Settings for "Type" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Application" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then "TierA Site01" content is displayed in the "Site" column
	Then "TRUE" content is displayed in the "Installed" column
	Then "RED" content is displayed in the "Compliance" column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| RED    |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabAdvertisementsOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Accessible FormNet Fill 2.2"
	And User click content from "Application" column
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "TRUE" content is displayed in the "Active" column
	When User clicks String Filter button for "Active" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Active" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMsiTabOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Accessible FormNet Fill 2.2"
	And User click content from "Application" column
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the "MSI" main-menu on the Details page
	When User navigates to the "MSI Files" sub-menu on the Details page
	And User have opened Column Settings for "File Name" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Product Code" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then "AOK Import" content is displayed in the "Source" column
	Then "ChangeBASE AOK" content is displayed in the "Source Type" column
	Then "GREEN" content is displayed in the "Compliance" column
	When User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values     |
	| AOK Import |
	When User closes Checkbox filter for "Source" column
	When User clicks String Filter button for "Source Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values         |
	| ChangeBASE AOK |
	When User closes Checkbox filter for "Source Type" column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compliance" column
	When User navigates to the "AOK" sub-menu on the Details page
	Then "AOK Import" content is displayed in the "Source" column
	Then "Windows 7" content is displayed in the "AOK Report" column
	Then "GREEN" content is displayed in the "Compatibility" column
	When User clicks String Filter button for "Source" column
	Then following String Values are displayed in the filter on the Details Page
	| Values     |
	| AOK Import |
	When User closes Checkbox filter for "Source" column
	When User clicks String Filter button for "AOK Report" column
	Then following String Values are displayed in the filter on the Details Page
	| Values    |
	| Windows 7 |
	When User closes Checkbox filter for "AOK Report" column
	When User clicks String Filter button for "Compatibility" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREEN  |
	When User closes Checkbox filter for "Compatibility" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_ApplicationsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDistributionTabOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Accessible FormNet Fill 2.2"
	And User click content from "Application" column
	Then Details page for "Accessible FormNet Fill 2.2" item is displayed to the user
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Devices" sub-menu on the Details page
	Then "TRUE" content is displayed in the "Installed" column
	Then "UNKNOWN" content is displayed in the "Used" column
	Then "TRUE" content is displayed in the "Entitled" column
	When User clicks String Filter button for "Installed" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Installed" column
	When User clicks String Filter button for "Used" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values  |
	| Unknown |
	When User closes Checkbox filter for "Used" column
	When User clicks String Filter button for "Entitled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Entitled" column
	When User navigates to the "AD" sub-menu on the Details page
	Then "UK" content is displayed in the "Domain" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AU     |
	| CA     |
	| UK     |
	| US-E   |
	| US-W   |
	When User closes Checkbox filter for "Domain" column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForDetailsTabOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "002B5DC7D4D34D5C895"
	And User click content from "Email Address" column
	Then Details page for "002B5DC7D4D34D5C895@bclabs.local" item is displayed to the user
	When User navigates to the "Email Addresses" sub-menu on the Details page
	Then "TRUE" content is displayed in the "Type" column
	Then "SMTP" content is displayed in the "Reply To" column
	When User clicks String Filter button for "Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| SMTP   |
	When User closes Checkbox filter for "Type" column
	When User clicks String Filter button for "Reply To" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Reply To" column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_MailboxesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "002B5DC7D4D34D5C895"
	And User click content from "Email Address" column
	Then Details page for "002B5DC7D4D34D5C895@bclabs.local" item is displayed to the user
	When User navigates to the "Users" main-menu on the Details page
	When User navigates to the "Users" sub-menu on the Details page
	When User switches to the "USE ME FOR AUTOMATION(MAIL SCHDLD)" project in the Top bar on Item details page
	Then "TRUE" content is displayed in the "Owner" column
	Then "" content is displayed in the "Domain" column
	When User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| Empty  |
	When User closes Checkbox filter for "Domain" column
	When User navigates to the "Groups" sub-menu on the Details page
	Then "BCLABS" content is displayed in the "Domain" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| BCLABS |
	When User closes Checkbox filter for "Domain" column
	When User navigates to the "Mailbox Permissions" sub-menu on the Details page
	Then "BCLABS" content is displayed in the "Domain" column
	Then "FullAccess" content is displayed in the "Permission" column
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| BCLABS |
	When User closes Checkbox filter for "Domain" column
	When User clicks String Filter button for "Permission" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| FullAccess       |
	| ReadPermission   |
	| DeleteItem       |
	| ChangeOwner      |
	| ChangePermission |
	When User closes Checkbox filter for "Permission" column

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_GroupsList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForMembersTabOnGroupsPage
	When User type "Schema Admins" in Global Search Field
	Then User clicks on "Schema Admins" search result
	And Details page for "Schema Admins" item is displayed to the user
	When User navigates to the "Members" main-menu on the Details page
	When User navigates to the "User Members" sub-menu on the Details page
	Then "DEV50" content is displayed in the "Domain" column
	Then "TRUE" content is displayed in the "Enabled" column
	When User have opened Column Settings for "Username" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Directory Type" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks String Filter button for "Domain" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| DEV50  |
	When User closes Checkbox filter for "Domain" column
	And User clicks String Filter button for "Enabled" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Enabled" column
	And User clicks String Filter button for "Directory Type" column
	Then following String Values are displayed in the filter on the Details Page
	| Values           |
	| Active Directory |
	When User closes Checkbox filter for "Directory Type" column