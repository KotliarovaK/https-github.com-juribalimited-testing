Feature: BaseUrl
	Edit and Save Self Service base url

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18941
Scenario: EvergreenJnr_AdminPage_CheckThatUserUserCanEditBaseUrl
	When User sets self service base url as 'https://default.corp.juriba.com'
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User navigates to the 'Self Service Settings' left submenu item
	Then Page with 'Self Services' header is displayed to user
	Then Page with 'Self Service Settings' subheader is displayed to user
	When User enters 'https://autotest.corp.juriba.com' text to 'Base URL' textbox
	When User clicks 'UPDATE' button
	Then 'Self service settings have been updated' text is displayed on inline success banner
	When User navigates to the 'Self Service Settings' left submenu item
	Then 'UPDATE' button is disabled
	Then 'https://autotest.corp.juriba.com' content is displayed in 'Base URL' textbox
	When User enters 'https://autotest.corp.juriba.com/updated' text to 'Base URL' textbox
	Then 'UPDATE' button is not disabled
	Then self service base url is equals to 'https://autotest.corp.juriba.com'