﻿Feature: CapacityUnit_ApplicationsPage
	Runs related tests for Capacity Unit fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19538 @Cleanup @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_ApplicationsList_CheckThatValueForCapacityUnitIsChangingSuccessfully
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project                      |
	| cu_DAS19538_3 | DAS19538    | false     | I-Computer Scheduled Project |
	When User navigates to the 'Application' details page for '20040610sqlserverck' item
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User switches to the "I-Computer Scheduled Project" project in the Top bar on Item details page
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