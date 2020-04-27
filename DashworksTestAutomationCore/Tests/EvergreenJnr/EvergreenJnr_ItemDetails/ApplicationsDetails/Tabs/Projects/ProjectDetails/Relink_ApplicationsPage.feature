Feature: Relink_ApplicationsPage
	Runs Relink related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title | Value                                                      |
	| Name  | "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'Microsoft SQL' in the 'Application' autocomplete field and selects 'Microsoft SQL Server 2012' value
	When User clicks 'RELINK' button on popup
	Then 'This object will be relinked to the selected Evergreen object in this project' text is displayed on inline tip banner
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	Then Details page for 'Microsoft SQL Server 2012' item is displayed to the user
	Then following content is displayed on the Details Page
	| Title | Value                     |
	| Name  | Microsoft SQL Server 2012 |
	When User clicks 'RELINK' button
	Then popup is displayed to User
	When User enters 'WPF' in the 'Application' autocomplete field and selects '"WPF/E" (codename) Community Technology Preview (Feb 2007)' value
	And User clicks 'RELINK' button on popup
	And User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18769 @DAS19124
Scenario: EvergreenJnr_ApplicationsList_CheckThatErrorIsDisplayedInTheRelinkToPopupAfterEnteringTwoSymbolsAndSpaceToTheSearchFieldAndClickingEnterButton
	When User navigates to the 'Application' details page for 'ACDSee 4.0.2 PowerPack Trial Version' item
	Then Details page for 'ACDSee 4.0.2 PowerPack Trial Version' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'k9 ' text to 'Application' textbox
	Then Error message is not displayed
	When User enters 'gh#' text to 'Application' textbox
	Then Error message is not displayed

@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @DAS18980
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage_WithOwnerToWithoutOwner
	When User navigates to the 'Application' details page for the item with '4017' ID
	Then Details page for 'Microsoft Exchange Client Language Pack - Lithuanian' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4016' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Exchange Client Language Pack - Vietnamese 15.0.1178.4 (4016)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title     | Value |
	| App Owner |       |
	#return values ​​back
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters '4017' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Exchange Client Language Pack - Lithuanian 15.0.847.32 (4017)' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner

#ppd AnnI 4/27/20: GD ready only for 'X_Ray' (need Cleanup?)
@Evergreen @Applications @EvergreenJnr_ItemDetails @Relink @DAS18002 @DAS18112 @DAS17899 @DAS18196 @X_Ray
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelinkOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage_WithoutOwnerToWithoutOwner
	When User navigates to the 'Application' details page for the item with '4018' ID
	Then Details page for 'Microsoft Visual C++ 2012 x86 Additional Runtime - 11.0.61030' item is displayed to the user
	When User selects 'Project 000 M Computer Scheduled' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button 
	Then popup is displayed to User
	When User enters 'Microsoft Corporation Microsoft .NET Framework 4.5 4.5.50709' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft .NET Framework 4.5 4.5.50709' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner
	#return values ​​back
	When User clicks 'RELINK' button
	Then popup is displayed to User
	When User enters 'Microsoft Corporation Microsoft Visual C++ 2012 x86 Additional Runtime - 11.0.50727 11.0.50727' in the 'Application' autocomplete field and selects 'Microsoft Corporation Microsoft Visual C++ 2012 x86 Additional Runtime - 11.0.50727 11.0.50727' value
	When User clicks 'RELINK' button on popup
	When User clicks 'RELINK' button on popup
	Then 'Application successfully relinked' text is displayed on inline success banner

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19335
Scenario: EvergreenJnr_ApplicationsList_CheckThatTooltipForDisabledRelinkButtonIsDisplayed
	When User navigates to the 'Application' details page for 'Adobe Acrobat Reader 3.01 Original' item
	Then Details page for 'Adobe Acrobat Reader 3.01 Original' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then popup is displayed to User
	Then Button 'RELINK' has 'Select an application' tooltip on popup

@Evergreen @Application @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19323 @Universe
Scenario: EvergreenJnr_ApplicationList_CheckThatObjectsAreDisplayedInSearchResultAfterEnteringPartOfObjectKeyToAutocomplete
	When User navigates to the 'Application' details page for '7-Zip 16.04 (x64)' item
	Then Details page for '7-Zip 16.04 (x64)' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RELINK' button
	Then only options having search term '230' are displayed in 'Application' autocomplete