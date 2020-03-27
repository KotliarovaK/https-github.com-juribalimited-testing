Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckDisplayAndFormatingOfTextComponentOnEndUserSelfService
	When User create static list with "DAS_20050" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20050_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20050_SS_1 | 20050_1_SI        | true    | true                | DAS_20050 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                  |
	| AOC Name      | DAS_20050_Proj | Do not allow owner to be changed |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText                                                                                  | ShowInSelfService |
	| Text_Component_Name_1 | <h1><strong>bold </strong><em>italic </em><u>underline</u><p>normal</p><em>italic </em>heading1</h1> | true              |
	| Text_Component_Name_2 | <p>normal</p>                                                                                        | true              |
	When User navigates to End User firs page with '20050_1_SI' Self Service Identifier
	#When User navigates to 'selfservice/am-s4?uid=c56a4180-65aa-42ec-a945-5fd21dec053' url via address line
	Then User sees 'bold ' text styled as 'Bold' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'italic ' text styled as 'Italic' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'underline' text styled as 'Underline' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'heading1' text styled as 'Heading 1' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'normal' text styled as 'Normal' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	When User clicks on 'Continue' button on end-user Self Service page
	Then User sees 'Thank You' text component of 'Thank You' on end-user page
	Then User sees 'normal' text styled as 'Normal' in 'Text_Component_Name_2' Text Component of 'Thank You' on end user page

	@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEditingAndChangingOrder
	When User create static list with "DAS_20049_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20050_SS_3 | 20049_3_SI        | true    | true                | 2004 Apps |
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20050_Proj | All Users | None            | Standalone Project |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                  |
	| AOC Name      | DAS_20050_Proj | Do not allow owner to be changed |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText     | ShowInSelfService |
	| Text_Component_Name_1 | <p>Text component 1</p> | true              |
	| Text_Component_Name_2 | <p>Text component 2</p> | true              |
	When User navigates to End User firs page with '20050_2_SI' Self Service Identifier
	Then User sees component with 'Text_Component_Name_1' name placed on '1' position
	Then User sees component with 'Text_Component_Name_1' name placed on '2' position
	Then Evergreen Dashboards page should be displayed to the user
	When User opens 'DAS_20050_SS_3' Self Service
	When User navigates to the 'Builder' left menu item
	When User selects 'Move to bottom' cogmenu option for 'Text' item type with 'Text component 1' name on Self Service Builder Panel
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text component 2' name on Self Service Builder Panel
	When User clears text editor
	When User enters 'Text component 0' text to the text editor
	When User navigates to End User firs page with '20049_3_SI' Self Service Identifier
	Then User sees 'Text component 0' text styled as 'Normal' in 'Text_Component_Name_2' Text Component of 'Welcome' on end user page

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20325 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_Checkzzzzzzzzz
	When User create static list with "DAS_20325" name on "Users" page with following items
	| ItemName |
	|          |
	When Project created via API
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| DAS_20325_Proj | All Users | None            | Standalone Project |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20325_SS_1 | 20325_1_SI        | true    | true                | DAS_20325 |
	When User creates new application ownership component for 'Welcome' Self Service page via API
	| ComponentName | ProjectName    | OwnerPermission                  |
	| AOC Name      | DAS_20325_Proj | Do not allow owner to be changed |
	Then User sees item with 'Text' type and 'Thank You' name on Self Service Builder Panel
	When User navigates to End User firs page with '20325_1_SI' Self Service Identifier
	When User clicks on 'Continue' button on end-user Self Service page
	Then Header is displayed on End User page
	Then Subject Title '(.*)' is displayed on End User page
	Then 'Continue' button is not displayed for End User
	Then 'Undo all changes I made on this page' button is not displayed for End User
	Then 'Back' button is not displayed for End User
	Then User sees 'Thank You' text styled as 'Normal' in 'Thank You' Text Component of 'Thank You' on end user page
	Then User sees 'You have completed the self service. You can now close the page.' text styled as 'Normal' in 'Thank You' Text Component of 'Thank You' on end user page


@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20325 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_temptemp
	When User navigates to 'selfservice/AV1?ObjectId=464b904d-bbf1-4dd9-a5cb-3da4ce20a2cf' url via address line
	When User clicks on 'Continue' button on end-user Self Service page
	Then Subject Title 'Application: MKS Source Integrity (Unknown)' is displayed on End User page
	Then User sees 'Thank You' text styled as 'Bolt' in 'Thank You' Text Component of 'Thank You' on end user page
	Then User sees 'You have completed the self service. You can now close the page.' text styled as 'Bolt' in 'Thank You' Text Component of 'Thank You' on end user page
	Then 'Undo all changes I made on this page' button is not displayed for End User
	Then 'Continue' button is not displayed for End User