Feature: SpecFlowFeature2
	I want to visit specflow page and click Github link

@mytag
Scenario: Page name assertion should fail
	Given I go to "https://specflow.org/" page
	Then should be on "wrong page" page
