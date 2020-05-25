Feature: AddComponentPopUp
	Tests that are related to Add Component PopUp

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @DAS20069 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasAListOfAvailableComponents
	When User create static list with "DAS_19982_SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
    | Name                 | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                              |
    | DAS_19982_TestProj_2 | 19982_ID_2        | true    | true                | DAS_19982_SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| 19982_ID_2        | TestPageSs2 | TestPageSsDisplay | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then popup with 'Add Component' title is displayed
	Then User sees 'Text' item with 'Add text with rich formatting and pre-defined styles' description on dialog
	Then User sees 'Application Ownership' item with 'View and change app owner' description on dialog