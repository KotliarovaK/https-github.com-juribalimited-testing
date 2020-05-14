Feature: ProjectsPart19
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13783 @Projects @Do_Not_Run_With_Projects @Do_Not_Run_With_AdminPage
Scenario: EvergreenJnr_ImportProjectPage_CheckSelectExistingProjectDropdownValuesOnImportProjectPage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks 'IMPORT PROJECT' button 
	And User selects 'Import to existing project' in the 'Import' dropdown
	Then User sees that 'Select Existing Project' dropdown contains following options:
	| OptionLabel                                       |
	| *Project K-Computer Scheduled Project             |
	| 2004 Rollout                                      |
	| Barry's User Project                              |
	| Computer Scheduled Test (Jo)                      |
	| Devices Evergreen Capacity Project                |
	| Email Migration                                   |
	| Havoc (Big Data)                                  |
	| Mailbox Evergreen Capacity Project                |
	| Project 000 M Computer Scheduled                  |
	| Project using broken list as scope                |
	| Project with associated broken list               |
	| USE ME FOR AUTOMATION(DEVICE SCHDLD)              |
	| USE ME FOR AUTOMATION(MAIL SCHDLD)                |
	| USE ME FOR AUTOMATION(USR SCHDLD)                 |
	| User Evergreen Capacity Project                   |
	| User Scheduled Project in Italian & Japanese (Jo) |
	| User Scheduled Test (Jo)                          |
	| Windows 10 Migration - Depot                      |
	| Windows 10 Teams and Request Types                |
	| Windows 10 Updates - Migration                    |
	| Windows 10 Updates - New York                     |
	| Windows 7 Migration (Computer Scheduled Project)  |
	| zDevice Sch for Automations Feature               |
	| zMailbox Sch for Automations Feature              |
	| zUser Sch for Automations Feature                 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13110 @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChecksThatErrorIsNotDisplayedWhenForProjectsUsesDynamicListAsAScope
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	And User create dynamic list with "Dynamic13110" name on "Devices" page
	Then "Dynamic13110" list is displayed to user
	When Project created via API and opened
	| ProjectName          | Scope        | ProjectTemplate | Mode               |
	| Project13110Dynamic1 | Dynamic13110 | None            | Standalone Project |
	Then Page with 'Project13110Dynamic1' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects         |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items           |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then additional onboarded Items are displayed in the History table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	And There are no errors in the browser console
	When Project created via API and opened
	| ProjectName          | Scope        | ProjectTemplate | Mode               |
	| Project13110Dynamic2 | Dynamic13110 | None            | Standalone Project |
	Then Page with 'Project13110Dynamic2' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items                                                      |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	| 0036 - Microsoft Access 97 SR-2 English                    |
	And There are no errors in the browser console
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects         |
	| 00HA7MKAVVFDAV  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
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
	Then Page with 'Project13110Static1' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page 
	When User expands multiselect and selects following Objects
	| Objects                                                      |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) (7.1.0) |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then additional onboarded Items are displayed in the History table
	| Items                                                |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
	And There are no errors in the browser console
	When Project created via API and opened
	| ProjectName         | Scope       | ProjectTemplate | Mode               |
	| Project13110Static2 | Static13110 | None            | Standalone Project |
	Then Page with 'Project13110Static2' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects                        |
	| 20040610sqlserverck (1.0.0)    |
	| AddressGrabber Standard (3.1)  |
	| Adobe Acrobat Reader 5.0 (1.0) |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items                    |
	| 20040610sqlserverck      |
	| AddressGrabber Standard  |
	| Adobe Acrobat Reader 5.0 | 
	And There are no errors in the browser console
	When User navigates to the 'Scope Changes' left menu item
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	Then additional onboarded Items are displayed in the History table
	| Items           |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12955 @DAS12820 @DAS11978 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderForQueueAndHistoryTab
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestProject55 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject55' header is displayed to user	
	Then "Show Original Application Column On Application Dashboards" checkbox is not displayed on the Admin page
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	Then 'Mailboxes' tab is opened on Project Scope Changes page
	When User expands multiselect and selects following Objects
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
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '10 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
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
	Then data in table is sorted by 'Item' column in ascending order by default
	Then data in table is sorted by 'Date' column in descending order by default
	When User navigates to the 'History' left menu item
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
	Then data in table is sorted by 'Item' column in ascending order by default
	Then data in table is sorted by 'Date' column in descending order by default
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects                                                       |
	| ACD Display 3.4                                               |
	| Hilfe zu Blockdiagrammen                                      |
	| Intel(R) Processor Graphics (20.19.15.4568)                   |
	| Microsoft Exchange Client Language Pack - Hindi (15.0.1178.4) |
	| NJStar Chinese Word Processor                                 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '5 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items                                           |
	| ACD Display 3.4                                 |
	| Hilfe zu Blockdiagrammen                        |
	| Intel(R) Processor Graphics                     |
	| Microsoft Exchange Client Language Pack - Hindi |
	| NJStar Chinese Word Processor                   |
	Then following Items are displayed at the top of the list
	| Items                                           |
	| ACD Display 3.4                                 |
	| Hilfe zu Blockdiagrammen                        |
	| Intel(R) Processor Graphics                     |
	| Microsoft Exchange Client Language Pack - Hindi |
	| NJStar Chinese Word Processor                   |
	Then data in table is sorted by 'Item' column in ascending order by default
	Then data in table is sorted by 'Date' column in descending order by default
	When User navigates to the 'History' left menu item
	Then additional onboarded Items are displayed in the History table
	| Items                                           |
	| ACD Display 3.4                                 |
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
	#Then data in table is sorted by 'Item' column in ascending order by default	#Then data in table is sorted by 'Date' column in descending order by default
