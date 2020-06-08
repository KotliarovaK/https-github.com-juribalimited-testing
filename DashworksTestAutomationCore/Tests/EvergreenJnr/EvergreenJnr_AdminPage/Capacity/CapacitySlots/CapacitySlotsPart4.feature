Feature: CapacitySlotsPart4
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13382 @DAS13149 @DAS13147 @DAS15827 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNewSlotIsSuccessfullyCreatedUsingExistingDisplayName
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| 13382ProjectForCapacity | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project                 | SlotName  | DisplayName |
	| 13382ProjectForCapacity | Slot13147 | Name13147   |
	| 13382ProjectForCapacity | NewName   | Name1       |
	| 13382ProjectForCapacity | Name1     | Name1       |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User opens 'Capacity Slot' column settings
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in table is sorted by 'Display Order' column in ascending order by default
	Then Content in the 'Capacity Slot' column is equal to
	| Content   |
	| Slot13147 |
	| NewName   |
	| Name1     |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13955 @DAS13681 @DAS14208 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlyLanguageIsDisplayedForSlotsAfterChangingOrRemovingLanguage
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| ChecksLanguage13955 | All Devices | None            | Standalone Project |
	And User navigates to the 'Details' left menu item
	And User clicks 'ADD LANGUAGE' button 
	And User selects "Dutch" language on the Project details page
	And User creates new Slot via Api
	| Project             | SlotName       | DisplayName |
	| ChecksLanguage13955 | ChecksLanguage | DAS13955    |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Details' left menu item
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks 'REMOVE' button on inline tip banner
	And User clicks 'ADD LANGUAGE' button 
	And User selects "German" language on the Project details page
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "German" Language is displayed in Translations table on the Capacity Slot page
	When User types "CheckName" in Display Name field for "German" Language in Translations table on the Capacity Slot page
	And User clicks 'UPDATE' button 
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "CheckName" is displayed in Display Name field for "German" Language in Translations table on the Capacity Slot page
	When User navigates to the 'Capacity' left menu item
	#You have unsaved changes. Are you sure you want to leave the page?
	And User navigates to the 'Details' left menu item
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	Then 'Removing German will delete all translations for this language in this project' text is displayed on inline tip banner
	When User clicks 'CANCEL' button on inline tip banner
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks 'REMOVE' button on inline tip banner
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	And User creates new Slot via Api
	| Project             | SlotName         | DisplayName |
	| ChecksLanguage13955 | ChecksLanguage 2 | DAS13955    |
	And User navigates to newly created Slot
	Then See Translations link on the Capacity Slot page is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13661 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCreatedSlotWithSelectedTypeTeamsAndRequestTypesIsDisplayedWithCorrectlyValue
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS14103 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName                        | DisplayName                     | CapacityType    |
	| ProjectForDAS14103 | capacity type = Teams and Paths | capacity type = Teams and Paths | Teams and Paths |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	Then '' content is displayed in the 'Capacity Units' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13417 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatNoUnitsOptionsWasAddedToCapacityUnitsFilter
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13417 | All Devices | None            | Standalone Project |
	And User creates new Slot via Api
	| Project            | SlotName                        | DisplayName                     | CapacityType    |
	| ProjectForDAS13417 | capacity type = Teams and Paths | capacity type = Teams and Paths | Teams and Paths |
	| ProjectForDAS13417 | capacity type = Capacity Units  | capacity type = Capacity Units  | Capacity Units  |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Slots' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Capacity Units' column:
	| checkboxes         |
	| All Capacity Units |
	Then Rows counter shows "1" of "2" rows
	And '' content is displayed in the 'Capacity Units' column