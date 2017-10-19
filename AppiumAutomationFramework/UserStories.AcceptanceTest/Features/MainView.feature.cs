﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UserStories.AcceptanceTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Main view - How to manage the different lists", Description="\tIn order to manage the diferrent lists\r\n\tAs a user\r\n\tI want to make the basic op" +
        "erations", SourceFile="Features\\MainView.feature", SourceLine=0)]
    public partial class MainView_HowToManageTheDifferentListsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MainView.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Main view - How to manage the different lists", "\tIn order to manage the diferrent lists\r\n\tAs a user\r\n\tI want to make the basic op" +
                    "erations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Main View - With an empty view the user can see a phrase", new string[] {
                "ID:83491912-EE62-4204-B7B3-9F2CD15B8D90",
                "Owner:",
                "Juan",
                "Serna"}, SourceLine=7)]
        public virtual void MainView_WithAnEmptyViewTheUserCanSeeAPhrase()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Main View - With an empty view the user can see a phrase", new string[] {
                        "ID:83491912-EE62-4204-B7B3-9F2CD15B8D90",
                        "Owner:",
                        "Juan",
                        "Serna"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("The application does not have any tasks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.Then("The user sees a proverb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Main View - When the user creates a task the main view have one task", new string[] {
                "ID:079E0D72-2753-4016-ADE3-7C27021D8AE6",
                "Owner:",
                "Juan",
                "Serna"}, SourceLine=13)]
        public virtual void MainView_WhenTheUserCreatesATaskTheMainViewHaveOneTask()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Main View - When the user creates a task the main view have one task", new string[] {
                        "ID:079E0D72-2753-4016-ADE3-7C27021D8AE6",
                        "Owner:",
                        "Juan",
                        "Serna"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("The application does not have any tasks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("The user goes to the add task view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("The user sets the task with the title \'Go to shop\', the content \'Buy eggs and oni" +
                    "ons\', and the color \'Red\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("The user creates the task", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("The application has \'1\' task created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
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
