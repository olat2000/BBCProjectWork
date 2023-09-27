Feature: BBCHome

As a user on BBC
I want to go on the Homepage
So that I can register

@tag1
Scenario: Verify user can register on BBC website
	Given a user navigate to BBC website 
	When user click on sign in
	And user click on register now
	And user click on thirteen or over
	And user enter their Day of Birth
	And user enter their Month of Birth
	And user enter their Year of Birth
	And user click on continue button
	And user enter their Email
	And user their Pword
	And user enter their Postcode
	And user select their gender
	And user click on Register button
	Then BBC Homepage is displayed