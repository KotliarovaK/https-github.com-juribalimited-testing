Feature: EvergreenCapacityUnit_EvergreenDetails_AppPage
	Runs related tests for Evergreen Capacity Units field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @EvergreenDetailsTab @EvergreenCapacityUnits @DAS21410 @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_ChecksThatNamesOfTheEvergreenCapacityUnitsOnTheEvergreenDetailsTabAreDisplayedAccordingToTheAdminPage
	When User navigates to the 'Application' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Details' left submenu item
	Then following Values are displayed in the dropdown for the 'Evergreen Capacity Unit' field:
	| Value                     |
	| Unassigned                |
	| Birmingham                |
	| Evergreen Capacity Unit 1 |
	| Evergreen Capacity Unit 2 |
	| Evergreen Capacity Unit 3 |
	| London - City             |
	| London - Southbank        |
	| Manchester                |
	| New York                  |

@Evergreen @Applications @EvergreenJnr_ItemDetails @EvergreenDetailsTab @DAS18852 @DAS19651 @DAS19318 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllFieldsAreAensitiveToSecurityRequirementsForAnalysisEditorRole
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password |
 	| TestBucketAuto | 123456   |
	Then Evergreen Dashboards page should be displayed to the user
	When User navigates to the 'Application' details page for 'ACDSee for Windows 95' item
	Then Details page for 'ACDSee for Windows 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following Values are displayed in the dropdown for the 'In Catalog' field:
	| Value |
	| TRUE  |
	| FALSE |
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	Then following Values are displayed in the dropdown for the 'Hide From End Users' field:
	| Value |
	| TRUE  |
	| FALSE |
	Then following Values are displayed in the dropdown for the 'Evergreen Capacity Unit' field:
	| Value                     |
	| Unassigned                |
	| Birmingham                |
	| Evergreen Capacity Unit 1 |
	| Evergreen Capacity Unit 2 |
	| Evergreen Capacity Unit 3 |
	| London - City             |
	| London - Southbank        |
	| Manchester                |
	| New York                  |
	When User clicks on edit button for 'Rationalisation' field
	Then popup is displayed to User
	When User clicks 'CANCEL' button