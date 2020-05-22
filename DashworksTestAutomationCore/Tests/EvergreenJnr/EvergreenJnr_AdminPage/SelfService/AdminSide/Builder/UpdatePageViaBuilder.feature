Feature: UpdatePageViaBuilder
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedPageConfigurationShownWhenUserEditPage
	When User create static list with "19792 UserStatList_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name             | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                |
	| 1         | 19792_TestProj_1 | 19792_ID_1        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 19792 UserStatList_1 |        
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| 19792_ID_1        | TestPageName_1 | TestPageDisplayName_1 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_1' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	Then 'TestPageName_1' content is displayed in 'Page Name' textbox
	Then 'TestPageDisplayName_1' content is displayed in 'Page Display Name' textbox
	Then 'Show page in self service' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUpdateButtonIsDisabledEnabledIfUserDidDidntChangesAndProperToolTipsAreDisplays
	When User create static list with "19792 UserStatList_2" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name             | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                |
	| 1         | 19792_TestProj_2 | 19792_ID_2        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 19792 UserStatList_2 |        
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_2' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| 19792_ID_2        | TestPageName_2 | TestPageDisplayName_2 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_2' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	Then 'UPDATE' button is disabled
	When User enters 'TestPageName_2' text to 'Page Name' textbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'ChangedPageName' text to 'Page Name' textbox
	Then 'UPDATE' button is not disabled
	When User enters 'TestPageName_2' text to 'Page Name' textbox
	Then 'UPDATE' button is disabled
	When User enters 'DisplayPage_1' text to 'Page Display Name' textbox
	Then 'UPDATE' button is not disabled
	When User enters 'TestPageDisplayName_2' text to 'Page Display Name' textbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters 'TestPageDisplayName_2' text to 'Page Display Name' textbox
	Then 'UPDATE' button is disabled
	When User unchecks 'Show page in self service' checkbox
	Then 'UPDATE' button is not disabled
	When User checks 'Show page in self service' checkbox
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User clears 'Page Display Name' textbox with backspaces
	Then 'UPDATE' button is not disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatChangesOfTheUpdatedPageWillBeSavedWithProperNotificationAndHighlightedOnContextPanel
	When User create static list with "19792 UserStatList_3" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name             | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                |
	| 1         | 19792_TestProj_3 | 19792_ID_3        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 19792 UserStatList_3 |   
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for '19792_TestProj_3' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| 19792_ID_3        | TestPageName_3 | TestPageDisplayName_3 | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_3' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User enters 'UPDATED_PageDisplayName' text to 'Page Display Name' textbox
	When User enters 'UPDATED_PageName' text to 'Page Name' textbox
	When User checks 'Show page in self service' checkbox
	When User clicks 'UPDATE' button
	Then Item with 'Page' type and 'UPDATED_PageName' name on Self Service Builder Panel is highlighted
	Then 'The page has been updated' text is displayed on inline success banner
	Then User sees item with 'Page' type and 'UPDATED_PageName' name on Self Service Builder Panel
	When User clicks on cogmenu button for item with 'Page' type and 'UPDATED_PageName' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	Then 'UPDATED_PageName' content is displayed in 'Page Name' textbox
	Then 'UPDATED_PageDisplayName' content is displayed in 'Page Display Name' textbox
	Then 'Show page in self service' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckNameAndDisplayNameFieldsValidation
	When User create static list with "<StatUserList>" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name     | ServiceIdentifier   | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope          |
	| 1         | <SSName> | <ServiceIdentifier> | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | <StatUserList> |     
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for '<SSName>' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier   | Name           | DisplayName           | ShowInSelfService |
	| <ServiceIdentifier> | TestPageName_4 | TestPageDisplayName_4 | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_4' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User enters '<PageName>' text to 'Page Name' textbox
	When User enters '<Page Display Name>' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	Then 'UPDATE' button is not disabled

	Examples:
	| StatUserList          | SSName          | ServiceIdentifier | PageName                                                     | Page Display Name                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
	| 19792 UserStatList_A4 | 19792_SSName_A4 | 19792_IA_4        | DisplayPage_2                                                |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
	| 19792 UserStatList_B4 | 19792_SSName_B4 | 19792_IB_4        | 60_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kknnnljfjndfjk9849804 | 254_S"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                   |
	| 19792 UserStatList_C4 | 19792_SSName_C4 | 19792_IC_4        | 41_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                    | 255_AS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                  |
	| 19792 UserStatList_D4 | 19792_SSName_D4 | 19792_IF_4        | 40_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                     | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                 |
	| 19792 UserStatList_F4 | 19792_SSName_F4 | 19792_IG_4        | 39_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^k                      | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClickedThePagePreviewIsShownOnTheDesignSurface
	When User create static list with "DAS19792_UserStatList_5" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name                | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                   |
	| 1         | DAS19792_TestProj_5 | 19792_ID_5        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | DAS19792_UserStatList_5 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'DAS19792_TestProj_5' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| 19792_ID_5        | TestPageName_5 | TestPageDisplayName_5 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_5' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User clicks 'CANCEL' button
	Then 'TestPageDisplayName_5' page subheader is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatWhenTheUserLeavesThePageConfigurationWithoutSavingChangesTheySeeTheStandardWarningModalWindowPopup
	When User create static list with "DAS19792_UserStatList_6" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name                | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope                   |
	| 1         | DAS19792_TestProj_6 | 19792_ID_6        | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | DAS19792_UserStatList_6 |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'DAS19792_TestProj_6' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| 19792_ID_6        | TestPageName_6 | TestPageDisplayName_6 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_6' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User enters 'UpdatedDisplayPage_A6' text to 'Page Display Name' textbox
	When User navigates to the 'Details' left submenu item
	Then popup is displayed to User