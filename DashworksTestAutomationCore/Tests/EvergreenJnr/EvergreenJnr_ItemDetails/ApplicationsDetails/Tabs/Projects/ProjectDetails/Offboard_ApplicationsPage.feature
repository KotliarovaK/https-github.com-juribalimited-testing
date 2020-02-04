Feature: Offboard_ApplicationsPage
	Runs Offboard Applications Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Applications @EvergreenJnr_ItemDetails @Offboard @DAS17919 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageOnApplicationsPage
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project17919 | All Devices | None            | Standalone Project |
	#TODO add API ONBOARDING step;
	When User navigates to the 'Application' details page for 'Technical Information Sampler: January 2003' item
	Then Details page for 'Technical Information Sampler: January 2003' item is displayed to the user
	When User selects 'Project17919' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then 'This application will be offboarded, this cannot be undone' text is displayed on inline tip banner
	When User clicks 'OFFBOARD' button 
	Then 'The application was successfully queued for offboarding from Project17919' text is displayed on inline success banner