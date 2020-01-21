Feature: ImportProjects
	Tests related to the Import Project functionality

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS16089
Scenario: EvergreenJnr_ImportProjectPage_CheckBannerMessageAfterImportProjectWithoutReadiness 
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	And Page with 'Projects' header is displayed to user
	When User clicks 'IMPORT PROJECT' button 
	Then Page with 'Import Project' subheader is displayed to user
	When User selects "Windows_7_Migration_(Computer_Scheduled_Project) (jet 5.3.3).xml" file to upload on Import Project page
	And User selects 'Import to new project' in the 'Import' dropdown
	And User enters 'DAS16089_TestProject' text to 'Project Name' textbox
	When User clicks 'IMPORT PROJECT' button
	Then 'Your file doesn't contain Readiness values' text is displayed on inline error banner

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS15989 @DAS19416 @Cleanup 
Scenario: EvergreenJnr_ImportProjectPage_CheckThatExtraUnknownReadinessIsNotCreatedWhileImportingToANewProject
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	And Page with 'Projects' header is displayed to user
	When User clicks 'IMPORT PROJECT' button 
	Then Page with 'Import Project' subheader is displayed to user
	When User selects "1803_Rollout.xml" file to upload on Import Project page
	And User selects 'Import to new project' in the 'Import' dropdown
	And User enters 'DAS15989_TestProject' text to 'Project Name' textbox
	When User clicks 'IMPORT PROJECT' button
	When User clicks newly created object link
	Then Page with 'DAS15989_TestProject' header is displayed to user
	When User navigates to the 'Readiness' left menu item
	Then 'UNKNOWN' content is not displayed in the 'Readiness' column
	#IGNORE is default and should always present
	Then 'IGNORE' content is displayed in the 'Readiness' column