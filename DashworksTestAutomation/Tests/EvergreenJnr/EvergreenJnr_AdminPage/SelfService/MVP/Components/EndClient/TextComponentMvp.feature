Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckDisplayAndFormatingOfTextComponentOnEndUserSelfService
	#When User create static list with "DAS_20049_33" name on "Users" page with following items
	#| ItemName |
	#|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20049_SS_3 | 20049_3_SI        | true    | true                | 2004 Apps |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText                                                                                  | ShowInSelfService |
	| Text_Component_Name_1 | <h1><strong>bold </strong><em>italic </em><u>underline</u><p>normal</p><em>italic </em>heading1</h1> | true              |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText | ShowInSelfService |
	| Text_Component_Name_2 | <p>normal</p>       | true              |
	When User navigates to 'selfservice/20049_3_SI?ObjectId=660e81ff-0536-4daa-bb8c-64267e2aa484' url via address line
	Then User sees 'bold ' text styled as 'Bold' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'italic ' text styled as 'Italic' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'underline' text styled as 'Underline' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'heading1' text styled as 'Heading 1' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	Then User sees 'normal' text styled as 'Normal' in 'Text_Component_Name_1' Text Component of 'Welcome' on end user page
	When User clicks on 'Continue' button on end-user Self Service page
	Then User sees 'Thank You' text component of 'Thank You' on end-user page
	Then User sees 'normal' text styled as 'Normal' in 'Text_Component_Name_2' Text Component of 'Thank You' on end user page

	@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckEditinzzzzzzzzzzzzzzzz
	#When User create static list with "DAS_20049_33" name on "Users" page with following items
	#| ItemName |
	#|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20049_SS_3 | 20049_3_SI        | true    | true                | 2004 Apps |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText     | ShowInSelfService |
	| Text_Component_Name_1 | <p>Text component 1</p> | true              |
	#When User creates new text component for 'Welcome' Self Service page via API
	#| ComponentName         | ExtraPropertiesText     | ShowInSelfService |
	#| Text_Component_Name_2 | <p>Text component 2</p> | true              |
	When User navigates to 'selfservice/20049_3_SI?ObjectId=660e81ff-0536-4daa-bb8c-64267e2aa484' url via address line
	Then User sees component with 'Text_Component_Name_1' name placed on '1' position
	#Then User sees component with 'Text_Component_Name_1' name placed on '2' position
	Then Evergreen Dashboards page should be displayed to the user




