Feature: Offboard_ApplicationsPage
	Runs Offboard Applications Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
@Evergreen @Applications @EvergreenJnr_ItemDetails @Offboard @DAS17919 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageOnApplicationsPage
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project17919 | All Devices | None            | Standalone Project |
	#TODO add API ONBOARDING step;
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "Technical Information Sampler: January 2003"
	And User click content from "Application" column
	Then Details page for "Technical Information Sampler: January 2003" item is displayed to the user
	When User switches to the "Project17919" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Warning message with "This application will be offboarded, this cannot be undone" text is displayed on the Project Details Page
	When User clicks the "OFFBOARD" Action button
	Then Success message is displayed and contains "The application was successfully queued for offboarding from Project17919" text