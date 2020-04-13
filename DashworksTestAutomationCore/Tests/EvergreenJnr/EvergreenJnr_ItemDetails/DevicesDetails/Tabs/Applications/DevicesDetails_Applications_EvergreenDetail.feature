Feature: DevicesDetails_Applications_EvergreenDetail
	Runs related tests for Applications tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12071
Scenario: EvergreenJnr_DevicesList_CheckThatOpenedSectionIsDisplayedCorrectlyOnTheDetailsPage
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Detail' left submenu item
	Then 'Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs' content is displayed in the 'Application' column
	And 'Advert - A0129C4E' content is displayed in the 'Advertisement' column
	And "14" rows found label displays on Details Page
	And table content is present
	Then 'Evergreen Detail' left submenu item is displayed
	When User navigates to the 'Advertisements' left submenu item
	Then 'Advert - A0121431' content is displayed in the 'Advertisement' column
	And 'Hewlett-Packard' content is displayed in the 'Vendor' column
	And "7" rows found label displays on Details Page
	And table content is present
	Then 'Advertisements' left submenu item is displayed
	When User navigates to the 'Collections' left submenu item
	Then 'Collection A01131CA' content is displayed in the 'Collection' column
	And 'A01 SMS (Spoof)' content is displayed in the 'Source' column
	And "7" rows found label displays on Details Page
	And table content is present
	Then 'Collections' left submenu item is displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16067 @DAS18535
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsInTheApplicationColumnAreLinksAndAfterClickingUserIsRedirectedCorrectApplication
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Advertisements' left submenu item
	Then table content is present
	When User enters "Microsoft Internet Explorer" text in the Search field for "Application" column
	When User clicks "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" link on the Details Page
	Then Details page for 'Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs' item is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15133
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationsSummaryRowCanBeCopied
	When User navigates to the 'Device' details page for '00BDM1JUR8IF419' item
	When User navigates to the 'Applications' left menu item
	When User enters "egcs-objc" text in the Search field for "Application" column
	When User right clicks on 'egcs-objc' cell from 'Application' column
	And User selects 'Copy row' option in context menu
	Then Next data 'egcs-objc   Red Hat   1.1.2   Red   Unknown   True   False' is copied

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20559
Scenario: EvergreenJnr_DevicesList_CheckThatInformationIsOrderedInTheUsedDurationMinsColumnOfTheApplicationsEvergreenDetailsTabAfterApplyingTheSorting
	When User navigates to the 'Device' details page for '01COJATLYVAR7A6' item
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Detail' left submenu item
	When User clicks following checkboxes from Column Settings panel for the 'Application' column:
	| checkboxes    |
	| Advertisement |
	| Association   |
	| Compliance    |
	When User clicks on 'Used Duration (Mins)' column header
	Then numeric data in table is sorted by 'Used Duration (Mins)' column in descending order
	When User clicks on 'Used Duration (Mins)' column header
	Then numeric data in table is sorted by 'Used Duration (Mins)' column in ascending order
	Then There are no errors in the browser console