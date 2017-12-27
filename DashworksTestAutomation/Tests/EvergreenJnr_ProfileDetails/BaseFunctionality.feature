@retry:1
Feature: BaseFunctionality
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

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @BaseFunctionality @DAS-10756 @Remove_Profile_Changes
Scenario: EvergreenJnr_DevicesList_CheckThatUpdateErrorIsNotDisplayedAfterChangingAProfileData
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "testEmail@test.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	And "TestAdmin" is displayed in Full Name field
	And "testEmail@test.com" is displayed in Email field