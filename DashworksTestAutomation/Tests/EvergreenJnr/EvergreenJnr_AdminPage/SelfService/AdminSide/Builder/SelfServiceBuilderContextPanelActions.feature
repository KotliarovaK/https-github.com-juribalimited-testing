Feature: SelfServiceBuilderContextPanelActions
	Scenarios to test Builder Panel

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20407 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperCogMenuOptionsArePresentAndMoveToOptionsWorksProperly
	When User create static list with "DAS_20407" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20407_SS_1 | 20407_1_SI        | true    | true                | DAS_20407 |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText             | ShowInSelfService |
	| Text_Component_Name_1 | <p>Sunt haud pauci homĭnes,</p> | true              |
	| Text_Component_Name_2 | <p>Sunt haud pauci homĭnes,</p> | true              |
	| Text_Component_Name_3 | <p>Sunt haud pauci homĭnes,</p> | true              |
	When User navigates to the 'Builder' left menu item
	Then User clicks on cogmenu button for item with 'Text' type and 'Text_Component_Name_1' name on Self Service Builder Panel and sees the following cogmenu options
	| Options          |
	| Edit             |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	Then User clicks on cogmenu button for item with 'Text' type and 'Text_Component_Name_2' name on Self Service Builder Panel and sees the following cogmenu options
	| Options          |
	| Edit             |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Delete           |
	Then User clicks on cogmenu button for item with 'Text' type and 'Text_Component_Name_3' name on Self Service Builder Panel and sees the following cogmenu options
	| Options          |
	| Edit             |
	| Move to top      |
	| Move to position |
	| Delete           |
	When User selects 'Move to bottom' cogmenu option for 'Text' item type with 'Text_Component_Name_2' name on Self Service Builder Panel
	When User selects 'Move to top' cogmenu option for 'Text' item type with 'Text_Component_Name_3' name on Self Service Builder Panel
	When User moves item with type 'Text' and 'Text_Component_Name_1' name to '3' position on Self Service Builder Panel
	Then User sees component on position in 'Welcome' page of Self Service Builder Panel
	| ComponentType | ComponentName         | ComponentPosition |
	| Text          | Text_Component_Name_1 | 3                 |
	| Text          | Text_Component_Name_2 | 2                 |
	| Text          | Text_Component_Name_3 | 1                 |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20407 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEditAndDeleteOptionsWorksProperly
	When User create static list with "DAS_20407" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20407_SS_2 | 20407_2_SI        | true    | true                | DAS_20407 |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName                | ExtraPropertiesText             | ShowInSelfService |
	| Text_Component_Name_Original | <p>Sunt haud pauci homĭnes,</p> | true              |
	When User navigates to the 'Builder' left menu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name_Original' name on Self Service Builder Panel
	When User clears 'Component Name' textbox
	When User enters 'Text_Component_Name_Renamed' text to 'Component Name' textbox
	When User clicks 'UPDATE' button
	Then User sees item with 'Text' type and 'Text_Component_Name_Renamed' name on Self Service Builder Panel
	When User selects 'Delete' cogmenu option for 'Text' item type with 'Text_Component_Name_Renamed' name on Self Service Builder Panel
	When User clicks 'DELETE' button on inline tip banner
	Then User doesn't see item with 'Text' type and 'Text_Component_Name_Renamed' name on Self Service Builder Panel