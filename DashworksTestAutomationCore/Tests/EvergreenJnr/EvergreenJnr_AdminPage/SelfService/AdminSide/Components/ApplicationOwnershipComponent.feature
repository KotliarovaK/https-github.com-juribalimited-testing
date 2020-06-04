Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20019 @DAS20153 @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20019_Proj | All Users | None            | Standalone Project |
	When User create static list with 'DAS_20019_1' name and 'Everyone can see' access type on 'Applications' page with following items
	| ItemName |
	|          |
	When User create static list with 'UserStatList_DAS_20019_1' name and 'Everyone can see' access type on 'Users' page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                    |
	| DAS_20019_SS_1 | 20019_1_SI        | true    | true                | UserStatList_DAS_20019_1 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 20019_1_SI        | TestPageSs1 | DAS_20019_Page_1 | true              |
	| 20019_1_SI        | TestPageSs2 | DAS_20019_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	Then Page with 'Create App Ownership Component' subheader is displayed to user
	Then Page with 'Owner' second level subheader is displayed to user
	Then following fields to display are displayed on application ownership component page
	| Fields to display |
	| Username          |
	| Domain            |
	| Display Name      |
	Then 'TestPageSs1' label with self service parent page name is displayed
	Then '' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is checked
	#If the user does not enter a component name a hint is shown with the text: A component name must be entered
	When User enters ' ' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then '' content is displayed in 'Project' autocomplete
	Then 'Project' autocomplete contains following options:
	| values         |
	| DAS_20019_Proj |
	Then 'Do not allow owner to be changed' radio button is checked
	Then 'Owner Scope' autocomplete is not displayed
	When User checks 'Allow owner to be removed only' radio button
	Then 'Owner Scope' autocomplete is not displayed
	When User checks 'Allow owner to be set to another user only' radio button
	Then 'Owner Scope' autocomplete is displayed
	When User checks 'Allow owner to be removed or set to another user' radio button
	Then 'Owner Scope' autocomplete is displayed
	Then '' content is displayed in 'Owner Scope' autocomplete
	Then 'Owner Scope' autocomplete contains following options:
	| values                   |
	| All Users                |
	| UserStatList_DAS_20019_1 |
	Then 'Owner Scope' autocomplete first option is 'All Users'
	Then following fields to display are displayed on application ownership component page
	| fields       |
	| Username     |
	| Domain       |
	| Display Name |
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19909 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EditApplicationOwnershipComponent
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_19909_Proj | All Users | None            | Standalone Project |
	When Project created via API and opened
	| ProjectName       | Scope     | ProjectTemplate | Mode               |
	| DAS_19909_Proj_Up | All Users | None            | Standalone Project |
	When User create static list with 'DAS_19909_2' name and 'Everyone can see' access type on 'Applications' page with following items
	| ItemName |
	|          |
	When User create static list with 'DAS_19909_3' name and 'Everyone can see' access type on 'Users' page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19909_SS_2 | 19909_2_SI        | true    | true                | DAS_19909_2 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19909_2_SI        | TestPageSs1 | DAS_19909_Page_1 | true              |
	| 19909_2_SI        | TestPageSs2 | DAS_19909_Page_2 | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                  |
	| AOC Name      | DAS_19909_Proj | Do not allow owner to be changed |
	When User navigates to the 'Builder' left submenu item
	#
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User waits for info message disappears under 'Owner Scope' field
	Then Page with 'Edit App Ownership Component' subheader is displayed to user
	Then 'Welcome' label with self service parent page name is displayed
	Then 'AOC Name' content is displayed in 'Component Name' textbox
	Then 'DAS_19909_Proj' content is displayed in 'Project' autocomplete
	Then 'Do not allow owner to be changed' radio button is checked
	#Return the step below to "unchecked" as soon as AOC component pass MVP stage
	Then 'Show this component' checkbox is checked
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#Update information
	When User enters 'AOC_Updated Name' text to 'Component Name' textbox
	When User selects 'DAS_19909_Proj_Up' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	When User selects 'DAS_19909_3' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	#The step below was disabled because of MVP changes, enable it when AOC component pass MVP stage
	#When User checks 'Show this component' checkbox
	When User clicks 'UPDATE' button
	#Check updated data
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC_Updated Name' name on Self Service Builder Panel
	Then Page with 'Edit App Ownership Component' subheader is displayed to user
	Then 'Welcome' label with self service parent page name is displayed
	Then 'AOC_Updated Name' content is displayed in 'Component Name' textbox
	Then 'DAS_19909_Proj_Up' content is displayed in 'Project' autocomplete
	Then 'Allow owner to be set to another user only' radio button is checked
	Then 'DAS_19909_3' content is displayed in 'Owner Scope' autocomplete
	Then 'Show this component' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19909 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CancelApplicationOwnershipComponentEditing
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19909_Proj_A | All Users | None            | Standalone Project |
	When Project created via API and opened
	| ProjectName         | Scope     | ProjectTemplate | Mode               |
	| DAS_19909_Proj_Up_A | All Users | None            | Standalone Project |
	When User create static list with 'DAS_19909_2_A' name and 'Everyone can see' access type on 'Applications' page with following items
	| ItemName |
	|          |
	When User create static list with 'DAS_19909_3_A' name and 'Everyone can see' access type on 'Users' page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name             | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope         |
	| DAS_19909_SS_2_A | 19909_2_AI        | true    | true                | DAS_19909_2_A |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                  |
	| AOC Name      | DAS_19909_Proj_A | Do not allow owner to be changed |
	When User navigates to the 'Builder' left submenu item
	#Update information
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User enters 'AOC_Updated Name' text to 'Component Name' textbox
	When User selects 'DAS_19909_Proj_Up_A' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	When User selects 'DAS_19909_3_A' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	#The step below was disabled because of MVP changes, enable it when AOC component pass MVP stage
	#When User checks 'Show this component' checkbox
	When User clicks 'CANCEL' button
	#Check that data is not updated
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User waits for info message disappears under 'Owner Scope' field
	Then 'AOC Name' content is displayed in 'Component Name' textbox
	Then 'DAS_19909_Proj_A' content is displayed in 'Project' autocomplete
	Then 'Do not allow owner to be changed' radio button is checked
	Then 'Owner Scope' autocomplete is not displayed
	When User checks 'Allow owner to be set to another user only' radio button
	Then '' content is displayed in 'Owner Scope' autocomplete
	#The step below was disabled because of MVP changes, enable it when AOC component pass MVP stage
	#Then 'Show this component' checkbox is unchecked