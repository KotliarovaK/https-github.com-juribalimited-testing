Feature: ManageComponents
	Manage Components tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19215 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenСomponentIsSelectedAndTheUserCollapsesThePagesBranchThePageItemHasAnOrangeBorderAndNotOrangeText
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