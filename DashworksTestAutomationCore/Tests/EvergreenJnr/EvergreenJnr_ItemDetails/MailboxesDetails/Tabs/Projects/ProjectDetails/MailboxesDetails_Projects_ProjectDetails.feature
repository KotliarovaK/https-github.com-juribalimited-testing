Feature: MailboxesDetails_Projects_ProjectDetails
	Runs related tests for Projects > Project Details

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Ann.Ilchenko 10/25/19: will be ready in the future (contact Lana for details)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17768 @Not_Ready
Scenario: EvergreenJnr_MailboxesList_CheckThatOnTheProjectDetailsTabDisplaysTheLanguageDefinedInTheAdminPageAsTheDefaultLanguage
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks on 'USE ME FOR AUTOMATION(MAIL SCHDLD)' cell from 'Project' column
	Then Page with 'USE ME FOR AUTOMATION(MAIL SCHDLD)' header is displayed to user
	When User navigates to the 'Details' left menu item
	And User clicks 'ADD LANGUAGE' button 
	And User selects "German" language on the Project details page
	And User opens menu for selected language
	Then User selects "Set as default" option for selected language
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Email Address" column
	Then Details page for '06BB714696274AC895A@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title    | Value  |
	| Language | German |