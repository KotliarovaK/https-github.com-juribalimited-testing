Feature: ItemDetails_MultiselectFilterChecking_DevicesPage
	Runs Multiselect Filter Checking for Devices Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @DAS18405 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForUsersTabOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	Then 'OUT OF SCOPE' content is displayed in the 'Stage for User Tasks' column
	And 'TRUE' content is displayed in the 'Owner' column
	And 'IGNORE' content is displayed in the 'Application Readiness' column
	And 'GREY' content is displayed in the 'Pre-Migration' column
	And 'GREY' content is displayed in the 'Migration' column
	#Column should not be displayed if no content to display
	And "Email Controls" column is not displayed to the user
	And 'GREY' content is displayed in the 'Communication' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Stage for User Tasks' column:
	| Values       |
	| OUT OF SCOPE |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Owner' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Application Readiness' column:
	| Values |
	| IGNORE |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Pre-Migration' column:
	| Values |
	| GREY   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Migration' column:
	| Values |
	| GREY   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Communication' column:
	| Values |
	| GREY   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenSummaryOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column
	Then 'GREEN' content is displayed in the 'Compliance' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'UNKNOWN' content is displayed in the 'Used' column
	Then 'TRUE' content is displayed in the 'Entitled' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| GREEN  |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Installed' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Used' column:
	| Values  |
	| Unknown |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Entitled' column:
	| Values |
	| True   |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabEvergreenDetailOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Detail' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
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
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| GREEN  |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Association' column:
	| Values    |
	| Installed |
	| Entitled  |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Advertisement' column:
	| Values            |
	| Advert - A0123493 |
	| Advert - A0123BFF |
	| Advert - A01267E3 |
	| Advert - A0126E99 |
	| Advert - A012A5EB |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Collection' column:
	| Values              |
	| Collection A011166A |
	| Collection A0114711 |
	| Collection A011618A |
	| Collection A011A360 |
	| Collection A011EB46 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Program' column:
	| Values  |
	| Install |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabAdvertisementsOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Advertisements' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	And User enters "Microsoft Office PowerPoint 2002 (XP)" text in the Search field for "Application" column
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values       |
	| TierA Site01 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForApplicationsTabCollectionsOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Collections' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	And User enters "Collection A011166A" text in the Search field for "Collection" column
	Then 'SMS/SCCM 2007' content is displayed in the 'Source Type' column
	Then 'A01 SMS (Spoof)' content is displayed in the 'Source' column
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source Type' column:
	| Values        |
	| SMS/SCCM 2007 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Source' column:
	| Values          |
	| A01 SMS (Spoof) |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values       |
	| TierA Site01 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabHardwareRulesOnDevicesPage
	When User navigates to the 'Device' details page for '00RUUMAH9OZN9A' item
	Then Details page for '00RUUMAH9OZN9A' item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Hardware Rules' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	Then 'AMBER' content is displayed in the 'Compliance' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| AMBER  |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17761 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatOnlyValueIncludedInTheColumnIsDisplayedInTheRelatedMultiselectFilterForComplianceTabApplicationIssuesOnDevicesPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Compliance' left menu item
	And User navigates to the 'Application Issues' left submenu item
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	And User enters "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" text in the Search field for "Application" column
	Then 'TierA Site01' content is displayed in the 'Site' column
	Then 'TRUE' content is displayed in the 'Installed' column
	Then 'RED' content is displayed in the 'Compliance' column
	Then following checkboxes are displayed in the filter dropdown menu for the 'Site' column:
	| Values       |
	| TierA Site01 |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Installed' column:
	| Values |
	| True   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Compliance' column:
	| Values |
	| RED    |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12253 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThePossibilityToRecheckingTheWorkflowColumnBlanksFilterAfterUncheckingIt
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Workflow' column:
	| checkboxes |
	| Empty      |
	When User checks following checkboxes in the filter dropdown menu for the 'Workflow' column:
	| checkboxes |
	| Empty      |
	Then 'Empty' checkbox is checked in the filter dropdown for the 'Workflow' column