Feature: UpdateApplicationAttributesAutomations1
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19003 @Universe
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationValidationsRun
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope     | Run    |
	| 19003_Automation | 19003       | true   | false              | 1803 Apps | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19003_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'yEnc32 (remove only)' in the 'Target Application' autocomplete field and selects 'yEnc32 (remove only) (1055)' value
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation' item from 'Automation' column
	When '19003_Automation' automation '19003_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                              |
	| zDeviceAut: Application Rationalisation |
	| zDeviceAut: Target App Friendly Name    |
	Then 'FORWARD PATH' content is displayed in the 'zDeviceAut: Application Rationalisation' column
	Then 'yEnc32 (remove only)' content is displayed in the 'zDeviceAut: Target App Friendly Name' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation' item from 'Automation' column
	When '19003_Automation' automation '19003_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                              |
	| zDeviceAut: Application Rationalisation |
	| zDeviceAut: Target App Friendly Name    |
	Then 'RETIRE' content is displayed in the 'zDeviceAut: Application Rationalisation' column
	Then '' content is displayed in the 'zDeviceAut: Target App Friendly Name' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19003 @Universe
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationValidationsRunForwardPath
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values             |
	| CodeWright 6.0BETA |
	When User create dynamic list with "19003_List" name on "Applications" page
	When User creates new Automation via API and open it
	| AutomationName    | Description | Active | StopOnFailedAction | Scope      | Run    |
	| 19003_Automation1 | 19003       | true   | false              | 19003_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19003_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation1' item from 'Automation' column
	When '19003_Automation1' automation '19003_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When '19003_Automation1' automation '19003_Action' action run has finished
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                              |
	| zDeviceAut: Application Rationalisation |
	| zDeviceAut: Target App Friendly Name    |
	Then 'KEEP' content is displayed in the 'zDeviceAut: Application Rationalisation' column
	Then 'yEnc32 (remove only)' content is displayed in the 'zDeviceAut: Target App Friendly Name' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation' item from 'Automation' column
	When '19003_Automation1' automation '19003_Action' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User clicks String Filter button for "Type" column on the Admin page
	When User selects "Automation Finish" checkbox from String Filter with item list on the Admin page
	And User clicks content from "Objects" column
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                              |
	| zDeviceAut: Application Rationalisation |
	| zDeviceAut: Target App Friendly Name    |
	Then 'FORWARD PATH' content is displayed in the 'zDeviceAut: Application Rationalisation' column
	Then 'RETIRE' content is displayed in the 'zDeviceAut: Target App Friendly Name' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19663 @Cleanup @Universe
Scenario: EvergreenJnr_AdminPage_CheckEditActionPageIfProjectWasDeleted
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 19663_Project | All Devices | None            | Standalone Project |
	#Need to Onboard Application
	When User creates new Automation via API and open it
	| AutomationName   | Description | Active | StopOnFailedAction | Scope           | Run    |
	| 19663_Automation | 19663       | true   | false              | All Application | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19663_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'CREATE' button