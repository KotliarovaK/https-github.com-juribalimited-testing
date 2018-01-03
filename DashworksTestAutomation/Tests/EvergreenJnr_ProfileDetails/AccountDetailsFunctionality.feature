@retry:1
Feature: AccountDetailsFunctionality
	Runs Profile Details related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS-10756 @Remove_Profile_Changes
Scenario: EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileData
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "TestEmail@test.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
	And "TestAdmin" is displayed in Full Name field
	And "TestEmail@test.com" is displayed in Email field

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS-10756 @Remove_Profile_Changes
Scenario: EvergreenJnr_AccountDetails_CheckThatCorrectErrorMessagesAreDisplayed
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User clears Full name field
	And User clicks Update button on Profile page
	Then "Enter your full name" error message is displayed
	When User changes Full Name to "Administrator"
	When User clears Email field
	And User clicks Update button on Profile page
	Then "Enter your email address" error message is displayed
	When User changes Email to "testEmail"
	And User clicks Update button on Profile page
	Then "Enter a valid email address" error message is displayed
	When User changes Email to "@test.com"
	And User clicks Update button on Profile page
	Then "Enter a valid email address" error message is displayed
	When User changes Email to "TestEmail@test"
	And User clicks Update button on Profile page
	Then "Enter a valid email address" error message is displayed
	When User changes Email to "TestEmail@test.com"
	When User Upload incorrect avatar to Account Details
	Then "File uploaded not recognised as an image" error message is displayed
	When User Upload correct avatar to Account Details
	Then Success message with "Image uploaded" text is displayed on Account Details page
	Then User picture is changed to uploaded photo
	When User clicks Remove on Account details page
	Then Success message with "Image removed" text is displayed on Account Details page
	Then User picture changed to default

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS-11524 @Remove_Profile_Changes
Scenario: EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "TestEmail@test.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
	And "TestAdmin" is displayed in Full Name field
	And "TestEmail@test.com" is displayed in Email field
	When User changes Full Name to "TestAdm"
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
