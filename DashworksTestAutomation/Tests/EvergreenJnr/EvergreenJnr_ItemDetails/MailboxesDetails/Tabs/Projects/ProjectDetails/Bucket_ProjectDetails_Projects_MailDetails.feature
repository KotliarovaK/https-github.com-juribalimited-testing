Feature: Bucket_ProjectDetails_Projects_MailDetails
	Runs related tests for Bucket field on Mailboxes Details page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19175 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatBucketGridOnTheItemDetailsPageIsDisplayedCorrectlyForAssociatedUsers
	When User navigates to the 'Mailbox' details page for '0141713E5CF84ADE907@bclabs.local' item
	Then Details page for '0141713E5CF84ADE907@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Bucket' field
	Then following columns are displayed on the Item details page:
	| ColumnName    |
	| Username      |
	| Display Name  |
	| Domain        |
	| Owner         |
	| Bucket        |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Domain' column:
	| Values |
	| BCLABS |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Owner' column:
	| Values |
	| True   |