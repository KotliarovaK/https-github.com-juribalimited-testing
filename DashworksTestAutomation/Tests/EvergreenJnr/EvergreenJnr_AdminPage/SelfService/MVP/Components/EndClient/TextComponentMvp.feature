Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20050 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatzzzzzzz
	When User create static list with "DAS_20049_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_20049_SS_3 | 20049_3_SI        | true    | true                | DAS_20049_33 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name      | DisplayName | ShowInSelfService |
	| 20049_3_SI        | Welcome   | Welcome     | true              |
	| 20049_3_SI        | Thank You | Thank You   | true              |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName         | ExtraPropertiesText                                                             | ShowInSelfService |
	| Text_Component_Name_1 | <h1><strong>bold </strong><em>italic </em><u>underline</u><em>italic </em></h1> | true              |
	#Then User navigates to the end user Self Service Welcome page
	When User navigates to 'selfservice/20049_3_SI?ObjectId=660e81ff-0536-4daa-bb8c-64267e2aa484' url via address line

	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 20049_3_SI        | TestPageSs4 | DAS_20049_Page_2 | true              |

