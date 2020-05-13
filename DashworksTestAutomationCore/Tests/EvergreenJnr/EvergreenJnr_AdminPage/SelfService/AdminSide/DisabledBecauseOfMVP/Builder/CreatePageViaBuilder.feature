Feature: CreatePageViaBuilder
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfServiceViaBuilder
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
	When User navigates to the 'Builder' left menu item
	Then 'Create Application Page' page subheader is displayed to user
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CREATE' button is displayed
	Then 'Page Name' textbox is displayed
	Then 'Page Display Name' textbox is displayed
	When User enters 'Page_1' text to 'Page Name' textbox
	When User enters 'DisplayPage_1' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	When User clicks 'CREATE' button
	Then 'The page has been created' text is displayed on inline success banner
	Then User sees item with 'Page' type and 'Page_1' name on Self Service Builder Panel
	Then Page with 'DisplayPage_1' subheader is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToAddPageToSelfServiceViaBuilderWithOnlyFiledPageName
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
	When User navigates to the 'Builder' left menu item
	When User enters 'Page_2' text to 'Page Name' textbox
	When User clicks 'CREATE' button
	Then 'The page has been created' text is displayed on inline success banner
	Then User sees item with 'Page' type and 'Page_2' name on Self Service Builder Panel

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatUserIsUnableToCretePageWithNotProperlyFiledFields
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
	When User navigates to the 'Builder' left menu item
	Then 'CREATE' button is displayed
	When User enters '<PageName>' text to 'Page Name' textbox
	When User enters '<Page Display Name>' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	Then 'CREATE' button is not disabled

	Examples:
	| PageName                                                     | Page Display Name                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
	|                                                              | DisplayPage_2                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
    | 60_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kknnnljfjndfjk9849804 | 254_S"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                   |
	| 41_S"FEIJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                    | 255_AS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                  |
	| 40_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^kk                     | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep                                                                                                                                                                                                                                                                 |
	| 39_S"FEJO:J&#*@YnifnoifnosndfJDN*&*(*^k                      | 256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep256_AS"ASEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwepnbjfnbvjinerigwperignjehfbvhdfbvberouibgoewuibgrebghjebgouhe_NLFS"FEIJO:J&#*@Y)NFNDFnjn45nk5kl34NFDHKGBUD#*($)%&*$(%&()#@&$KJKSFBVKJBSVJKSkjngjngnrniorngiwep |
	
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatWhenTheCancelButtonIsClickedTheCreatePageConfigurationIsClosedAndTheDefaultViewIsReloaded
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
	When User navigates to the 'Builder' left menu item
	Then 'Create Application Page' page subheader is displayed to user
	When User enters 'Page_4' text to 'Page Name' textbox
	When User enters 'DisplayPage_4' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	When User clicks 'CREATE' button
	Then User sees item with 'Page' type and 'Page_4' name on Self Service Builder Panel
	When User clicks 'CREATE PAGE' button
	When User enters 'Page_44' text to 'Page Name' textbox
	When User enters 'DisplayPage_44' text to 'Page Display Name' textbox
	When User clicks 'CANCEL' button
	Then 'CREATE PAGE' button is displayed
	Then Page with 'DisplayPage_4' subheader is displayed to user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatWhenCancelButtonIsClickedWhileCreatingVeryFirstPageForTheSelfServiceThenCreatePageFormReturnsToTheDefaultState
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
	When User navigates to the 'Builder' left menu item
	Then 'Create Application Page' page subheader is displayed to user
	When User enters 'Page_5' text to 'Page Name' textbox
	When User enters 'DisplayPage_5' text to 'Page Display Name' textbox
	When User checks 'Show page in self service' checkbox
	When User clicks 'CANCEL' button
	Then 'Show page in self service' checkbox is unchecked
	Then '' content is displayed in 'Page Name' textbox
	Then '' content is displayed in 'Page Display Name' textbox
	Then 'CREATE' button is disabled
	
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatValidationMessageDisplaysIfUserLeftPageNameEmpty
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
	When User navigates to the 'Builder' left menu item
	When User enters 'Page_5' text to 'Page Name' textbox
	When User enters 'DisplayPage_5' text to 'Page Display Name' textbox
	When User clears 'Page Name' textbox with backspaces
	Then 'A page name must be entered' error message is displayed for 'Page Name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19831 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCanOpenCreateSelfServicePageWhenOnePageIsAlreadyExists
	When User create static list with "1803 Apps" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API
	| ServiceId | Name       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName | Scope     |
	| 1         | TestProj_6 | Test_ID_6         | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       | 1803 Apps |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| Test_ID_6         | TestPageSs2 | TestPageSsDisplay | false             |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' parent left menu item
	When User clicks 'Edit' option in Cog-menu for 'TestProj_6' item from 'Self Service Name' column
	Then Self Service Details page is displayed correctly
	When User navigates to the 'Builder' left submenu item
	When User clicks 'CREATE PAGE' button
	Then 'Create Application Page' page subheader is displayed to user
	Then 'Page Name' textbox is displayed
	Then 'Page Display Name' textbox is displayed
	Then 'CREATE' button is disabled