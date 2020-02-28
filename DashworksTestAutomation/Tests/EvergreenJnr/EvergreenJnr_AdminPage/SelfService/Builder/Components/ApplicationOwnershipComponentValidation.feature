Feature: ApplicationOwnershipComponentValidation
	Application Ownership component Validation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup
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
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
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
	#Uncomment this and remove line below when all rpojects will be available to select
	#When User selects 'DAS_19910_Proj' option from 'Project' autocomplete
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	Then 'CREATE' button is not disabled
	#Create is disabled when User Scope is not set
	When User checks 'Allow owner to be removed or set to another user' radio button
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#AOC can be created when correct data is entered
	When User selects 'DAS_19910_11' option from 'User Scope' autocomplete
	Then 'CREATE' button is not disabled
	When User clicks 'CREATE' button
	Then 'The component has been created' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup
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
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create AOC
	When User enters 'AOC Name' text to 'Component Name' textbox
	#Uncomment this and remove line below when all rpojects will be available to select
	#When User selects 'DAS_19910_Proj_2' option from 'Project' autocomplete
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	When User selects 'DAS_19910_22' option from 'User Scope' autocomplete
	When User clicks 'CREATE' button
	#
	When User lists were removed by API
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'User Evergreen Capacity Project' content is displayed in 'Project' autocomplete
	Then '[List not found]' content is displayed in 'User Scope' autocomplete
	Then 'The selected list cannot be found' error message is displayed for 'User Scope' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup
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
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create AOC
	When User enters 'AOC Name' text to 'Component Name' textbox
	#Uncomment this and remove line below when all rpojects will be available to select
	#When User selects 'DAS_19910_Proj_3' option from 'Project' autocomplete
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	When User selects 'Broken_DAS_19910_33' option from 'User Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'User Scope' dropdown
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	#Check Broken list column validation
	When User selects 'DAS_19910_33' option from 'User Scope' autocomplete
	When User clicks 'CREATE' button
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	When User selects 'Broken_DAS_19910_33' option from 'User Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'User Scope' dropdown
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'Some values are missing or not valid' text
	#Check list with missed column validation
	When User selects 'DAS_19910_33' option from 'User Scope' autocomplete
	When User selects 'MissedClolumn_DAS_19910_33' option from 'User Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'User Scope' dropdown
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipUpdatedButtonValidation
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
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_3 | 19910_3_SI        | true    | true                | DAS_19910_3 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_3_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_3_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create AOC
	When User enters 'AOC Name' text to 'Component Name' textbox
	#Uncomment this and remove line below when all rpojects will be available to select
	#When User selects 'DAS_19910_Proj_4' option from 'Project' autocomplete
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User checks 'Allow owner to be set to another user only' radio button
	When User selects 'DAS_19910_33' option from 'User Scope' autocomplete
	When User checks 'Show this component' checkbox
	When User clicks 'CREATE' button
	#By default update button is disabled
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	#Updated button is still disabled when user change name to the same one
	When User enters 'TEMP NAME' text to 'Component Name' textbox
	Then 'UPDATED' button is not disabled
	When User enters 'AOC Name' text to 'Component Name' textbox
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	#Updated button is still disabled when user change Project to the same one
	#When User selects 'DAS_19910_Proj_Test_3' option from 'Project' autocomplete
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then 'UPDATED' button is not disabled
	#When User selects 'DAS_19910_Proj_4' option from 'Project' autocomplete
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	#Updated button is still disabled when user change radiobutton selection to the same state
	When User checks 'Allow owner to be removed or set to another user' radio button
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'Some values are missing or not valid' text
	When User checks 'Allow owner to be set to another user only' radio button
	When User checks 'Do not allow owner to be changed' radio button
	Then 'UPDATED' button is not disabled
	When User checks 'Allow owner to be set to another user only' radio button
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	#Updated button is still disabled when user change 'Show this component' selection to the same one
	When User unchecks 'Show this component' checkbox
	Then 'UPDATED' button is not disabled
	When User checks 'Show this component' checkbox
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text
	#Updated User Scope
	When User checks 'Allow owner to be removed or set to another user' radio button
	When User selects 'DAS_19910_33' option from 'User Scope' autocomplete
	When User clicks 'UPDATE' button
	Then 'The AOC Name component has been updated' text is displayed on inline success banner
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User selects 'DAS_19910_test_33' option from 'User Scope' autocomplete
	Then 'UPDATED' button is not disabled
	When User selects 'DAS_19910_33' option from 'User Scope' autocomplete
	Then 'UPDATED' button is disabled
	Then 'UPDATED' button has tooltip with 'No changes made' text

	#Sould be updated after DAS-20114 implementation
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipPageValidationWhenProjectWasRemoved
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19910_Proj_5 | All Users | None            | Standalone Project |
	When User create static list with "DAS_19910_2" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_19910_22" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19910_SS_5 | 19910_5_SI        | true    | true                | DAS_19910_5 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19910_5_SI        | TestPageSs1 | DAS_19910_Page_1 | true              |
	| 19910_5_SI        | TestPageSs2 | DAS_19910_Page_2 | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	#Create AOC
	When User enters 'AOC Name' text to 'Component Name' textbox
	#Uncomment this and remove line below when all rpojects will be available to select: DAS-20114
	When User selects 'DAS_19910_Proj_5' option from 'Project' autocomplete
	When User clicks 'CREATE' button
	#
	When Projects created by User are removed via API
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	Then '[Project not found]' content is displayed in 'Project' autocomplete
	Then 'The selected project cannot be found' error message is displayed for 'User Scope' field