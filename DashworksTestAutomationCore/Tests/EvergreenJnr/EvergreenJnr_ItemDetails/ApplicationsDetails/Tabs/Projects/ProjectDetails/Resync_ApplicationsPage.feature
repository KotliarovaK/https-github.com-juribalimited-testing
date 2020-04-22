Feature: Resync_ApplicationsPage
	Runs Resync related tests on Applications Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @Resync @DAS18035
Scenario: EvergreenJnr_ApplicationsList_CheckThatResyncOptionIsWorkedCorrectlyForProjectDetailsOnApplicationsPage
	When User navigates to the 'Application' details page for 'Borland Together Edition for Microsoft Visual Studio .NET' item
	Then Details page for 'Borland Together Edition for Microsoft Visual Studio .NET' item is displayed to the user
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button 
	Then popup is displayed to User
	Then 'Resync name' checkbox is checked
	When User clicks 'RESYNC' button on popup
	Then 'Application successfully resynced' text is displayed on inline success banner

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfAppIsAleadyOnboardedAndNotKeep
	When User navigates to the 'Application' details page for the item with '228' ID
	Then Details page for 'Hotfix for Windows Media Player 10 (KB903157)' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value                                        |
	| Rationalisation | FORWARD PATH                                 |
	| Target App      | Microsoft Assessments on Server 10.1.10586.0 |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | Uncategorised |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | Uncategorised |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfAppIsAleadyOnboardedAndIsKeep
	When User navigates to the 'Application' details page for the item with '4166' ID
	Then Details page for 'EC2ConfigService' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value                    |
	| Rationalisation | FORWARD PATH             |
	| Target App      | Adobe Adobe Reader 5 1.0 |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | Uncategorised |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button
	Then following content is displayed on the Details Page
	| Title               | Value          |
	| App Rationalisation | Forward Path   |
	| Target App          | Adobe Reader 5 |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfAppIsNotOnboarded
	When User navigates to the 'Application' details page for the item with '4346' ID
	Then Details page for 'Dolby Voice 2.7.0' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value                                                                        |
	| Rationalisation | FORWARD PATH                                                                 |
	| Target App      | ABBYY Software House ABBYY FineReader 8.0 Professional Edition 8.00.706.4603 |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | Uncategorised |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | Uncategorised |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfAppIsNotOnboardedAndEvergreenForwardPathedToIt
	When User navigates to the 'Application' details page for the item with '1' ID
	Then Details page for 'Python 2.2a4' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value |
	| Rationalisation | KEEP  |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | Keep  |
	| Target App          |       |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | Keep  |
	| Target App          |       |