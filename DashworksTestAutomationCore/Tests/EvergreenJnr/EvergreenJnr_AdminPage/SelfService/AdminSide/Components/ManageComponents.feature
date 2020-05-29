Feature: ManageComponents
	Manage Components tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19215 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatWhenСomponentIsSelectedAndTheUserCollapsesThePagesBranchThePageItemHasAnOrangeBorderAndNotOrangeText
	When User create static list with "SelfServiceStaticAppList" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name       | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope                    |
	| TestProj_1 | Test_ID_1         | true    | true                | SelfServiceStaticAppList |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name          | DisplayName       | ShowInSelfService |
	| Test_ID_1         | TestPageSs1_1 | TestPageSsDisplay | false             |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name          | DisplayName       | ShowInSelfService |
	| Test_ID_1         | TestPageSs1_2 | TestPageSsDisplay | false             |
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left menu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1_1' name on Self Service Builder Panel
	When User clicks on 'Text' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'TextCompName_1' text to 'Component Name' textbox
	When User enters 'Some text for test 1' text to the text editor
	When User clicks 'CREATE' button
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs1_1' name on Self Service Builder Panel
	When User clicks on 'Text' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'TextCompName_2' text to 'Component Name' textbox
	When User enters 'Some text for test 1' text to the text editor
	When User clicks 'CREATE' button
	When User clicks on item with 'Text' type and 'TextCompName_1' name on Self Service Builder Panel
	When User clicks on Collapse button for item with 'Page' type and 'TestPageSs1_1' name on Self Service Builder Panel
	Then Item with 'Page' type and 'TestPageSs1_1' name on Self Service Builder Panel is highlighted
	Then Item name text with 'Page' type and 'TestPageSs1_1' name on Self Service Builder Panel is not highlighted

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21165 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_ChecThatProperErrorMessageDisplaysWhenUserIsTryingToUpdateNonExistingComponent
	When User create static list with "DAS_21165_AppList_2" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_21165_SS_2 | 21165_2_SI        | true    | true                | DAS_21165_AppList_2 |
	When User navigates to the 'Builder' left menu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Thank You' name on Self Service Builder Panel
	When User opens '21165_2_SI' Self Service in a new tab
	When User navigates to the 'Builder' left menu item
	When User selects 'Delete' cogmenu option for 'Text' item type with 'Thank You' name on Self Service Builder Panel
	When User clicks 'DELETE' button on inline tip banner
	When User switches to previous tab
	When User enters '_Additional_Text' text to the text editor
	When User clicks 'UPDATE' button
	Then 'This component does not exist' text is displayed on inline error banner