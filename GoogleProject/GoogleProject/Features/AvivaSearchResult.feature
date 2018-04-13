Feature: Aviva search result
	In order to see Aviva link
	As a customer
	I want to see the Aviva link

Scenario: Aviva search positive scenario
	Given I am on Google home page 
	When I search for text Aviva
	Then I can see the search result page with the number of links
    And I should print the 5th link text as Aviva - Home | Facebook

Scenario: Aviva search negative scenario
    Given I am on Google home page 
	When I search for text Aviva
	Then I can see the search result page with the number of links
    And I should print the 4th link text as Aviva - Wikipedia
	But shoud not see Aviva - Home | Facebook text