Feature: CreateSelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @DAS19364 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateSelfService
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
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
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User selects 'StaticListForSS' option from 'Self Service Scope' autocomplete
	When User enters 'Test_ID_2' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedName
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 2004 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '2004 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'Test_ID_3' text to 'Self Service Identifier' textbox
	Then 'A self service with this name already exists' error message is displayed for 'Self Service Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then Page with 'Self Services' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithoutSelectedScope
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User enters 'Test_ID_4' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @Not_Ready
#Need to add REALY broken list to the step or make the existing as broken
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithBrokenScopeList
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects 'Application List (Complex) - BROKEN LIST' option from 'Self Service Scope' autocomplete 
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	Then 'This list has errors' error message is displayed for 'Self Service Scope' dropdown
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedIdentifier
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_6 | Test_ID_6         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_66' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'Test_ID_6' text to 'Self Service Identifier' textbox
	Then 'A self service with this identifier already exists' error message is displayed for 'Self Service Identifier' field
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithNotAllowableCharactersInSelfServiceIdentifierTextField
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
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
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is not disabled
	Then '<Self Service Identifier after cut>' content is displayed in 'Self Service Identifier' textbox
	
Examples:
	| Self Service Identifier                       | Self Service Identifier after cut |
	| 123qweTJ911                                   | 123qweTJ91                        |
	| 123ttt789012                                  | 123ttt7890                        |
	| xxx4567890WIEOEOEPEP1111212123424334324234234 | xxx4567890                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserWillBeReturnedToTheGridPageIfNoDataWasEnteredAndCancelButtonWasClicked
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User clicks 'CANCEL' button
	Then 'CREATE SELF SERVICE' button is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19289 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperNotificationAndLinkInItAreDisplayedWhenUserCreatedSelfService
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_7' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_7' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	Then 'click here to view the TestProj_7 self service' link is displayed on inline success banner
	Then User clicks on 'click here to view the TestProj_7 self service' link on inline success banner
	Then Page with 'TestProj_7' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19842 @DAS19876 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatSelfServiceNameShouldShowsWhenEachOfTheSelfServiceSubActionsAreSelected
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_8 | Test_ID_8         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	Then Page with 'Self Services' header is displayed to user
	When User navigates to the 'Self Services' left submenu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_8' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Style' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Details' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Builder' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Style' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Builder' left submenu item
	Then Page with 'TestProj_8' header is displayed to user
	When User navigates to the 'Style' left submenu item
	Then Page with 'TestProj_8' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19864 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatSelfServiceUrlPreviewConstructedProperly
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_9 | Test_ID_9         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_9' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	Then Self Service URL preview that contains 'https://api.test.corp.juriba.com' base URL and 'Test_ID_9' Self Service identifier displays

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19922 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatAllAplicationsAreAvaibleInSelfServiceScopeDropdown
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 2004 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then 'Self Service Scope' autocomplete contains following options:
	| Options          |
	| All Applications |