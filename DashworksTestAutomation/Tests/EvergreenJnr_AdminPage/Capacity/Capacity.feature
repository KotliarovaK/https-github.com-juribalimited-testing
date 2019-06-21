Feature: Capacity
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720 @DAS13431 @DAS13162 @DAS14037 @DAS15823 @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When Project created via API and opened
	| ProjectName             | Scope     | ProjectTemplate | Mode               |
	| ProjectForCapacity13720 | All Users | None            | Standalone Project |
	And User clicks "Capacity" tab
	Then "Capacity Units" text value is displayed in the "Capacity Mode" dropdown
	When User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then Counter shows "1" found rows
	When User clicks content from "Capacity Unit" column
	And User changes Name to "Default Capacity Unit" in the "Capacity Unit Name" field on the Project details page 
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	And Columns on Admin page is displayed in following order:
	| ColumnName    |
	|               |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Devices       |
	| Users         |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForDevicesProjectCapacityUnits
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| 13431DevicesProject | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Devices       |
	| Users         |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13431 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckDefaultColumnsForMailboxesProjectCapacityUnits
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| 13431MailboxesProject | All Mailboxes | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then Columns on Admin page is displayed in following order:
	| ColumnName    |
	| Capacity Unit |
	|               |
	| Description   |
	| Default       |
	| Slots         |
	| Users         |
	| Mailboxes     |
	| Applications  |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13723 @DAS13370 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity13723 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Override Dates" tab on the Project details page
	When User clicks the "CREATE OVERRIDE DATE" Action button
	And User enters "5 Jan 2019" date in the "Override Start Date" field
	And User enters "" date in the "Override End Date" field
	Then Filling field error with "An override end date must be entered" text is displayed
	When User enters "4 Oct 2018" date in the "Override End Date" field
	Then "CREATE" Action button is disabled
	Then "CREATE" Action button have tooltip with "Some settings are not valid" text
	When User enters "" date in the "Override Start Date" field
	Then Filling field error with "An override start date must be entered" text is displayed
	When User enters "4 Oct 2018" date in the "Override Start Date" field
	And User enters "7 Oct 2018" date in the "Override End Date" field
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your override date has been created" text
	And "Unlimited" content is displayed in "Capacity" column
	When User enters ">1" text in the Search field for "Capacity" column
	Then Rows counter shows "1" of "1" rows
	When User clicks content from "Start Date" column
	And User enters "3 Oct 2018" date in the "Override End Date" field
	Then "UPDATE" Action button is disabled
	Then "UPDATE" Action button have tooltip with "No changes made" text
	When User enters "" date in the "Override Start Date" field
	And User enters "" date in the "Override End Date" field
	Then Filling field error with "An override start date must be entered" text is displayed
	And Filling field error with "An override end date must be entered" text is displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13790 @DAS13528 @DAS13165 @DAS13164 @DAS13154 @DAS14037 @DAS14236 @DAS13157 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectLinkIsDisplayedInTheGreenBannerForCreatedUnit
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity13790 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit13790 capacity unit" link
	When User enters "13720" text in the Search field for "Description" column
	Then Rows counter shows "1" of "2" rows
	When User clicks newly created object link
	Then URL contains "evergreen/#/admin/project/"
	When User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	#Remove # after DAS-14037 fixed
	#Then Success message is displayed correctly
	When User enters "13720" text in the Search field for "Description" column
	And User click content from "Capacity Unit" column
	Then "Default Unit" checkbox is checked and cannot be unchecked
	When User clicks the "CANCEL" Action button
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " CapacityUnit13790 " Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13528" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit2" Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13528" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User selects "Capacity Details" tab on the Project details page
	And User selects "Clone evergreen capacity units to project capacity units" in the "Capacity Units" dropdown
	And User clicks the "UPDATE" Action button
	#Remove # after DAS-14037 fixed
	#Then Success message is displayed correctly
	Then Success message is displayed and contains "The project capacity details have been updated" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS12672 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOneDefaultCapacityUnitCanBeCreated
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity12672 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	And "TRUE" content is displayed in "Default" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default unit" text is displayed on the Admin page
	When User close message on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit12672" Name in the "Capacity Unit Name" field on the Project details page
	And User type "12672" Name in the "Description" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12672 capacity unit" link
	When User clicks newly created object link
	Then URL contains "capacity/units/unit/"
	And "Default Unit" checkbox is checked and cannot be unchecked
	# commented until DAS-13151
	# And "UPDATE" Action button is disabled 
	# And "CANCEL" Action button is disabled
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User clicks content from "Capacity Unit" column
	And User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	And User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14240 @DAS16372
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitsGridUpdatedAfterUnitUpdatingOrCreation
	When User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks content from "Capacity Unit" column
	When User clicks "Projects" navigation link on the Admin page
	Then Warning Pop-up is not displayed
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks content from "Capacity Unit" column
	When User clicks "Administration" navigation link on the Admin page
	Then Warning Pop-up is not displayed
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit14240" Name in the "Capacity Unit Name" field on the Project details page
	And User type "14240" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	| CapacityUnit14240 |
	When User enters "CapacityUnit14240" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	And User type "CapacityUnit14240NameUpdated" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	And User sees next Units on the Capacity Units page:
	| units                        |
	| Unassigned                   |
	| CapacityUnit14240NameUpdated |
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit14240NameUpdated |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitWithEmptyName
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " " Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	Then Create Capacity Unit button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13166 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProject
	When Project created via API and opened
	| ProjectName        | Scope         | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Mailboxes | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	#next capacity name used in "1803 Rollout" project
	And User type "Manchester" Name in the "Capacity Unit Name" field on the Project details page 
	And User type "Manchester Operations" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Counter shows "2" found rows
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @DAS12672 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message is not displayed on the Capacity Units page
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |
	When User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945_2" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13159 @DAS13754 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| 13159ProjectForCapacity | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "NewUnit" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "13159" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "A13159Unit" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	Then "Capacity Unit" column content is displayed in the following order:
	| Items             |
	| Unassigned        |
	| 13159             |
	| A13159Unit        |
	| CapacityUnit13790 |
	| NewUnit           |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Capacity @Senior_Projects @DAS14029 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnits
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName      | ShortName | Description | Type |
	| Project14029 Snr | 13498     |             |      |
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Project14029 Snr" project details
	And User clicks "Capacity" tab
	And User selects "Capacity Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project14029 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Capacity Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field

@Evergreen @Admin @EvergreenJnr_AdminPage @DAS13928 @DAS14614 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectlMessageAppearsWhenDefaultLanguageDoesNotHaveTranslations
	When Project created via API and opened
	| ProjectName                | Scope     | ProjectTemplate | Mode               |
	| ChecksDefaultLanguage13928 | All Users | None            | Standalone Project |
	And User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	And User selects following Objects
	| Objects                                |
	| 1A701E05916148A6A3F (Fairlchild, Sara) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User clicks "Details" tab
	And User clicks the "ADD LANGUAGE" Action button
	And User selects "Brazilian" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	And Error message with "You cannot update the default language to Brazilian because there are items in the project which have not been translated into this language." text is displayed
	When User clicks "Scope" tab
	And User selects "Queue" tab on the Project details page
	Then Counter shows "1" found rows
	#When User selects "History" tab on the Project details page
	#And User enters "1A701E05916148A6A3F" text in the Search field for "Item" column
	#Then User clicks on "1A701E05916148A6A3F" search result
	#When User navigates to the "Projects" tab

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13422
Scenario: EvergreenJnr_AdminPage_CheckingPercentageCapacityToReachBeforeShowingAmberField
	When User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User changes Percentage to reach before showing amber to "101"
	Then "UPDATE" Action button is disabled
	When User changes Percentage to reach before showing amber to "100"
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS14103 @DAS14172 @Delete_Newly_Created_Project @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits
	When Project created via API and opened
	| ProjectName        | Scope      | ProjectTemplate | Mode               |
	| ProjectForDAS14103 | All Device | None            | Standalone Project |
	And User clicks "Capacity" tab
	Then User selects "Teams and Request Types" option in "Capacity Mode" dropdown
	And User selects "Clone evergreen capacity units to project capacity units" option in "Capacity Units" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User click on Back button
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN CAPACITY UNIT" Action button
	And User type "Capacity Unit For DAS14103" Name in the "Capacity Unit Name" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks newly created object link
	And User selects "Devices" tab on the Capacity Units page
	Then "Devices" tab is selected on the Admin page
	When User clicks the "ADD DEVICE" Action button
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	And User clicks the "ADD DEVICES" Action button
	Then Success message is displayed and contains "The selected device has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Users" tab on the Capacity Units page
	Then "Users" tab is selected on the Admin page
	When User clicks the "ADD USER" Action button
	And User selects following Objects
	| Objects   |
	| AAC860150 |
	And User clicks the "ADD USERS" Action button
	Then Success message is displayed and contains "The selected user has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User selects "Applications" tab on the Capacity Units page
	Then "Applications" tab is selected on the Admin page
	When User clicks the "ADD APPLICATION" Action button
	And User selects following Objects
	| Objects                                                         |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	And User clicks the "ADD APPLICATIONS" Action button
	Then Success message is displayed and contains "The selected application has been queued for update, if it does not appear immediately try refreshing the grid" text
	When User clicks "Administration" navigation link on the Admin page
	And User enters "ProjectForDAS14103" text in the Search field for "Project" column
	And User click content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks "Users" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	And User clicks "Applications" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects                                    |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "To be created" italic content is displayed
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                                      |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 001BAQXT6JWFPI                             |
	| AAC860150                                  |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "AAC860150" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User enters "0004 - Adobe Acrobat Reader 5.0.5 Francais" text in the Search field for "Item" column
	Then "Capacity Unit For DAS14103" content is displayed in "Capacity Unit" column
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "Capacity Unit For DAS14103" text in the Search field for "Capacity Unit" column
	Then "1" content is displayed in "Devices" column
	And "1" content is displayed in "Users" column
	And "1" content is displayed in "Applications" column
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName           |
	| Capacity Unit For DAS14103 |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13961 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatOriginalCapacityUnitStoredAndDisplayedIfCapacityUnitForOnboardedObjectsWasChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13961 | All Devices | None            | Standalone Project |
	And User clicks "Scope" tab
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects        |
	| 001BAQXT6JWFPI |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	And User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items          |
	| 001BAQXT6JWFPI |
	When User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13961" Name in the "Capacity Unit Name" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "CREATE" Action button
	And User clicks "Scope" tab
	And User selects "History" tab on the Project details page
	And User enters "001BAQXT6JWFPI" text in the Search field for "Item" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13956 @DAS14068 @DAS14218 @Delete_Newly_Created_Project @Do_Not_Run_With_CapacityUnits @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitInAProjectMappedToEvergreenDefaultCapacityUnit
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User updates Capacity Units via api
	| OldName    | Name     | Description | IsDefault |
	| Unassigned | New Name |             |           |
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	And User enters "ProjectForDAS13956" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks newly created object link	
	And User selects "Capacity" tab on the Project details page	
	Then User selects "Clone evergreen capacity units to project capacity units" option in "Capacity Units" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User navigates to the "Units" sub-menu on the Details page
	Then Counter shows "1" found rows
	And "Unassigned" content is displayed for "Capacity Unit" column
	And "New Name" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14218
Scenario: EvergreenJnr_AdminPage_CheckingMapsToEvergreenColumnDisplayedForDifferentProjectTypes
	When User navigates to "User Evergreen Capacity Project" project details
	Then Project "User Evergreen Capacity Project" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 1" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 2" content is displayed for "Maps to Evergreen" column
	When User enters "3" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 3" content is displayed for "Maps to Evergreen" column
	When User navigates to "Devices Evergreen Capacity Project" project details
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User have opened Column Settings for "Capacity Unit" column
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13156 @Set_Default_Capacity_Unit @Set_Default_Capacity_Unit @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedApplicationsAreDisplayedCapacityUnits
	When User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " 1Test" Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13156" Name in the "Description" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName         |
	| 7-Zip 16.04 (x64)        |
	| 7-Zip 9.20 (x64 edition) |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "1Test" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User clicks String Filter button for "Project" column
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column
	When User selects "Email Migration" checkbox from String Filter with item list on the Admin page
	Then "2" content is displayed in "Applications" column
	#remove this part
	#When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	#And User click content from "Capacity Unit" column
	#And User updates the "Default Unit" checkbox state
	#And User clicks the "UPDATE" Action button
	#When User clicks Reset Filters button on the Admin page
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| 1Test            |
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @Not_Run
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfDeviceProjectLeadToCorrectFilteredLists
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then "<ListName>" list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Windows7Mi: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values     |
	| Unassigned |
	And Options is displayed in added filter info
	| Values |
	| is     |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS15266 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatEnableCapacityCheckboxIsDisplayedOnTheCapacityDetailsScreen
	When Project created via API and opened
	| ProjectName       | Scope       | ProjectTemplate | Mode               |
	| 15266_TestProject | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is checked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is unchecked on the Admin page
	Then "Enforce capacity on project object page" checkbox is unchecked on the Admin page
	When User clicks "Enforce capacity on self service pages" checkbox on the Project details page
	Then "Enforce capacity on self service pages" checkbox is checked on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	When User clicks "Enforce capacity on project object page" checkbox on the Project details page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	When User clicks "Enforce capacity on project object page" checkbox on the Project details page
	When User clicks "Enforce capacity on self service pages" checkbox on the Project details page
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS15585
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageAboutUnconfirmedChangesAppears
	When User navigates to "1803 Rollout" project details
	And User clicks "Capacity" tab
	And User clicks "Enable Capacity" checkbox on the Project details page
	And User selects "Units" tab on the Project details page
	Then "You have unsaved changes. Are you sure you want to leave the page?" text is displayed in the warning message
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message