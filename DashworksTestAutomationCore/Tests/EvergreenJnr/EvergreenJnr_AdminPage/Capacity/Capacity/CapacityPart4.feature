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
	And User navigates to the 'Scope Changes' left menu item
	And User expands multiselect and selects following Objects
	| Objects                                |
	| 1A701E05916148A6A3F (Fairlchild, Sara) |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Details' left menu item
	And User clicks 'ADD LANGUAGE' button
	And User selects "Brazilian" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	#DAS-19339 - message should not disappear. let's wait for 6 second to check this
	When User waits for '6' seconds
	Then 'You cannot update the default language to Brazilian because there are items in the project which have not been translated into this language.' text is displayed on inline error banner
	When User navigates to the 'Scope' left menu item
	#And User navigates to the 'Queue' left menu item
	#Then Counter shows "1" found rows
	When User navigates to the 'History' left menu item
	Then Following items displayed in the History table
	| Items               |
	| 1A701E05916148A6A3F |
	When User clicks on '1A701E05916148A6A3F' cell from 'Item' column
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13422 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckingPercentageCapacityToReachBeforeShowingAmberField
	When Project created via API and opened
	| ProjectName        | Scope        | ProjectTemplate | Mode               |
	| ProjectForDAS13422 | 2004 Rollout | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User changes Percentage to reach before showing amber to "101"
	Then 'UPDATE' button is disabled
	When User changes Percentage to reach before showing amber to "100"
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13961 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatOriginalCapacityUnitStoredAndDisplayedIfCapacityUnitForOnboardedObjectsWasChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13961 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect and selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	And User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items          |
	| 001BAQXT6JWFPI |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	When User navigates to the 'Capacity' left menu item
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project            |
	| CapacityUnit13961 |             | true      | ProjectForDAS13961 |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	And User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
