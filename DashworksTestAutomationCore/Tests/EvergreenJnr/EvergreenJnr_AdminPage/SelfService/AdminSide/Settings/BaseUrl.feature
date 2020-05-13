Feature: BaseUrl
	Edit and Save Self Service base url

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @SelfService_BaseURL @Do_Not_Run_With_SelfService_BaseURL @DAS18941 @DAS19821 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCanEditBaseUrl
	When User sets self service base url as 'https://default.corp.juriba.com'
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User navigates to the 'Self Service Settings' left submenu item
	Then Page with 'Self Service Settings' header is displayed to user
	Then Page with 'Self Service Settings' subheader is displayed to user
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'https://autotest.corp.juriba.com' text to 'Base URL' textbox
	When User clicks 'UPDATE' button
	Then 'Self Services' left submenu item is active
	Then 'Self Service Settings' left submenu item is not active
	Then 'Self service settings have been updated' text is displayed on inline success banner
	When User navigates to the 'Self Service Settings' left submenu item
	Then 'UPDATE' button is disabled
	Then 'https://autotest.corp.juriba.com' content is displayed in 'Base URL' textbox
	When User enters 'https://autotest.corp.juriba.com/updated' text to 'Base URL' textbox
	Then 'UPDATE' button is not disabled
	Then self service base url is equals to 'https://autotest.corp.juriba.com'

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @SelfService_BaseURL @Do_Not_Run_With_SelfService_BaseURL @DAS18941 @DAS19821 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckBaseUrlValidationMessages
	When User sets self service base url as 'https://errormessagevalidation.corp.juriba.com'
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User navigates to the 'Self Service Settings' left submenu item
	#
	When User enters '' text to 'Base URL' textbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'Ensure the Base URL is in the format: http(s)://dashworks.mycorp.com' error message is displayed for 'Base URL' field
	#
	When User enters 'https://' text to 'Base URL' textbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'Ensure the Base URL is in the format: http(s)://dashworks.mycorp.com' error message is displayed for 'Base URL' field
	#
	When User enters 'https://te†st.com' text to 'Base URL' textbox
	Then 'UPDATE' button is disabled
	Then 'Ensure the Base URL is in the format: http(s)://dashworks.mycorp.com' error message is displayed for 'Base URL' field
	#
	When User enters '//test.com' text to 'Base URL' textbox
	Then 'UPDATE' button is disabled
	Then 'Ensure the Base URL is in the format: http(s)://dashworks.mycorp.com' error message is displayed for 'Base URL' field
	#
	When User enters 'http://okurl.com/' text to 'Base URL' textbox
	Then 'UPDATE' button is not disabled
	Then tooltip is not displayed for 'UPDATE' button
	When User clicks 'UPDATE' button
	Then 'Self service settings have been updated' text is displayed on inline success banner
	Then self service base url is equals to 'http://okurl.com'

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @SelfService_BaseURL @Do_Not_Run_With_SelfService_BaseURL @DAS19821 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCanCancelBaseUrlEditing
	When User sets self service base url as 'https://cancelediting.corp.juriba.com'
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User navigates to the 'Self Service Settings' left submenu item
	When User enters 'https://testcancelation.corp.juriba.com' text to 'Base URL' textbox
	When User clicks 'CANCEL' button
	Then 'Self Services' left submenu item is active
	Then 'Self Service Settings' left submenu item is not active
	Then self service base url is equals to 'https://cancelediting.corp.juriba.com'

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21053 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceUrlGenerateCorretly
	When User creates Self Service via API and open it
	| Name         | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope            |
	| DAS_21053_SS | 21053_SI          | true    | true                | All Applications |
	When User sets self service base url as 'https://new.com'
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User opens 'DAS_21053_SS' Self Service
	Then Self Service URL preview that contains 'https://new.com' base URL and '21053_SI' Self Service identifier displays