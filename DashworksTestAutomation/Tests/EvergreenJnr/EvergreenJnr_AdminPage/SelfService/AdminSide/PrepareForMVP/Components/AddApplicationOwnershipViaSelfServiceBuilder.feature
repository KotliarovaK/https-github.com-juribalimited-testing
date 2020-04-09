Feature: AddApplicationOwnershipViaSelfServiceBuilder
	Add Application Ownership via Self Service builder

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneApplicationOwnershipInToFirstPage
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name       | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                    |
	| TestProj_4 | Test_ID_4         | true    | true                | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name          | DisplayName       | ShowInSelfService |
	| Test_ID_4         | TestPageSs4_1 | TestPageSsDisplay | false             |
	| Test_ID_4         | TestPageSs4_2 | TestPageSsDisplay | false             |
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs4_1' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'OwnComp_1' text to 'Component Name' textbox
	#Replace project to some that will be created using API after 20114 implementation
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User clicks 'CREATE' button
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs4_1' name on Self Service Builder Panel
	Then 'Application Ownership' item on dialog is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatLastPageDoesNotAllowAnyInteractiveComponentToBeAdded 
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name       | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                    |
	| TestProj_5 | Test_ID_5         | true    | true                | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name         | DisplayName       | ShowInSelfService |
	| Test_ID_5         | TestPageSs_1 | TestPageSsDisplay | false             |
	| Test_ID_5         | TestPageSs_2 | TestPageSsDisplay | false             |
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs_2' name on Self Service Builder Panel
	Then 'Application Ownership' item on dialog is disabled