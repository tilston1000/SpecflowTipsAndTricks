Feature: AddUsersSecondOption

Scenario: Add multiple users
	Given I have input these users
	| FirstName | LastName |
	| Sarah     | Smith    |
	| Gentry    | Jones    |
	When I choose to add
	Then the users will be added