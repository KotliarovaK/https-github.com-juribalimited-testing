Feature: FiltersAddColumn
	Runs add column related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS10781 @DAS11573
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes   |
		| <SelectedCheckboxes> |

	Examples:
		| PageName     | FilterName            | SelectedCheckboxes               |
		| Devices      | Operating System      | Add Operating System column      |
		| Devices      | City                  | Add City column                  |
		| Users        | Zip Code              | Add Zip Code column              |
		| Applications | Application Owner     | Add Application Owner column     |
		| Mailboxes    | Mailbox Filter 1      | Add Mailbox Filter 1 column      |
		| Devices      | Compliance            | Add Compliance column            |
		| Mailboxes    | Owner Department Code | Add Owner Department Code column |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS11187 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnOptionIsNotAvailableForApplicationCustomFieldsFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Owner" filter from "Application Custom Fields" category
	Then "Add column" checkbox is not displayed

@Evergreen @AllLists @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11351
Scenario Outline: EvergreenJnr_AllLists_DevicesList_CheckThatAddColumnOptionIsAvailableForOwnerDepartmentFilter
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Department" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes                    |
		| Add Owner Department Name column      |
		| Add Owner Department Full Path column |

	Examples:
		| PageName  |
		| Mailboxes |
		| Devices   |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11619
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisabledForAlreadySelectedColumn
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Add column"checkbox is checked and cannot be unchecked

	Examples:
		| ListName     | FilterName              |
		| Devices      | Hostname                |
		| Devices      | Device Type             |
		| Devices      | Operating System        |
		| Devices      | Owner Display Name      |
		| Users        | Username                |
		| Users        | Domain                  |
		| Users        | Display Name            |
		| Users        | Distinguished Name      |
		| Applications | Application             |
		| Applications | Vendor                  |
		| Applications | Version                 |
		| Mailboxes    | Email Address (Primary) |
		| Mailboxes    | Mailbox Platform        |
		| Mailboxes    | Mail Server             |
		| Mailboxes    | Mailbox Type            |
		| Mailboxes    | Owner Display Name      |

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS11829
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisplayedForOrganisationCategoryFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes   |
		| <SelectedCheckboxes> |

	Examples:
		| ListName  | FilterName                 | SelectedCheckboxes                    |
		| Devices   | Department Name            | Add Department Name column            |
		| Devices   | Department Full Path       | Add Department Full Path column       |
		| Devices   | Owner Department Name      | Add Owner Department Name column      |
		| Devices   | Owner Department Full Path | Add Owner Department Full Path column |
		| Mailboxes | Department Name            | Add Department Name column            |
		| Mailboxes | Department Full Path       | Add Department Full Path column       |
		| Mailboxes | Owner Department Name      | Add Owner Department Name column      |
		| Mailboxes | Owner Department Full Path | Add Owner Department Full Path column |
