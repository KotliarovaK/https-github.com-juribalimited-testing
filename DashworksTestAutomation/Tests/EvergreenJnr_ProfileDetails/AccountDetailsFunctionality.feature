@retry:1
Feature: AccountDetailsFunctionality
	Runs Profile Details related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS10756 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileData
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "automation2@juriba.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	And "TestAdmin" is displayed in Full Name field
	And "automation2@juriba.com" is displayed in Email field

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS10756 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatCorrectErrorMessagesAreDisplayed
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
	When User changes Email to "automation2@juriba.com"
	When User Upload incorrect avatar to Account Details
	Then "The file uploaded is not recognised as an image" error message is displayed
	When User Upload correct avatar to Account Details
	Then Success message with "Image changed" text is displayed on Account Details page
	Then User picture is changed to uploaded photo
	When User clicks Remove on Account details page
	Then Success message with "Image removed" text is displayed on Account Details page
	Then User picture changed to default

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS11524 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User changes Full Name to "TestAdmin"
	When User changes Email to "automation2@juriba.com"
	And User clicks Update button on Profile page
	Then Error message is not displayed on Profile page
	And "TestAdmin" is displayed in Full Name field
	And "automation2@juriba.com" is displayed in Email field
	When User changes Full Name to "TestAdm"
	Then Error message is not displayed on Profile page

@Evergreen @ProfileDetails @EvergreenJnr_FilterFeature @UserProfile @DAS11723 @API @Not_Run
Scenario: EvergreenJnr_UserProfile_CheckThatDefaultListPageSizeIs1000API
	Then default list page Size is "1000" and Cache "10"

	@Evergreen @ProfileDetails @EvergreenJnr_FilterFeature @UserProfile @API @Not_Run
Scenario: EvergreenJnr_UserProfile_ChecksListPageSizeAPI
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Advanced" page on Account details
	And User changes List Page Size to "2500"
	And User clicks Update button on the Advanced page
	When User clicks "Devices" on the left-hand menu
	Then page Size is "2500" on "Devices" page

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS11646 @DAS12947 @DAS13026 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatNotificationMessageDisappearsAfter5Seconds
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Preferences" page on Account details
	And User changes language to "English US"
	And User clicks Update button on Preferences page
	Then Notification message is displayed for a few seconds on Preferences page
	When User changes language to "Français"
	And User clicks Update button on Preferences page
	Then page elements are translated into French
	When User changes language to "English US"
	And User clicks Update button on Preferences page
	When User changes Display Mode to "High Contrast"
	And User clicks Update button on Preferences page
	Then Display Mode is changed to High Contrast
	When User changes Display Mode to "Normal"
	And User clicks Update button on Preferences page

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS13026
Scenario: EvergreenJnr_UserProfile_ChangingListPageSizeAndListPagesToCache
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Advanced" page on Account details
	When User changes List Page Size to "99"
	Then List Page Size is changed to "100"
	When User changes List Page Size to "5001"
	Then List Page Size is changed to "5000"
	When User changes List Pages to Cache to "2"
	Then List Pages to Cache is changed to "3"
	When User changes List Pages to Cache to "16"
	Then List Pages to Cache is changed to "15"
	When User changes List Pages to Cache to "10"
	And User changes List Page Size to "1000"
	And User clicks Update button on the Advanced page
	Then Success message with "User preferences have been changed" text is displayed on the Advanced page

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS13026 @Remove_Password_Changes
Scenario: EvergreenJnr_UserProfile_ChangingPassword
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the "Change Password" page on Account details
	Then Change Password page is displayed to user
	When User enters "IncorrectCurrentPassword" in the Current Password field
	And User enters "m!gration" in the New Password field
	And User enters "m!gration" in the Confirm Password field
	And User clicks Update button on the Change Password page
	Then Error message with "Current password is incorrect" text is displayed on the Change Password page
	When User enters "IncorrectCurrentPassword" in the Current Password field
	And User enters "m!gration" in the New Password field
	And User enters "test5846" in the Confirm Password field
	And User clicks Update button on the Change Password page
	Then Error message with "New password doesn't match" text is displayed on the Change Password page
	When User enters "m!gration" in the Current Password field
	And User enters "m!gration" in the New Password field
	And User enters "test5846pass" in the Confirm Password field
	And User clicks Update button on the Change Password page
	Then Error message with "Your new password must be different to your current password" text is displayed on the Change Password page
	When User enters "m!gration" in the Current Password field
	And User enters "54891" in the New Password field
	And User enters "54891" in the Confirm Password field
	And User clicks Update button on the Change Password page
	Then Error message with "New password must be at least 6 characters long" text is displayed on the Change Password page
	When User enters "m!gration" in the Current Password field
	And User enters "test5846" in the New Password field
	And User enters "test5846" in the Confirm Password field
	And User clicks Update button on the Change Password page
	Then Success message with "Password has been changed" text is displayed on the Change Password page