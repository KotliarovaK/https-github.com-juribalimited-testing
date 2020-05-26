Feature: ApplicationOwnershipComponentEndUserSide
		Scenarios related to last End User page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @DAS20322 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckRemoveOwnerWorksProperlyOnEndUserSide
	When User resync 'Application' objects for '2004 Rollout' project
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @DAS20426 @DAS21095 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckChangeOwnerWorksProperlyOnEndUserSide
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
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
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
	Then 'Update' button is disabled on popup
	Then Button 'Update' has 'Some values are missing or not valid' tooltip on popup
	When User clicks 'Cancel' button on popup
	Then popup is not displayed to User
	When User clicks on 'Change Owner' button on end user Self Service page
	When User enters 'Jones' in the 'Owner' autocomplete field and selects '03C54BC1198843A4A03 (Jones, Tina)' value
	When User clicks 'Update' button on popup
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20421 @DAS20239 @DAS21095 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckChangeAndRemoveOwnerOnEndUserPage
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_20421_Proj_1 | All Users | None            | Standalone Project |
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
	When User create static list with "DAS_20421_AppList_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_20421_SS_1 | 20421_1_SI        | true    | true                | DAS_20421_AppList_1 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                                  | UserScope |
	| AOC Name      | DAS_20421_Proj_1 | Allow owner to be removed or set to another user | All Users |
	When User navigates to End User landing page with '20421_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	When User enters 'Jones' in the 'Owner' autocomplete field and selects '03C54BC1198843A4A03 (Jones, Tina)' value
	When User clicks 'Update' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn        |
	| Username     | 03C54BC1198843A4A03 |
	| Domain       | BCLABS              |
	| Display Name | Jones, Tina         |
	When User clicks on 'Change Owner' button on end user Self Service page
	Then popup with 'Change Owner' title is displayed
	Then 'Remove owner' radio button is enabled
	Then 'Assign an owner' radio button is enabled
	Then 'Update' button is disabled on popup
	Then Button 'Update' has 'Some values are missing or not valid' tooltip on popup
	Then 'Update' button is disabled on popup
	Then 'Cancel' button is not disabled on popup
	When User checks 'Remove owner' radio button
	Then 'Update' button is not disabled on popup
	When User checks 'Assign an owner' radio button
	Then 'Owner' autocomplete is displayed
	Then 'Update' button is disabled on popup
	Then Button 'Update' has 'Some values are missing or not valid' tooltip on popup
	Then 'Cancel' button is not disabled on popup

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20647 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatOwnerDropdownShowOnlyUsersThatHaveBeenOnboardedIntoProject
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20425 @DAS21095 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckRemovingAndAssigningNewOwner
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20425_Proj | All Users | None            | Standalone Project |
	#Change onbording to API step when DAS-20820 will be done
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands 'Users to add' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                              |
	| 024213574157421A9CD (Reyes, Natasha) |
	| 03C54BC1198843A4A03 (Jones, Tina)    |
	And User clicks 'UPDATE ALL CHANGES' button
	And User clicks 'UPDATE PROJECT' button
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#Change onbording to API step when DAS-20820 will be done
	When User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands 'Applications to add' multiselect to the 'Applications' tab on Project Scope Changes page and selects following Objects
	| Objects    |
	| VSCmdShell |
	And User clicks 'UPDATE ALL CHANGES' button
	And User clicks 'UPDATE PROJECT' button
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User create static list with "DAS_20425_forComponent" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20425" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20425_SS_1 | 20425_1_SI        | true    | true                | DAS_20425 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                                  | UserScope              | ShowInSelfService |
	| AOC Name      | DAS_20425_Proj | Allow owner to be removed or set to another user | DAS_20425_forComponent | true              |
	When User navigates to End User landing page with '20425_1_SI' Self Service Identifier
	And User clicks on 'Change Owner' button on end user Self Service page
	And User enters 'Jones' in the 'Owner' autocomplete field and selects '03C54BC1198843A4A03 (Jones, Tina)' value
	And User clicks 'Update' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn        |
	| Username     | 03C54BC1198843A4A03 |
	| Domain       | BCLABS              |
	| Display Name | Jones, Tina         |
	When User clicks on 'Continue' button on end user Self Service page
	And User navigates to the 'Application' details page for 'VSCmdShell' item
	Then Details page for 'VSCmdShell' item is displayed to the user
	When User selects 'DAS_20425_Proj' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title     | Value      |
	| App Owner | Jones Tina |
	When User navigates to End User landing page with '20425_1_SI' Self Service Identifier
	And User clicks on 'Change Owner' button on end user Self Service page
	And User checks 'Remove owner' radio button
	And User clicks 'Update' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn |
	| Username     |              |
	| Domain       |              |
	| Display Name |              |
	When User clicks on 'Continue' button on end user Self Service page
	And User navigates to the 'Application' details page for 'VSCmdShell' item
	Then Details page for 'VSCmdShell' item is displayed to the user
	When User selects 'DAS_20425_Proj' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title     | Value |
	| App Owner |       |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20427 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_RemoveOwnerAndRadioBattonValidationOnEndUserPage
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_20427_Proj_1 | All Users | None            | Standalone Project |
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
	When User create static list with "DAS_20427_forComponent_1" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	| 024213574157421A9CD |
	When User create static list with "DAS_20427_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20427_SS_1 | 20427_1_SI        | true    | true                | DAS_20427_1 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                | UserScope                |
	| AOC Name      | DAS_20427_Proj_1 | Allow owner to be removed only | DAS_20427_forComponent_1 |
	When User navigates to End User landing page with '20427_1_SI' Self Service Identifier
	Then 'Remove Owner' button is disabled for End User
	Then 'Remove Owner' button has tooltip with 'This application to do not have an owner to be removed' text on end user Self Service page
	When User opens 'DAS_20427_SS_1' Self Service
	When User navigates to the 'Builder' left menu item
	When User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	When User checks 'Allow owner to be removed or set to another user' radio button
	When User selects 'DAS_20427_forComponent_1' option from 'Owner Scope' autocomplete without search
	When User clicks 'UPDATE' button
	When User navigates to End User landing page with '20427_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then 'Remove owner' radio button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20825 @Cleanup @SelfService @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperWarningMessageDisplaysIfAOCScopeListDoesNotContainAnyUserButUserOnboardedToTheProject
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_20825_Proj_1 | All Users | None            | Standalone Project |
	#User onboarding
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User expands 'Users to add' multiselect to the 'Users' tab on Project Scope Changes page and selects following Objects
	| Objects                              |
	| 024213574157421A9CD (Reyes, Natasha) |
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
	When User create static list with "DAS_20825_UserList_1A" name on "Users" page with following items
	| ItemName            |
	| 03C54BC1198843A4A03 |
	When User create static list with "DAS_20825_AppList_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_20825_SS_1 | 20825_1_SI        | true    | true                | DAS_20825_AppList_1 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                            | UserScope             |
	| AOC Name      | DAS_20825_Proj_1 | Allow owner to be set to another user only | DAS_20825_UserList_1A |
	When User navigates to End User landing page with '20825_1_SI' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	Then 'There are no valid users' error message is displayed under 'Owner' field on Self Service EndUser dialog

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21198 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckWarningPopUpAfterDeletingUserScopeFromAOCAndRedirectingToAnotherPage
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_21198_Proj | All Users | None            | Standalone Project |
	When User create static list with "DAS_21198" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User create static list with "DAS_21198_scope" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_21198_SS_1 | 21198_1_SI        | true    | true                | DAS_21198 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                            | UserScope       | ShowInSelfService |
	| AOC Name      | DAS_21198_Proj | Allow owner to be set to another user only | DAS_21198_scope | true              |
	When User navigates to the 'Builder' left menu item
	And User selects 'Edit' cogmenu option for 'Application Ownership' item type with 'AOC Name' name on Self Service Builder Panel
	And User enters '' text to 'Owner Scope' textbox
	And User clicks on item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup
	Then "YES" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21181 @Cleanup @SelfService @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatOnlyOnboardedUsersThatInTheScopeListCanBeFoundInOwnerDropdown
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| DAS_21181_Proj_1 | All Users | None            | Standalone Project |
	When User onboard objects to 'DAS_21181_Proj_1' project
	| UserObjects         |
	| 024213574157421A9CD |
	| 0BC5F2D82BC34785AB8 |
	When User onboard objects to 'DAS_21181_Proj_1' project
	| ApplicationObjects |
	| VSCmdShell         |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Users' on the left-hand menu
	When User clicks the Filters button
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 0BC5F2D82BC34785AB8 |
	When User selects 'SAVE AS DYNAMIC LIST' option from Save menu and creates 'DAS_21181_AppStatList_2' list
	When User clicks the Permissions button
	When User selects 'Everyone can see' in the 'Sharing' dropdown
	When User create static list with "DAS_21181" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_21181_SS_1 | 21181_SI_1        | true    | true                | DAS_21181 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName      | OwnerPermission                            | UserScope               | ShowInSelfService |
	| AOC Name      | DAS_21181_Proj_1 | Allow owner to be set to another user only | DAS_21181_AppStatList_2 | true              |
	When User navigates to End User landing page with '21181_SI_1' Self Service Identifier
	When User clicks on 'Change Owner' button on end user Self Service page
	#Then 'There are no valid users' error message is displayed under 'Owner' field on Self Service EndUser dialog
	When User enters 'Andrews' in the 'Owner' autocomplete field and selects '0BC5F2D82BC34785AB8 (Andrews, Katie)' value
	When User clicks 'Update' button on popup
	Then User sees following items for 'AOC Name' application ownership component on 'Welcome' end user page
	| FirstColumn  | SecondColumn        |
	| Username     | 0BC5F2D82BC34785AB8 |
	| Domain       | BCLABS              |
	| Display Name | Andrews, Katie      |