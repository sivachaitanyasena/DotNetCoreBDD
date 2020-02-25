Feature: LoginPage
	In order to login client site
	As a external user
	I want to be able login application 

@External
Scenario Outline: Login External Site using Valid Credentials
	Given User Navigates to application <SiteType> login page
	When User login using credentials <UserName> and <PassWordType>
	Then User should be able to login succesfully <UserFirstName>
	And  Test completed Successfully
Examples: 
| SiteType | UserName                  | PassWordType  | UserFirstName |
| External | chaturvediankit@gmail.com | validPassword | Ankit         |

@External
Scenario Outline: Validate Forgot Password link External Site
	Given User Navigates to application <SiteType> login page
	Then User should be able to validate forgot password link
	And  Test completed Successfully
Examples: 
| SiteType |
| External |

@External
Scenario Outline: Logout External Site
	Given User Navigates to application <SiteType> login page
	When User login using credentials <UserName> and <PassWordType>
	Then User should be able to login succesfully <UserFirstName>
	When User click on Logout link
	Then User should be redirected to Login Page
Examples: 
| SiteType | UserName                  | PassWordType  | UserFirstName |
| External | chaturvediankit@gmail.com | validPassword | Ankit         |


@External
Scenario Outline: Login External Site using InValid Credentials
	Given User Navigates to application <SiteType> login page
	When User login using credentials <UserName> and <PassWordType>
	Then Then User should get <Error> message
Examples: 
| SiteType | UserName                  | PassWordType    | Error                        |
| External | chaturvediankit@gmail.com | invalidPassword | Your username or password is incorrect|