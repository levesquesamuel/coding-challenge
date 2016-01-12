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
namespace Coding_Challenge.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Obtenir des suggestions de ville")]
    public partial class ObtenirDesSuggestionsDeVilleFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SuggestionsDeVille.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-CA"), "Obtenir des suggestions de ville", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Un seul résultat lorsque le nom exact est entré")]
        public virtual void UnSeulResultatLorsqueLeNomExactEstEntre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un seul résultat lorsque le nom exact est entré", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
    testRunner.When("je visite la page de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 5
    testRunner.And("j\'entre Amos dans la boite de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nom"});
            table1.AddRow(new string[] {
                        "Amos, QC, Canada"});
#line 6
    testRunner.Then("je devrais voir un résultat dans la grille", ((string)(null)), table1, "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Un seul résultat lorsqu\'un nom partiel est entré")]
        public virtual void UnSeulResultatLorsquUnNomPartielEstEntre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un seul résultat lorsqu\'un nom partiel est entré", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
    testRunner.Given("que je suis à la position géographique 43.70011, -79.4163", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Étant donné ");
#line 12
    testRunner.When("je visite la page de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 13
    testRunner.And("j\'entre London dans la boite de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nom"});
            table2.AddRow(new string[] {
                        "London, ON, Canada"});
            table2.AddRow(new string[] {
                        "London, OH, USA"});
            table2.AddRow(new string[] {
                        "London, KY, USA"});
            table2.AddRow(new string[] {
                        "Londontowne, MD, USA"});
#line 14
    testRunner.Then("je devrais voir les résultats suivants dans la grille", ((string)(null)), table2, "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Effacer les résultats lorsqu\'aucun nom n\'est entré")]
        public virtual void EffacerLesResultatsLorsquAucunNomNEstEntre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Effacer les résultats lorsqu\'aucun nom n\'est entré", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.When("je visite la page de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 23
    testRunner.And("j\'entre Amos dans la boite de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 24
    testRunner.And("j\'efface le contenu de la boite de recherche", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nom"});
#line 25
    testRunner.Then("je devrais voir les résultats suivants dans la grille", ((string)(null)), table3, "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion