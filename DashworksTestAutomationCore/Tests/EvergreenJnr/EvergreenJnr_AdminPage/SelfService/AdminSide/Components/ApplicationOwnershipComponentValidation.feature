Feature: ApplicationOwnershipComponentValidation
	Application Ownership component Validation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CreateApplicationOwnershipPageValidation
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_11" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_1 | 19910_1_SI        | true    | true                | DAS_19910_1 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_1_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_1_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create is disabled by default
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#Empty component Name
	When User enters ' ' text to 'Component Name' textbox
	When User clicks Body container
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#Create become enabled again after correct data imput
	When User enters 'Name To Be Removed' text to 'Component Name' textbox
	When User selects 'DAS_19910_Proj' option from 'Project' autocomplete
	Then 'CREATE' button is not disabled
	#Create is disabled when User Scope is not set
	When User checks 'Allow owner to be removed or set to another user' radio button
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#AOC can be created when correct data is entered
	When User selects 'DAS_19910_11' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'CREATE' button is not disabled
	When User clicks 'CREATE' button
	Then 'The component has been created' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipPageValidationWhenUserScopeDeleted
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_2 | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_2" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_22" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_2 | 19910_2_SI        | true    | true                | DAS_19910_2 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_2_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_2_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                            | UserScope    | ShowInSelfService |
	| AOC Name      | DAS_19910_Proj_2 | Allow owner to be set to another user only | DAS_19910_22 | true              |
	When User navigates to the 'Builder' left submenu item
	#
	When User lists were removed by API
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'DAS_19910_Proj_2' content is displayed in 'Project' autocomplete
	Then '[List not found]' content is displayed in 'Owner Scope' autocomplete
	Then 'The selected list cannot be found' error message is displayed for 'Owner Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipPageValidationWhenBrokenListIsSelectedInUserScope
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_3 | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_3" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates broken list with 'Broken_DAS_19910_33' name on 'Users' page
	When User creates list with 'MissedClolumn_DAS_19910_33' name and missing column on 'Users' page
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_3 | 19910_3_SI        | true    | true                | DAS_19910_3 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_3_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_3_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create AOC
	When User enters 'AOC Name' text to 'Component Name' textbox
	When User selects 'DAS_19910_Proj_3' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	#Check that use is not able to create AOC with broken list
	When User selects 'Broken_DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'The selected list has errors' error message is displayed for 'Owner Scope' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#Check that use is not able to create AOC with list with missed columns
	When User selects 'MissedClolumn_DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'The selected list has errors' error message is displayed for 'Owner Scope' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#Check Broken list column validation
	When User selects 'DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	When User clicks 'CREATE' button
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User selects 'Broken_DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'The selected list has errors' error message is displayed for 'Owner Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#Check list with missed column validation
	When User selects 'DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	When User selects 'MissedClolumn_DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'The selected list has errors' error message is displayed for 'Owner Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipUpdateButtonValidation
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_4 | All Users | None            | Standalone Project |
	When Project created via API
	| ProjectName           | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_Test_3 | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_3" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_test_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_3 | 19910_3_SI        | true    | true                | DAS_19910_3 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_3_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_3_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                            | UserScope    | ShowInSelfService |
	| AOC Name      | DAS_19910_Proj_4 | Allow owner to be set to another user only | DAS_19910_33 | true              |
	When User opens 'DAS_19910_SS_3' Self Service
	When User navigates to the 'Builder' left submenu item
	#By default update button is disabled
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#UPDATE button is still disabled when user change name to the same one
	When User enters 'TEMP NAME' text to 'Component Name' textbox
	Then 'UPDATE' button is not disabled
	When User enters 'AOC Name' text to 'Component Name' textbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User selects 'DAS_19910_Proj_Test_3' option from 'Project' autocomplete
	Then 'UPDATE' button is not disabled
	When User selects 'DAS_19910_Proj_4' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#UPDATE button is still disabled when user change radiobutton selection to the same state
	When User checks 'Allow owner to be removed or set to another user' radio button
	Then 'UPDATE' button is not disabled
	When User checks 'Do not allow owner to be changed' radio button
	Then 'UPDATE' button is not disabled
	When User checks 'Allow owner to be set to another user only' radio button
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#Scope selection should be dropped
	Then '' content is displayed in 'Owner Scope' autocomplete
	When User selects 'DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#The steps below was disabled because of MVP changes, enable it when AOC component pass MVP stage
	#UPDATE button is still disabled when user change 'Show this component' selection to the same one
	#When User unchecks 'Show this component' checkbox
	#Then 'UPDATE' button is not disabled
	#When User checks 'Show this component' checkbox
	#Then 'UPDATE' button is disabled
	#Then 'UPDATE' button has tooltip with 'No changes made' text
	#UPDATE Owner Scope
	When User checks 'Allow owner to be removed or set to another user' radio button
	When User clicks 'UPDATE' button
	Then 'The application ownership component has been updated' text is displayed on inline success banner
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User waits for info message disappears under 'Owner Scope' field
	When User selects 'DAS_19910_test_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'UPDATE' button is not disabled
	When User selects 'DAS_19910_33' option from 'Owner Scope' autocomplete
	When User waits for info message disappears under 'Owner Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipPageValidationWhenProjectWasRemoved
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_5 | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_5" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_5 | 19910_5_SI        | true    | true                | DAS_19910_5 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_5_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_5_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                | ShowInSelfService |
	| AOC Name      | DAS_19910_Proj_5 | Allow owner to be removed only | true              |
	When User navigates to the 'Builder' left submenu item
	#
	When Projects created by User are removed via API
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then '[Project not found]' content is displayed in 'Project' autocomplete
	Then 'The selected project cannot be found' error message is displayed for 'Project' field