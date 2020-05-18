Feature: SelfServices
	Runs Self Services related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#AnnI 5/15/20 Need GD!
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS21182 @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatSearchForSelfServiceLinkColumnIsWorkingCorrectly
	When User navigates to the 'Application' details page for the item with '2015' ID
	Then Details page for '7zip' item is displayed to the user
	When User navigates to the 'Self Service' parent left menu item
	And User navigates to the 'Self Services' left submenu item
	#AnnI 5/15/20: Loks like we will need to update this (Self Service) link.
	When User enters "https://autorelease.corp.juriba.com/evergreen/#/selfservice/zUScopeDel/1812b656-b505-4e74-85f9-d8de84e212be" text in the Search field for "Self Service Link" column
	Then "1" rows are displayed in the agGrid