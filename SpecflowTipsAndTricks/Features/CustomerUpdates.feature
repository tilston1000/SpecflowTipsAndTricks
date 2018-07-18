Feature: CustomerUpdates

@cust
Scenario: Save updated customer
	Given I have changed a customer
	When I choose save
	Then the updated customer should be saved
