Feature: ItemDetails_TabContentChecking
	Runs Item Details Tab Content Checking related tests

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
	Then User sees loaded tab "Evergreen Detail" on the Details page
	When User navigates to the 'Advertisements' left submenu item
	Then 'Advert - A0121431' content is displayed in the 'Advertisement' column
	And 'Hewlett-Packard' content is displayed in the 'Vendor' column
	And "7" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Advertisements" on the Details page
	When User navigates to the 'Collections' left submenu item
	Then 'Collection A01131CA' content is displayed in the 'Collection' column
	And 'A01 SMS (Spoof)' content is displayed in the 'Source' column
	And "7" rows found label displays on Details Page
	And table content is present
	And User sees loaded tab "Collections" on the Details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User navigates to the 'Mailbox' details page for 'julia.bell@juriba.com' item
	When User navigates to the 'Trend' left menu item
	Then Highcharts graphic is displayed on the Details Page
	And There are no errors in the browser console
	When User navigates to the 'Details' left menu item
	Then There are no errors in the browser console
	When User navigates to the 'Trend' left menu item
	Then There are no errors in the browser console
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17856
Scenario: EvergreenJnr_ApplicationsList_CheckThatGroupsCountIsCorrectOnEvergreenApplicationDetailsPage
	When User navigates to the 'Application' details page for 'Folder Size for Windows (2.3)' item
	When User navigates to the 'Distribution' left menu item
	Then 'Groups' tab is displayed on left menu on the Details page and contains '1' count of items
	When User navigates to the 'Groups' left submenu item
	Then 'GSMS-FolderSize-2.3' content is displayed in the 'Group' column
	And "1" rows found label displays on Details Page