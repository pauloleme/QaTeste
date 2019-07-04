Feature: BingSearch
	In order to search using Bing
	as Common User
	I want view all relevant results	

@simpleSearchTag
Scenario: SearchSimpleText
	Given Opened Browser
	And Navigate to Bing Url
	When Enter text on search box
	And Click on SearchButton
	Then Show the results
	And Close Browser