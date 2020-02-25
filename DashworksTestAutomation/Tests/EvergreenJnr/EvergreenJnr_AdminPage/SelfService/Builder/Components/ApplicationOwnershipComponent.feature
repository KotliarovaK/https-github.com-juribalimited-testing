Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Complete this test when DAS-20019 will be completelly implemented
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20019 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20019_Proj | All Users | None            | Standalone Project |
	When User create static list with "DAS_20019_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_20019_11" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20019_SS_1 | 20019_1_SI        | true    | true                | DAS_20019_1 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 20019_1_SI        | TestPageSs1 | DAS_20019_Page_1 | true              |
	| 20019_1_SI        | TestPageSs2 | DAS_20019_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	Then Page with 'Create App Ownership Component' subheader is displayed to user
	Then 'TestPageSs1' label with self service parent page name is displayed
	Then '' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is unchecked
	#If the user does not enter a component name a hint is shown with the text: A component name must be entered
	When User enters ' ' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	#Then '' content is displayed in 'Project' autocomplete
	#TODO update this part after 20114 will be implemented
	#Then 'Project' autocomplete contains following options:
	#| values         |
	#| DAS_20019_Proj |
	Then 'Do not allow owner to be changed' radio button is checked
	Then 'User Scope' autocomplete is not displayed
	When User clicks 'Allow owner to be removed only' radio button
	Then 'User Scope' autocomplete is not displayed
	When User clicks 'Allow owner to be set to another user only' radio button
	Then 'User Scope' autocomplete is displayed
	When User clicks 'Allow owner to be removed or set to another user' radio button
	Then 'User Scope' autocomplete is displayed
	#Then '' content is displayed in 'User Scope' autocomplete
	Then 'User Scope' autocomplete contains following options:
	| values       |
	| All Users    |
	| DAS_20019_11 |
	Then 'User Scope' autocomplete first option is 'All Users'
	Then following fields to display are displayed on app ownership component page
	| fields          |
	| Username (User) |
	| Domain          |
	| Display Name    |
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text