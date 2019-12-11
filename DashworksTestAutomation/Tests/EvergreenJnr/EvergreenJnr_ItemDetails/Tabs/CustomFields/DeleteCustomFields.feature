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
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 17266    | CfDAS16489_1 | ValueDAS16489_1 |
	# 17152_-------->| original ObjId 17152
	And User navigates to the 'Device' details page for 'WIN-KTJC6PMV2P5' item
	Then Details page for "WIN-KTJC6PMV2P5" item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	#Cancel
	And User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then 'The selected custom field will be permanently deleted' text is displayed on inline tip banner
	When User clicks 'CANCEL' button on inline tip banner
	Then inline tip banner is not displayed
	And 'ValueDAS16489_1' content is displayed in the 'Value' column
	#Delete
	When User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then 'The selected custom field will be permanently deleted' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	Then 'No custom fields found for this device' message is displayed on empty greed
	And 'ValueDAS16489_1' content is not displayed in the 'Value' column
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '0' count of items
	And There are no errors in the browser console

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS17695 @DAS18362 @Cleanup
Scenario: EvergreenJnr_MailboxesList_DeleteGroupedCustomFields
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS17695_1 | FlDAS17695_1 | true                | true    | true    |
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value            |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1A |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1B |
	And User navigates to the 'Mailbox' details page for 'gregoja@bclabs.local' item
	Then Details page for "gregoja@bclabs.local" item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	When User clicks Group By button on the Admin page and selects "Value" value
	Then Cog menu is not displayed on the Admin page
	When User expands 'ValueDAS17695_1A' row in the groped grid
	And User clicks "Delete" option in Cog-menu for "FlDAS17695_1" item on Admin page
	Then 'The selected custom field will be permanently deleted' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And Grid is grouped
	And '1' options are selected in the Group By menu
	And 'Custom Fields' tab is displayed on left menu on the Details page and contains '1' count of items
	When User expands 'ValueDAS17695_1B' row in the groped grid
	Then 'ValueDAS17695_1A' content is not displayed in the 'Value' column
	And 'ValueDAS17695_1B' content is displayed in the 'Value' column
