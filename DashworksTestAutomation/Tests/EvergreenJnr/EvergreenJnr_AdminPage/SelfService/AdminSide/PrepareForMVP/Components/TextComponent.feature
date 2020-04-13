Feature: TextComponent
	Text Component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19979 @Cleanup
Scenario: EvergreenJnr_AdminPage_TextComponentUiCheckForCreatePage
	When User create static list with "DAS_19979_11" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_19979_SS_1 | 19979_1_SI        | true    | true                | DAS_19979_11 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName    | ShowInSelfService |
	| 19979_1_SI        | TestPageSs2 | DAS_19979_Page | true              |
	When User navigates to the 'Builder' left submenu item
	When User clicks on Add Item button for item with 'Page' type and 'TestPageSs2' name on Self Service Builder Panel
	When User clicks on 'Text' component on dialog
	When User clicks 'ADD' button on popup
	Then Page with 'DAS_19979_SS_1' header is displayed to user
	Then Page with 'Create Text Component' subheader is displayed to user
	Then 'TestPageSs2' label with self service parent page name is displayed
	Then text editor is displayed
	Then '' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is unchecked
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19979 @DAS20049 @Cleanup
Scenario: EvergreenJnr_AdminPage_TextComponentUiCheckForUpdatePage
	When User create static list with "DAS_19979_22" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_19979_SS_2 | 19979_2_SI        | true    | true                | DAS_19979_22 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 19979_2_SI        | TestPageSs3 | DAS_19979_Page_2 | true              |
	When User creates new text component for 'TestPageSs3' Self Service page via API
	| ComponentName       | ExtraPropertiesText | ShowInSelfService |
	| Text_Component_Name | <p>Some_Content</p> | true              |
	When User navigates to the 'Builder' left submenu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name' name on Self Service Builder Panel
	Then Page with 'DAS_19979_SS_2' header is displayed to user
	Then Page with 'Edit Text Component' subheader is displayed to user
	Then 'TestPageSs3' label with self service parent page name is displayed
	Then 'Text_Component_Name' content is displayed in 'Component Name' textbox
	Then text editor is displayed
	Then text editor contains text
	| text         |
	| Some_Content |
	Then 'Show this component' checkbox is checked
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	When User enters '' text to 'Component Name' textbox
	Then 'Enter a component name' error message is displayed for 'Component Name' field
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#
	When User enters 'Text_Component_Name' text to 'Component Name' textbox
	When User clicks Body container
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#
	When User clears text editor
	When User clicks Body container
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	#
	When User enters 'Some_Content' text to the text editor
	When User clicks Body container
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'No changes made' text
	#
	When User enters '_Additional_Text' text to the text editor
	When User enters 'Updated Name' text to 'Component Name' textbox
	When User unchecks 'Show this component' checkbox
	When User clicks 'UPDATE' button
	Then 'The Updated Name component has been updated' text is displayed on inline success banner
	Then Item with 'Page' type and 'TestPageSs3' name on Self Service Builder Panel is highlighted
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Updated Name' name on Self Service Builder Panel
	Then 'Updated Name' content is displayed in 'Component Name' textbox
	Then text editor contains text
	| text                         |
	| Some_Content_Additional_Text |
	Then 'Show this component' checkbox is unchecked

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20049 @Cleanup
Scenario: EvergreenJnr_AdminPage_TextComponentUiCheckForCancelUpdateFunctionality
	When User create static list with "DAS_20049_33" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope        |
	| DAS_20049_SS_3 | 20049_3_SI        | true    | true                | DAS_20049_33 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName      | ShowInSelfService |
	| 20049_3_SI        | TestPageSs4 | DAS_20049_Page_2 | true              |
	When User creates new text component for 'TestPageSs4' Self Service page via API
	| ComponentName       | ExtraPropertiesText | ShowInSelfService |
	| Text_Component_Name | <p>Some_Content</p> | true              |
	When User navigates to the 'Builder' left submenu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name' name on Self Service Builder Panel
	When User enters 'Updated Name' text to 'Component Name' textbox
	When User enters 'Additional Text' text to the text editor
	When User unchecks 'Show this component' checkbox
	When User clicks 'CANCEL' button
	#
	Then Item with 'Page' type and 'TestPageSs4' name on Self Service Builder Panel is highlighted
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name' name on Self Service Builder Panel
	Then 'Text_Component_Name' content is displayed in 'Component Name' textbox
	Then 'Show this component' checkbox is checked
	Then text editor does not contains text
	| text            |
	| Additional Text |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20160 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatTextEditorOptionsIsAvailableForTextComponent
	When User create static list with "DAS_20160" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope     |
	| DAS_20160_SS_3 | 20160_3_SI        | true    | true                | DAS_20160 |
	When User creates new text component for 'Welcome' Self Service page via API
	| ComponentName       | ExtraPropertiesText | ShowInSelfService |
	| Text_Component_Name | <p>Some_Content</p> | true              |
	When User navigates to the 'Builder' left submenu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'Text_Component_Name' name on Self Service Builder Panel
	Then formatting options are displayed on the text component
	Then header format options are displayed on the text component
	| Options   |
	| Heading 1 |
	| Heading 2 |
	| Heading 3 |
	| Heading 4 |
	| Heading 5 |
	| Normal    |