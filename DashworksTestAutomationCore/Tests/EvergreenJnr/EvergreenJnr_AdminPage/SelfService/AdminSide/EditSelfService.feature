Feature: EditSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18214 @DAS19364 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceIsMatchedToTheOpenedOneAndUserIsAbleToEditIt
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name        | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_1  | Test_ID_1         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then Page with 'Self Services' header is displayed to user
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then Page with 'TestProj_1' header is displayed to user
	Then 'TestProj_1' content is displayed in 'Self Service Name' textbox
	Then 'Test_ID_1' content is displayed in 'Self Service Identifier' textbox
	Then 'Primary Object Type' dropdown is disabled
	Then '1803 Apps' content is displayed in 'Self Service Scope' autocomplete
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'NEW_TestProj_1' text to 'Self Service Name' textbox
	Then 'UPDATE' button is not disabled
	When User clears 'Self Service Name' textbox with backspaces
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutName
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name        | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_12 | Test_ID_12        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_12' item from 'Self Service Name' column
	When User clears 'Self Service Name' textbox with backspaces
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete without search
	When User enters 'Test_ID_12' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutChanges
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_4 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete without search
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User enters 'Test_ID_3' text to 'Self Service Identifier' textbox
	When User clicks Body container
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithoutSelectedScope
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_5 | Test_ID_5         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User enters 'TestProjectx' text to 'Self Service Name' textbox
	When User clears 'Self Service Scope' autocomplete with backspaces
	When User enters 'SS_ID_9' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithBrokenScopeList
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_6 | Test_ID_6         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
    When User clicks 'Edit' option in Cog-menu for 'TestProj_6' item from 'Self Service Name' column
	When User enters 'TestProj_66' text to 'Self Service Name' textbox
	When User selects 'Application List (Complex) - BROKEN LIST' option from 'Self Service Scope' autocomplete without search
	When User enters 'Test_ID_66' text to 'Self Service Identifier' textbox
	Then 'The selected list has errors' error message is displayed for 'Self Service Scope' dropdown
	Then 'UPDATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithNotAllowableCharactersInSelfServiceIdentifierTextField
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_7 | Test_ID_7         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
    When User clicks 'Edit' option in Cog-menu for 'TestProj_7' item from 'Self Service Name' column
	When User enters 'TestProj_77' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete without search
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'The allowable characters are letters, numbers, underscore and hyphen' error message is displayed for 'Self Service Identifier' field
	Then 'UPDATE' button is disabled

Examples:
	| Self Service Identifier |
	| 123QWE78!@              |
	| 123 QWE789              |
	| My**&                   |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckThatUserCantUpdateSelfServiceWithMoreThanTenCharactersInSelfServiceIdentifierTextField
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_8 | Test_ID_8         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |   
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_8' item from 'Self Service Name' column
	When User enters 'TestProj_88' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete without search
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'UPDATE' button is not disabled
	Then '<Self Service Identifier after cut>' content is displayed in 'Self Service Identifier' textbox

Examples:
	| Self Service Identifier                       | Self Service Identifier after cut |
	| 123qweTJ911                                   | 123qweTJ91                        |
	| 123456789012                                  | 1234567890                        |
	| 1234567890WIEOEOEPEP1111212123424334324234234 | 1234567890                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatDisabledSelfServiceChangesTheCheckboxStateInEditAfterEnableInCogMenu
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_9 | Test_ID_9         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |      
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Enable' option in Cog-menu for 'TestProj_9' item from 'Self Service Name' column
	When User clicks 'Edit' option in Cog-menu for 'TestProj_9' item from 'Self Service Name' column
	Then 'Enable self service portal' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @DAS19692 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatEnabledSelfServiceChangesTheCheckboxStateInEditAfterDisableInCogMenu
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_1 | Test_ID_1         | true   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |       
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Disable' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then 'Enable self service portal' checkbox is unchecked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @DAS19692 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperNitificationWillBeDisplayedWhenEnableDisableSelfService
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_2 | Test_ID_2         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Enable' option in Cog-menu for 'TestProj_2' item from 'Self Service Name' column
	Then 'The self service has been enabled' text is displayed on inline success banner
	When User clicks 'Disable' option in Cog-menu for 'TestProj_2' item from 'Self Service Name' column
	Then 'The self service has been disabled' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperNitificationAndButtonsOnItWillBeDisplayedWhenUserIsAboutToDeleteSelfService
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
    When User clicks 'Delete' option in Cog-menu for 'TestProj_3' item from 'Self Service Name' column
	Then 'This self service will be permanently deleted' text is displayed on inline tip banner
	Then 'DELETE' button is displayed on inline tip banner
	Then 'CANCEL' button is displayed on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19280 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperNitificationWillBeDisplayedAfterTheSelfServiceWasDeletedAndItDoesntDisaplysAnymoreInTheGrid
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_4 | Test_ID_4         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
    When User clicks 'Delete' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	When User clicks 'CANCEL' button on inline tip banner
	Then inline tip banner is not displayed
	When User clicks 'Delete' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	When User clicks 'DELETE' button on inline tip banner
	Then '1 self service has been deleted' text is displayed on inline success banner
	Then 'TestProj_13' content is not displayed in the 'Self Service Name' column

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19289 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperNotificationAndLinkInItAreDisplayedWhenUserUpadatesSelfService
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_5 | Test_ID_5         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
    When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	When User enters 'TestProj_55' text to 'Self Service Name' textbox
	When User enters 'Test_ID_55' text to 'Self Service Identifier' textbox
	When User clicks 'UPDATE' button
	Then 'The self service has been updated' text is displayed on inline success banner
	Then 'click here to view the TestProj_55 self service' link is displayed on inline success banner
	Then User clicks on 'click here to view the TestProj_55 self service' link on inline success banner
	Then Page with 'TestProj_55' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19864 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUpdatedSelfServiceUrlPreviewConstructedProperly
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_6 | Test_ID_6         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_6' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	Then Self Service URL preview that contains 'https://api.test.corp.juriba.com' base URL and 'Test_ID_6' Self Service identifier displays
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
    When User clicks 'Edit' option in Cog-menu for 'TestProj_6' item from 'Self Service Name' column
	When User enters 'Test_ID_66' text to 'Self Service Identifier' textbox
	When User clicks 'UPDATE' button
	When User clicks 'Edit' option in Cog-menu for 'TestProj_6' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	Then Self Service URL preview that contains 'https://api.test.corp.juriba.com' base URL and 'Test_ID_66' Self Service identifier displays

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19922 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatAllAplicationsAreAvaibleInSelfServiceScopeDropdownWhileUpdate
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_7 | Test_ID_7         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 2004 Apps |
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_7' item from 'Self Service Name' column
	When User clears 'Self Service Scope' autocomplete with backspaces
	Then 'Self Service Scope' autocomplete contains following options:
	| Options          |
	| All Applications |