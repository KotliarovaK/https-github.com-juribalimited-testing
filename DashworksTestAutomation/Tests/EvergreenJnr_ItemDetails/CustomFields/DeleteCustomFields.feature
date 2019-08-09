﻿Feature: DeleteCustomFields
	Delete Custom fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Remove Not_Ready for Orbit
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS16489 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckCustomFieldDeleting
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Computer |
	| CfDAS16489_1 | FlDAS16489_1 | true                | true    | true     |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 6735     | CfDAS16489_1 | ValueDAS16489_1 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "DU37EV2NCNFI4H"
	And User click content from "Hostname" column
	Then Details page for "DU37EV2NCNFI4H" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Cancel
	And User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected custom field will be deleted, do you want to proceed?" text is displayed on the Project Details Page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	And "ValueDAS16489_1" content is displayed in the "Value" column
	#Delete
	When User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected custom field will be deleted, do you want to proceed?" text is displayed on the Project Details Page
	When User clicks Delete button in the warning message
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And "No custom fields found for this device" message is displayed on the Details Page
	And "ValueDAS16489_1" content is not displayed in the "Value" column
	And There are no errors in the browser console

#Remove Not_Ready for Orbit
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS17695 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_DeleteGroupedCustomFields
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS17695_1 | FlDAS17695_1 | true                | true    | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value            |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1A |
	| mailbox    | 48731    | CfDAS17695_1 | ValueDAS17695_1B |
	And User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "gregoja@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "gregoja@bclabs.local" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	When User clicks Group By button on the Admin page and selects "Value" value
	Then Cog menu is not displayed on the Admin page
	When User expands 'ValueDAS17695_1A' row in the groped grid
	And User clicks "Delete" option in Cog-menu for "FlDAS17695_1" item on Admin page
	Then Warning message with "The selected custom field will be deleted, do you want to proceed?" text is displayed on the Project Details Page
	When User clicks Delete button in the warning message
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And Grid is not grouped
	And No options are selected in the Group By menu
	And "ValueDAS17695_1A" content is not displayed in the "Value" column
	And "ValueDAS17695_1B" content is displayed in the "Value" column
