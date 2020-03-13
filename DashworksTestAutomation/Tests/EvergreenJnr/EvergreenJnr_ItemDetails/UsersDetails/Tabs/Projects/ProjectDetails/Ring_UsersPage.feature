Feature: Ring_UsersPage
	Runs related tests for Ring field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS17144 @DAS17145 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatValueForRingIsChangingSuccessfully
	When User creates new Ring via api
	| Name           | Description | IsDefault | Project                           |
	| RingDAS17144_1 | DAS17144    | false     | USE ME FOR AUTOMATION(USR SCHDLD) |
	| RingDAS17144_2 | DAS17144    | false     | USE ME FOR AUTOMATION(USR SCHDLD) |
	When User navigates to the 'User' details page for '0088FC8A50DD4344B92' item
	Then Details page for '0088FC8A50DD4344B92' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User selects 'RingDAS17144_1' in the dropdown for the 'Ring' field
	Then 'User successfully moved to RingDAS17144_1' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title | Value          |
	| Ring  | RingDAS17144_1 |
	When User navigates to 'evergreen/#/admin/project/72/rings' URL in a new tab
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

@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19948
Scenario: EvergreenJnr_UsersList_CheckThatRingFieldIsDisplayedDependingOnTheProjectScopeForUsersPage
	When User navigates to the 'User' details page for the item with '80600' ID
	Then Details page for '00CFE13AAE104724AF5 ' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title | Value       |
	| Ring  | Unassigned3 |
	When User selects '*Project K-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
	Then 'Ring' field is not displayed in the table
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then 'Ring' field is not displayed in the table