Feature: AddTextComponentViaSelfServiceBuilder
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserSeesProperTootltipForAddItemButton
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                    |
	| 1         | TestProj_1 | Test_ID_1         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | ObjectTypeId | DisplayName       | ShowInSelfService |
	| Test_ID_1         | TestPageSs1 | 3            | TestPageSsDisplay | false             |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
    Then User sees 'Add Component' tootltip text of Add Item button for item with 'Page' type and 'TestPageSs1' name on Self Service Builder Panel

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheAddComponentPopUpHasAListOfAvailableComponents
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                    |
	| 1         | TestProj_2 | Test_ID_2         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | ObjectTypeId | DisplayName       | ShowInSelfService |
	| Test_ID_1         | TestPageSs2 | 3            | TestPageSsDisplay | false             |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_2' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs2' name on Self Service Builder Panel
	Then popup with 'Add Component' title is displayed
	Then User sees 'Text' component on dialog page
	Then User sees 'Application Ownership' component on dialog page

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWillBeHighlightedAndAddButtonEnabled
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                    |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | ObjectTypeId | DisplayName       | ShowInSelfService |
	| Test_ID_3         | TestPageSs3 | 3            | TestPageSsDisplay | false             |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_3' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs3' name on Self Service Builder Panel
	Then 'ADD' button is disabled on popup
	Then 'CANCEL' button is not disabled on popup
	Then Button 'ADD' has 'Select a component' tooltip on popup
    When User clicks on 'Text' component on dialog page
	Then 'CANCEL' button is not disabled on popup
	Then 'ADD' button is not disabled on popup
	Then 'Text' component on dialog page is highlighted

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19982 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAfterClickOnComponentItWillBejfhdhsiufhdsohfisdhfhsdifhsd
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                    |
	| 1         | TestProj_4 | Test_ID_4         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | ObjectTypeId | DisplayName       | ShowInSelfService |
	| Test_ID_4         | TestPageSs4 | 3            | TestPageSsDisplay | false             |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
    When User clicks on Add Item button for item with 'Page' type and 'TestPageSs4' name on Self Service Builder Panel
    When User clicks on 'Text' component on dialog page
	When User clicks 'ADD' button on popup
	Then popup is not displayed to User