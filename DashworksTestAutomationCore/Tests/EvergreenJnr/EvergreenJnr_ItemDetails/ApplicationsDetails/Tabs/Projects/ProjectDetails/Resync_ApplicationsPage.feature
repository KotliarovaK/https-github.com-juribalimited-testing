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

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
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
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
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
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value          |
	| App Rationalisation | FORWARD PATH   |
	| Target App          | Adobe Reader 5 |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
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
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
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
	| App Rationalisation | KEEP  |
	| Target App          |       |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfAppIsOnboardedButNotForwardPathedToAnotherApp
	When User navigates to the 'Application' details page for the item with '630' ID
	Then Details page for 'ATI Multimedia Center' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value |
	| Rationalisation | KEEP  |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfProjectAndEvergreenAppIsRetired
	When User navigates to the 'Application' details page for the item with '985' ID
	Then Details page for 'WebZIP' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value  |
	| Rationalisation | RETIRE |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppRetiredAndProjectAppIsUncategorised
	When User navigates to the 'Application' details page for the item with '209' ID
	Then Details page for 'xine-devel' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value  |
	| Rationalisation | RETIRE |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppRetiredAndProjectAppIsForwardPathedToAnotherApp
	When User navigates to the 'Application' details page for the item with '783' ID
	Then Details page for 'Aide sur les fichiers programme' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value  |
	| Rationalisation | RETIRE |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value           |
	| App Rationalisation | FORWARD PATH    |
	| Target App          | MKS Toolkit 8.6 |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |
	#go to app2
	When User navigates to the 'Application' details page for the item with '193' ID
	Then Details page for 'MKS Toolkit 8.6' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppRetiredAndProjectAppIsForwardPathedToFirstApp
	When User navigates to the 'Application' details page for the item with '243' ID
	Then Details page for 'Adobe Reader 7.0.7 - Chinese Simplified' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value  |
	| Rationalisation | RETIRE |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |
	When User clicks 'RESYNC' button
	Then 'Any apps forward pathed to this app will be set to Uncategorised' text is displayed on inline tip banner
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |
	#go to app2
	When User navigates to the 'Application' details page for the item with '944' ID
	Then Details page for 'SlingPlayer' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAndProjectAppsAreUncategorised
	When User navigates to the 'Application' details page for the item with '4316' ID
	Then Details page for 'Skype™ 7.37' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value         |
	| Rationalisation | UNCATEGORISED |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppIsUncategorisedAndProjectAppIsRetired
	When User navigates to the 'Application' details page for the item with '4523' ID
	Then Details page for 'Softerra LDAP Administrator 2015.2 (64-bit)' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value         |
	| Rationalisation | UNCATEGORISED |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value  |
	| App Rationalisation | RETIRE |
	| Target App          |        |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppIsUncategorisedAndProjectAppIAppOneIsForwardPathedToAppTwo
	When User navigates to the 'Application' details page for the item with '4120' ID
	Then Details page for 'Datazen Publisher' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value         |
	| Rationalisation | UNCATEGORISED |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value        |
	| App Rationalisation | FORWARD PATH |
	| Target App          | DivX Pro     |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	#go to app2
	When User navigates to the 'Application' details page for the item with '1031' ID
	Then Details page for 'DivX Pro' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20732 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatRationalisationIsWorksCorrectlyIfEvergreenAppIsUncategorisedAndProjectAppIAppTwoIsForwardPathedToAppOne
	When User navigates to the 'Application' details page for the item with '234' ID
	Then Details page for 'River Past Audio Converter' item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	Then following content is displayed on the Details Page
	| Title           | Value         |
	| Rationalisation | UNCATEGORISED |
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value |
	| App Rationalisation | KEEP  |
	| Target App          |       |
	When User clicks 'RESYNC' button
	When User unchecks 'Resync owner' checkbox
	When User unchecks 'Resync name' checkbox
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |
	#go to app2
	When User navigates to the 'Application' details page for the item with '106' ID
	Then Details page for 'SBClient 5.2.4.246' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' parent left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title               | Value         |
	| App Rationalisation | UNCATEGORISED |
	| Target App          |               |