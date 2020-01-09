Feature: EditSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18214 @DAS19364 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceIsMatchedToTheOpenedOneAndUserIsAbleToEditIt
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then Page with 'Self Services' header is displayed to user
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then Page with 'TestProj_5' header is displayed to user
	Then 'TestProj_5' content is displayed in 'Self Service Name' textbox
	Then 'TestP_ID_5' content is displayed in 'Self Service Identifier' textbox
	Then 'Primary Object Type' dropdown is disabled
	Then '1803 Apps' content is displayed in 'Self Service Scope' autocomplete
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'NEW_TestProj_5' text to 'Self Service Name' textbox
	Then 'UPDATE' button is not disabled
	When User clears 'Self Service Name' textbox with backspaces
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutName
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_7' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_7' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_7' item from 'Self Service Name' column
	When User clears 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_7' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutChanges
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_3' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_3' text to 'Self Service Identifier' textbox
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User clicks Body container
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutSelectedScope
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_1' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	When User enters 'TestProjectx' text to 'Self Service Name' textbox
	When User clears 'Self Service Scope' autocomplete with backspaces
	When User enters 'SS_ID_9' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @Not_Ready
#Need to add REALY broken list to the step or make the existing as broken
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithBrokenScopeList
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects 'Application List (Complex) - BROKEN LIST' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	Then 'This list has errors' error message is displayed for 'Self Service Scope' dropdown
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithNotAllowableCharactersInSelfServiceIdentifierTextField
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'The allowable characters are letters, numbers, underscore and hyphen' error message is displayed for 'Self Service Identifier' field
	Then 'UPDATE' button is disabled

Examples:
	| Self Service Identifier |
	| 123QWE78!@              |
	| 123 QWE789              |
	| My**&                   |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithMoreThanTenCharactersInSelfServiceIdentifierTextField
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is not disabled
	Then '<Self Service Identifier after cut>' content is displayed in 'Self Service Identifier' textbox

Examples:
	| Self Service Identifier                       | Self Service Identifier after cut |
	| 123qweTJ911                                   | 123qweTJ91                        |
	| 123456789012                                  | 1234567890                        |
	| 1234567890WIEOEOEPEP1111212123424334324234234 | 1234567890                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatDisabledSelfServiceChangesTheCheckboxStateInEditAfterEnableInCogMenu
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Enable' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then 'Enable self service portal' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatEnabledSelfServiceChangesTheCheckboxStateInEditAfterDisableInCogMenu
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User checks 'Enable self service portal' checkbox
	When User clicks 'CREATE' button
	When User clicks 'Disable' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then 'Enable self service portal' checkbox is unchecked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperNitificationWillBeDisplayedWhenEnableDisableSelfService
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Enable' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then 'The TestProj_5 has been enabled' text is displayed on inline success banner
	When User clicks 'Disable' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then 'The TestProj_5 has been disabled' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperNitificationAndButtonsOnItWillBeDisplayedWhenUserIsAboutToDeleteSelfService
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_7' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_7' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Delete' option in Cog-menu for 'TestProj_7' item from 'Self Service Name' column
	Then 'This self service will be permanently deleted' text is displayed on inline tip banner
	Then 'DELETE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperNitificationWillBeDisplayedAfterTheSelfServiceWasDeletedAndItDoesntDisaplysAnymoreInTheGrid
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_13' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_13' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Delete' option in Cog-menu for 'TestProj_13' item from 'Self Service Name' column
	When User clicks 'CANCEL' button on inline tip banner
	Then inline tip banner is not displayed
	When User clicks 'Delete' option in Cog-menu for 'TestProj_13' item from 'Self Service Name' column
	When User clicks 'DELETE' button on inline tip banner
	Then '1 self service has been deleted' text is displayed on inline success banner
	Then 'TestProj_13' content is not displayed in the 'Self Service Name' column