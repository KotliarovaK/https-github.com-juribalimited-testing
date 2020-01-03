Feature: CreateBucket
	Create Bucket

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @DAS18351 @Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedBucketUsingTheSpaceAsAFirstSymbol
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks 'CREATE EVERGREEN BUCKET' button 
	Then Page with 'Create Evergreen Bucket' subheader is displayed to user
	When User enters '11770' text to 'Bucket Name' textbox
	When User selects 'Admin IT' option from 'Team' autocomplete
	When User clicks 'CREATE' button 
	Then 'The bucket has been created' text is displayed on inline success banner
	When User clicks 'CREATE EVERGREEN BUCKET' button 
	Then Page with 'Create Evergreen Bucket' subheader is displayed to user
	When User enters ' 11770' text to 'Bucket Name' textbox
	When User selects 'Admin IT' option from 'Team' autocomplete
	When User clicks 'CREATE' button 
	Then 'A bucket already exists with this name' text is displayed on inline error banner
	Then There are no errors in the browser console
	When User clicks 'CREATE EVERGREEN BUCKET' button 
	When User enters '11770' text to 'Bucket Name' textbox
	Then 'A bucket already exists with this name' error message is displayed for 'Bucket Name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS16636 @Buckets @Set_Default_Bucket @Cleanup @Do_Not_Run_With_Buckets
Scenario: EvergreenJnr_AdminPage_CreatingDefaultBucket
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| TestBucket5 | Admin IT | true      |
	And User navigates to newly created Bucket
	Then Page with 'TestBucket5' header is displayed to user
	When User enters 'NewBucket5' text to 'Bucket Name' textbox
	When User selects 'I-Team' option from 'Team' autocomplete
	And User clicks 'UPDATE' button 
	Then 'The NewBucket5 bucket has been updated' text is displayed on inline success banner
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then 'FALSE' content is displayed in the 'Default' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11891 @DAS11747 @DAS13471 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	Then Search fields for "Devices" column contain correctly value
	Then Search fields for "Users" column contain correctly value
	Then Search fields for "Mailboxes" column contain correctly value
	When User clicks 'CREATE EVERGREEN BUCKET' button 
	Then Page with 'Create Evergreen Bucket' subheader is displayed to user
	When User enters ' ' text to 'Bucket Name' textbox
	When User selects 'Admin IT' option from 'Team' autocomplete
	Then 'CREATE' button is disabled