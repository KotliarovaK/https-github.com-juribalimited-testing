Feature: UsersDetails_Applications_EvergreenOwned.feature
	Runs related tests for Applications > Evergreen Owned tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18198 @DAS18876 @Set_Application_Owned_User @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatEvergreenOwnedSubtabIsDisplayedCorrectly
	Given Link user to the Evergreen application owned
	| UserName  | ApplicationId |
	| ZZP911429 | 57            |
	When User navigates to the 'User' details page for the item with '1100' ID
	Then Details page for 'FWU5490440' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Owned' left submenu item
	Then 'No applications owned by this user' message is displayed on empty greed
	When User navigates to the 'User' details page for the item with '5431' ID
	Then Details page for 'ZZP911429 (Jason R. Dominguez)' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Owned' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Application        |
	| Vendor             |
	| Version            |
	| Compliance         |
	| Rationalisation    |
	| Target App         |
	| In Catalog         |
	| Criticality        |
	| Hide From End User |
	Then Counter shows "1" found rows

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18854 @Set_Application_Owned_User
Scenario: EvergreenJnr_UsersList_CheckThatLinksInEvergreenOwnedSubtabAreWorkingCorrectly
	Given Link user to the Evergreen application owned
	| UserName  | ApplicationId |
	| ZZP911429 | 57            |
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for 'ZZP911429' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Owned' left submenu item
	When User clicks "DirectX 8.1 SDK for Visual Basic" link on the Details Page
	Then Details page for 'DirectX 8.1 SDK for Visual Basic' item is displayed to the user
	Then User click back button in the browser
	And Details page for 'ZZP911429' item is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20046 @Set_Application_Owned_User
Scenario: EvergreenJnr_UsersList_CheckThatGroupedNameIsNotDisplayedAsALink
	Given Link user to the Evergreen application owned
	| UserName  | ApplicationId |
	| ZZP911429 | 57            |
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for 'ZZP911429' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Owned' left submenu item
	When User clicks Group By button and set checkboxes state
	| Checkboxes  | State |
	| Application | true  |
	Then 'DirectX 8.1 SDK for Visual Basic' grouped name is not displayed as a link

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20047 @Set_Application_Owned_User
Scenario: EvergreenJnr_UsersList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnEvergreenOwnedTab
	Given Link user to the Evergreen application owned
	| UserName   | ApplicationId |
	| CVS3269200 | 4252          |
	When User navigates to the 'User' details page for 'CVS3269200' item
	Then Details page for 'CVS3269200' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Evergreen Owned' left submenu item
	Then 'Empty' content is displayed in the 'Application' column