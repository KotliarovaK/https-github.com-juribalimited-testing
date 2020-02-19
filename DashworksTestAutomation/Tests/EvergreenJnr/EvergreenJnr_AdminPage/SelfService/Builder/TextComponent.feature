Feature: TextComponent
	Text Component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Vitalii: waiting steps from Andrew
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19979 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_TextComponentUiCheckForCreatePage
	When User create static list with "DAS_19979_11" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_19979_SS_1 | 19979_1_SI        | true    | true                | DAS_19979_11 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName    | ShowInSelfService |
	| 19979_1_SI        | TestPageSs2 | DAS_19979_Page | true              |
	#
	#Open Text Component
	#
	Then Page with 'DAS_19979_SS_1' header is displayed to user
	Then Page with 'Create Text Component' subheader is displayed to user
	Then 'TestPageSs2' label with self service parent page name is displayed
	Then text editor is displayed
	Then '' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is unchecked
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text

#Vitalii: waiting steps from Andrew
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19979 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_TextComponentUiCheckForUpdatePage
	When User create static list with "DAS_19979_22" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_19979_SS_2 | 19979_2_SI        | true    | true                | DAS_19979_22 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19979_2_SI        | TestPageSs3 | DAS_19979_Page_2 | true              |
	#
	#Open already Created Text component
	#
	Then Page with 'DAS_19979_SS_2' header is displayed to user
	Then Page with 'Create Text Component' subheader is displayed to user
	Then 'TestPageSs3' label with self service parent page name is displayed
	Then text editor is displayed
	Then 'COMPONENT_NAME' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is checked
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters '' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text