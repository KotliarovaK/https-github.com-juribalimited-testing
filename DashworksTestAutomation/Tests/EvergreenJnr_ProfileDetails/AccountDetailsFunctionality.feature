﻿@retry:1
Feature: AccountDetailsFunctionality
	Runs Profile Details related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS10756 @Remove_Profile_Changes
Scenario: EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileData
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "automation@juriba.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
	And "TestAdmin" is displayed in Full Name field
	And "automation@juriba.com" is displayed in Email field

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS10756 @Remove_Profile_Changes
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
	When User changes Email to "automation@juriba.com"
	When User Upload incorrect avatar to Account Details
	Then "The file uploaded not recognised as an image" error message is displayed
	When User Upload correct avatar to Account Details
	Then Success message with "Image uploaded" text is displayed on Account Details page
	Then User picture is changed to uploaded photo
	When User clicks Remove on Account details page
	Then Success message with "Image removed" text is displayed on Account Details page
	Then User picture changed to default

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @AccountDetailsFunctionality @DAS11524 @Remove_Profile_Changes
Scenario: EvergreenJnr_AccountDetails_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "automation@juriba.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
	And "TestAdmin" is displayed in Full Name field
	And "automation@juriba.com" is displayed in Email field
	When User changes Full Name to "TestAdm"
	Then Error message is not displayed on Profile page
	Then Success message with "Account details have been changed" text is displayed on Account Details page
