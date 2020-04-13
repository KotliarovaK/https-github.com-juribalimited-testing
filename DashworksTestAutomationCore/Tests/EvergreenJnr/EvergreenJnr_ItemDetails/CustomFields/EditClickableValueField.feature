Feature: EditClickableValueField
	Edit clickable value field

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckEditableFieldDisplayAndToolTips
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Computer |
	| CfDAS15473_1 | FlDAS15473_1 | true                | true    | true     |
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value                |
	| device     | 6648     | CfDAS15473_1 | ValueDAS15473_#$‡!_1 |
	And User navigates to the 'Device' details page for '00YWR8TJU4ZF8V' item
	Then Details page for '00YWR8TJU4ZF8V' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	When User doubleclicks on 'ValueDAS15473_#$‡!_1' cell from 'Value' column
	Then Save and Cancel buttons with tooltips are displayed for clickable value

@Evergreen @Applications @EvergreenJnr_ItemDetails @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckDataIsUpdatedInClickableValue
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Application |
	| CfDAS15473_2 | FlDAS15473_2 | true                | true    | true        |
	And User creates Custom Field via API
	| ObjectType  | ObjectId | FieldName    | Value           |
	| application | 507      | CfDAS15473_2 | ValueDAS15473_2 |
	And User navigates to the 'Application' details page for 'ACDSee 8' item
	Then Details page for 'ACDSee 8' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	#Save changes
	When User change text in 'ValueDAS15473_2' cell from 'Value' column to 'UPDATED_V' text
	Then Save and Cancel buttons are NOT displayed for clickable value
	And 'UPDATED_V' content is displayed in the 'Value' column
	#Cancel changes
	When User doubleclicks on 'UPDATED_V' cell from 'Value' column
	And User clicks Cancel button for clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And 'UPDATED_V' content is displayed in the 'Value' column

@Evergreen @Applications @EvergreenJnr_ItemDetails @CustomFields @DAS17584 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckDataIsUpdatedUsingCogMenu
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Application |
	| CfDAS17584_1 | FlDAS17584_1 | true                | true    | true        |
	And User creates Custom Field via API
	| ObjectType  | ObjectId | FieldName    | Value        |
	| application | 750      | CfDAS17584_1 | Value17584_1 |
	And User navigates to the 'Application' details page for 'PCFriendly' item
	Then Details page for 'PCFriendly' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	#Save changes
	When User clicks 'Edit' option in Cog-menu for 'FlDAS17584_1' item from 'Custom Field' column
	And User save 'UPDATED_UPD' text in clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And 'UPDATED_UPD' content is displayed in the 'Value' column
	#Cancel changes
	When User clicks 'Edit' option in Cog-menu for 'FlDAS17584_1' item from 'Custom Field' column
	And User clicks Cancel button for clickable value
	Then Save and Cancel buttons are NOT displayed for clickable value
	And 'UPDATED_UPD' content is displayed in the 'Value' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS15473 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckClickableValueSavedOnFocusLost
	When User creates new Custom Field via API
	| FieldName    | FieldLabel   | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS15473_3 | FlDAS15473_3 | true                | true    | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName    | Value           |
	| mailbox    | 46384    | CfDAS15473_3 | ValueDAS15473_3 |
	And User navigates to the 'Mailbox' details page for '0072B088173449E3A93@bclabs.local' item
	Then Details page for '0072B088173449E3A93@bclabs.local' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	#Save changes
	When User change text in 'ValueDAS15473_3' cell from 'Value' column to 'UPDATED_Focus_Lost' text without saving
	When User clicks Body container
	Then Save and Cancel buttons are NOT displayed for clickable value
	And 'UPDATED_Focus_Lost' content is displayed in the 'Value' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @CustomFields @DAS20064 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatEditingOfTheCustomFieldIsActivatedOnTheObjectDetailsPageViaTheCogMenuInCaseTheSearchFilterHadBeenApplied
	When User creates new Custom Field via API
	| FieldName     | FieldLabel    | AllowExternalUpdate | Enabled | Mailbox |
	| CfDAS20064_3A | FlDAS20064_3A | true                | true    | true    |
	| CfDAS20064_3B | FlDAS20064_3B | true                | true    | true    |
	And User navigate to Evergreen URL
	And User creates Custom Field via API
	| ObjectType | ObjectId | FieldName     | Value            |
	| mailbox    | 46384    | CfDAS20064_3A | ValueDAS20064_3A |
	| mailbox    | 46384    | CfDAS20064_3B | ValueDAS20064_3B |
	And User navigates to the 'Mailbox' details page for '0072B088173449E3A93@bclabs.local' item
	Then Details page for '0072B088173449E3A93@bclabs.local' item is displayed to the user
	When User navigates to the 'Custom Fields' left submenu item
	When User enters "DAS20064" text in the Search field for "Value" column
	When User clicks 'Edit' option in Cog-menu for 'FlDAS20064_3B' item from 'Custom Field' column
	Then Save and Cancel buttons with tooltips are displayed for clickable value
	When User save 'ValueDAS20064_3B_UPD' text in clickable value
	When User clicks button with 'ResetFilters' aria label
	When User enters "FlDAS20064_3B" text in the Search field for "Custom Field" column
	Then 'ValueDAS20064_3B_UPD' content is displayed in the 'Value' column