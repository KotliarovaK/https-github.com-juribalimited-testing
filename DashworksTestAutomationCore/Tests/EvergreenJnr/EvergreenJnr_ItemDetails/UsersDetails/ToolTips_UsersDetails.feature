Feature: ToolTips_UsersDetails
	Runs User Item Details Top Bar  related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20762
Scenario: EvergreenJnr_UsersList_CheckThatTooltipIsDisplayedCorrectlyForReadinessValueOnTheDetailsPage
	When User navigates to the 'User' details page for 'XKP860180' item
	Then Details page for 'XKP860180' item is displayed to the user
	When User selects 'Barry's User Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item
	Then User sees 'Grey' tooltip for 'GREY' value in the field