Feature: HomePage
	In order to validate Home Page
	As a external User
	I want to validate Home Page

@External
Scenario Outline: Validate Home Page for Local Country User in External Site 
	Given User Navigates to application <SiteType> login page
	When User login using credentials <UserName> and <PassWordType>
	Then User should be redirected to Home Page
	And  User should be able to see <UserFullName>
	When User click on Logout link
	Then User should be redirected to Login Page

	Examples: 
| SiteType | Username      | PasswordType  | UserFullName  | ClientName     |
| External | validPassword | validPassword | Jain,Abhishek | Ankit's Client |
