Feature: DeleteCustomFields
	Delete Custom fields

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
	| device     | 6735     | FlDAS16489_1 | ValueDAS16489_1 |
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "DU37EV2NCNFI4H"
	And User click content from "Hostname" column
	Then Details page for "DU37EV2NCNFI4H" item is displayed to the user
	When User navigates to the "Custom Fields" sub-menu on the Details page
	#Cancel
	And User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected Custom Field will be deleted, do you want to proceed?" text is displayed on the Project Details Page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	And "ValueDAS16489_1" content is displayed in the "Value" column
	#Delete
	When User clicks "Delete" option in Cog-menu for "FlDAS16489_1" item on Admin page
	Then Warning message with "The selected Custom Field will be deleted, do you want to proceed?" text is displayed on the Project Details Page
	When User clicks Delete button in the warning message
	Then Success message with "Custom field value deleted successfully" text is displayed on Action panel
	And "No custom fields found for this device" message is displayed on the Details Page
	And There are no errors in the browser console	
