Feature: AddTextComponentViaSelfServiceBuilder
	Add text component via Self Service builder

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserSeesProperTootltipForAddItemButton
	When User create static list with "AppStatList_DAS_19982_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
    | Name                 | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                   |
    | TestProj_1_DAS_19982 | 19982_ID_1        | true    | true                | AppStatList_DAS_19982_1 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| 19982_ID_1        | TestPageSs1 | TestPageSsDisplay | false             |
	When User navigates to the 'Builder' left menu item
    Then User sees 'Add Component' tootltip text of Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWillBeHighlightedAndAddButtonEnabled
	When User create static list with "AppStatList_DAS_19982_3" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
    | Name                 | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                   |
    | TestProj_DAS_19982_3 | 19982_ID_3        | true    | true                | AppStatList_DAS_19982_3 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| 19982_ID_3        | TestPageSs3 | TestPageSsDisplay | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs3' name on Self Service Builder Panel
	Then 'ADD' button is disabled on popup
	Then 'CANCEL' button is not disabled on popup
	Then Button 'ADD' has 'Select a component' tooltip on popup
    When User clicks on 'Text' component on dialog
	Then 'CANCEL' button is not disabled on popup
	Then 'ADD' button is not disabled on popup
	Then 'Text' component on dialog is highlighted

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @DAS20765 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatWhenUserClickedOnAddButtonThePopupWillBeRemovedAndBuildeDesignSurfaceShowsCorrecComponentConfigurationPage
	When User create static list with "AppStatList_DAS_19982_4" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
    | Name                 | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                   |
    | TestProj_DAS_19982_4 | 19982_ID_4        | true    | true                | AppStatList_DAS_19982_4 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| 19982_ID_4        | TestPageSs4 | TestPageSsDisplay | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs4' name on Self Service Builder Panel
    When User clicks on 'Text' component on dialog
	Then popup is displayed to User
	When User clicks 'ADD' button on popup
	Then popup is not displayed to User
	Then 'CREATE' button is displayed
	Then 'CREATE' button is disabled
	Then 'CANCEL' button is displayed
	Then 'CANCEL' button is not disabled
	Then 'Show this component' checkbox is checked
	Then 'Show this component' checkbox is disabled
	Then Page with 'Create Text Component' subheader is displayed to user