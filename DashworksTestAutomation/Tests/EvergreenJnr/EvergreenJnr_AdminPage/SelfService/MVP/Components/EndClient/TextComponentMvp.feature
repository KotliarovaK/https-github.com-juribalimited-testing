Feature: TextComponentMvp
	Scenarios related to Text component on End User page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckDisplayAndFormatingOfTextComponentOnEndUserSelfService
	When User create static list with "DAS_20050" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20050_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20050_SS_1 | 20050_1_SI        | true    | true                | DAS_20050 |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText                                                                                  | ShowInSelfService |
	| Text_Component_Name_1 | <h1><strong>bold </strong><em>italic </em><u>underline</u><p>normal</p><em>italic </em>heading1</h1> | true              |
	| Text_Component_Name_2 | <p>normal</p>                                                                                        | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                  |
	| AOC Name      | 2004 Rollout | Do not allow owner to be changed |
	When User navigates to End User landing page with '20050_1_SI' Self Service Identifier
	Then User sees 'bold ' text styled as 'Bold' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'italic ' text styled as 'Italic' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'underline' text styled as 'Underline' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'heading1' text styled as 'Heading 1' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'normal' text styled as 'Normal' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	When User clicks on 'Continue' button on end user Self Service page
	Then User sees 'Thank You' text component 'Thank You' on end user page

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEditingAndChangingOrder
	When User create static list with "DAS_20050_2" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20050_SS_2 | 20050_2_SI        | true    | true                | DAS_20050_2 |
	#Use the step blow as soon as it will be possible instead of gold data
	#When Project created via API
	#| ProjectName    | Scope     | ProjectTemplate | Mode               |
	#| DAS_20050_Proj | All Users | None            | Standalone Project |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText     | ShowInSelfService |
	| Text_Component_Name_1 | <p>Text component 1</p> | true              |
	| Text_Component_Name_2 | <p>Text component 2</p> | true              |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName  | OwnerPermission                  |
	| AOC Name      | 2004 Rollout | Do not allow owner to be changed |
	When User navigates to End User landing page with '20050_2_SI' Self Service Identifier
	Then User sees 'Text component 1' text styled as 'Normal' in the Text Component 'Text_Component_Name_1' that placed on '1' position on 'Welcome' End User page
	Then User sees 'Text component 2' text styled as 'Normal' in the Text Component 'Text_Component_Name_2' that placed on '2' position on 'Welcome' End User page
	When User opens 'DAS_20050_SS_2' Self Service
	When User navigates to the 'Builder' left menu item
	When User selects 'Move to bottom' cogmenu option for 'Text' item type with 'Text_Component_Name_1' name on Self Service Builder Panel
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name_2' name on Self Service Builder Panel
	When User clears text editor
	When User enters 'Text component 0' text to the text editor
	When User clicks 'UPDATE' button
	When User navigates to End User landing page with '20050_2_SI' Self Service Identifier
	Then User sees 'Text component 0' text styled as 'Normal' in the Text Component 'Text_Component_Name_2' that placed on '1' position on 'Welcome' End User page