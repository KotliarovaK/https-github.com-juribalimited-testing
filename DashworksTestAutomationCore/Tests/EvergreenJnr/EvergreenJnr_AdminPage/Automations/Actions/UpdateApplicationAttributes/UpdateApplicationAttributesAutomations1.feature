Feature: UpdateApplicationAttributesAutomations1
	Runs Update Application Attributes Actions type related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19003 @DAS19832 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationValidationsRun
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                     |
	| Effective File Search 2.12 |
	When User refreshes agGrid
	When User create dynamic list with "19832_List" name on "Applications" page
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| 19003_Automation | 19003       | true     | false              | 19832_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19003_Action1' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'yEnc32 (remove only)' in the 'Target Application' autocomplete field and selects 'yEnc32 (remove only) (1055)' value
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation' item from 'Automation' column
	When '19003_Automation' automation '19003_Action1' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19003_Automation" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then 'FORWARD PATH' content is displayed in the 'zDeviceAut: Rationalisation' column
	Then 'yEnc32 (remove only)' content is displayed in the 'zDeviceAut: Target App Name' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19003 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckUpdateRationalisationValidationsRunForwardPath
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values             |
	| CodeWright 6.0BETA |
	When User refreshes agGrid
	When User create dynamic list with "19003_List" name on "Applications" page
	When User creates new Automation via API and open it
	| Name              | Description | IsActive | StopOnFailedAction | Scope      | Run    |
	| 19003_Automation1 | test_19003  | true     | false              | 19003_List | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19003_Action2' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'CREATE' button
	#Run Automation
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation1' item from 'Automation' column
	When '19003_Automation1' automation '19003_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When '19003_Automation1' automation '19003_Action2' action run has finished
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then 'KEEP' content is displayed in the 'Evergreen Rationalisation' column
	#Return to previous value
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	When User navigates to the 'Actions' left menu item
	When User clicks content from "Action" column
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	And User clicks 'UPDATE' button
	When User clicks 'Automations' header breadcrumb
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	When User clicks 'Run now' option in Cog-menu for '19003_Automation1' item from 'Automation' column
	When '19003_Automation1' automation '19003_Action2' action run has finished
	When User navigates to the 'Automation Log' left menu item
	When User enters "19003_Automation1" text in the Search field for "Automation" column
	Then "SUCCESS" content is displayed for "Outcome" column
	When User unchecks following checkboxes in the filter dropdown menu for the 'Type' column:
	| checkboxes        |
	| Automation Finish |
	And User clicks content from "Objects" column
	Then 'RETIRE' content is displayed in the 'Evergreen Rationalisation' column

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19663 @DAS19229 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckEditActionPageIfProjectWasDeleted
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 19663_Automation | 19663       | true     | false              | All Applications | Manual |
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 19663_Project | All Devices | None            | Standalone Project |
	Then Page with '19663_Project' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects              |
	| BeoPlayer            |
	| Creative MediaSource |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Automations' left menu item
	Then Page with 'Automations' header is displayed to user
	When User enters "19663_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	When User clicks refresh button in the browser
	#Create Action
	When User clicks 'CREATE ACTION' button
	When User clicks refresh button in the browser
	And User enters '19663_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects '19663_Project' option from 'Project or Evergreen' autocomplete
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'CREATE' button
	#Delete Project
	When User clicks 'Automations' header breadcrumb
	When User navigates to the 'Projects' left menu item
	And User enters "19663_Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	#Check Action grid
	When User navigates to the 'Automations' left menu item
	When User enters "19663_Automation" text in the Search field for "Automation" column
	When User clicks content from "Automation" column
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	Then "[Project not found]" content is displayed for "Project" column
	#Check Edit Action page
	When User clicks content from "Action" column
	Then '[Project not found]' content is displayed in 'Project or Evergreen' textbox
	#Waiting for adding _ngcontent (Eugene K)
	#Then 'The selected project cannot be found' error message is displayed for 'Project or Evergreen' field
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then No error message is displayed for 'Project or Evergreen' field

@Evergreen @EvergreenJnr_AdminPage @Automations @DAS19690 @DAS20720 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatTargetApplicationNotFoundIsNotDisplayedOnEditActionPage
	When User creates new Automation via API and open it
	| Name             | Description | IsActive | StopOnFailedAction | Scope            | Run    |
	| 19690_Automation | 19690       | true     | false              | All Applications | Manual |
	Then Automation page is displayed correctly
	When User navigates to the 'Actions' left menu item
	#Create Action
	When User clicks 'CREATE ACTION' button
	And User enters '19690_Action' text to 'Action Name' textbox
	And User selects 'Update application attributes' in the 'Action Type' dropdown
	When User selects 'Project 000 M Computer Scheduled' option from 'Project or Evergreen' autocomplete
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Photo Premium' in the 'Target Application' autocomplete field and selects 'Microsoft Microsoft Photo Premium 10 10.0.0706 (534)' value
	When User clicks 'CREATE' button
	#Check Action Grid
	Then "Rationalisation" content is displayed for "Task or Field" column
	Then 'Project 000 M Computer Scheduled' content is displayed in the 'Project' column
	Then 'Forward Path, Microsoft Microsoft Photo Premium 10 10.0.0706' content is displayed in the 'Value' column
	When User clicks content from "Action" column
	#Check Edit Action Page
	Then 'Project 000 M Computer Scheduled' content is displayed in 'Project or Evergreen' autocomplete
	Then 'FORWARD PATH' content is displayed in 'Rationalisation' dropdown
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text