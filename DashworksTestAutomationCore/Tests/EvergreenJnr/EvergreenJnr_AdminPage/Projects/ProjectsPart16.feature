Feature: ProjectsPart16
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13390 @DAS12582 @DAS11978 @DAS12825 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatOnboardedObjectsWorkCorrectlyForTwoUsers
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13390 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect and selects following Objects
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
	And User clicks 'UPDATE ALL CHANGES' button 
	Then 'UPDATE ALL CHANGES' button is disabled
	When User clicks 'CANCEL' button 
	Then 'UPDATE ALL CHANGES' button is not disabled
	When User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
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
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
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
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '25 devices will be added, 25 users will be added, 25 applications will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '75 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 17254 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects         |
	| 019BFPQGKK5QT8N |
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14604 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2104 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	#go to create new user
	When User clicks 'Projects' on the left-hand menu
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
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "Project13390" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope Changes' left menu item
	#Maybe info banner should be instead of tip
	Then inline tip banner is not displayed
	And "Devices to add (0 of 17254 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects         |
	| 019BFPQGKK5QT8N |
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14604 selected)" is displayed to the user in the Project Scope Changes section
	And following objects were not found
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2104 selected)" is displayed to the user in the Project Scope Changes section 
	And following objects were not found
	| Objects                                                              |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13391 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then open tab in the Project Scope Changes section is active
	When User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects         |
	| 001BAQXT6JWFPI  |
	| 001PSUMZYOW581  |
	| 00BDM1JUR8IF419 |
	When User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects                         |
	| AAC860150 (Kerrie D. Ruiz)      |
	| AAD1011948 (Pinabel Cinq-Mars)  |
	| AAG081456 (Melanie Z. Fowler)   |
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12645 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckingSortingOrderOfTheObjectsInTheProjectScopeChanges
	When Project created via API and opened
	| ProjectName      | Scope         | ProjectTemplate | Mode               |
	| TestProject12645 | All Mailboxes | None            | Standalone Project |
	Then Page with 'TestProject12645' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User selects following Objects from the expandable multiselect
	| Objects                                                |
	| 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895@bclabs.local (Collor, Christopher) |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)     |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	Then following objects were not found
	| Objects                                                |
	| 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895@bclabs.local (Collor, Christopher) |
	| 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie)     |
	Then Objects are displayed in alphabetical order on the Admin page
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @Cleanup @DAS11758 @DAS14190 @DAS15528
Scenario: EvergreenJnr_AdminPage_CheckThatSelectAllCheckboxIsWorkingCorrectlyOnAdminPage
	# added zeros to Project names to male sure they always on top of grid
	When Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| 001Checkbox11758 | All Users | None            | Standalone Project |
	And Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| 002Checkbox11758 | All Users | None            | Standalone Project |
	And Project created via API and opened
	| ProjectName      | Scope     | ProjectTemplate | Mode               |
	| 003Checkbox11758 | All Users | None            | Standalone Project |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then '001Checkbox11758' content is displayed in the 'Project' column
	Then '002Checkbox11758' content is displayed in the 'Project' column
	Then '003Checkbox11758' content is displayed in the 'Project' column
	When User selects all rows on the grid
	Then Select All checkbox have full checked state
	When User select "Project" rows in the grid
	| SelectedRowsName |
	| 001Checkbox11758 |
	Then Select All checkbox have indeterminate checked state
	When User deselect all rows on the grid
	Then Select All checkbox have unchecked state
	When User enters "Checkbox11758" text in the Search field for "Project" column
	When User selects all rows on the grid
	Then Select All checkbox have indeterminate checked state
	When User removes selected item
	Then 'The selected projects have been deleted' text is displayed on inline success banner
	Then Select All checkbox have unchecked state

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12578 @DAS12999 @DAS13429 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatTheEditListFunctionIsHiddenAfterCancelingCreatingProjectFromTheMainLists
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User clicks 'CANCEL' button 
	Then "<DynamicListName>" list is displayed to user
	And Edit List menu is not displayed
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject7894' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CANCEL' button 
	Then Page with 'Projects' header is displayed to user

Examples:
	| ListName  | ColumnName    | DynamicListName |
	| Devices   | Hostname      | TestList6589    |
	| Users     | Username      | TestList6588    |
	| Mailboxes | Email Address | TestList6587    |