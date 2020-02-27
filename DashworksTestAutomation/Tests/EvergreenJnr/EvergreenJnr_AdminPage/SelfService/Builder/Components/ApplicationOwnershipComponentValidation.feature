Feature: ApplicationOwnershipComponentValidation
	Application Ownership component Validation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Complete this test when DAS-19910 will be completelly implemented
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19910 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_CreateApplicationOwnershipPageValidation
	When Project created via API and opened
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