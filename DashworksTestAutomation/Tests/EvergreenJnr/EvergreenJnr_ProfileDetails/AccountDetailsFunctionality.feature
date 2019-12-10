Feature: AccountDetailsFunctionality
	Runs Profile Details related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS10756 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileData
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User enters 'TestAdmin' text to 'Full Name' textbox
	When User enters 'automation4@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then error inline tip banner is displayed
	Then 'TestAdmin' content is displayed in 'Full Name' textbox
	Then 'automation4@juriba.com' content is displayed in 'Email' textbox
	When User enters 'Administrator' text to 'Full Name' textbox
	When User enters 'automation@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button 

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS10756 @DAS12947 @DAS11523 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatCorrectErrorMessagesAreDisplayed
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User clears Full name field
	And User clicks 'UPDATE' button
	Then 'Enter your full name' text is displayed on error inline tip banner
	When User enters 'Administrator' text to 'Full Name' textbox
	When User enters '' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter your email address' text is displayed on error inline tip banner
	When User enters 'testEmail' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on error inline tip banner
	When User clicks refresh button in the browser
	When User enters '@test.com' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on error inline tip banner
	When User Upload incorrect avatar to Account Details
	Then 'The file uploaded is not recognised as an image' text is displayed on error inline tip banner
	When User enters 'TestEmail@test' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on error inline tip banner
	When User enters 'automation2@juriba.com' text to 'Email' textbox
	When User Upload correct avatar to Account Details
	Then 'Image changed' text is displayed on success inline tip banner
	Then User picture is changed to uploaded photo
	When User clicks 'REMOVE' button
	Then 'Image removed' text is displayed on success inline tip banner
	Then User picture changed to default

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS11524 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User enters 'TestAdmin' text to 'Full Name' textbox
	When User enters 'automation3@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then error inline tip banner is displayed
	Then 'TestAdmin' content is displayed in 'Full Name' textbox
	Then 'automation3@juriba.com' content is displayed in 'Email' textbox
	When User enters 'TestAdm' text to 'Full Name' textbox
	Then error inline tip banner is displayed
	When User enters 'Administrator' text to 'Full Name' textbox
	When User enters 'automation@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button

@Evergreen @ProfileDetails @EvergreenJnr_FilterFeature @UserProfile @DAS13026 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_ChecksListPageSizeAPI
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
	And User changes List Page Size to "2500"
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on success inline tip banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	And page Size is "2500" on "Devices" page
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
	And User changes List Page Size to "1000"
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on success inline tip banner

@Evergreen @ProfileDetails @EvergreenJnr_FilterFeature @UserProfile @DAS11723 @DAS16979
Scenario: EvergreenJnr_UserProfile_CheckThatDefaultListPageSizeIs1000API
	Then default list page Size is "1000" and Cache "10"

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS11646 @DAS12947 @DAS13026 @DAS16248 @DAS16232 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatNotificationMessageDisappearsAfter5Seconds
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Preferences' left menu item
	When User selects 'English US' in the 'Language' dropdown
	When User clicks 'UPDATE' button
	Then Notification message is displayed for a few seconds on Preferences page
	When User selects 'Français' in the 'Language' dropdown
	When User clicks 'UPDATE' button
	Then page elements are translated into French
	When User selects 'English UK' in the 'Langue' dropdown
	When User clicks 'METTRE À JOUR' button
	When User selects 'High Contrast' in the 'Display Mode' dropdown
	When User clicks 'UPDATE' button
	When User selects 'English US' in the 'Language' dropdown
	Then Display Mode is changed to High Contrast
	When User selects 'English UK' in the 'Language' dropdown
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User enters "1803 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Readiness' left menu item
	Then Cog-menu DDL is displayed in High Contrast mode
	When User clicks Profile in Account Dropdown
	When User navigates to the 'Preferences' left menu item
	When User selects 'Normal' in the 'Display Mode' dropdown
	When User clicks 'UPDATE' button

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS13026
Scenario: EvergreenJnr_UserProfile_ChangingListPageSizeAndListPagesToCache
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
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
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on success inline tip banner

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS13026 @DAS14187 @Remove_Password_Changes
Scenario: EvergreenJnr_UserProfile_ChangingPassword
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Change Password' left menu item
	Then Change Password page is displayed to user
	When User enters 'IncorrectCurrentPassword' text to 'Current Password' textbox
	When User enters 'm!gration' text to 'New Password' textbox
	When User enters 'm!gration' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'Current password is incorrect' text is displayed on error inline tip banner
	And There are no errors in the browser console
	When User enters 'IncorrectCurrentPassword' text to 'Current Password' textbox
	When User enters 'm!gration' text to 'New Password' textbox
	When User enters 'test5846' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'New password doesn't match' text is displayed on error inline tip banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters 'm!gration' text to 'New Password' textbox
	When User enters 'test5846pass' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'Your new password must be different to your current password' text is displayed on error inline tip banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters '54891' text to 'New Password' textbox
	When User enters '54891' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'New password must be at least 6 characters long' text is displayed on error inline tip banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters 'test5846' text to 'New Password' textbox
	When User enters 'test5846' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'Password has been changed' text is displayed on success inline tip banner
	#Then Success message is displayed with "Password has been changed" text
	#Then Success message with "Password has been changed" text is displayed on the Change Password page
	And There are no errors in the browser console