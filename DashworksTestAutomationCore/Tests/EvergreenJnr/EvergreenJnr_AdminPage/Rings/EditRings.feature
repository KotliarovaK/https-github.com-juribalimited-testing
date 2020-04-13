Feature: EditRings
	 Edit Ring

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14839 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatRingsDetailsPageCanBeSeenAfterTypeOfRingWasChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode                            |
	| ProjectForDAS14839 | All Devices | None            | Clone from Evergreen to Project |
	And User navigates to the 'Details' left menu item
	Then 'Clone Evergreen rings to project rings' content is displayed in 'Rings' dropdown
	When User navigates to the 'Rings' left menu item
	Then 'TRUE' content is displayed in the 'Default' column
	When User navigates to the 'Details' left menu item
	And User selects 'Use project rings' in the 'Rings' dropdown
	And User navigates to the 'Rings' left menu item
	And User clicks content from "Ring" column
	And User enters 'OneRing' text to 'Ring name' textbox
	And User enters 'TwoRing' text to 'Description' textbox
	And User clicks 'UPDATE' button 
	Then User sees "1" rows in grid
	When User clicks content from "Ring" column
	Then "OneRing" content is displayed in "Ring name" field
	Then "TwoRing" content is displayed in "Description" field