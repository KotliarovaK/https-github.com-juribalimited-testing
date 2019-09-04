Feature: DeleteCustomFields
	Delete Custom fields

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS16489 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckCustomFieldDeleting
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Computer |
	| CfDAS16489_1 | FlDAS16489_1 | true                | true    | true     |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 17152    | CfDAS16489_1 | ValueDAS16489_1 |
	And User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User perform search by "WIN-KTJC6PMV2P5"
	And User click content from "Hostname" column
	Then Details page for "WIN-KTJC6PMV2P5" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Cancel
	And User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected custom field will be permanently deleted" text is displayed on the Project Details Page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	And 'ValueDAS16489_1' content is displayed in the 'Value' column
	#Delete
	When User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected custom field will be permanently deleted" text is displayed on the Project Details Page
	When User clicks Delete button in the warning message
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And "No custom fields found for this device" message is displayed on the Details Page
	And "ValueDAS16489_1" content is not displayed in the "Value" column
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '0' count of items
	And There are no errors in the browser console

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS17695 @Cleanup
Scenario: EvergreenJnr_MailboxesList_DeleteGroupedCustomFields
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS17695_1 | FlDAS17695_1 | true                | true    | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value            |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1A |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1B |
	And User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User perform search by "gregoja@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "gregoja@bclabs.local" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	When User clicks Group By button on the Admin page and selects "Value" value
	Then Cog menu is not displayed on the Admin page
	When User expands 'ValueDAS17695_1A' row in the groped grid
	And User clicks "Delete" option in Cog-menu for "FlDAS17695_1" item on Admin page
	Then Warning message with "The selected custom field will be permanently deleted" text is displayed on the Project Details Page
	When User clicks Delete button in the warning message
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And Grid is not grouped
	And No options are selected in the Group By menu
	And "Custom Fields" tab is displayed on left menu on the Details page and contains '1' count of items
	And "ValueDAS17695_1A" content is not displayed in the "Value" column
	And 'ValueDAS17695_1B' content is displayed in the 'Value' column
