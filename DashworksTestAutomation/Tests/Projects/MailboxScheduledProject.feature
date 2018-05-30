Feature: CreateMailboxScheduledProject
	Runs Project related tests

@Projects @Project @MailboxScheduledProject @Delete_Newly_Created_Team
Scenario: Projects_CreateMailboxScheduledProject
	Given User is on Dashworks Homepage
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Projects link
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates Project
	| ProjectName     | ProjectShortName | ProjectDescription | ProjectTypeString       |
	| TestProjectName | TestText         | TestText           | MailboxScheduledProject |
	When User clicks "Create Project" button
	Then "Manage Project Details" page is displayed to the user
	When User navigate to Manage link
	When User select "Manage Users" option in Management Console
	Then User create a new Dashworks User
	| Username | FullName                  | Password | ConfirmPassword |
	| AAA0Test | MailboxScheduledProject 0 | 1234qwer | 1234qwer        |
	Then Success message is displayed
	Then created User is displayed in the table
	Then User create a new Dashworks User
	| Username | FullName                  | Password | ConfirmPassword |
	| AAA1Test | MailboxScheduledProject 1 | 1234qwer | 1234qwer        |
	Then Success message is displayed
	Then created User is displayed in the table
	Then User create a new Dashworks User
	| Username | FullName                  | Password | ConfirmPassword |
	| AAA2Test | MailboxScheduledProject 2 | 1234qwer | 1234qwer        |
	Then Success message is displayed
	Then created User is displayed in the table
	When User navigate to Dashworks User Site link
	When User navigate to Projects link
	Then "Projects Home" page is displayed to the user
	When User select Project
	Then User make this Project Default
	Then Default Project News Title is displayed correctly
	Then User navigate to created Project
	Then "Manage Project Details" page is displayed to the user
	Then Project Name is displayed correctly
	When User updates the Details page
	| ShowOriginalColumn | IncludeSiteName | NotApplicableApplications | InstalledApplications | EntitledApplications | TaskEmailCcEmailAddress | TaskEmailBccEmailAddress | StartDate  | EndDate     |
	| true               | true            | true                      | true                  | true                 | Test@test.com           | Test@test.com            | 8 May 2012 | 10 Apr 2018 |
	Then Success message is displayed with "Project was successfully updated" text
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 0 | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 1 | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 2 | Mailbox          |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	Then User removes created Request Type
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 0 | User             |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	Then User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 1 | Application      |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	Then User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User clicks "Create Request Type" button
	When User create Request Type
	| Name                | Description               | ObjectTypeString |
	| TestRequestTypeName | MailboxScheduledProject 2 | Mailbox          |
	Then Success message is displayed
	When User clicks "Cancel" button
	Then created Request Type is displayed in the table
	When User click on the created Request Type
	Then User updates the Request Type page
	| DefaultRequestType |
	| true               |
	Then Success message is displayed with "Request Type successfully updated" text
	When User clicks "Cancel" button
	Then created Request Type is a Default
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	When User create Category
	| Name             | Description | ObjectTypeString |
	| TestCategoryName | TestText    | Mailbox          |
	Then Success message is displayed with "Category successfully created." text
	When User clicks "« Go Back" button
	Then created Category is displayed in the table