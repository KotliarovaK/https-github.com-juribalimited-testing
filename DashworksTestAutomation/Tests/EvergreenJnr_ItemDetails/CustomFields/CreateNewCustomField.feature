﻿Feature: CreateNewCustomField
	Create New Custom Field

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Do_Not_Run_With_CustomFields @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips
	When User creates new Custom Field
	| FieldName     | FieldLabel    | AllowExternalUpdate | Enabled | Computer |
	| CfDAS16487_1a | FlDAS16487_1a | true                | true    | true     |
	| CfDAS16487_1b | FlDAS16487_1b | true                | false   | true     |
	| CfDAS16487_1c | FlDAS16487_1c | true                | true    | false    |
	And User navigate to Evergreen URL
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "QFI94WAUX17N4I"
	And User click content from "Hostname" column
	Then Details page for "QFI94WAUX17N4I" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks 'ADD CUSTOM FIELD' button 
	Then "ADD" Action button is disabled
	And "ADD" Action button have tooltip with "Some values are missing or invalid" text
	Then "CANCEL" Action button is enabled
	When User clicks Body container
	Then 'Custom Field' autocomplete last option is 'FlDAS16487_1a'
	And 'Custom Field' autocomplete does NOT have options
	| Options       |
	| FlDAS16487_1b |
	| FlDAS16487_1c |
	When User selects 'FlDAS16487_1a' option after search from 'Custom Field' autocomplete
	Then "ADD" Action button is enabled

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox | Computer | User | Application |
	| CfDAS16487_1 | FlDAS16487_1 | true                | true    | true    | true     | true | true        |
	And User navigates to the 'Mailbox' details page for '03F0CCD0F3384DE5A9F@bclabs.local' item
	Then Details page for "03F0CCD0F3384DE5A9F@bclabs.local" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    |
	| mailbox    | 43801    | FlDAS16487_1 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And '' content is displayed in the 'Value' column
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '1' count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CreateCustomField
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_2 | FlDAS16487_2 | true                | true    | true |
	And User navigates to the 'User' details page for 'BrissonTa' item
	Then Details page for "BrissonTa (Ta Brisson)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value                |
	| user       | 98968    | FlDAS16487_2 | Value_@#†_DAS16487_2 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And 'Value_@#†_DAS16487_2' content is displayed in the 'Value' column
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '1' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CancelCustomFieldCreation
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_3 | FlDAS16487_3 | true                | true    | true |
	And User navigates to the 'User' details page for 'VriezeGi' item
	Then Details page for "VriezeGi (Ginette Vrieze)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks 'ADD CUSTOM FIELD' button 
	When User selects 'FlDAS16487_3' option from 'Custom Field' autocomplete
	And User enters 'Somve_Value' text to 'Value' textbox
	And User clicks Cancel button on Add Custom Field popup
	Then 'Custom Fields' tab is displayed on left menu on the Details page and contains '0' count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS16487 @Cleanup
Scenario: EvergreenJnr_UsersList_CreateCustomFieldWithSameData
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS17614_4 | FlDAS17614_4 | true                | true    | true |
	And User navigates to the 'User' details page for 'OBM473400' item
	Then Details page for "OBM473400 (Jeannie L. Moreno)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	Then 'No custom fields found for this user' message is displayed on empty greed
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value       |
	| user       | 17884    | FlDAS17614_4 | Value_17614 |
	Then 'FlDAS17614_4' content is displayed in the 'Custom Field' column
	And 'Value_17614' content is displayed in the 'Value' column
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '1' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!
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
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '2' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!

@Evergreen @Users @EvergreenJnr_ItemDetails @CustomFields @DAS17695 @DAS17960 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckGroupByResetAfterCreatingNewCustomField
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS17695_2 | FlDAS17695_2 | true                | true    | true |
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value            |
	| user       | 3532     | CfDAS17695_2 | ValueDAS17695_2A |
	| user       | 3532     | CfDAS17695_2 | ValueDAS17695_2B |
	And User navigates to the 'User' details page for 'TAI6096068' item
	And User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks Group By button on the Admin page and selects "Custom Field" value
	Then Cog menu is not displayed on the Admin page
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value            |
	| user       | 3532     | FlDAS17695_2 | ValueDAS17695_2C |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '3' count of items
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
	And No options are selected in the Group By menu