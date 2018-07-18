Feature: ExternalBindingAssemblies

Scenario: Post a timeline update
	Given The user 'Sarah' exists in the system
	When I submit a status update of "eating dinner"
	Then the update should appear in my timeline
