Feature: GeneralEndUser
	General scenarios related to End User pages

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20330 @Cleanup @SelfService @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisPageButtonIsntPresent
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_20330_Proj_1 | All Users | None            | Standalone Project |
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
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User create static list with "DAS_20330_forComponent_1" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20330_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Add an onboarded owner to the App
	When User navigates to the 'Application' details page for 'VSCmdShell' item
	When User selects 'DAS_20330_Proj_1' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'App Owner' field
	When User enters 'Natasha' in the 'User' autocomplete field and selects 'BCLABS\024213574157421A9CD (79951) - Reyes, Natasha' value
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20330_SS_1 | 20330_1_SI        | true    | true                | DAS_20330_1 |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText | ShowInSelfService |
	| Text_Component_Name_1 | <p>normal</p>       | true              |
	When User navigates to End User landing page with '20330_1_SI' Self Service Identifier
	Then 'Undo all changes I made on this page' button is not displayed for End User
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                  | UserScope                |
	| AOC Name      | DAS_20330_Proj_1 | Do not allow owner to be changed | DAS_20330_forComponent_1 |
	When User navigates to End User landing page with '20330_1_SI' Self Service Identifier
	Then 'Undo all changes I made on this page' button is not displayed for End User

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20330 @Cleanup @SelfService @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUndoAllChangesIMadeOnThisPageButtonWorksCorrectly
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_20330_Proj_2 | All Users | None            | Standalone Project |
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
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User create static list with "DAS_20330_forComponent_2" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20330_2" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	Given User resync 'Application' objects for 'DAS_20330_Proj_2' project
    | values     |
    | VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20330_SS_2 | 20330_2_SI        | true    | true                | DAS_20330_2 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                                  | UserScope                |
	| AOC Name      | DAS_20330_Proj_2 | Allow owner to be removed or set to another user | DAS_20330_forComponent_2 |
	When User navigates to End User landing page with '20330_2_SI' Self Service Identifier
	Then 'Undo all changes I made on this page' button is disabled for End User
	Then 'Undo all changes I made on this page' button has tooltip with 'You have not made any changes yet' text on end user Self Service page
	When User clicks on 'Change Owner' button on end user Self Service page
	When User checks 'Remove owner' radio button
	When User clicks 'Change Owner' button on popup
	When User clicks on 'Undo all changes I made on this page' button on end user Self Service page
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn   |
	| Username     | VGZ6407126     |
	| Domain       | FR             |
	| Display Name | Arlette Sicard |
	When User clicks on 'Change Owner' button on end user Self Service page
	When User checks 'Assign an owner' radio button
	When User enters 'Jones' in the 'Owner' autocomplete field and selects '03C54BC1198843A4A03 (Jones, Tina)' value
	When User clicks 'Change Owner' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn        |
	| Username     | 03C54BC1198843A4A03 |
	| Domain       | BCLABS              |
	| Display Name | Jones, Tina         |
	When User clicks on 'Undo all changes I made on this page' button on end user Self Service page
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn   |
	| Username     | VGZ6407126     |
	| Domain       | FR             |
	| Display Name | Arlette Sicard |  