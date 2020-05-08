Feature: BaseUrlApi
	Edit and Save Self Service base url via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18941 @API @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserUserCanEditBaseUrlApi
	When User sets self service base url as 'https://api.test.corp.juriba.com'
	Then self service base url is equals to 'https://api.test.corp.juriba.com'