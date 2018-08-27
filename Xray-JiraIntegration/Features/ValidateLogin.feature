@XRAYIN-3
Feature: 

	
	@XRAYIN-1
	Scenario: validate successful login of CommonWealth Bank
		Given I enter CBA url in Browser
		Then I enter "91759195" in ClientNumber field
		Then I enter "al03)(inJ" in password field
		Then Click LogOn button
		Then verify successful login
		Then click logout
			

	
	@XRAYIN-2
	Scenario: validate invalid login in CBA
		Given I enter CBA url in Browser
		Then I enter "9175916" in ClientNumber field
		Then I enter "12345678" in password field
		Then Click LogOn button
		Then verify Login Error Message