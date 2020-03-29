﻿Feature: LastPageMVP
		Scenarios related to last End User page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20325 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEndUserLastPage
	When User create static list with "DAS_20325" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20325_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20325_SS_1 | 20325_1_SI        | true    | true                | DAS_20325 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                  |
	| AOC Name      | 2004 Rollout | Do not allow owner to be changed |
	When User navigates to the 'Builder' left menu item
	Then User sees item with 'Text' type and 'Thank You' name on Self Service Builder Panel
	When User navigates to firs End User page with '20325_1_SI' Self Service Identifier
	When User clicks on 'Continue' button on end user Self Service page
	Then Header is displayed on End User page
	Then Subject Title 'Application: VSCmdShell' is displayed on End User page
	Then 'Continue' button is not displayed for End User
	Then 'Undo all changes I made on this page' button is not displayed for End User
	Then 'Back' button displayed for End User
	Then User sees 'Thank You' text component 'Thank You' on end user page
	Then User sees 'You have completed the self service.' text styled as 'Normal' in 'Thank You' Text Component of 'Thank You' on end user page
	Then User sees 'You can now close the page.' text styled as 'Normal' in 'Thank You' Text Component of 'Thank You' on end user page