Feature: Ring_DevicesPage
	Runs related tests for Ring field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS17144 @DAS17163 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatValueForRingIsChangingSuccessfully
	When User creates new Ring via api
	| Name           | Description | IsDefault | Project      |
	| RingDAS17144_1 | DAS17144    | false     | 2004 Rollout |
	| RingDAS17144_2 | DAS17144    | false     | 2004 Rollout |
	When User navigates to the 'Device' details page for 'CDBR7TV3Y9T2ITS' item
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User selects 'RingDAS17144_1' in the dropdown for the 'Ring' field
	Then 'Device successfully moved to RingDAS17144_1' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title | Value          |
	| Ring  | RingDAS17144_1 |
	When User navigates to 'evergreen/#/admin/project/63/rings' URL in a new tab
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| RingDAS17144_2   |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected ring has been deleted' text is displayed on inline success banner
	When User switches to previous tab
	When User selects 'RingDAS17144_2' in the dropdown for the 'Ring' field
	Then 'Ring does not exist' text is displayed on inline error banner

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS17144 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksthatThePermissionIsWorkingCorrectlyForTheRingField
	When User create new User via API
	| Username     | Email | FullName | Password  | Roles                          |
	| UserDAS17144 | Value | DAS17144 | m!gration | Project Computer Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username     | Password  |
 	| UserDAS17144 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User navigates to the 'Device' details page for 'CDBR7TV3Y9T2ITS' item
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then arrow for editing the 'Ring' field is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS17144
Scenario: EvergreenJnr_DevicesList_CheckThatListOfRingsIsDisplayedCorrectlyOnTheDetailsPage
	When User navigates to the 'Device' details page for 'CDBR7TV3Y9T2ITS' item
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following Values are displayed in the dropdown for the 'Ring' field:
	| Value            |
	| Unassigned       |
	| Pilot            |
	| Early Adopters   |
	| IT Users         |
	| Business Wave 1  |
	| Business Wave 2  |
	| Business Wave 3  |
	| Critical Systems |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19948
Scenario: EvergreenJnr_DevicesList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeForDevicePage
	When User navigates to the 'Device' details page for the item with '6793' ID
	Then Details page for '00KWQ4J3WKQM0G' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title | Value      |
	| Ring  | Unassigned |
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then 'Ring' field is not displayed in the table