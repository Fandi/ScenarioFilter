﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FeatureAFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureA.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature A", "", ProgrammingLanguage.CSharp, new string[] {
                        "filter:A"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Feature A")))
            {
                UnitTestProject.FeatureAFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Feature filtered by A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        public virtual void FeatureFilteredByA()
        {
#if !A
#line 4
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Feature filtered by A.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Feature filtered by A", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Then("this scenario should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario filtered by B")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:B")]
        public virtual void ScenarioFilteredByB()
        {
#if !A || !B
#line 8
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Scenario filtered by B.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario filtered by B", new string[] {
                        "filter:B"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Then("this scenario should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario filtered by A, B, and C")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:C")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:B,A")]
        public virtual void ScenarioFilteredByABAndC()
        {
#if !A || !C || !B
#line 13
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Scenario filtered by A, B, and C.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario filtered by A, B, and C", new string[] {
                        "filter:C",
                        "filter:B,A"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
    testRunner.Then("this scenario should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario filtered by A and !B")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A,!B")]
        public virtual void ScenarioFilteredByAAndB()
        {
#if !A || !!B
#line 17
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Scenario filtered by A and !B.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario filtered by A and !B", new string[] {
                        "filter:A,!B"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Then("this negative scenario should be inconclusive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario filtered by D")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:D")]
        public virtual void ScenarioFilteredByD()
        {
#if !A || !D
#line 21
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Scenario filtered by D.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario filtered by D", new string[] {
                        "filter:D"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Then("this negative scenario should be inconclusive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scenario filtered by !E and has a custom tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Feature A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("filter:!E")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("custom")]
        public virtual void ScenarioFilteredByEAndHasACustomTag()
        {
#if !A || !!E
#line 25
Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive("The following scenario is not valid for current test run configuration: Scenario filtered by !E and has a custom tag.");
#endif
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scenario filtered by !E and has a custom tag", new string[] {
                        "filter:!E",
                        "custom"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
    testRunner.Then("this scenario should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
