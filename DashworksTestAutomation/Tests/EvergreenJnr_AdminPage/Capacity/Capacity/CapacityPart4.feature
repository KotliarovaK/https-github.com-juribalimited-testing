Feature: CapacityPart4
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13928 @DAS14614 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlMessageAppearsWhenDefaultLanguageDoesNotHaveTranslations
	When Project created via API and opened
	| ProjectName                | Scope     | ProjectTemplate | Mode               |
	| ChecksDefaultLanguage13928 | All Users | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User selects "Scope Changes" tab on the Project details page
	And User expands multiselect and selects following Objects
	| Objects                                |
	| 1A701E05916148A6A3F (Fairlchild, Sara) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User navigates to the 'Details' left menu item
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Brazilian" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	And Error message with "You cannot update the default language to Brazilian because there are items in the project which have not been translated into this language." text is displayed
	When User navigates to the 'Scope' left menu item
	And User selects "Queue" tab on the Project details page
	Then Counter shows "1" found rows
	#When User selects "History" tab on the Project details page
	#And User enters "1A701E05916148A6A3F" text in the Search field for "Item" column
	#Then User clicks on "1A701E05916148A6A3F" search result
	#When User navigates to the "Projects" tab

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13422 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckingPercentageCapacityToReachBeforeShowingAmberField
	When Project created via API and opened
	| ProjectName        | Scope        | ProjectTemplate | Mode               |
	| ProjectForDAS13422 | 1803 Rollout | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User changes Percentage to reach before showing amber to "101"
	Then "UPDATE" Action button is disabled
	When User changes Percentage to reach before showing amber to "100"
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS14103 @DAS14172 @Cleanup @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits
	When Project created via API and opened
	| ProjectName        | Scope      | ProjectTemplate | Mode               |
	| ProjectForDAS14103 | All Device | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User selects "Teams and Paths" in the "Capacity Mode" dropdown
	And User selects "Clone evergreen capacity units to project capacity units" in the "Capacity Units" dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User creates new Capacity Unit via api
	| Name                       | Description | IsDefault |
	| Capacity Unit For DAS14103 |             | false     |
	And User navigates to newly created Capacity Unit
	And User selects "Devices" tab on the Capacity Units page
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected device has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Users" tab on the Capacity Units page
	Then "Users" tab is selected on the Admin page
	When User clicks the "ADD USER" Action button
	And User selects following Objects
	| Objects   |
	| AAC860150 |
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected user has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Applications" tab on the Capacity Units page
	Then "Applications" tab is selected on the Admin page
	When User clicks the "ADD APPLICATION" Action button
	And User selects following Objects
	| Objects                                                         |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	And User clicks the "ADD APPLICATIONS" Action button
	Then Success message is displayed and contains "The selected application has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS14103" text in the Search field for "Project" column
	And User click content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect to add objects 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User navigates to the 'Users' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect to add objects 
	And User selects following Objects
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect to add objects 
	And User selects following Objects
	| Objects                                    |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	And User enters "Capacity Unit For DAS14103" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Devices" column
	And "1" content is displayed in "Users" column
	And "1" content is displayed in "Applications" column
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Evergreen" link on the Admin page
	When User navigates to the 'Capacity Units' left menu item
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName           |
	| Capacity Unit For DAS14103 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13961 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatOriginalCapacityUnitStoredAndDisplayedIfCapacityUnitForOnboardedObjectsWasChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13961 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect to add objects 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items          |
	| 001BAQXT6JWFPI |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	When User navigates to the 'Capacity' left menu item
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project            |
	| CapacityUnit13961 |             | true      | ProjectForDAS13961 |
	And User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	And User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column