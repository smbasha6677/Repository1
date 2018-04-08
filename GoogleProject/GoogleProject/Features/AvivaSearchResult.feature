Feature: Aviva search result
	In order to see Aviva link
	As a customer
	I want to see the Aviva link


Scenario: Aviva search positive scenario
	Given I am on Google home page 
	When I search for text Aviva
	And I see the 5th link
	Then I should see the Aviva text

Scenario: Aviva search negative scenario
	Given I am on Google home page 
	When I search for text Google
	And I see the 5th link
	Then I should not see the Aviva text

