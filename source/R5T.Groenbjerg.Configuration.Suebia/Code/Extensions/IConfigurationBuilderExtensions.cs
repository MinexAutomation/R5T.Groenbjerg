using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace R5T.Groenbjerg.Configuration.Suebia
{
    public static class IConfigurationBuilderExtensions
    {
        /// <summary>
        /// Default uses the <see cref="AddGitHubConfigurationJsonFile(IConfigurationBuilder, IServiceProvider)"/> method.
        /// </summary>
        public static IConfigurationBuilder AddGitHubConfigurationJsonFile(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            var gitHubConfigurationJsonFilePathProvider = configurationServiceProvider.GetRequiredService<IGitHubConfigurationJsonFilePathProvider>();

            var gitConfigurationJsonFilePath = gitHubConfigurationJsonFilePathProvider.GetGitHubConfigurationJsonFilePath();

            configurationBuilder.AddJsonFile(gitConfigurationJsonFilePath);

            return configurationBuilder;
        }
    }
}
