Feature: ValTechTest

Scenario: Complete all Valtech Tests
	Given I am on the Valtech Homepage
	And I have asserted that the Recent Blogs text is present
	Then I navigate to the About, Services and Work pages and assert the titles
	Then I navigate to the Contact Us page and return the total number of offices