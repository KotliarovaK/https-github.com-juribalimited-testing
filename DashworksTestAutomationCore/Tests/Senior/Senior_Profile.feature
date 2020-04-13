Feature: Senior_Profile
	Runs Projects Profile related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Senior @Dashworks @Projects_Dashworks @Senior_Profile @DAS17586
Scenario: Senior_ChecksThatUserCanUpdateUserPasswordOnSenior
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Preferences page
	Then "User Profile" page is displayed to the user
	When User navigate to Change Password page
	Then "Change Password" page is displayed to the user
	When User enters "m!gration" in the Current Password field in Senior
	When User enters "123456" in the New Password field in Senior
	When User enters "123456" in the Confirm Password field in Senior
	When User submits password changes in Senior
	Then "Your password was successfully changed" message displayed on User Profile page
	#teardown
	When User navigate to Change Password page
	Then "Change Password" page is displayed to the user
	When User enters "123456" in the Current Password field in Senior
	When User enters "m!gration" in the New Password field in Senior
	When User enters "m!gration" in the Confirm Password field in Senior
	When User submits password changes in Senior
	Then "Your password was successfully changed" message displayed on User Profile page
