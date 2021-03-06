﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Devon4Net.SpecFlow.SpecFlow.LoginUserTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SpecFlowFeatureLogin", Description="\tIn order to log in \r\n\tAs a waiter\r\n\tI want to be told when the waiter logs in", SourceFile="SpecFlow\\LoginUserTest\\Features\\SpecFlowFeatureLogin.feature", SourceLine=0)]
    public partial class SpecFlowFeatureLoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeatureLogin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeatureLogin", "\tIn order to log in \r\n\tAs a waiter\r\n\tI want to be told when the waiter logs in", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Waiter logs in", SourceLine=5)]
        public virtual void WaiterLogsIn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Waiter logs in", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("I have entered \"waiter\" into the username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have entered \"waiter\" into the password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("The result of login process is \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the result should be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Waiter logs in error", SourceLine=12)]
        public virtual void WaiterLogsInError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Waiter logs in error", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("I have entered \"waiter\" into the username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("I have entered \"aaaa\" into the password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("The result of login process is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the result should not be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User0 logs in", SourceLine=19)]
        public virtual void User0LogsIn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User0 logs in", null, ((string[])(null)));
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("I have entered \"user0\" into the username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I have entered \"password\" into the password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("The result of login process is \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the result should be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User0 logs in wrong", SourceLine=26)]
        public virtual void User0LogsInWrong()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User0 logs in wrong", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
 testRunner.Given("I have entered \"user0\" into the username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And("I have entered \"password\" into the password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("The result of login process is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the result should not be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void UserLogsInCorrectly(string username, string password, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User logs in correctly", null, exampleTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given(string.Format("I have entered {0} into the username TableExample", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And(string.Format("I have entered {0} into the password TableExample", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("The result of login process is \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the result should be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User logs in correctly, waiter", SourceLine=42)]
        public virtual void UserLogsInCorrectly_Waiter()
        {
#line 35
this.UserLogsInCorrectly("waiter", "waiter", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User logs in correctly, user0", SourceLine=42)]
        public virtual void UserLogsInCorrectly_User0()
        {
#line 35
this.UserLogsInCorrectly("user0", "password", ((string[])(null)));
#line hidden
        }
        
        public virtual void UserLogsInFails(string username, string password, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User logs in fails", null, exampleTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 47
 testRunner.Given(string.Format("I have entered {0} into the username TableExample", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.And(string.Format("I have entered {0} into the password TableExample", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("The result of login process is \"false\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.When("I press login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("the result should not be \"true\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User logs in fails, waiter", SourceLine=53)]
        public virtual void UserLogsInFails_Waiter()
        {
#line 46
this.UserLogsInFails("waiter", "aaa", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("User logs in fails, user0", SourceLine=53)]
        public virtual void UserLogsInFails_User0()
        {
#line 46
this.UserLogsInFails("user0", "aaa", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
