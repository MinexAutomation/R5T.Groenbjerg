using System;using R5T.T0064;


namespace R5T.Groenbjerg.Configuration
{[ServiceDefinitionMarker]
    public interface IGitHubConfigurationJsonFilePathProvider:IServiceDefinition
    {
        string GetGitHubConfigurationJsonFilePath();
    }
}
