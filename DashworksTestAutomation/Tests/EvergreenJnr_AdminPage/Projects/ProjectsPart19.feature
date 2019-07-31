Feature: ProjectsPart19
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13783 @Projects @Do_Not_Run_With_Projects @Do_Not_Run_With_AdminPage
Scenario: EvergreenJnr_ImportProjectPage_CheckSelectExistingProjectDropdownValuesOnImportProjectPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "IMPORT PROJECT" Action button
	And User selects "Import to existing project" option in the "Import" dropdown on the Import Project Page
	Then User sees that "Select Existing Project" dropdown contains following options on Import Projects page:
	| OptionLabel                                       |
	| 1803 Rollout                                      |
	| Babel (English, German and French)                |
	| Barry's User Project                              |
	| Computer Scheduled Test (Jo)                      |
	| Devices Evergreen Capacity Project                |
	| Email Migration                                   |
	| Havoc (Big Data)                                  |
	| I-Computer Scheduled Project                      |
	| Mailbox Evergreen Capacity Project                |
	| Migration Project Phase 2 (User Project)          |
	| Project K-Computer Scheduled Project              |
	| User Evergreen Capacity Project                   |
	| User Scheduled Project in Italian & Japanese (Jo) |
	| User Scheduled Test (Jo)                          |
	| Windows 10 Migration - Depot                      |
	| Windows 10 Teams and Request Types                |
	| Windows 10 Updates - Migration                    |
	| Windows 10 Updates - New York                     |
	| Windows 7 Migration (Computer Scheduled Project)  |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13110 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChecksThatErrorIsNotDisplayedWhenForProjectsUsesDynamicListAsAScope
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "Dynamic13110" name on "Devices" page
	Then "Dynamic13110" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13110Dynamic1" in the "Project Name" field
	And User selects "Dynamic13110" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Project13110Dynamic1" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects         |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items           |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	When User selects "History" tab on the Project details page
	Then additional onboarded Items are displayed in the History table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	And There are no errors in the browser console
	When User click on Back button
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13110Dynamic2" in the "Project Name" field
	And User selects "Dynamic13110" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Project13110Dynamic2" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects         |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User selects "History" tab on the Project details page
	Then additional onboarded Items are displayed in the History table
	| Items           |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13110 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatErrorIsNotDisplayedWhenForProjectsUsesStaticListAsAScope
	When User create static list with "Static13110" name on "Devices" page with following items
	| ItemName        |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	Then "Static13110" list is displayed to user
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| Project13110Static1 | Static13110 | None            | Standalone Project |
	Then Project "Project13110Static1" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                        |
	| 20040610sqlserverck (1.0.0)    |
	| AddressGrabber Standard (3.1)  |
	| Adobe Acrobat Reader 5.0 (1.0) |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                    |
	| 20040610sqlserverck      |
	| AddressGrabber Standard  |
	| Adobe Acrobat Reader 5.0 |
	When User selects "History" tab on the Project details page
	Then additional onboarded Items are displayed in the History table
	| Items                    |
	| 20040610sqlserverck      |
	| AddressGrabber Standard  |
	| Adobe Acrobat Reader 5.0 |
	And There are no errors in the browser console
	When User click on Back button
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project13110Static2" in the "Project Name" field
	And User selects "Static13110" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "Project13110Static2" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                        |
	| 20040610sqlserverck (1.0.0)    |
	| AddressGrabber Standard (3.1)  |
	| Adobe Acrobat Reader 5.0 (1.0) |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                    |
	| 20040610sqlserverck      |
	| AddressGrabber Standard  |
	| Adobe Acrobat Reader 5.0 |
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                    |
	| 20040610sqlserverck      |
	| AddressGrabber Standard  |
	| Adobe Acrobat Reader 5.0 | 
	And There are no errors in the browser console
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User selects "History" tab on the Project details page
	Then additional onboarded Items are displayed in the History table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12955 @DAS12820 @DAS11978 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderForQueueAndHistoryTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject55" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject55" is displayed to user
	Then "Show Original Application Column On Application Dashboards" checkbox is not displayed on the Admin page
	When User selects "Scope Changes" tab on the Project details page
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 00K4CEEQ737BA4L |
	| 00YWR8TJU4ZF8V  |
	| 019BFPQGKK5QT8N |
	| 02C80G8RFTPA9E  |
	| 06T5FX3CUY08AE  |
	| 0BET6XYEOG5ESB  |
	| 07RJRCQDVK1KLR  |
	| 0E402TL1EG79GIT |
	| 0GLO1UYQ5AKCZEA |
	| DK1LF3X47N7PWX7 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "10 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 00K4CEEQ737BA4L |
	| 00YWR8TJU4ZF8V  |
	| 019BFPQGKK5QT8N |
	| 02C80G8RFTPA9E  |
	| 06T5FX3CUY08AE  |
	| 0BET6XYEOG5ESB  |
	| 07RJRCQDVK1KLR  |
	| 0E402TL1EG79GIT |
	| 0GLO1UYQ5AKCZEA |
	| DK1LF3X47N7PWX7 |
	Then data in table is sorted by "Item" column in ascending order by default on the Admin page
	Then data in table is sorted by "Date" column in descending order by default on the Admin page
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items           |
	| 00K4CEEQ737BA4L |
	| 00YWR8TJU4ZF8V  |
	| 019BFPQGKK5QT8N |
	| 02C80G8RFTPA9E  |
	| 06T5FX3CUY08AE  |
	| 0BET6XYEOG5ESB  |
	| 07RJRCQDVK1KLR  |
	| 0E402TL1EG79GIT |
	| 0GLO1UYQ5AKCZEA |
	| DK1LF3X47N7PWX7 |
	Then data in table is sorted by "Item" column in ascending order by default on the Admin page
	Then data in table is sorted by "Date" column in descending order by default on the Admin page
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                       |
	| Advantage Data Architect                                      |
	| Hilfe zu Blockdiagrammen                                      |
	| Intel(R) Processor Graphics (20.19.15.4568)                   |
	| Microsoft Exchange Client Language Pack - Hindi (15.0.1178.4) |
	| NJStar Chinese Word Processor                                 |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "5 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                           |
	| Advantage Data Architect                        |
	| Hilfe zu Blockdiagrammen                        |
	| Intel(R) Processor Graphics                     |
	| Microsoft Exchange Client Language Pack - Hindi |
	| NJStar Chinese Word Processor                   |
	Then following Items are displayed at the top of the list
	| Items                                           |
	| Advantage Data Architect                        |
	| Hilfe zu Blockdiagrammen                        |
	| Intel(R) Processor Graphics                     |
	| Microsoft Exchange Client Language Pack - Hindi |
	| NJStar Chinese Word Processor                   |
	Then data in table is sorted by "Item" column in ascending order by default on the Admin page
	Then data in table is sorted by "Date" column in descending order by default on the Admin page
	When User selects "History" tab on the Project details page
	Then additional onboarded Items are displayed in the History table
	| Items                                           |
	| Advantage Data Architect                        |
	| Hilfe zu Blockdiagrammen                        |
	| Intel(R) Processor Graphics                     |
	| Microsoft Exchange Client Language Pack - Hindi |
	| NJStar Chinese Word Processor                   |
	#Then following Items are displayed at the top of the list
	#| Items                                           |
	#| Advantage Data Architect                        |
	#| Hilfe zu Blockdiagrammen                        |
	#| Intel(R) Processor Graphics                     |
	#| Microsoft Exchange Client Language Pack - Hindi |
	#| NJStar Chinese Word Processor                   |
	#When User clicks String Filter button for "Object Type" column on the Admin page
	#When User clicks "Device" checkbox from boolean filter on the Admin page
	#Then data in table is sorted by "Item" column in ascending order by default on the Admin page
	#Then data in table is sorted by "Date" column in descending order by default on the Admin page