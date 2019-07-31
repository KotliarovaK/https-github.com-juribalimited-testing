Feature: EditClickableValueField
	Edit clickable value field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User | Computer | Application | Mailbox |
	| CfDAS15473_1 | FlDAS15473_1 | true                | true    | true | true     | true        | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 6648     | CfDAS15473_1 | ValueDAS15473_1 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00YWR8TJU4ZF8V"
	And User click content from "Hostname" column
	Then Details page for "00YWR8TJU4ZF8V" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	When User doubleclicks on 'ValueDAS15473_1' cell from 'Value' column
	Then Save and Cancel buttons with tooltips are displayed for clickable value

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckDataIsUpdatedInClickableValue
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User | Computer | Application | Mailbox |
	| CfDAS15473_2 | FlDAS15473_2 | true                | true    | true | true     | true        | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 6648     | CfDAS15473_2 | ValueDAS15473_2 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00YWR8TJU4ZF8V"
	And User click content from "Hostname" column
	Then Details page for "00YWR8TJU4ZF8V" item is displayed to the user
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckClickableValueSavedOnFocusLost
	When User clicks "Projects" on the left-hand menu
	And User navigate to Manage link
	And User select "Custom Fields" option in Management Console
	And User creates new Custom Field
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | User | Computer | Application | Mailbox |
	| CfDAS15473_3 | FlDAS15473_3 | true                | true    | true | true     | true        | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| device     | 6648     | CfDAS15473_3 | ValueDAS15473_3 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "00YWR8TJU4ZF8V"
	And User click content from "Hostname" column
	Then Details page for "00YWR8TJU4ZF8V" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Save changes
	When User change text in 'ValueDAS15473_3' cell from 'Value' column to 'UPDATED_Focus_Lost' text without saving
	When User clicks Body container
	Then Save and Cancel buttons are NOT displayed for clickable value
	And "UPDATED_Focus_Lost" content is displayed in the "Value" column