﻿Feature: ItemDetails_MultiselectFilterChecking_DevicesPage
	Runs Multiselect Filter Checking for Devices Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then 'OUT OF SCOPE' content is displayed in the 'Stage for User Tasks' column
	And 'TRUE' content is displayed in the 'Owner' column
	And 'NONE' content is displayed in the 'Application Readiness' column
	And 'GREY' content is displayed in the 'Pre-Migration' column
	And 'GREY' content is displayed in the 'Migration' column
	#Column should not be displayed if no content to display
	And "Email Controls" column is not displayed to the user
	And 'GREY' content is displayed in the 'Communication' column
	When User clicks String Filter button for "Stage for User Tasks" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| OUT OF SCOPE |
	When User closes Checkbox filter for "Stage for User Tasks" column
	And User clicks String Filter button for "Owner" column
	Then following Boolean Values are displayed in the filter on the Details Page
	| Values |
	| True   |
	When User closes Checkbox filter for "Owner" column
	And User clicks String Filter button for "Application Readiness" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| NONE   |
	When User closes Checkbox filter for "Application Readiness" column
	And User clicks String Filter button for "Pre-Migration" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |
	When User closes Checkbox filter for "Pre-Migration" column
	And User clicks String Filter button for "Migration" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |
	When User closes Checkbox filter for "Migration" column
	And User clicks String Filter button for "Communication" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| GREY   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column
	Then 'GREEN' content is displayed in the 'Compliance' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'UNKNOWN' content is displayed in the 'Used' column
	Then 'TRUE' content is displayed in the 'Entitled' column
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
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Detail' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column
	Then 'GREEN' content is displayed in the 'Compliance' column
	And Content in the 'Advertisement' column is equal to
	| Content           |
	| Advert - A0123BFF |
	| Advert - A0123BFF |
	And Content in the 'Collection' column is equal to
	| Content             |
	| Collection A011618A |
	| Collection A011618A |
	And Content in the 'Program' column is equal to
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
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Advertisements' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column
	Then 'TierA Site01' content is displayed in the 'Site' column
	When User clicks String Filter button for "Site" column
	Then following String Values are displayed in the filter on the Details Page
	| Values       |
	| TierA Site01 |
	When User closes Checkbox filter for "Site" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Collections' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then 'SMS/SCCM 2007' content is displayed in the 'Source Type' column
	Then 'A01 SMS (Spoof)' content is displayed in the 'Source' column
	Then 'TierA Site01' content is displayed in the 'Site' column
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
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for "00RUUMAH9OZN9A" item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Hardware Rules' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	Then 'AMBER' content is displayed in the 'Compliance' column
	When User clicks String Filter button for "Compliance" column
	Then following String Values are displayed in the filter on the Details Page
	| Values |
	| AMBER  |
	When User closes Checkbox filter for "Compliance" column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabApplicationIssuesOnDevicesPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Application Issues' left submenu item
	When User switches to the "Windows 7 Migration (Computer Scheduled Project)" project in the Top bar on Item details page
	And User enters "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" text in the Search field for "Application" column
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'RED' content is displayed in the 'Compliance' column
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12253
Scenario: EvergreenJnr_DevicesList_CheckThePossibilityToRecheckingTheWorkflowColumnBlanksFilterAfterUncheckingIt
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	And User clicks String Filter button for "Workflow" column
	When User selects "Empty" checkbox from String Filter on the Details Page
	And User clicks String Filter button for "Workflow" column
	When User selects "Empty" checkbox from String Filter on the Details Page
	And User clicks String Filter button for "Workflow" column
	Then "Empty" checkbox is checked on the Details Page