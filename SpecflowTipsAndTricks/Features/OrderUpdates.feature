Feature: OrderUpdates

Scenario: Save updated order
	Given I have changed an order
	When I choose save
	Then the updated order should be saved

