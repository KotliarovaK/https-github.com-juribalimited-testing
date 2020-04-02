Feature: ApplicationOwnershipComponentEndUserSide
		Scenarios related to last End User page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSide
	When User create static list with "DAS_20421" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20325_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20421_SS_1 | 20421_1_SI        | true    | true                | DAS_20421 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                |
	| AOC Name      | 2004 Rollout | Allow owner to be removed only |
	When User navigates to End User landing page with '20421_1_SI' Self Service Identifier
	When User clicks on 'Remove Owner' button on end user Self Service page
	Then 'Remove Owner' button is disabled for End User
	#Username, Domain and Display Name are empty

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSide
	When User create static list with "DAS_20421" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20325_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20421_SS_1 | 20421_1_SI        | true    | true                | DAS_20421 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                            |
	| AOC Name      | 2004 Rollout | Allow owner to be set to another user only |
	When User navigates to End User landing page with '20421_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then popup is displayed to User
	Then popup with 'Change Owner' title is displayed
	Then 'Owner' autocomplete is displayed
	Then 'Change Owner' button is disabled on popup
	Then Button 'Change Owner' has 'Some values are missing or not valid' tooltip on popup
	When User clicks 'Cancel' button on popup
	Then popup is not displayed to User

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserPage
	When User create static list with "DAS_20421" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20325_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20421_SS_1 | 20421_1_SI        | true    | true                | DAS_20421 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                                  |
	| AOC Name      | 2004 Rollout | Allow owner to be removed or set to another user |
	When User navigates to End User landing page with '20421_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then popup with 'Change Owner' title is displayed
	Then 'Remove owner' radio button is enabled
	Then 'Assign an owner' radio button is enabled
	Then 'Change Owner' button is disabled on popup
	Then Button 'Change Owner' has 'Some values are missing or not valid' tooltip on popup
	Then 'Change Owner' button is disabled on popup
	Then 'Cancel' button is not disabled on popup