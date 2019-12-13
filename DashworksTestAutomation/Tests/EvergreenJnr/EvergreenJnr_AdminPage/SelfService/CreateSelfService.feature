Feature: CreateSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateSelfService
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Service' left menu item
	Then Page with 'Self Service' header is displayed to user
	When User clicks 'CREATE SELF SERVICE' button
	Then Page with 'Self Service' header is displayed to user
	Then There are no errors in the browser console
	When User enters 'TestProject1' text to 'Self Service Name' textbox
	When User selects 'a1' option from 'Self Service Scope' autocomplete
	When User enters 'TestProjectSSIdentifier1' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	When User clicks 'CREATE' button