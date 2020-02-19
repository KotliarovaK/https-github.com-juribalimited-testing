Feature: UpdatePageViaBuilder
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatSelectedPageConfigurationShownWhenUserEditPage
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_1 | Test_ID_1         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_1' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_1         | TestPageName_1 | 3            | TestPageDisplayName_1 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_1' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	Then 'TestPageName_1' content is displayed in 'Page Name' textbox
	Then 'TestPageDisplayName_1' content is displayed in 'Page Display Name' textbox
	Then 'Show page in self service' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatUpdateButtonIsDisabledEnabledIfUserDidDidntChangesAndProperToolTipsAreDisplays
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_2 | Test_ID_2         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_2' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_2         | TestPageName_2 | 3            | TestPageDisplayName_2 | true              |
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatChangesOfTheUpdatedPageWillBeSavedWithProperNotificationAndHighlightedOnContextPanel
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_3 | Test_ID_3         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_3' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_3         | TestPageName_3 | 3            | TestPageDisplayName_3 | false             |
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckNameAndDisplayNameFieldsValidation
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
    When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_4 | Test_ID_4         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_4' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_4         | TestPageName_4 | 3            | TestPageDisplayName_4 | false             |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_4' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User enters '<PageName>' text to 'Page Name' textbox
	When User enters '<Page Display Name>' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	Then 'UPDATE' button is not disabled

	Examples:
	| PageName                                                     | Page Display Name                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
	| DisplayPage_2                                                |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
	| 60_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kknnnljfjndfjk9849804 | 254_S"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                   |
	| 41_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                    | 255_AS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                  |
	| 40_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                     | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                 |
	| 39_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^k                      | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClickedThePagePreviewIsShownOnTheDesignSurface
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_5 | Test_ID_5         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |         
    When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_5' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_5         | TestPageName_5 | 3            | TestPageDisplayName_5 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_5' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User clicks 'CANCEL' button
	Then 'TestPageDisplayName_5' page subheader is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19792 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_CheckThatWhenTheUserLeavesThePageConfigurationWithoutSavingChangesTheySeeTheStandardWarningModalWindowPopup
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
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| Test_ID_6         | TestPageName_6 | 3            | TestPageDisplayName_5 | true              |
	When User navigates to the 'Builder' left menu item
    When User clicks on cogmenu button for item with 'Page' type and 'TestPageName_6' name on Self Service Builder Panel
	When User clicks 'Edit' option in opened Cog-menu
	When User enters 'UpdatedDisplayPage_6' text to 'Page Display Name' textbox
	When User navigates to the 'Details' left submenu item
	Then popup is displayed to User