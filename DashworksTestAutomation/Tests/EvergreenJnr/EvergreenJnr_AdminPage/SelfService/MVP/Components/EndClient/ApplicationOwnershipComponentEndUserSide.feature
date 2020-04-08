Feature: ApplicationOwnershipComponentEndUserSide
		Scenarios related to last End User page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @DAS20322 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSide
	Given User resync 'Application' objects for '2004 Rollout' project
    | values     |
    | VSCmdShell |
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
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
 	| FirstColumn  | SecondColumn |
 	| Username     |              |
 	| Domain       |              |
 	| Display Name |              |
	When User clicks on 'Continue' button on end user Self Service page
	When User navigates to the 'Application' details page for 'VSCmdShell' item
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title     | Value |
	| App Owner |       |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @DAS20426 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSide
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20421_Proj | All Users | None            | Standalone Project |
	#User onboarding
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User expands 'Users to add' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                              |
	| 024213574157421A9CD (Reyes, Natasha) |
	| 03C54BC1198843A4A03 (Jones, Tina)    |
	When User clicks 'UPDATE ALL CHANGES' button
	When User clicks 'UPDATE PROJECT' button
	#Application onboarding
    When User navigates to the 'Applications' tab on Project Scope Changes page
    When User expands 'Applications to add' multiselect to the 'Applications' tab on Project Scope Changes page and selects following Objects
    | Objects    |
    | VSCmdShell |
    When User clicks 'UPDATE ALL CHANGES' button
    When User clicks 'UPDATE PROJECT' button
	When User create static list with "DAS_20421_forComponent" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20421" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20421_SS_1 | 20421_1_SI        | true    | true                | DAS_20421 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                            | UserScope              |
	| AOC Name      | DAS_20421_Proj | Allow owner to be set to another user only | DAS_20421_forComponent |
	When User navigates to End User landing page with '20421_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then popup with 'Change Owner' title is displayed
	Then 'Owner' autocomplete is displayed
	Then 'Change Owner' button is disabled on popup
	Then Button 'Change Owner' has 'Some values are missing or not valid' tooltip on popup
	When User clicks 'Cancel' button on popup
	Then popup is not displayed to User
	When User clicks on 'Change Owner' button on end user Self Service page
	When User enters 'Jones' in the 'Owner' autocomplete field and selects '03C54BC1198843A4A03 (Jones, Tina)' value
	When User clicks 'Change Owner' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn        |
	| Username     | 03C54BC1198843A4A03 |
	| Domain       | BCLABS              |
	| Display Name | Jones, Tina         |
	When User clicks on 'Continue' button on end user Self Service page
	#User navigates to Evergreen Dashworks - Applications - Application Details page to check that the changes applied
	When User navigates to the 'Application' details page for 'VSCmdShell' item
	When User selects 'DAS_20421_Proj' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title     | Value      |
	| App Owner | Jones Tina |

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
	When User checks 'Remove owner' radio button
	Then 'Change Owner' button is not disabled on popup
	When User checks 'Assign an owner' radio button
	Then 'Owner' autocomplete is displayed
	Then 'Change Owner' button is disabled on popup
	Then Button 'Change Owner' has 'Some values are missing or not valid' tooltip on popup
	Then 'Cancel' button is not disabled on popup

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20647 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatOwnerDropdownShowOnlyUsersThatHaveBeenOnboardedIntoProject
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20647_Proj | All Users | None            | Standalone Project |
	Then Page with 'DAS_20647_Proj' header is displayed to user
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands 'Users to add' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                           |
	| 03C54BC1198843A4A03 (Jones, Tina) |
	And User clicks 'UPDATE ALL CHANGES' button
	Then '1 user will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands 'Applications to add' multiselect to the 'Applications' tab on Project Scope Changes page and selects following Objects
	| Objects    |
	| VSCmdShell |
	And User clicks 'UPDATE ALL CHANGES' button
	Then '1 application will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User create static list with "DAS_20647_forComponent" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20647" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20647_SS_1 | 20647_1_SI        | true    | true                | DAS_20647 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                                  | UserScope              |
	| AOC Name      | DAS_20647_Proj | Allow owner to be removed or set to another user | DAS_20647_forComponent |
	When User navigates to End User landing page with '20647_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then only below options are displayed in 'Owner' autocomplete after search by '03C54BC1198843A4A03 (Jones, Tina)' text
	| Options                           |
	| 03C54BC1198843A4A03 (Jones, Tina) |
	When User clicks on 'Change Owner' button on end user Self Service page
	When User enters '024213574157421A9CD (Reyes, Natasha)' text to 'Owner' textbox
	Then 'Owner' autocomplete is not displayed