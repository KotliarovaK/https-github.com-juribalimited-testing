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
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE SLOT" Action button
	And User type "Slot13147" Name in the "Slot Name" field on the Project details page
	And User type "Name13147" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE SLOT" Action button
	And User type "NewName" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And There are no errors in the browser console
	When User clicks the "CREATE SLOT" Action button
	And User type "Name1" Name in the "Slot Name" field on the Project details page
	And User type "Name1" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	When User have opened Column Settings for "Capacity Slot" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then numeric data in "Display Order" column is sorted in ascending order by default on the Admin page
	Then "Capacity Slot" column content is displayed in the following order:
	| Items     |
	| Slot13147 |
	| NewName   |
	| Name1     |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13955 @DAS13681 @DAS14208 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlyLanguageIsDisplayedForSlotsAfterChangingOrRemovingLanguage
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| ChecksLanguage13955 | All Devices | None            | Standalone Project |
	And User clicks "Details" tab
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Dutch" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "ChecksLanguage" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks "Capacity" tab
	And User clicks "Details" tab
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks "REMOVE" button in the warning message on Admin page
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "German" language on the Project details page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "German" Language is displayed in Translations table on the Capacity Slot page
	When User types "CheckName" in Display Name field for "German" Language in Translations table on the Capacity Slot page
	And User clicks the "UPDATE" Action button
	And User enters "ChecksLanguage" text in the Search field for "Capacity Slot" column
	And User clicks content from "Capacity Slot" column
	And User clicks "See Translations" link on the Capacity Slot page
	Then "CheckName" is displayed in Display Name field for "German" Language in Translations table on the Capacity Slot page
	When User clicks "Capacity" tab
	#You have unsaved changes. Are you sure you want to leave the page?
	And User clicks "Details" tab
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	Then Warning message with "Removing German will delete all translations for this language in this project" text is displayed on the Project Details Page
	When User clicks "CANCEL" button in the warning message on Admin page
	And User opens menu for selected language
	Then User selects "Remove" option for selected language
	When User clicks "REMOVE" button in the warning message on Admin page
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "ChecksLanguage 2" Name in the "Slot Name" field on the Project details page
	And User type "DAS13955" Name in the "Display Name" field on the Project details page
	And User clicks the "CREATE" Action button
	And User clicks newly created object link
	Then See Translations link on the Capacity Slot page is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13661 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCreatedSlotWithSelectedTypeTeamsAndRequestTypesIsDisplayedWithCorrectlyValue
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS14103 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Teams and Paths" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Paths" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	And "" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13417 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatNoUnitsOptionsWasAddedToCapacityUnitsFilter
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13417 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	And User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Teams and Paths" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Teams and Paths" Name in the "Display Name" field on the Project details page
	Then User selects "Teams and Paths" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks the "CREATE SLOT" Action button
	And User type "capacity type = Capacity Units" Name in the "Slot Name" field on the Project details page
	And User type "capacity type = Capacity Units" Name in the "Display Name" field on the Project details page
	Then User selects "Capacity Units" option in "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your capacity slot has been created" text
	When User clicks String Filter button for "Capacity Units" column on the Admin page
	And User selects "All Capacity Units" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "1" of "2" rows
	And "" content is displayed in "Capacity Units" column
