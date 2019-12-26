Feature: UpdateApplicationAttributesAutomations
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18727 @DAS18966 @Cleanup @Not_Ready
#Waiting 'Update application attributes' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesForAutomations
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18727_Automation | 18727       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18727_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then following Values are displayed in the 'Sticky Compliance' dropdown:
	| Options   |
	| No change |
	| Empty     |
	| UNKNOWN   |
	| RED       |
	| AMBER     |
	| GREEN     |
	| IGNORE    |
	Then following Values are displayed in the 'Rationalisation' dropdown:
	| Options       |
	| No change     |
	| FORWARD PATH  |
	| KEEP          |
	| RETIRE        |
	| UNCATEGORISED |
	Then 'CREATE' button is disabled
	Then 'SAVE AND CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	Then 'SAVE AND CREATE ANOTHER' button has tooltip with 'Select at least one value to change' text
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'CREATE' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18830 @DAS19135 @Cleanup @Not_Ready
#Waiting 'Update application attributes' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesSavingAndRestoringValues
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18830_Automation | 18830       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18830_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Sticky Compliance" content is displayed for "Task or Field" column
	Then "Update application attributes" content is displayed for "Type" column
	Then "Green" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '18830_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' dropdown
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18834 @DAS19033 @Cleanup @Not_Ready
#Waiting 'Update application attributes' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateApplicationAttributesRunAutomation
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                                 |
	| Infragistics NetAdvantage for .NET 2006 Vol. 3 CLR 2.0 |
	When User clicks the Actions button
	When User selects all rows on the grid
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticList18834" name
	Then "StaticList18834" list is displayed to user
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope           | Run    |
	| 18834_Automation | 18834       | true   | false              | StaticList18834 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18834_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Empty' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18834_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
	When '18834_Automation' automation '18834_Action' action run has finished
	When User clicks refresh button in the browser
	When User enters "18834_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| Sticky Compliance |
	Then '' content is displayed in the 'Sticky Compliance' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'IGNORE' in the 'Sticky Compliance' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User clicks 'Run now' option in Cog-menu for '18834_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18834_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName        |
	| Sticky Compliance |
	Then 'IGNORE' content is displayed in the 'Sticky Compliance' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateUpplicationAttributesNotShownForNoApplicationScopedAutomation
	When User creates new Automation via API and open it
	| AutomationName        | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 18966_User_Automation | 18966       | true   | false              | All Users | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '18966_Action' text to 'Action Name' textbox
	Then following Values are displayed in the 'Action Type' dropdown:
	| Value               |
	| Update path         |
	| Update task value   |
	| Update custom field |
	Then following Values are not displayed in the 'Action Type' dropdown:
	| Options                       |
	| Update application attributes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup @Not_Ready
#Waiting 'Update application attributes' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateUpplicationAttributesInAutomationsForMailboxesScopedProject
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18966_Automation1 | 18966       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18966_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup @Not_Ready
#Waiting 'Update application attributes' in the 'Action Type' dropdown for automation
Scenario: EvergreenJnr_AdminPage_CheckUpdateUpplicationAttributesInAutomationsForUserScopedProject
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18966_Automation2 | 18966       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18966_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateUpplicationAttributesInAutomationsForDevicesScopedProject
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18966_Automation3 | 18966       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18966_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects '1803 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19240 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUnknownValueDisplayingForUnknownRationalisation
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19240_Automation | 19240       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters 'Unknown' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'UNKNOWN' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Check Action grid
	Then 'Unknown' content is displayed in the 'Value' column
	Then 'Unknown' content is displayed in the 'Action' column