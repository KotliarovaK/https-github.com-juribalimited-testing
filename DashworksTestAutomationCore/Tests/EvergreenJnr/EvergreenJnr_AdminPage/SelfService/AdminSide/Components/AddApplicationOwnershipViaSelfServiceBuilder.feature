Feature: AddApplicationOwnershipViaSelfServiceBuilder
	Add Application Ownership via Self Service builder

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneApplicationOwnershipInToFirstPage
	When Project created via API
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_19982_Proj_1 | All Users | None            | Standalone Project |
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
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'OwnComp_1' text to 'Component Name' textbox
	When User selects 'DAS_19982_Proj_1' option from 'Project' autocomplete
	When User clicks 'CREATE' button
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then User does not see 'Application Ownership' item on dialog

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatLastPageDoesNotAllowAnyInteractiveComponentToBeAdded 
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
	Then User does not see 'Application Ownership' item on dialog

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20243 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserUnableToCreateTwoApplicationOwnershipComponents
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_1' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	#Add first one AOC  
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'OwnComp_1' text to 'Component Name' textbox
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User opens 'TestP_ID_1' Self Service in a new tab
	#Try to add second one AOC in a new browser tab
	When User navigates to the 'Builder' left menu item
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then User sees 'Text' item on dialog
	Then User sees 'Application Ownership' item on dialog
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'OwnComp_1' text to 'Component Name' textbox
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User clicks 'CREATE' button
	When User switches to previous tab
	When User clicks 'CREATE' button
	Then 'Only one app ownership component can be added to this page' text is displayed on inline tip banner