Feature: CreateSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi
	When User creates Self Service via API
	| Id | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId |
	| 1  | TestSelfService_name99 | id191879          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       |
	Then User checks the created Self Service via API