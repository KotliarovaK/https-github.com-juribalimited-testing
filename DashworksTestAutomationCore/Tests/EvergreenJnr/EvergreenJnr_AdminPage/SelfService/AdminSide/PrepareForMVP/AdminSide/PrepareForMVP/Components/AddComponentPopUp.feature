Feature: AddComponentPopUp
	Tests that are related to Add Component PopUp

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasAListOfAvailableComponents
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
    | Name       | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                    |
    | TestProj_2 | Test_ID_2         | true    | true                | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| Test_ID_2         | TestPageSs2 | TestPageSsDisplay | false             |
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs2' name on Self Service Builder Panel
	Then popup with 'Add Component' title is displayed
	Then User sees 'Text' component on dialog
	Then User sees 'Application Ownership' component on dialog