Feature: CreateAutomations
	Create Automations

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS15309 @DAS15626 @DAS16880 @DAS16931 @DAS17102 @DAS17630 @DAS18328 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckActionGridInAutomations
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	When User enters '15309_laptop' text to 'Automation Name' textbox
	When User enters '15309' text to 'Description' textbox
	Then Main lists are displayed correctly in the Scope dropdown
	| ListName         |
	| All Devices      |
	| All Device Types |
	| All Users        |
	| All Applications |
	| All Mailboxes    |
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User checks 'Active' checkbox
	When User checks 'Stop on failed action' checkbox
	Then 'CREATE' button is disabled
	When User selects 'Manual' in the 'Run' dropdown
	And User clicks 'CREATE' button 
	When User navigates to the 'Actions' left menu item
	Then "No actions found" message is displayed on the Admin Page
	Then 'CREATE ACTION' button is not disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS15764 @DAS15423 @DAS17134 @DAS17771 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreateAutomationFieldsIsNotPopulatedWithPreviouslyCreatedAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	Then following Values are displayed in the 'Run' dropdown:
	| Values                     |
	| Manual                     |
	| After Transform            |
	| Scheduled: Dashworks Daily |
	When User enters 'DAS16801_Automation' text to 'Automation Name' textbox
	When User enters 'LongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescription' text to 'Description' textbox
	When User selects '2004 Rollout' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User checks 'Active' checkbox
	And User clicks 'CREATE' button 
	When User clicks 'Automations' header breadcrumb
	When User clicks 'CREATE AUTOMATION' button 
	Then '' content is displayed in 'Description' textbox
	Then '' content is displayed in 'Automation Name' textbox
	Then '' content is displayed in 'Scope' textbox
	Then 'Active' checkbox is unchecked
	When User enters 'DAS16801_Automation_Second' text to 'Automation Name' textbox
	When User enters 'DAS16801' text to 'Description' textbox
	When User selects '2004 Rollout' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User checks 'Active' checkbox
	And User clicks 'CREATE' button 
	When User navigates to the 'Details' left menu item
	When User enters 'LongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescriptionLongDescription' text to 'Description' textbox
	Then 'UPDATE' button is not disabled
	When User enters 'DAS16801_Automation' text to 'Automation Name' textbox
	Then 'An automation with this name already exists' error message is displayed for 'Automation Name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16801 @DAS16805
Scenario: EvergreenJnr_AdminPage_CheckThatAdminTabIsHighlightedAfterClickingOnAutomation
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User clicks content from "Automation" column
	Then 'Edit Automation' page subheader is displayed to user
	Then 'Admin' left-hand menu is highlighted
	Then Automation page is displayed correctly
	Then 'Admin' left-hand menu is highlighted

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS16844 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationCanBeCreatedWithListHavingArchivedItems
	When User clicks 'Devices' on the left-hand menu
	And User sets includes archived devices in 'true'
	And User create dynamic list with "List16844" name on "Devices" page
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Automations' left menu item
	And User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	When User enters 'DAS16844_Automation' text to 'Automation Name' textbox
	And User enters 'DAS16844' text to 'Description' textbox
	When User selects 'List16844' option from 'Scope' autocomplete
	And User selects 'Manual' in the 'Run' dropdown
	And User checks 'Active' checkbox
	And User clicks 'CREATE' button 
	Then 'The automation has been created' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS17241 @Cleanup @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckScopeListsIconsForAutomations
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks on 'Username' column header
	And User create dynamic list with "17241_List" name on "Users" page
	Then "17241_List" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User clicks 'CREATE AUTOMATION' button 
	Then 'Create Automation' page subheader is displayed to user
	Then 'setting' icon displayed for 'All Devices' option from 'Scope' autocomplete
	Then 'hide' icon displayed for '2004 Stages' option from 'Scope' autocomplete
	Then 'visibility' icon displayed for 'Migration Type Capacity' option from 'Scope' autocomplete
	Then 'visibility_off' icon displayed for '17241_List' option from 'Scope' autocomplete

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20331 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageForScopeDropdown
	When User creates broken list with '20331_BrokenList' name on 'Users' page
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User clicks 'CREATE AUTOMATION' button 
	When User enters '20331_Automation' text to 'Automation Name' textbox
	When User enters '20331' text to 'Description' textbox
	When User selects '20331_BrokenList' option from 'Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'Scope' field
	When User selects 'All Users' option from 'Scope' autocomplete
	Then 'List validated' success message for 'Scope' field