Feature: DeleteBucketsFromTheTeam
	Delete Buckets From The Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11763 @DAS12742 @DAS12760 @DAS11912 @DAS12772 @Teams
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeletingBucketFromBucketsSection
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User have opened Column Settings for "Members" column
	And User clicks Filter button on the Column Settings panel
	When User clicks the  filter type dropdown on the Column Settings panel
	Then following Values are displayed in the filter type dropdown
	| Values                |
	| Equals                |
	| Not Equal             |
	| Less than or equal    |
	| Less than             |
	| Greater than          |
	| Greater than or equal |
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "IB Team" team details is displayed to the user
	When User navigates to the 'Buckets' left menu item
	And User enters "Group IB Team" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	And There are no errors in the browser console
