Feature: ToolTips_UsersDetails
	Runs related tests for tooltips check on User Item Details page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20762 @DAS20784 @DAS20113
Scenario: EvergreenJnr_UsersList_CheckThatTooltipIsDisplayedCorrectlyForReadinessValueOnTheDetailsPage
	When User navigates to the 'User' details page for the item with '85167' ID
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Project Details' left submenu item
	Then User sees 'Apps In Initiation' tooltip for 'LIGHT BLUE' value in the field
	Then User sees 'Apps In Initiation' tooltip for value with 'Overall Readiness' title in the top bar
	Then User sees 'Apps In Initiation' tooltip for value with 'Task Readiness' title in the top bar