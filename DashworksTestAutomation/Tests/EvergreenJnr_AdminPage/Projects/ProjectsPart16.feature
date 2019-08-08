﻿Feature: ProjectsPart16
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13390 @DAS12582 @DAS11978 @DAS12825 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_ChecksThatOnboardedObjectsWorkCorrectlyForTwoUsers
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13390 | All Devices | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	| 00CWZRC4UK6W20  |
	| 00HA7MKAVVFDAV  |
	| 00I0COBFWHOF27  |
	| 00K4CEEQ737BA4L |
	| 00KLL9S8NRF0X6  |
	| 00KWQ4J3WKQM0G  |
	| 00OMQQXWA1DRI6  |
	| 00RUUMAH9OZN9A  |
	| 00SH8162NAS524  |
	| 00YTY8U3ZYP2WT  |
	| 00YWR8TJU4ZF8V  |
	| 011PLA470S0B9DJ |
	| 018UQ6KL9TF4YF  |
	| 019BFPQGKK5QT8N |
	| 01COJATLYVAR7A6 |
	| 01DRMO46G58SXK  |
	| 01KFZ6XUVQSII0  |
	| 0281Z793OLLLDU6 |
	| 02C80G8RFTPA9E  |
	| 02X387UDGZJPQY  |
	| 03063X2ZUCDN0A1 |
	| 03U75EKEMUQMUS  |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then "UPDATE ALL CHANGES" Action button is disabled
	When User clicks the "CANCEL" Action button
	Then "UPDATE ALL CHANGES" Action button is active
	When User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                         |
	| AAC860150 (Kerrie D. Ruiz)      |
	| AAD1011948 (Pinabel Cinq-Mars)  |
	| AAG081456 (Melanie Z. Fowler)   |
	| AAH0343264 (Luc Gauthier)       |
	| AAK881049 (Miguel W. Owen)      |
	| AAL852547 (Robbie A. Roach)     |
	| AAM044531 (Dustin R. Alvarez)   |
	| AAO271828 (Ramona D. Curtis)    |
	| AAO3000042 (Georgette Pichette) |
	| AAO438834 (James Y. Mc Bride)   |
	| AAO798996 (Darren J. Walter)    |
	| AAQ9911340 (Javier Lanctot)     |
	| AAT858228 (Cheri B. Evans)      |
	| AAT891621 (Henry F. Mccall)     |
	| AAV4528222 (Felicienne Vadnais) |
	| AAV500479 (Wendi H. Dougherty)  |
	| AAY704360 (Micah H. Mccall)     |
	| ABE8110806 (Brice Grimard)      |
	| ABG5308934 (Carolos Vallée)     |
	| ABK350523 (Alyssa A. Williams)  |
	| ABM798049 (Roland C. Bond)      |
	| ABN563832 (Dewayne D. Butler)   |
	| ABP977697 (Rocky Y. Stout)      |
	| ABQ575757 (Salvador K. Waller)  |
	| ABS188911 (Jesus W. Kirk)       |
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	| 0047 - Microsoft Access 97 SR-2 Francais (8.0)                       |
	| 20040610sqlserverck (1.0.0)                                          |
	| 32VerSee v.231 en (C:\32VerSee\)                                     |
	| Access 97 Rumtime                                                    |
	| ACDSee 4.0 SendPix & Email Update (1.00.0000)                        |
	| ACDSee Mobile 1.2 for Palm OS? (1.2)                                 |
	| ActiveBar Version 2.0 Upgrade                                        |
	| AddFlow 4                                                            |
	| Adobe Acrobat Reader 3.0 ((Not Available))                           |
	| Adobe SVG Viewer 3.0 (3.0)                                           |
	| aktion (0.3.6)                                                       |
	| AltaVista Power Tools for IE5                                        |
	| Amazon Redshift ODBC Driver 64-bit (1.2.1)                           |
	| AnalogX TrackSeek                                                    |
	| AppForge 2.0 Professional (02.00.0110)                               |
	| Ask Toolbar 4.0 (OEM1000) (4.0.1.1)                                  |
	| AtomixMP3                                                            |
	| aumix (2.7)                                                          |
	| Avery Zweckform Assistent                                            |
	| Axosoft OnTime 2005 Enterprise Server (5.3.0)                        |
	| BDE 5.01 Upgrade                                                     |
	| Brava! Reader 2.5 (2.5)                                              |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "25 devices will be added, 25 users will be added, 25 applications will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message with "75 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	And "Applications to add (0 of 2104 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14604 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	When User clicks "Devices" tab in the Project Scope Changes section
	Then "Devices to add (0 of 17254 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects         |
	| 019BFPQGKK5QT8N |
	#go to create new user
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                 |
	| DAS13390 | 13390    | 1234qwer | 1234qwer        | Project Administrator |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	#login using created user
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13390 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Project13390" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	Then Success message is not displayed on the Admin page
	And "Devices to add (0 of 17254 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects         |
	| 019BFPQGKK5QT8N |
	When User clicks "Users" tab in the Project Scope Changes section
	Then "Users to add (0 of 14604 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	When User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2104 selected)" is displayed to the user in the Project Scope Changes section 
	And following objects were not found
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13391 | All Devices | None            | Standalone Project |
	And User selects "Scope" tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then open tab in the Project Scope Changes section is active
	When User expands the object to add 
	And User selects following Objects
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                         |
	| AAC860150 (Kerrie D. Ruiz)      |
	| AAD1011948 (Pinabel Cinq-Mars)  |
	| AAG081456 (Melanie Z. Fowler)   |
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5)                   |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                        |
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13390" User

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12645 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_CheckingSortingOrderOfTheObjectsInTheProjectScopeChanges
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12645" in the "Project Name" field
	And User selects "All Mailboxes" in the Scope Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject12645" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects
	| Objects                                                |
	| 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895@bclabs.local (Collor, Christopher) |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)     |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	Then following objects were not found
	| Objects                                                |
	| 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895@bclabs.local (Collor, Christopher) |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)     |
	Then Objects are displayed in alphabetical order on the Admin page
	When User clicks "Users" tab in the Project Scope Changes section
	When User expands the object to add
	Then Objects are displayed in alphabetical order on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @Cleanup @DAS11758 @DAS14190 @DAS15528 @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatSelectAllCheckboxIsWorkingCorrectlyOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1Checkbox11758" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "1Checkbox11758" name is displayed correctly
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "2Checkbox11758" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "2Checkbox11758" name is displayed correctly
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "3Checkbox11758" in the "Project Name" field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "3Checkbox11758" name is displayed correctly
	When User selects all rows on the grid
	Then 'Select All' checkbox have full checked state on the Admin page
	When User select "Project" rows in the grid
	| SelectedRowsName |
	| 1Checkbox11758   |
	Then 'Select All' checkbox have indeterminate checked state on the Admin page
	When User selects all rows on the grid
	And User enters "Checkbox11758" text in the Search field for "Project" column
	When User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12578 @DAS12999 @DAS13429 @Cleanup @TEST
Scenario Outline: EvergreenJnr_AdminPage_CheckThatTheEditListFunctionIsHiddenAfterCancelingCreatingProjectFromTheMainLists
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks the "CANCEL" Action button
	Then "<DynamicListName>" list is displayed to user
	And Edit List menu is not displayed
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject7894" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks the "CANCEL" Action button
	Then "Projects" page should be displayed to the user

Examples:
	| ListName  | ColumnName    | DynamicListName |
	| Devices   | Hostname      | TestList6589    |
	| Users     | Username      | TestList6588    |
	| Mailboxes | Email Address | TestList6587    |