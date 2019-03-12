Feature: SpecFlowFeature1
	I want to visit specflow page and click Github link

@mytag
Scenario: Go to page and click link
	Given I go to "https://specflow.org/" page
	When I click "Contribute on Github" link
	Then should be on "https://github.com/techtalk/SpecFlow" page

