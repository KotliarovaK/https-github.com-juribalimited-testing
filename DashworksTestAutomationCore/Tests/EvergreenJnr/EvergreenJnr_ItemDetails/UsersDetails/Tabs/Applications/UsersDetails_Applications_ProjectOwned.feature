Feature: UsersDetails_Applications_ProjectOwned.feature
	Runs related tests for Applications > Project Owned tab 

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @UsersDetails @ApplicationsTab @DAS17808 @DAS18408 @DAS19246 @DAS20802
Scenario: EvergreenJnr_UsersList_CheckThatProjectOwnedSubtabIsDisplayedCorrectly
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for 'ZZP911429' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then 'No applications owned by this user' message is displayed on empty greed
	When User navigates to the 'User' details page for 'LYZ6880619' item
	Then Details page for 'LYZ6880619' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then "1" rows found label displays on Details Page
	When User clicks following checkboxes from Column Settings panel for the 'Target App' column:
	| checkboxes                     |
	| Vendor                         |
	| Version                        |
	| Application                    |
	| Hide From End Users            |
	| Rationalisation                |
	| Target App                     |
	| Target App Hide From End Users |
	| Target App Readiness           |
	Then following columns are displayed on the Item details page:
	| ColumnName                     |
	| Criticality                    |
	| Hide From End Users            |
	| Target App Criticality         |
	| Target App Hide From End Users |
	| Path                           |
	| Category                       |
	| Workflow                       |
	| Date                           |
	| Stage 3                        |

@Evergreen @Users @EvergreenJnr_ItemDetails @UsersDetails @ApplicationsTab @DAS18700
Scenario: EvergreenJnr_UsersList_CheckThatRationalisationColumnIsDisplayedCorrectlyOnProjectOwnedTab 
	When User navigates to the 'User' details page for 'LYZ6880619' item
	Then Details page for 'LYZ6880619' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then "Rationalisation" column is displayed to the user
	Then following checkboxes are displayed in the filter dropdown menu for the 'Rationalisation' column:
	| Values        |
	| UNCATEGORISED |
	When User closes Checkbox filter
	Then 'Rationalisation' column contains following content
	| Content       |
	| UNCATEGORISED |

@Evergreen @Users @EvergreenJnr_ItemDetails @UsersDetails @ApplicationsTab @DAS18743
Scenario: EvergreenJnr_UsersList_CheckThatLinksInProjectOwnedSubtabAreWorkingCorrectly
	When User navigates to the 'User' details page for 'LYZ6880619' item
	Then Details page for 'LYZ6880619' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	When User clicks "Quartus II 2.0 Web Edition Full" link on the Details Page
	Then Details page for 'Quartus II 2.0 Web Edition Full' item is displayed to the user
	Then User click back button in the browser
	And Details page for 'LYZ6880619' item is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @UsersDetails @ApplicationsTab @DAS19321
Scenario: EvergreenJnr_UsersList_CheckThatGridIsUpdatedOnTheProjectOwnedTabAfterChangingTheProject
	When User navigates to the 'User' details page for the item with '29342' ID
	Then Details page for 'SNL594136' item is displayed to the user
	When User selects 'Barry's User Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then 'VideoLAN VLC media player 0.8.2-test2 (A01)' content is displayed in the 'Application' column
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	Then 'Vertigo Managed Smart Documents Wrapper (SMS_GEN)' content is displayed in the 'Application' column

@Evergreen @Users @EvergreenJnr_ItemDetails @UsersDetails @ApplicationsTab @DAS20047 @DAS20088 @DAS20186
Scenario: EvergreenJnr_UsersList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnProjectOwnedTab
	When User navigates to the 'User' details page for the item with '537' ID
	Then Details page for 'CVS3269200' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Project Owned' left submenu item
	Then 'Empty' content is displayed in the 'Application' column
	When User click content from "Application" column
	Then 'User Evergreen Capacity Project' content is displayed in 'Item Details Project' dropdown
	Then 'Details' left menu item is expanded