Feature: Normal Login

Scenario: Correct login details
  Given I have signed in as 'Sarah'
	And this is not the first time I have logged in
  When the initial screen is shown
  Then the tutorial video is hidden
