﻿Feature: UpdateApplicationAttributesAutomations
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18727 @Cleanup @Not_Ready
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
	Then 'Evergreen' content is displayed in 'Project or Evergreen' dropdown
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then following Values are displayed in the 'Sticky Compliance' dropdown:
	| Options   |
	| No change |
	| UNKNOWN   |
	| RED       |
	| AMBER     |
	| GREEN     |
	| IGNORE    |
	Then 'CREATE' button is disabled
	Then 'SAVE AND CREATE ANOTHER' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	Then 'SAVE AND CREATE ANOTHER' button has tooltip with 'Select at least one value to change' text
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'CREATE' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'SAVE AND CREATE ANOTHER' button is not disabled

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18830 @Cleanup @Not_Ready
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
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Actions grid check
	Then "Sticky Compliance" content is displayed for "Task or Field" column
	Then "Update application attributes" content is displayed for "Type" column
	Then "GREEN" content is displayed for "Value" column
	#Actions content check
	When User clicks content from "Action" column
	Then 'Edit Action' page subheader is displayed to user
	Then '18830_Action' content is displayed in 'Action Name' textbox
	Then 'Update application attributes' content is displayed in 'Action Type' dropdown
	Then 'Evergreen' content is displayed in 'Project or Evergreen' dropdown
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS18834 @Cleanup @Not_Ready
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
	And User enters '18834_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18834_Automation" item on Admin page
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
	Then 'RED' content is displayed in the 'Sticky Compliance' column
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
	When User enters "18834_Automation" text in the Search field for "Automation" column
	When User clicks "Run now" option in Cog-menu for "18834_Automation" item on Admin page
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