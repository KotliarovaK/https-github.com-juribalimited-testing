Feature: AutomationsPage2
	Runs Automations Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS19946 @Wormhole
Scenario: EvergreenJnr_AdminPage_CheckValidingForScopeLists
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "Mailboxes_Scope" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then 'Edit Automation' page subheader is displayed to user
	When User selects 'Mailbox List (Complex) - BROKEN LIST' option from 'Scope' autocomplete
	When User waits for info message disappears under 'Scope' field
	When User navigates to the 'Actions' left menu item
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20115 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCorrectTooltipIsDisplayedForAutomationnWhenListContainsMeOrMyTeamFilters
	When User clicks '<List>' on the left-hand menu
	When User clicks on '<Column>' column header
	When User create dynamic list with "<List>ListForAutomation_20115" name on "<List>" page
	Then "<List>ListForAutomation_20115" list is displayed to user
	When User creates new Automation via API
	| Name                   | Description | IsActive | StopOnFailedAction | Scope                         | Run    |
	| <List>Automation_20115 | test        | true     | false              | <List>ListForAutomation_20115 | Manual |
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "<Filter>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <Value>        |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to '<List>Automation_20115' automation details
	Then '<Message>' error message is displayed for 'Scope' field

Examples:
	| List    | Column   | Filter                                                                                                        | Value   | Message                                                                                                       |
	| Devices | Hostname | Windows7Mi: Computer Information ---- Text fill; Text fill; \ Computer Read Only Task in Self Service (Owner) | Me      | This list uses, or refers to a list that uses, a value of "Me" which is not valid as an automation scope      |
	| Users   | Username | Windows7Mi: Communication \ Send Applications List - User Object Task (Team)                                  | My Team | This list uses, or refers to a list that uses, a value of "My Team" which is not valid as an automation scope |

@Evergreen @Admin @EvergreenJnr_AdminPage @Automations @DAS20759 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatAutomationWithUnknownNameCanBeCreated
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User clicks 'CREATE AUTOMATION' button 
	When User enters 'Unknown' text to 'Automation Name' textbox
	When User enters 'test_20759' text to 'Description' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User selects 'Manual' in the 'Run' dropdown
	When User clicks 'CREATE' button
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Automations' left menu item
	When User enters "Unknown" text in the Search field for "Automation" column
	Then 'Unknown' content is displayed in the 'Automation' column

@Evergreen @Automations @DAS20954 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatAutomationActionLabelIsDisplayedForSelectedFilter
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 20954_Project | All Devices | None            | Standalone Project |
	Then Page with '20954_Project' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects        |
	| 00KWQ4J3WKQM0G |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User creates new Automation via API and open it
	| Name     | Description | IsActive | StopOnFailedAction | Scope       | Run    |
	| DAS20954 | DAS20954    | true     | false              | All Devices | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks 'CREATE ACTION' button 
	Then Create Action page is displayed to the User
	When User enters 'DAS20954_Action' text to 'Action Name' textbox
	When User selects 'Update ring' in the 'Action Type' dropdown
	When User selects '20954_Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Ring' autocomplete
	When User clicks 'CREATE' button
	When User clicks 'Automations' header breadcrumb
	Then Page with 'Automations' header is displayed to user
	When User enters "DAS20954" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for 'DAS20954' item from 'Automation' column
	When 'DAS20954' automation 'DAS20954_Action' action run has finished
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And user select "DAS20954 \ DAS20954_Action" filter
	And User checks 'Empty' checkbox
	And User clicks 'ADD' button
	Then "Automation Action DAS20954 \ DAS20954_Action is Empty" is displayed in added filter info