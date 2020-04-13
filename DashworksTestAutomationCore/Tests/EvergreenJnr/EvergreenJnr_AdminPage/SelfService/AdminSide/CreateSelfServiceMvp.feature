Feature: CreateSelfServiceMvp
	Crete Self Service MVP

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @SelfServiceMVP @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTwoPagesWillBeCreatedByDefaultWhenNewSelfServiceIsCreated
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then Page with 'Self Services' header is displayed to user
	Then There are no errors in the browser console
	When User enters 'TestProj_1' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_1' text to 'Self Service Identifier' textbox
	Then 'Allow anonymous user to use self service' checkbox is disabled
	Then 'Allow anonymous user to use self service' checkbox is checked
	Then 'Enable self service portal' checkbox is enabled
	Then 'Enable self service portal' checkbox is unchecked
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	Then 'click here to view the TestProj_1 self service' link is displayed on inline success banner
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @SelfServiceMVP @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToEditTheNamesInEditMode
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_2' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_2' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	When User selects 'Edit' cogmenu option for 'Page' item type with 'Welcome' name on Self Service Builder Panel
	When User clears 'Page Name' textbox with backspaces
	When User clears 'Page Display Name' textbox with backspaces
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @SelfServiceMVP @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatProperOptionsAreDisabledInCogMenuAndCreatePageButtonDoesntDisplay
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_3' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_3' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then User clicks on cogmenu button for item with 'Page' type and 'Welcome' name on Self Service Builder Panel and sees the following cogmenu options
	| Options        |
	| Edit           |
	Then User clicks on cogmenu button for item with 'Page' type and 'Thank You' name on Self Service Builder Panel and sees the following cogmenu options
	| Options        |
	| Edit           |
	Then 'CREATE PAGE' button is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19950 @SelfServiceMVP @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddOnlyOneApplicationOwnershipComponentToTheFirstPageAndUableToAddItToTheLastOne
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          | 
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_4' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20272 @SelfServiceMVP @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatTheBannerAboutCreatedSelfServiceWontBeDisplayedIfUserSwitchBetweenPages
    When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'CREATE SELF SERVICE' button
	Then There are no errors in the browser console
	When User enters 'TestProj_5' text to 'Self Service Name' textbox
	When User selects '1803 Apps' option from 'Self Service Scope' autocomplete
	When User enters 'TestP_ID_5' text to 'Self Service Identifier' textbox
	When User clicks 'CREATE' button
	Then 'The self service has been created' text is displayed on inline success banner
	Then 'click here to view the TestProj_5 self service' link is displayed on inline success banner
	When User navigates to the 'Details' left menu item
	Then inline success banner is not displayed
	When User navigates to the 'Builder' left menu item
	Then inline success banner is not displayed