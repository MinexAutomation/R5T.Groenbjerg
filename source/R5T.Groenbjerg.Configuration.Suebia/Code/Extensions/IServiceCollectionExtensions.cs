using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Suebia;


namespace R5T.Groenbjerg.Configuration.Suebia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitHubConfigurationJsonFilePathProvider"/> implementation of <see cref="IGitHubConfigurationJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitHubConfigurationJsonFilePathProvider(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            services
                .AddSingleton<IGitHubConfigurationJsonFilePathProvider, GitHubConfigurationJsonFilePathProvider>()
                .Run(secretsDirectoryFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitHubConfigurationJsonFilePathProvider"/> implementation of <see cref="IGitHubConfigurationJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitHubConfigurationJsonFilePathProvider> AddGitHubConfigurationJsonFilePathProviderAction(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<IGitHubConfigurationJsonFilePathProvider>(() => services.AddGitHubConfigurationJsonFilePathProvider(
                secretsDirectoryFilePathProviderAction));

            return serviceAction;
        }
    }
}
