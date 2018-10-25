using AutoMapper;
using Devon4Net.Business.Common;
using Devon4Net.Business.Common.UserManagement.Service;
using Devon4Net.Infrastructure.ApplicationUser;
using Devon4Net.Infrastructure.Test;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Devon4Net.SpecFlow.SpecFlow.LoginUserTest.Steps
{
    [Binding]
    public class SpecFlowFeatureLoginSteps : BaseManagementTest
    {
        private string username;
        private string password;
        private bool loginProcessResult;
        private bool Res;

        public ILoginService LoginService { get; set; }

        public override void ConfigureMapper()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperProfile());
            });
            Mapper = mockMapper.CreateMapper();
        }

        public SpecFlowFeatureLoginSteps()
        {
            //Mocking the required objects
            var mockUserManager = new Mock<UserManager<ApplicationUser>>(
                new Mock<IUserStore<ApplicationUser>>().Object,
                new Mock<IOptions<IdentityOptions>>().Object,
                new Mock<IPasswordHasher<ApplicationUser>>().Object,
                new IUserValidator<ApplicationUser>[0],
                new IPasswordValidator<ApplicationUser>[0],
                new Mock<ILookupNormalizer>().Object,
                new Mock<IdentityErrorDescriber>().Object,
                new Mock<IServiceProvider>().Object,
                new Mock<ILogger<UserManager<ApplicationUser>>>().Object).Object;

            var mockSignInManager = new Mock<SignInManager<ApplicationUser>>(
                mockUserManager,
                new Mock<IHttpContextAccessor>().Object,
                new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object,
                new Mock<IOptions<IdentityOptions>>().Object,
                new Mock<ILogger<SignInManager<ApplicationUser>>>().Object,
                new Mock<IAuthenticationSchemeProvider>().Object);


            //Define the results objects of the fake calls
            var result = new Mock<SignInResult>();


            //Define the response of the fake call of the mocked servide 
            mockSignInManager.Setup(m => m.PasswordSignInAsync("waiter", "waiter", true, false)).Returns(Task.FromResult(result.Object));


            //Initializing the moqued service
            LoginService = new LoginService(mockSignInManager.Object, mockUserManager);
        }

        [Given(@"I have entered ""(.*)"" into the username")]
        public void GivenIHaveEnteredIntoTheUsername(string u)
        {
            username = u;
        }
        
        [Given(@"I have entered ""(.*)"" into the password")]
        public void GivenIHaveEnteredIntoThePassword(string p)
        {
            password = p;
        }
        
        [Given(@"The result of login process is ""(.*)""")]
        public void GivenTheResultOfLoginProcessIs(bool r)
        {
            loginProcessResult = r;
        }

        [Given(@"I have entered (.*) into the username TableExample")]
        public void GivenIHaveEnteredIntoTheUsernameTableExample(string u)
        {
            username = u;
        }

        [Given(@"I have entered (.*) into the password TableExample")]
        public void GivenIHaveEnteredIntoThePasswordTableExample(string p)
        {
            password = p;
        }
        
        [When(@"I press login")]
        public async void WhenIPressLogin()
        {
            Res = await LoginService.LoginAsync(username, password);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(bool r)
        {
            Assert.IsTrue(loginProcessResult == r);
        }
        
        [Then(@"the result should not be ""(.*)""")]
        public void ThenTheResultShouldNotBe(bool r)
        {
            Assert.IsTrue(loginProcessResult != r);
        }
    }
}
