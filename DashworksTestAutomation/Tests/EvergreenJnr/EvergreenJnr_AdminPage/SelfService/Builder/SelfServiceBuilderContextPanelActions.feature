Feature: SelfServiceBuilderContextPanelActions
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18994 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServicePageViaContextPanelCogMenu
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_1 | Test_ID_1         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_1         | TestPageName_1 | 3            | TestPageDisplayName_1 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on CogMenu button for item with 'Page' type and 'TestPageName_1' name on Self Service Builder Panel
	When User clicks 'Delete' option in opened Cog-menu