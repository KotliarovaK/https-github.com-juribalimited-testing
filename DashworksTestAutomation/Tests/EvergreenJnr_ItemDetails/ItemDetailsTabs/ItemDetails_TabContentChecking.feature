Feature: ItemDetails_TabContentChecking
	Runs Item Details Tab Content Checking related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12071
Scenario: EvergreenJnr_DevicesList_CheckThatOpenedSectionIsDisplayedCorrectlyOnTheDetailsPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Applications' left menu item
	And User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" content is displayed in "Application" column
	And "Advert - A0129C4E" content is displayed in "Advertisement" column
	And "14" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Evergreen Detail" on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Advert - A0121431" content is displayed in "Advertisement" column
	And "Hewlett-Packard" content is displayed in "Vendor" column
	And "7" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Advertisements" on the Details page
	When User navigates to the "Collections" sub-menu on the Details page
	Then "Collection A01131CA" content is displayed in "Collection" column
	And "A01 SMS (Spoof)" content is displayed in "Source" column
	And "7" rows found label displays on Details Page
	And table content is present
	And User sees loaded tab "Collections" on the Details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "julia.bell@juriba.com"
	And User click content from "Email Address" column
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