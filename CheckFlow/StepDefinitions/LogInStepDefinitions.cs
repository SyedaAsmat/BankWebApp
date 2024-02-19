using BankWebApp;
using NUnit.Framework;

namespace CheckFlow.StepDefinitions
{
    [Binding]
    public class LogInStepDefinitions
    {
        private string username;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly UserLogin userLogin;

        public LogInStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            userLogin = new UserLogin();
        }
        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndValidPassword(string un, string pwd)
        {
            username = un;
            password = pwd;
        }
        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginResult = userLogin.Login(username, password);
        }
        [Then(@"the result should Login Success")]
        public void ThenTheResultShouldLoginSuccess()
        {
            Assert.AreEqual("Login success", loginResult);
        }
        [Given(@"a user with invalid username ""(.*)"" and valid password ""(.*)""")]
        //[Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string usr, string invalid)
        {
            username = usr;
            username = invalid;
        }
        [Then(@"the result should Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            Assert.AreEqual("Login failed", loginResult);
        }
    }
}
