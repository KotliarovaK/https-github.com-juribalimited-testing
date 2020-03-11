Feature: CreateNewCustomField
	Create New Custom Field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Do_Not_Run_With_CustomFields @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips
	When User creates new Custom Field via API
	| FieldName     | FieldLabel    | AllowExternalUpdate | Enabled | Computer |
	| CfDAS16487_1a | FlDAS16487_1a | true                | true    | true     |
	| CfDAS16487_1b | FlDAS16487_1b | true                | false   | true     |
	| CfDAS16487_1c | FlDAS16487_1c | true                | true    | false    |
	When User navigates to the 'Device' details page for 'QFI94WAUX17N4I' item
	Then Details page for 'QFI94WAUX17N4I' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	And User clicks 'ADD CUSTOM FIELD' button 
	Then 'ADD' button is disabled
	Then 'ADD' button has tooltip with 'Some values are missing or invalid' text
	Then 'CANCEL' button is not disabled
	When User clicks Body container
	Then 'Custom Field' autocomplete last option is 'FlDAS16487_1a'
	And 'Custom Field' autocomplete does NOT have options
	| Options       |
	| FlDAS16487_1b |
	| FlDAS16487_1c |
	When User selects 'FlDAS16487_1a' option after search from 'Custom Field' autocomplete
	Then 'ADD' button is not disabled

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox | Computer | User | Application |
	| CfDAS16487_1 | FlDAS16487_1 | true                | true    | true    | true     | true | true        |
	And User navigates to the 'Mailbox' details page for '03F0CCD0F3384DE5A9F@bclabs.local' item
	Then Details page for '03F0CCD0F3384DE5A9F@bclabs.local' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    |
	| mailbox    | 43801    | FlDAS16487_1 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And '' content is displayed in the 'Value' column
	And 'Custom Fields' left submenu item with '1' count is displayed

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CreateCustomField
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_2 | FlDAS16487_2 | true                | true    | true |
	And User navigates to the 'User' details page for 'BrissonTa' item
	Then Details page for 'BrissonTa (Ta Brisson)' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value                |
	| user       | 98968    | FlDAS16487_2 | Value_@#†_DAS16487_2 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And 'Value_@#†_DAS16487_2' content is displayed in the 'Value' column
	And 'Custom Fields' left submenu item with '1' count is displayed
	Then "1" rows found label displays on Details Page

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CancelCustomFieldCreation
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_3 | FlDAS16487_3 | true                | true    | true |
	And User navigates to the 'User' details page for 'VriezeGi' item
	Then Details page for 'VriezeGi (Ginette Vrieze)' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	And User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'FlDAS16487_3' option from 'Custom Field' autocomplete
	And User enters 'Somve_Value' text to 'Value' textbox
	When User clicks 'CANCEL' button on popup
	Then 'Custom Fields' left submenu item with '0' count is displayed

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CreateCustomFieldWithSameData
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS17614_4 | FlDAS17614_4 | true                | true    | true |
	And User navigates to the 'User' details page for 'OBM473400' item
	Then Details page for 'OBM473400 (Jeannie L. Moreno)' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	Then 'No custom fields found for this user' message is displayed on empty greed
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value       |
	| user       | 17884    | FlDAS17614_4 | Value_17614 |
	Then 'FlDAS17614_4' content is displayed in the 'Custom Field' column
	And 'Value_17614' content is displayed in the 'Value' column
	And 'Custom Fields' left submenu item with '1' count is displayed
	Then "1" rows found label displays on Details Page
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value       |
	| user       | 98968    | FlDAS17614_4 | Value_17614 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And Content in the 'Custom Field' column is equal to
	| Content      |
	| FlDAS17614_4 |
	| FlDAS17614_4 |
	And Content in the 'Value' column is equal to
	| Content     |
	| Value_17614 |
	| Value_17614 |
	And 'Custom Fields' left submenu item with '2' count is displayed
	Then "2" rows found label displays on Details Page

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS17695 @DAS17960 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS17695_2 | FlDAS17695_2 | true                | true    | true |
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value            |
	| user       | 3532     | CfDAS17695_2 | ValueDAS17695_2A |
	| user       | 3532     | CfDAS17695_2 | ValueDAS17695_2B |
	And User navigates to the 'User' details page for 'TAI6096068' item
	And User navigates to the 'Custom Fields' left submenu item
	When User clicks Group By button and set checkboxes state
	| Checkboxes   | State |
	| Custom Field | true  |
	Then Cog menu is not displayed on the Admin page
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value            |
	| user       | 3532     | FlDAS17695_2 | ValueDAS17695_2C |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And 'Custom Fields' left submenu item with '3' count is displayed
	And Content in the 'Custom Field' column is equal to
	| Content      |
	| FlDAS17695_2 |
	| FlDAS17695_2 |
	| FlDAS17695_2 |
	And Content in the 'Value' column is equal to
	| Content          |
	| ValueDAS17695_2A |
	| ValueDAS17695_2B |
	| ValueDAS17695_2C |
	And Grid is not grouped
	Then '0' options are checked in the 'GroupBy' menu panel