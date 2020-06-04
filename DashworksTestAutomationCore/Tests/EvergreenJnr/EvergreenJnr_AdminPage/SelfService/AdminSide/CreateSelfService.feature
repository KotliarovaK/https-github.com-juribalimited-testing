Feature: CreateSelfServiceMvp
	Crete Self Service MVP

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatTwoPagesWillBeCreatedByDefaultWhenNewSelfServiceIsCreated
    When User create static list with "AppStatList_DAS19950_1" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then Page with 'Self Services' header is displayed to user
	Then There are no errors in the browser console
	When User enters 'TestProj_1' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19950_1' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	Then User sees item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then Page with 'Welcome' subheader is displayed to user
	Then User sees item with 'Page' type and 'Thank You' name on Self Service Builder Panel
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Welcome' name on Self Service Builder Panel
	Then 'Welcome' content is displayed in 'Page Name' textbox
	Then 'Welcome' content is displayed in 'Page Display Name' textbox
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Thank You' name on Self Service Builder Panel
	Then 'Thank You' content is displayed in 'Page Name' textbox
	Then 'Thank You' content is displayed in 'Page Display Name' textbox
	When User navigates to the 'Details' left menu item
	When User navigates to the 'Builder' left menu item
	Then 'Welcome' page subheader is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @DAS21297 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToEditTheNamesInEditMode
    When User create static list with "AppStatList_DAS19950_2" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_2' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19950_2' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Welcome' name on Self Service Builder Panel
	When User clears 'Page Name' textbox with backspaces
	When User clears 'Page Display Name' textbox with backspaces
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters 'Updated Welcome0' text to 'Page Name' textbox
	When User enters 'Updated Welcome' text to 'Page Display Name' textbox
	When User clicks 'UPDATE' button
	Then User sees item with 'Page' type and 'Updated Welcome0' name on Self Service Builder Panel
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Updated Welcome0' name on Self Service Builder Panel
	Then 'Updated Welcome0' content is displayed in 'Page Name' textbox
	Then 'Updated Welcome' content is displayed in 'Page Display Name' textbox
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Thank You' name on Self Service Builder Panel
	When User clears 'Page Name' textbox with backspaces
	When User clears 'Page Display Name' textbox with backspaces
	When User enters 'Updated ThankYou0' text to 'Page Name' textbox
	When User enters 'Updated ThankYou' text to 'Page Display Name' textbox
	When User clicks 'UPDATE' button
	Then User sees item with 'Page' type and 'Updated ThankYou0' name on Self Service Builder Panel
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Updated ThankYou0' name on Self Service Builder Panel
	Then 'Updated ThankYou0' content is displayed in 'Page Name' textbox
	Then 'Updated ThankYou' content is displayed in 'Page Display Name' textbox

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperOptionsAreDisabledInCogMenuAndCreatePageButtonDoesntDisplay
    When User create static list with "AppStatList_DAS19950_3" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19950_3' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_3' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then User clicks on cogmenu button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel and sees the following cogmenu options
	| Options        |
	| Edit           |
	Then User clicks on cogmenu button for item with 'Page' type and 'Thank You' name on Self Service Builder Panel and sees the following cogmenu options
	| Options        |
	| Edit           |
	Then 'CREATE PAGE' button is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneApplicationOwnershipComponentToTheFirstPageAndUableToAddItToTheLastOne
    When User create static list with "AppStatList_DAS19950_4" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19950_4' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then User sees 'Text' item on dialog
	Then User sees 'Application Ownership' item on dialog
	When User clicks on 'Application Ownership' component on dialog
	When User clicks 'ADD' button on popup
	When User enters 'OwnComp_1' text to 'Component Name' textbox
	When User selects 'User Evergreen Capacity Project' option from 'Project' autocomplete
	When User clicks 'CREATE' button
	When User clicks on Add Item button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel
	Then User does not see 'Application Ownership' item on dialog
	Then User sees 'Text' item on dialog
	When User clicks 'CANCEL' button
	When User clicks on Add Item button for item with 'Page' type and 'Thank You' name on Self Service Builder Panel
	Then User sees 'Text' item on dialog
	Then User does not see 'Application Ownership' item on dialog

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20272 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatTheBannerAboutCreatedSelfServiceWontBeDisplayedIfUserSwitchBetweenPages
    When User create static list with "AppStatList_DAS20272_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS20272_1' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	When User navigates to the 'Details' left menu item
	Then inline success banner is not displayed
	When User navigates to the 'Builder' left menu item
	Then inline success banner is not displayed

	@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @DAS19364 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateSelfService
	When User create static list with "AppStatList_DAS19187_1" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	Then Page with 'Self Services' header is displayed to user
	When User clicks 'CREATE SELF SERVICE' button
	Then Page with 'Self Services' header is displayed to user
	Then There are no errors in the browser console
	When User enters 'TestProject1' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19187_1' option from 'Self Service Scope' autocomplete without search
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	When User clicks 'CREATE' button

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithoutName
	When User create static list with "AppStatList_DAS19082_1" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User selects 'AppStatList_DAS19082_1' option from 'Self Service Scope' autocomplete without search
	When User enters 'Test_ID_2' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedName
	When User create static list with "AppStatList_DAS19082_2" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                  |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | AppStatList_DAS19082_2 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19082_2' option from 'Self Service Scope' autocomplete without search
	When User enters 'Test_ID_3' text to 'Self Service Identifier' textbox
	Then 'A self service with this name already exists' error message is displayed for 'Self Service Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then Page with 'Self Services' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithoutSelectedScope
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User enters 'Test_ID_4' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithBrokenScopeList
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects 'Application List (Complex) - BROKEN LIST' option from 'Self Service Scope' autocomplete without search
	When User enters 'TestP_ID_4' text to 'Self Service Identifier' textbox
	Then 'This list has errors' error message is displayed for 'Self Service Scope' dropdown
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithDuplicatedIdentifier
	When User create static list with "AppStatList_DAS19082_3" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                  |
	| 1         | TestProj_6 | Test_ID_6         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | AppStatList_DAS19082_3 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_66' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19082_3' option from 'Self Service Scope' autocomplete without search
	When User enters 'Test_ID_6' text to 'Self Service Identifier' textbox
	Then 'A self service with this identifier already exists' error message is displayed for 'Self Service Identifier' field
	Then 'CREATE' button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithNotAllowableCharactersInSelfServiceIdentifierTextField
	When User create static list with "<AppList>" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters '<SelfServiceName>' text to 'Self Service Name' textbox
	When User selects '<AppList>' option from 'Self Service Scope' autocomplete without search
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'The allowable characters are letters, numbers, underscore and hyphen' error message is displayed for 'Self Service Identifier' field
	Then 'CREATE' button is disabled

Examples:
	| AppList                 | SelfServiceName | Self Service Identifier |
	| AppStatList_DAS19082_4A | SSName_4A       | 123QWE78!@              |
	| AppStatList_DAS19082_4B | SSName_4B       | 123 QWE789              |
	| AppStatList_DAS19082_4C | SSName_4C       | My**&                   |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckThatUserCantCreateSelfServiceWithMoreThanTenCharactersInSelfServiceIdentifierTextField
	When User create static list with "<AppList>" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters '<SelfServiceName>' text to 'Self Service Name' textbox
	When User selects '<AppList>' option from 'Self Service Scope' autocomplete without search
	When User enters '<Self Service Identifier>' text to 'Self Service Identifier' textbox
	Then 'CREATE' button is not disabled
	Then '<Self Service Identifier after cut>' content is displayed in 'Self Service Identifier' textbox
	
Examples:
	| AppList                 | SelfServiceName | Self Service Identifier                       | Self Service Identifier after cut |
	| AppStatList_DAS19082_5A | SSName_5A       | 123qweTJ911                                   | 123qweTJ91                        |
	| AppStatList_DAS19082_5B | SSName_5B       | 123ttt789012                                  | 123ttt7890                        |
	| AppStatList_DAS19082_5C | SSName_5C       | xxx4567890WIEOEOEPEP1111212123424334324234234 | xxx4567890                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19082 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUserWillBeReturnedToTheGridPageIfNoDataWasEnteredAndCancelButtonWasClicked
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User clicks 'CANCEL' button
	Then 'CREATE SELF SERVICE' button is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19289 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperNotificationAndLinkInItAreDisplayedWhenUserCreatedSelfService
    When User create static list with "AppStatList_DAS19289_1" name on "Applications" page with following items
	| ItemName |
	|          | 
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'TestProj_7' text to 'Self Service Name' textbox
	When User selects 'AppStatList_DAS19289_1' option from 'Self Service Scope' autocomplete without search
	When User enters 'TestP_ID_7' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	Then Page with 'TestProj_7' header is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19842 @DAS19876 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceNameShouldShowsWhenEachOfTheSelfServiceSubActionsAreSelected
    When User create static list with "AppStatList_DAS19842_1" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                  |
	| 1         | TestProj_8 | Test_ID_8         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | AppStatList_DAS19842_1 |         
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
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceUrlPreviewConstructedProperly
    When User create static list with "AppStatList_DAS19864_1" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                  |
	| 1         | TestProj_9 | Test_ID_9         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | AppStatList_DAS19864_1 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_9' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	Then Self Service URL preview that contains 'https://api.test.corp.juriba.com' base URL and 'Test_ID_9' Self Service identifier displays

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19922 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatAllAplicationsAreAvaibleInSelfServiceScopeDropdown
    When User create static list with "AppStatList_DAS19922_1" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                  |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | AppStatList_DAS19922_1 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then 'Self Service Scope' autocomplete contains following options:
	| Options          |
	| All Applications |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20759 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceWithUnknownNameCanBeCreated
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User enters 'Unknown' text to 'Self Service Name' textbox
	When User selects 'All Applications' option from 'Self Service Scope' autocomplete
	When User enters 'testSelfService' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User enters "Unknown" text in the Search field for "Self Service Name" column
	Then 'Unknown' content is displayed in the 'Self Service Name' column

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20469 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperInlineErrorBannerDispaysWhenSelfServiceIdIsChangedToAnInvalidOne
    When User create static list with "DAS_20469_AppList_1" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_20469_SS_1 | 20469_1_SI        | true    | true                | DAS_20469_AppList_1 |  
	When User opens Self Service with invalid ID '2XXXX_1_SI'
    Then 'This self service does not exist' text is displayed on inline error banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20207 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperInlineErrorBannerDispaysWhenSelfServiceAlreadyExistsWithThisName
	When User create static list with "DAS_20207_AppList_1" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User create static list with "DAS_20207_AppList_2" name on "Applications" page with following items
	| ItemName |
	|          |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'DAS_20207_SS_1' text to 'Self Service Name' textbox
	When User creates Self Service via API
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_20207_SS_1 | 20207_1_SI        | true    | true                | DAS_20207_AppList_1 |
	When User selects 'DAS_20207_AppList_2' option from 'Self Service Scope' autocomplete
	When User enters '20207_2_SI' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked	
	When User clicks 'CREATE' button
	Then 'A self service already exists with this name' text is displayed on inline error banner

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21197 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatProperInlineErrorBannerDispaysWhenSelfServiceAlreadyExistsWithThisIdentifier
	When User create static list with "DAS_21197_AppList_1" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User create static list with "DAS_21197_AppList_2" name on "Applications" page with following items
	| ItemName |
	|          |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'DAS_21197_SS_2' text to 'Self Service Name' textbox
	When User selects 'DAS_21197_AppList_2' option from 'Self Service Scope' autocomplete
	When User enters '21197_1_SI' text to 'Self Service Identifier' textbox
	When User creates Self Service via API
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope               |
	| DAS_21197_SS_1 | 21197_1_SI        | true    | true                | DAS_21197_AppList_1 |
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked	
	When User clicks 'CREATE' button
	Then 'A self service already exists with this identifier' text is displayed on inline error banner

	@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21433 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatNoUnsavedChagesPopupWhenUserLeaveCreateSSBlancAndNavigateToSettings
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	When User navigates to the 'Self Services' parent left menu item
	Then popup is not displayed to User