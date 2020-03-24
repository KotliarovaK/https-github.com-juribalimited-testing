Feature: UpdateApplicationAttributesInCatalog
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19259 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckAutomationsActionsInCatalogCreateEditPageDisplay
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19259_Automation | 19259       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19259_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then 'InCatalog' dropdown is not displayed
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'No change' value is displayed in the 'In Catalog' dropdown
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Select at least one value to change' text
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User selects 'UNKNOWN' in the 'Sticky Compliance' dropdown
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Parental Controls' in the 'Target Application' autocomplete field and selects 'Yahoo! Yahoo! Parental Controls (1036)' value
	When User clicks 'CREATE' button
	#Check Action Grid
	Then "Sticky Compliance, In Catalog, Rationalisation" content is displayed for "Task or Field" column
	Then '' content is displayed in the 'Project' column
	Then 'Unknown, True, Forward Path, Yahoo! Yahoo! Parental Controls' content is displayed in the 'Value' column
	When User clicks content from "Action" column
	#Check Edit Action Page
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'UNKNOWN' content is displayed in 'Sticky Compliance' dropdown
	Then 'FORWARD PATH' content is displayed in 'Rationalisation' dropdown
	Then 'TRUE' value is displayed in the 'In Catalog' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19542 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckAutomationsActionsInCatalogRunNow
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values             |
	| CodeWright 6.0BETA |
	When User refreshes agGrid
	When User create dynamic list with "19542_List" name on "Applications" page
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope      | Run    |
	| 19542_Automation | 19542       | true   | false              | 19542_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19542_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19542_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19542_Automation' item from 'Automation' column
	When '19542_Automation' automation '19542_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19542_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then 'TRUE' content is displayed in the 'In Catalog' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19542_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'FALSE' in the 'In Catalog' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19542_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19542_Automation' item from 'Automation' column
	When '19542_Automation' automation '19542_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19542_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	Then 'FALSE' content is displayed in the 'In Catalog' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19541 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckAutomationsActionsInCatalogSavingAndRestoringValues
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope            | Run    |
	| 19541_Automation | 19541       | true   | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19541_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'TRUE' in the 'In Catalog' dropdown
	When User selects 'UNKNOWN' in the 'Sticky Compliance' dropdown
	When User clicks 'CREATE' button
	When User clicks content from "Action" column
	#Check Edit Action Page
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'UNKNOWN' content is displayed in 'Sticky Compliance' dropdown
	Then 'TRUE' value is displayed in the 'In Catalog' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	#Updated Action
	When User selects 'FALSE' in the 'In Catalog' dropdown
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	When User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19541_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	#Check Updated Actio
	Then 'Evergreen' content is displayed in 'Project or Evergreen' autocomplete
	Then 'RED' content is displayed in 'Sticky Compliance' dropdown
	Then 'FALSE' value is displayed in the 'In Catalog' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19629 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckObjectsInAutomationsLogForProjectAndEvergreen
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values       |
	| VBA (2627.4) |
	When User refreshes agGrid
	When User create dynamic list with "19629_List" name on "Applications" page
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope      | Run    |
	| 19629_Automation | 19629       | true   | false              | 19629_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19629_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Starbase Cosmic' in the 'Target Application' autocomplete field and selects 'Starbase Cosmic CodeWright Integrator (11)' value
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19629_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19629_Automation' item from 'Automation' column
	When '19629_Automation' automation '19629_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When '19629_Automation' automation '19629_Action' action run has finished
	When User enters "19629_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19629_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'zUser Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Starbase CodeWright ' in the 'Target Application' autocomplete field and selects 'Starbase CodeWright 6.0BETA (107)' value
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19629_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19629_Automation' item from 'Automation' column
	When '19629_Automation' automation '19629_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19629_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Objects' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19926 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckRunningAutomationsBasedOnApplicationsListWithInScopeFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	When User refreshes agGrid
	When User create dynamic list with "19926_List" name on "Applications" page
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope      | Run    |
	| 19926_Automation | 19926       | true   | false              | 19926_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User enters '19926_Action' text to 'Action Name' textbox
	When User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19926_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19926_Automation' item from 'Automation' column
	When '19926_Automation' automation '19926_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When '19926_Automation' automation '19926_Action' action run has finished
	When User enters "19926_Automation" text in the Search field for "Automation" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	Then "SUCCESS" content is displayed for "Outcome" column