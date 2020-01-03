Feature: CreateSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @DAS19364 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateSelfService
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then Page with 'Self Services' header is displayed to user
	When User clicks 'CREATE SELF SERVICE' button
	Then Page with 'Self Services' header is displayed to user
	Then There are no errors in the browser console
	When User enters 'TestProject1' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	When User clicks 'CREATE' button

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithoutName
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedName
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Service' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	Then 'A self service with this name already exists' error message is displayed for 'Self Service Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then Page with 'Create Self Service' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithoutSelectedScope
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProject1' text to 'Self Service Name' textbox
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithBrokenScopeList
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects 'Alex M List' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	Then 'This list has errors' error message is displayed for 'Self Service Scope' dropdown
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedIdentifier
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Service' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	Then 'A self service with this identifier already exists' error message is displayed for 'Self Service Identifier' field
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithNotAllowableCharactersInSelfServiceIdentifierTextField
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'The allowable characters are letters, numbers, underscore and hyphen' error message is displayed for 'Self Service Identifier' field
	Then 'CREATE' button is disabled

Examples:
	| Self Service Identifier |
	| 123QWE78!@              |
	| 123 QWE789              |
	| My**&                   |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithMoreThanTenCharactersInSelfServiceIdentifierTextField
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	
Examples:
	| Self Service Identifier                          |
	| 123qweTJ911                                      |
	| 123456789012                                     |
	| 1234567890WIEOEOEPEP1111212123424334324234234    |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserWillBeReturnedToTheGridPageIfNoDataWasEnteredAndCancelButtonWasClicked
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User clicks 'CANCEL' button
	Then 'CREATE SELF SERVICE' button is displayed