﻿Feature: CreateNewCustomField
	Create New Custom Field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Remove Not_Ready for Orbit
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckAddCustomFieldPopupUiAndTooltips
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName     | FieldLabel    | AllowExternalUpdate | Enabled | Computer |
	| CfDAS16487_1a | FlDAS16487_1a | true                | true    | true     |
	| CfDAS16487_1b | FlDAS16487_1b | true                | false   | true     |
	| CfDAS16487_1c | FlDAS16487_1c | true                | true    | false    |
	And User navigate to Evergreen URL
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "QFI94WAUX17N4I"
	And User click content from "Hostname" column
	Then Details page for "QFI94WAUX17N4I" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks the "ADD CUSTOM FIELD" Action button
	Then Add button is displayed on Add Custom Field popup
	And Cancel button is enabled on Add Custom Field popup
	And 'Custom Field' autocomplete last option is 'FlDAS16487_1a'
	And 'Custom Field' autocomplete does NOT have option
	| Option        |
	| FlDAS16487_1b |
	| FlDAS16487_1c |
	When User selects 'FlDAS16487_1a' option after search from 'Custom Field' autocomplete
	Then Add button is enabled on Add Custom Field popup

	#Remove Not_Ready for Orbit
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CreateCustomFieldWithEmptyValue
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox | Computer |
	| CfDAS16487_1 | FlDAS16487_1 | true                | true    | true    | true     |
	And User navigate to Evergreen URL
	And User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "03F0CCD0F3384DE5A9F@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "03F0CCD0F3384DE5A9F@bclabs.local" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    |
	| mailbox    | 43801    | FlDAS16487_1 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And "" content is displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items

	#Remove Not_Ready for Orbit
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_CreateCustomField
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_2 | FlDAS16487_2 | true                | true    | true |
	And User navigate to Evergreen URL
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "BrissonTa"
	And User click content from "Username" column
	Then Details page for "BrissonTa (Ta Brisson)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value                |
	| user       | 98968    | FlDAS16487_2 | Value_@#†_DAS16487_2 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And "Value_@#†_DAS16487_2" content is displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!

	#Remove Not_Ready for Orbit
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_CancelCustomFieldCreation
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS16487_3 | FlDAS16487_3 | true                | true    | true |
	And User navigate to Evergreen URL
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "VriezeGi"
	And User click content from "Username" column
	Then Details page for "VriezeGi (Ginette Vrieze)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks the "CUSTOM FIELDS" Action button
	When User selects 'FlDAS16487_3' option from 'Custom Field' autocomplete
	And User enters 'Somve_Value' text to 'Value' textbox
	And User clicks Cancel button on Add Custom Field popup
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items

	#Remove Not_Ready for Orbit
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_CreateCustomFieldWithSameData
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User |
	| CfDAS17614_4 | FlDAS17614_4 | true                | true    | true |
	And User navigate to Evergreen URL
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "OBM473400"
	And User click content from "Username" column
	Then Details page for "OBM473400 (Jeannie L. Moreno)" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	Then 'No custom fields found for this user' message is displayed on empty greed
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value       |
	| user       | 17884    | FlDAS17614_4 | Value_17614 |
	Then "FlDAS17614_4" content is displayed in the "Custom Field" column
	And "Value_17614" content is displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!
	When User creates Custom Field
	| ObjectType | ObjectId | FieldName    | Value       |
	| user       | 98968    | FlDAS17614_4 | Value_17614 |
	Then Success message with "New custom field value added successfully" text is displayed on Action panel
	And Content is displayed in the "Custom Field" column
	| Content      |
	| FlDAS17614_4 |
	| FlDAS17614_4 |
	And Content is displayed in the "Value" column
	| Content     |
	| Value_17614 |
	| Value_17614 |
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '2' count of items
	#ADD VERIFICATION FOR ROW COUNTER!!!