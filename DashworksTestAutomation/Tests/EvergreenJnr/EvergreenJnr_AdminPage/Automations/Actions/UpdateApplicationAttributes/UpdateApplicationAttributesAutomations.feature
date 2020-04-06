Feature: UpdateApplicationAttributesAutomations
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18727 @DAS18966 @Cleanup
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
	| Remove    |
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
	Then 'SAVE & CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'SAVE & CREATE ANOTHER' button has tooltip with 'Some values are missing or not valid' text
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'CREATE' button is not disabled
	Then 'SAVE & CREATE ANOTHER' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'SAVE & CREATE ANOTHER' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18830 @DAS19135 @Cleanup
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
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18834 @DAS19033 @DAS17675 @Cleanup
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
	| Name             | Description | IsActive | StopOnFailedAction | Scope           | Run    |
	| 18834_Automation | 18834       | true     | false              | StaticList18834 | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18834_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Remove' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18834_Automation' item from 'Automation' column
	When '18834_Automation' automation '18834_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	Then current date and time are displayed for '18834_Automation' automation
	When User enters "18834_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
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
	Then 'UPDATE' button is disabled
	When User selects 'AMBER' in the 'Sticky Compliance' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '18834_Automation' item from 'Automation' column
	When User navigates to the 'Automation Log' left menu item
	When User clicks refresh button in the browser
	When User enters "18834_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then 'AMBER' content is displayed in the 'Sticky Compliance' column

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
	| Update custom field |
	| Update path         |
	| Update task value   |
	Then following Values are not displayed in the 'Action Type' dropdown:
	| Options                       |
	| Update application attributes |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup
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

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18966 @Cleanup
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
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	Then 'CREATE' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19240 @DAS18886 @Cleanup
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
	When User opens 'Action' column settings
	When User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Update Type" checkbox on the Column Settings panel
	Then "" content is displayed for "Update Type" column
	Then grid headers are displayed in the following order
	| ColumnName    |
	| Action        |
	|               |
	| Type          |
	| Project       |
	| Task or Field |
	| Update Type   |
	| Value         |

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19094 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationInActionGrid
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 19094_Automation | 19094       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '19094_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'No change' in the 'Sticky Compliance' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'CREATE' button
	#Check Action grid
	Then '19094_Action' content is displayed in the 'Action' column
	Then 'Keep' content is displayed in the 'Value' column
	Then 'Rationalisation' content is displayed in the 'Task or Field' column
	#Update Action
	When User clicks content from "Action" column
	When User enters '19094_New_Action' text to 'Action Name' textbox
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User clicks 'UPDATE' button
	#Check Action grid
	Then '19094_New_Action' content is displayed in the 'Action' column
	Then 'Retire' content is displayed in the 'Value' column
	Then 'Rationalisation' content is displayed in the 'Task or Field' column
	Then '2004 Rollout' content is displayed in the 'Project' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18978 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckSavingAndRestoringActionForUpdateApplicationAttributes
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18978_Automation | 18978       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18978_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Drawing Converter' in the 'Target Application' autocomplete field and selects 'Visio CAD Drawing Converter 1.0.0.0 (340)' value
	When User clicks 'CREATE' button
	#Check Action grid
	Then '18978_Action' content is displayed in the 'Action' column
	Then 'Rationalisation' content is displayed in the 'Task or Field' column
	Then 'Barry's User Project' content is displayed in the 'Project' column
	Then 'Forward Path, Visio CAD Drawing Converter 1.0.0.0' content is displayed in the 'Value' column
	#Check Action value
	When User clicks content from "Action" column
	Then "18978_Action" content is displayed in "Action Name" field
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Barry's User Project' content is displayed in 'Project or Evergreen' autocomplete
	Then 'FORWARD PATH' content is displayed in 'Rationalisation' dropdown
	Then 'Visio CAD Drawing Converter 1.0.0.0 (340)' content is displayed in 'Target Application' textbox
	#Update Action
	When User enters 'New_Action' text to 'Action Name' textbox
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'EC2ConfigService' in the 'Target Application' autocomplete field and selects 'Amazon Web Services EC2ConfigService 3.17.1032.0 (4006)' value
	When User clicks 'UPDATE' button
	#Check Action grid
	Then 'New_Action' content is displayed in the 'Action' column
	Then 'Forward Path, Amazon Web Services EC2ConfigService 3.17.1032.0' content is displayed in the 'Value' column
	Then 'Rationalisation' content is displayed in the 'Task or Field' column
	Then 'Email Migration' content is displayed in the 'Project' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18988 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationValidationWhenForwardPathIsSelected
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 18988_Automation | 18988       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '18988_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters '2' text to 'Target Application' textbox
	Then validation message 'Enter at least 3 characters' is displayed below 'Target Application' field
	When User enters 'Autotest' text to 'Target Application' textbox
	Then validation message 'No results found' is displayed below 'Target Application' field
	When User enters 'MacrShockwave80 ' in the 'Target Application' autocomplete field and selects 'Macromedia MacrShockwave80 8.0 (265)' value
	When User clicks 'CREATE' button
	#Check Action grid
	Then '18988_Action' content is displayed in the 'Action' column
	Then 'Rationalisation' content is displayed in the 'Task or Field' column
	Then 'Computer Scheduled Test (Jo)' content is displayed in the 'Project' column
	Then 'Forward Path, Macromedia MacrShockwave80 8.0' content is displayed in the 'Value' column