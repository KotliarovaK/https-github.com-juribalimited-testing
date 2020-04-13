Feature: CapacityUnit_ApplicationsPage
	Runs related tests for Capacity Unit fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19538 @Cleanup @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_ApplicationsList_CheckThatValueForCapacityUnitIsChangingSuccessfully
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project                           |
	| cu_DAS19538_3 | DAS19538    | false     | USE ME FOR AUTOMATION(USR SCHDLD) |
	When User navigates to the 'Application' details page for the item with '419' ID
	Then Details page for 'ACDSee 4.0' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then 'MOVE' button is disabled on popup
	When User selects 'cu_DAS19538_3' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'Application successfully moved to cu_DAS19538_3' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_3 |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18607 @DAS19651 @DAS19318
Scenario: EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for 'GogoTools version 2.1.0.9' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User selects 'Important' in the dropdown for the 'Criticality' field
	Then 'Criticality successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title       | Value     |
	| Criticality | Important |
	When User selects 'Uncategorised' in the dropdown for the 'Criticality' field
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18852 @DAS19651 @DAS19318 @Universe
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
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User clicks 'CANCEL' button
	When User clicks on edit button for 'Rationalisation' field
	Then popup is displayed to User
	When User clicks 'CANCEL' button