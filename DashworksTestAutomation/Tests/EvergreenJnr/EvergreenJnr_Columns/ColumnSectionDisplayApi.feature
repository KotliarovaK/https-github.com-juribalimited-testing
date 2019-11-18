Feature: ColumnSectionDisplayApi
	Runs Column Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Devices @EvergreenJnr_Columns @ColumnSectionDisplay @API @DAS13419
Scenario: EvergreenJnr_DevicesList_ChecksThatColumnsPanelDoesNotIncludeUnpublishedTasks
	Then the following subcategories are NOT displayed for "Project Tasks: Windows7Mi" Columns category:
	| Value             |
	| Adhoc Information |
	| Targeting Date    |
	| Migration Updates |

@Evergreen @Users @EvergreenJnr_Columns @ColumnSectionDisplay @API @DAS13419 @DAS14288
Scenario: EvergreenJnr_UsersList_ChecksThatFilterPanelDoesNotIncludeUnpublishedTasks
	Then the following subcategories are NOT displayed for "Project Tasks: prK" Columns category:
	| Value                                                    |
	| user-norm-radb-k                                         |
	| Email Notifications Allowed?Email Notifications Allowed? |
