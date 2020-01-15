Feature: ProjectsPart26
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS19363
Scenario: EvergreenJnr_AdminPage_CheckThatAppOwnersSectionIsDisabledWhenDoNotIncludeUsersRadioSelected
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	When User clicks 'Do not include users' radio button
	Then 'Do not include app owners' radio button is disabled
	Then 'Include app owners' radio button is disabled