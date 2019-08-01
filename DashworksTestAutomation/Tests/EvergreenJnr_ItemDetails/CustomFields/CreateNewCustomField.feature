Feature: CreateNewCustomField
	Create New Custom Field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Remove Not_Ready for Orbit
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckCustomFieldUiAndTooltips
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "02IE2CQR3L2ZX1"
	And User click content from "Hostname" column
	Then Details page for "02IE2CQR3L2ZX1" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	And User clicks the "CUSTOM FIELDS" Action button
	Then Add button is displayed on Add Custom Field popup
	Then Cancel button is enabled on Add Custom Field popup

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
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    |
	| mailbox    | 43801    | CfDAS16487_1 |
	And User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "03F0CCD0F3384DE5A9F@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "03F0CCD0F3384DE5A9F@bclabs.local" item is displayed to the user
	And "" content is displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items

	#Remove Not_Ready for Orbit
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16487 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CreateCustomField
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox | Computer |
	| CfDAS16487_2 | FlDAS16487_2 | true                | true    | true    | true     |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| mailbox    | 43801    | CfDAS16487_2 | ValueDAS16487_2 |
	And User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "03F0CCD0F3384DE5A9F@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "03F0CCD0F3384DE5A9F@bclabs.local" item is displayed to the user
	And "" content is displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items