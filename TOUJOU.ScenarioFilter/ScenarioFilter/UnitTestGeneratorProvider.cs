using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Parser.SyntaxElements;
using TechTalk.SpecFlow.Utils;

namespace TOUJOU.ScenarioFilter
{
    public sealed class UnitTestGeneratorProvider : MsTest2010GeneratorProvider
    {
        //TODO: should be configurable
        private const string PREFIX = "filter";

        private const string FEATURE_FILTER_CACHE_NAME = "featureFilters";
        private const string FILTER_REGEX_CAPTURE_GROUPNAME = "filter";
        private const string FILTER_REGEX_PATTERN_FORMAT = @"^{0}\:(?<{1}>\!*[a-zA-Z][a-zA-Z_0-9]*)(\,(?<{1}>\!*[a-zA-Z][a-zA-Z_0-9]*))*$";

        private Regex _regex;

        public UnitTestGeneratorProvider(CodeDomHelper codeDomHelper) : base(codeDomHelper)
        {
            string pattern = string.Format(FILTER_REGEX_PATTERN_FORMAT, PREFIX, FILTER_REGEX_CAPTURE_GROUPNAME);
            this._regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.ExplicitCapture);
        }

        public override void SetTestMethod(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string scenarioTitle)
        {
            base.SetTestMethod(generationContext, testMethod, scenarioTitle);

            Feature feature = generationContext.Feature;
            Scenario scenario = feature.Scenarios.Where(item => string.Equals(item.Title, scenarioTitle, StringComparison.InvariantCulture)).FirstOrDefault();

            if (scenario != null)
            {
                string[] featureFilters = null;

                if (generationContext.CustomData.ContainsKey(FEATURE_FILTER_CACHE_NAME))
                {
                    if (generationContext.CustomData[FEATURE_FILTER_CACHE_NAME] is string[])
                    {
                        featureFilters = (string[])generationContext.CustomData[FEATURE_FILTER_CACHE_NAME];
                    }
                    else
                    {
                        generationContext.CustomData.Remove(FEATURE_FILTER_CACHE_NAME);
                    }
                }

                if (featureFilters == null)
                {
                    featureFilters = this.GetFilters(feature.Tags);
                    generationContext.CustomData.Add(FEATURE_FILTER_CACHE_NAME, featureFilters);
                }

                string[] scenarioFilters = this.GetFilters(scenario.Tags);
                string[] filters = new string[featureFilters.Length + scenarioFilters.Length];

                featureFilters.CopyTo(filters, 0);
                scenarioFilters.CopyTo(filters, featureFilters.Length);

                filters = filters.Distinct(StringComparer.InvariantCulture).ToArray();

                if (filters.Length > 0)
                {
                    StringBuilder sb = new StringBuilder("#if ");

                    for (int i = 0; i < filters.Length; i++)
                    {
                        if (i == 0)
                        {
                            sb.AppendFormat("!{0}", filters[i]);
                        }
                        else
                        {
                            sb.AppendFormat(" || !{0}", filters[i]);
                        }
                    }

                    testMethod.Statements.Add(new CodeSnippetStatement(sb.ToString()));
                    CodeDomHelper.AddSourceLinePragmaStatement(testMethod.Statements, scenario.FilePosition.Line, scenario.FilePosition.Column);

                    string statement = string.Format("Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive(\"The following scenario is not valid for current test run configuration: {0}.\");", scenario.Title);
                    testMethod.Statements.Add(new CodeSnippetStatement(statement));

                    testMethod.Statements.Add(new CodeSnippetStatement("#endif"));
                }
            }
        }

        private string[] GetFilters(Tags tags)
        {
            if (tags == null)
            {
                return new string[0];
            }

            List<string> filters = new List<string>();

            foreach (Tag tag in tags)
            {
                Match match = _regex.Match(tag.Name);

                if (match.Groups[FILTER_REGEX_CAPTURE_GROUPNAME].Success)
                {
                    for (int i = 0; i < match.Groups[FILTER_REGEX_CAPTURE_GROUPNAME].Captures.Count; i++)
                    {
                        filters.Add(match.Groups[FILTER_REGEX_CAPTURE_GROUPNAME].Captures[i].Value);
                    }
                }
            }

            return filters.ToArray();
        }
    }
}
