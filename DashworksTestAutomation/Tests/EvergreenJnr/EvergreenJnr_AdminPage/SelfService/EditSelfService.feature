Feature: EditSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18214 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceIsMatchedToTheOpenedOneAndUserIsAbleToEditIt
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Service' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Name' column
	Then Page with 'TestProj_5' header is displayed to user
	Then 'TestProj_5' content is displayed in 'Self Service Name' textbox
	Then 'TestP_ID_5' content is displayed in 'Self Service Identifier' textbox
	Then 'Primary Object Type' dropdown is disabled
	Then '1803 Apps' content is displayed in 'Self Service Scope' autocomplete
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'NEW_TestProj_5' text to 'Self Service Name' textbox
	Then 'UPDATE' button is not disabled
	When User enters '' text to 'Self Service Name' textbox
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text