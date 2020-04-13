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
	Then inline error banner is not displayed
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
	Then 'Enter your full name' text is displayed on inline error banner
	When User enters 'Administrator' text to 'Full Name' textbox
	When User enters '' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter your email address' text is displayed on inline error banner
	When User enters 'testEmail' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on inline error banner
	When User clicks refresh button in the browser
	When User enters '@test.com' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on inline error banner
	When User Upload incorrect avatar to Account Details
	Then 'The file uploaded is not recognised as an image' text is displayed on inline error banner
	When User enters 'TestEmail@test' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then 'Enter a valid email address' text is displayed on inline error banner
	When User enters 'automation2@juriba.com' text to 'Email' textbox
	When User Upload correct avatar to Account Details
	Then 'Image changed' text is displayed on inline success banner
	Then User picture is changed to uploaded photo
	When User clicks 'REMOVE' button
	Then 'Image removed' text is displayed on inline success banner
	Then User picture changed to default

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS11524 @DAS12947 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_CheckThatErrorIsNotDisplayedAfterChangingProfileDataTwice
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User enters 'TestAdmin' text to 'Full Name' textbox
	When User enters 'automation3@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button
	Then inline error banner is not displayed
	Then 'TestAdmin' content is displayed in 'Full Name' textbox
	Then 'automation3@juriba.com' content is displayed in 'Email' textbox
	When User enters 'TestAdm' text to 'Full Name' textbox
	Then inline error banner is not displayed
	When User enters 'Administrator' text to 'Full Name' textbox
	When User enters 'automation@juriba.com' text to 'Email' textbox
	And User clicks 'UPDATE' button

@Evergreen @ProfileDetails @EvergreenJnr_FilterFeature @UserProfile @DAS13026 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_ChecksListPageSizeAPI
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
	When User enters '2500' text to 'List Page Size' textbox
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on inline success banner
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	And page Size is "2500" on "Devices" page
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
	When User enters '1000' text to 'List Page Size' textbox
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on inline success banner

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
	When User enters "2004 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Readiness' left menu item
	Then Cog-menu DDL is displayed in High Contrast mode
	When User clicks Profile in Account Dropdown
	When User navigates to the 'Preferences' left menu item
	When User selects 'Normal' in the 'Display Mode' dropdown
	When User clicks 'UPDATE' button

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS13026 @Remove_Profile_Changes
Scenario: EvergreenJnr_UserProfile_ChangingListPageSizeAndListPagesToCache
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Advanced' left menu item
	When User enters '99' text to 'List Page Size' textbox
	Then '100' content is displayed in 'List Page Size' textbox
	When User enters '5001' text to 'List Page Size' textbox
	Then '5000' content is displayed in 'List Page Size' textbox
	When User enters '2' text to 'List Pages to Cache' textbox
	Then '3' content is displayed in 'List Pages to Cache' textbox
	When User enters '16' text to 'List Pages to Cache' textbox
	Then '15' content is displayed in 'List Pages to Cache' textbox
	When User enters random number between '100' and '5000' to 'List Page Size' textbox
	When User enters random number between '3' and '15' to 'List Pages to Cache' textbox
	And User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on inline success banner

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
	Then 'Current password is incorrect' text is displayed on inline error banner
	And There are no errors in the browser console
	When User enters 'IncorrectCurrentPassword' text to 'Current Password' textbox
	When User enters 'm!gration' text to 'New Password' textbox
	When User enters 'test5846' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'New password doesn't match' text is displayed on inline error banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters 'm!gration' text to 'New Password' textbox
	When User enters 'test5846pass' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'Your new password must be different to your current password' text is displayed on inline error banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters '54891' text to 'New Password' textbox
	When User enters '54891' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'New password must be at least 6 characters long' text is displayed on inline error banner
	And There are no errors in the browser console
	When User enters 'm!gration' text to 'Current Password' textbox
	When User enters 'test5846' text to 'New Password' textbox
	When User enters 'test5846' text to 'Confirm Password' textbox
	And User clicks 'UPDATE' button
	Then 'Password has been changed' text is displayed on inline success banner
	#Then Success message is displayed with "Password has been changed" text
	#Then Success message with "Password has been changed" text is displayed on the Change Password page
	And There are no errors in the browser console

 @Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS18672
Scenario: EvergreenJnr_UserProfile_CheckThatTimeZoneCanBeValidatedAndUpdated
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Preferences' left menu item
	Then '(UTC+00:00) Dublin, Edinburgh, Lisbon, London' content is displayed in 'Time Zone' autocomplete
	Then '(UTC+01:00) Dublin, Edinburgh, Lisbon, London' content is not displayed in 'Time Zone' autocomplete after search
	Then 'A time zone must be selected' error message is displayed for 'Time Zone' field 
	Then 'UPDATE' button is disabled
	When User selects '(UTC) Coordinated Universal Time' option after search from 'Time Zone' autocomplete
	When User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	When User navigates to the 'Preferences' left menu item
	Then '(UTC) Coordinated Universal Time' content is displayed in 'Time Zone' autocomplete

 @Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS19054
Scenario: EvergreenJnr_UserProfile_CheckUpdateButtonStateWhenSwitchingBetweenTabsWithoutAnyChanges
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Preferences' left menu item
	Then 'UPDATE' button is disabled
	When User navigates to the 'Advanced' left menu item
	Then 'UPDATE' button is disabled
	When User navigates to the 'Change Password' left menu item
	Then 'UPDATE' button is disabled
	When User navigates to the 'Account Details' left menu item
	Then 'UPDATE' button is disabled

@Evergreen @ProfileDetails @EvergreenJnr_ProfileDetails @UserProfile @DAS19271
Scenario: EvergreenJnr_UserProfile_CheckThatNoValidationErrorDisplayedAfterReselectingTimeZoneOption
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	When User navigates to the 'Preferences' left menu item
	Then 'Time Zone' autocomplete contains following options:
	| Options                                  |
	| (UTC-12:00) International Date Line West |
	Then inline error banner is not displayed
	When User selects '(UTC-12:00) International Date Line West' option after search from 'Time Zone' autocomplete
	When User clicks 'UPDATE' button
	Then 'User preferences have been changed' text is displayed on inline success banner
	When User navigates to the 'Advanced' left menu item
	When User navigates to the 'Preferences' left menu item
	Then '(UTC-12:00) International Date Line West' content is displayed in 'Time Zone' autocomplete