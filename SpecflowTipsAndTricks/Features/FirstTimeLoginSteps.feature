Feature: First time login

Scenario: Correct login details
  Given I have successfully logged in as 'Sarah'
	And this is the first time I have logged in
  When the initial screen is shown
  Then the tutorial video is available to watch
