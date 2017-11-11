#@retry:3
Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @ItemDetailsDisplay @EvergreenJnr_ListDetails @DAS-10438
Scenario: Evergreen Jnr_DevicesList_Details_All empty fields in item details are displayed as Unknown
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "01BQIYGGUW5PRP6"
	And User click content from "Hostname" column
	When User navigates to the "Details" tab
	Then Fields with empty information are displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @ItemDetailsDisplay @EvergreenJnr_ListDetails @DAS-10438
Scenario: Evergreen Jnr_UsersList_Details_All empty fields in item details are displayed as Unknown
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "ABW1509426"
	And User click content from "Username" column
	When User navigates to the "Details" tab
	Then Fields with empty information are displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @ItemDetailsDisplay @EvergreenJnr_ListDetails @DAS-10438
Scenario: Evergreen Jnr_ApplicationsList_Details_All empty fields in item details are displayed as Unknown
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "Python 2.2a4"
	And User click content from "Application" column
	When User navigates to the "Details" tab
	Then Fields with empty information are displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Mailboxes @ItemDetailsDisplay @EvergreenJnr_ListDetails @DAS-10438
Scenario: Evergreen Jnr_MailboxesList_Details_All empty fields in item details are displayed as Unknown
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "abel.z.warner@dwlabs.local"
	And User click content from "Email Address" column
	When User navigates to the "Details" tab
	Then Fields with empty information are displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out
