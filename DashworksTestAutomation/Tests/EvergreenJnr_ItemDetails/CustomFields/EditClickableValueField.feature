Feature: EditClickableValueField
	Edit clickable value field

Background: Pre-Conditions
	Given User is logged in to the Projects
	When User navigate to Manage link
	And User select "Custom Fields" option in Management Console

	#Remove Not_Ready for Orbit
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Computer |
	| CfDAS15473_1 | FlDAS15473_1 | true                | true    | true     |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value                |
	| device     | 6648     | CfDAS15473_1 | ValueDAS15473_#$‡!_1 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00YWR8TJU4ZF8V"
	And User click content from "Hostname" column
	Then Details page for "00YWR8TJU4ZF8V" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	When User doubleclicks on 'ValueDAS15473_#$‡!_1' cell from 'Value' column
	Then Save and Cancel buttons with tooltips are displayed for clickable value

	#Remove Not_Ready for Orbit
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckDataIsUpdatedInClickableValue
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Application |
	| CfDAS15473_2 | FlDAS15473_2 | true                | true    | true        |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType  | ObjectId | FieldName    | Value           |
	| application | 507      | CfDAS15473_2 | ValueDAS15473_2 |
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACDSee 8"
	And User click content from "Application" column
	Then Details page for "ACDSee 8" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Save changes
	When User change text in 'ValueDAS15473_2' cell from 'Value' column to 'UPDATED_V' text
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_V" content is displayed in the "Value" column
	#Cancel changes
	When User doubleclicks on 'UPDATED_V' cell from 'Value' column
	And User clicks Cancel button for clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_V" content is displayed in the "Value" column

	#Remove Not_Ready for Orbit
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS17584 @Cleanup @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckDataIsUpdatedUsingCogMenu
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Application |
	| CfDAS17584_1 | FlDAS17584_1 | true                | true    | true        |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType  | ObjectId | FieldName    | Value        |
	| application | 750      | CfDAS17584_1 | Value17584_1 |
	And User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "PCFriendly"
	And User click content from "Application" column
	Then Details page for "PCFriendly" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Save changes
	When User clicks "Edit" option in Cog-menu for "FlDAS17584_1" item on Admin page
	And User save 'UPDATED_UPD' text in clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_UPD" content is displayed in the "Value" column
	#Cancel changes
	When User clicks "Edit" option in Cog-menu for "FlDAS17584_1" item on Admin page
	And User clicks Cancel button for clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_UPD" content is displayed in the "Value" column

	#Remove Not_Ready for Orbit
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckClickableValueSavedOnFocusLost
	When User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS15473_3 | FlDAS15473_3 | true                | true    | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| mailbox    | 46384    | CfDAS15473_3 | ValueDAS15473_3 |
	And User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "0072B088173449E3A93@bclabs.local"
	And User click content from "Email Address" column
	Then Details page for "0072B088173449E3A93@bclabs.local" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Save changes
	When User change text in 'ValueDAS15473_3' cell from 'Value' column to 'UPDATED_Focus_Lost' text without saving
	When User clicks Body container
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_Focus_Lost" content is displayed in the "Value" column