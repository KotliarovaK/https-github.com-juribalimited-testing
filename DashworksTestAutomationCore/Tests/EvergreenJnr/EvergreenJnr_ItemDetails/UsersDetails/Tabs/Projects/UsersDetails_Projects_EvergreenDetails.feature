Feature: UsersDetails_Projects_EvergreenDetails
	Runs related tests for Projects > Evergreen Details tab on Users Details page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 3/18/20: This is implemented only for 'Wormhole'
@Evergreen @Users @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20323 @DAS20382 @Cleanup @Wormhole
Scenario: EvergreenJnr_UsersList_CheckThatErrorMessageIsDisplayedOnTheObjectDetailsPageIfEvergreenBucketChangedByAdminUser
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username           | Password |
	| TestAnalysisEditor | qa111111 |
	Then Evergreen Dashboards page should be displayed to the user
	When User navigates to the 'User' details page for '00BDBAEA57334C7C8F4' item
	Then Details page for '00BDBAEA57334C7C8F4' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title            | Value     |
	| Evergreen Bucket | Evergreen |
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects 'Manchester' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to Manchester' text is displayed on inline tip banner
	When User navigates to 'evergreen/#/user/87443/projects/evergreen' URL in a new tab
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects 'Birmingham' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to Birmingham, you will no longer be able to edit these objects' text is displayed on inline tip banner
	When User clicks 'MOVE' button on popup
	When User switches to previous tab
	When User clicks 'MOVE' button on popup
	Then 'You no longer has the permission to edit this User' text is displayed on inline error banner
	Then following content is displayed on the Details Page
	| Title            | Value      |
	| Evergreen Bucket | Birmingham |