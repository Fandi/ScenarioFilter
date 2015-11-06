using BoDi;
using TechTalk.SpecFlow.Generator.Configuration;
using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;

[assembly: TechTalk.SpecFlow.Infrastructure.GeneratorPlugin(typeof(TOUJOU.ScenarioFilter.GeneratorPlugin))]

namespace TOUJOU.ScenarioFilter
{
    public class GeneratorPlugin : IGeneratorPlugin
    {
        void IGeneratorPlugin.RegisterConfigurationDefaults(SpecFlowProjectConfiguration specFlowConfiguration)
        {
        }

        void IGeneratorPlugin.RegisterCustomizations(ObjectContainer container, SpecFlowProjectConfiguration generatorConfiguration)
        {
            container.RegisterTypeAs<UnitTestGeneratorProvider, IUnitTestGeneratorProvider>();
        }

        void IGeneratorPlugin.RegisterDependencies(ObjectContainer container)
        {
        }
    }
}
