Feature: Relink_UsersPage
	Runs Relink related tests on Users Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#need to add cleanup
@Evergreen @Users @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @Cleanup @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnUsersPage
	When User navigates to the 'User' details page for 'ZZR457072' item
	Then Details page for 'ZZR457072' item is displayed to the user
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title | Value     |
	| Name  | ZZR457072 |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	And 'Resync apps' checkbox is checked
	And 'Resync name' checkbox is checked
	When User enters 'dsf' in the 'User' autocomplete field and selects 'DSF4350513' value
	When User selects state 'true' for 'Resync apps' checkbox
	When User selects state 'true' for 'Resync name' checkbox
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'User successfully relinked' text is displayed on inline success banner
	#waiting for the RELINK process to be completed
	When User waits for '3' seconds
	Then Details page for 'DSF4350513' item is displayed to the user
	And following content is displayed on the Details Page
	| Title | Value     |
	| Name  | ZZR457072 |
	When User clicks 'RESYNC' button
	And User clicks 'RESYNC' button on popup
	Then 'User successfully resynced' text is displayed on inline success banner
	#waiting for the RESYNC process to be completed
	When User waits for '3' seconds
	Then following content is displayed on the Details Page
	| Title | Value      |
	| Name  | DSF4350513 |
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	Then "11" rows found label displays on Details Page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'RELINK' button
	And User enters 'ZZR457072' in the 'User' autocomplete field and selects 'ZZR457072' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'User successfully relinked' text is displayed on inline success banner
	#waiting for the RELINK process to be completed
	When User waits for '3' seconds

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19335
Scenario: EvergreenJnr_UsersList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed
	When User navigates to the 'User' details page for 'SNL594136' item
	Then Details page for 'SNL594136' item is displayed to the user
	When User selects 'Windows 10 Migration - Depot' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then popup is displayed to User
	Then Button 'RELINK' has 'Select a user' tooltip on popup

@Evergreen @User @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_UserList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'User' details page for '013DA2178AB4444CAF2' item
	Then Details page for '013DA2178AB4444CAF2 (Filler, Ed)' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '80568' are displayed in 'User' autocomplete