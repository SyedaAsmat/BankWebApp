Feature: LoginTest

A short summary of the feature

@mytag
Scenario: Successful UserLogin
	Given a user with valid username "user123" and valid password "user@123"
	When the Login method is called
	Then the result should Login Success

Scenario: Unsuccessful UserLogin
	Given a user with invalid username "invalid_user" and valid password "invalid"
	When the Login method is called
	Then the result should Login Failed
