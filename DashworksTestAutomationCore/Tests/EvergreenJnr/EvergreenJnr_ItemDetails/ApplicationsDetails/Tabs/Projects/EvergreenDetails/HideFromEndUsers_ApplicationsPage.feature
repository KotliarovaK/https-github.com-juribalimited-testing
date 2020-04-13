Feature: HideFromEndUsers_ApplicationsPage
	Runs related tests for Hide From End Users field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @HideFromEndUsers @DAS18849 @DAS19753 @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUserFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'ACDSee for Windows 95' item
	Then Details page for 'ACDSee for Windows 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| Hide From End Users | FALSE |
	When User selects 'TRUE' in the dropdown for the 'Hide From End Users' field
	Then 'Hide from end users successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title               | Value |
	| Hide From End Users | TRUE  |
	When User selects 'FALSE' in the dropdown for the 'Hide From End Users' field
	Then 'Hide from end users successfully changed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title               | Value |
	| Hide From End Users | FALSE |