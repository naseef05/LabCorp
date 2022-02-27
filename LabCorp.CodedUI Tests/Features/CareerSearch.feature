Feature: CareerSearch
As an user,I should be able to go to career search page and apply

Scenario: Successfully navigate to career search page
Given I have access to labcorp website
When I click on career tab
Then I will be redirected to career page

Scenario: Search for a position at career page
Given I am at career page
And I write postion name QA Analyst
When I press enter	
Then job title job location job display and other three verification