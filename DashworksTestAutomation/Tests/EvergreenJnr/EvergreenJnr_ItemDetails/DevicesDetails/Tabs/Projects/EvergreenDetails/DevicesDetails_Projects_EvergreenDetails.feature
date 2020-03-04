Feature: DevicesDetails_Projects_EvergreenDetails
	Runs related tests for Projects > Evergreen Details tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14941 @DAS12963
Scenario: EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Ring' field
	Then 'New Ring' autocomplete contains following options:
	| Options          |
	| Unassigned       |
	| Evergreen Ring 1 |
	| Evergreen Ring 3 |
	| TestBulkUpdate   |
	Then There are no errors in the browser console