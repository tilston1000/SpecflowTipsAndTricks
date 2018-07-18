Feature: Login

Scenario: Add two numbers
	Given I have entered a username of 'Sarah'
		And a password of 'mc82#RF92'
	When I choose login
		But I don't choose remember me
	Then I should be logged in
		And taken to the home screen
		But my username should not be remembered

Scenario: Another scenario
	Given A
	When B
	Then C

Scenario: Yet another scenario
	Given X
	When Y
	Then Z
