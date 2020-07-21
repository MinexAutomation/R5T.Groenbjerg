using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Sardinia;


namespace R5T.Groenbjerg.Configuration
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitHubConfiguration(this IServiceCollection services)
        {
            services
                .Configure<Configuration.Raw.GitHubConfiguration>()
                .ConfigureOptions<GitHubConfigurationConfigureOptions>()
                ;

            return services;
        }

        public static IServiceAction<IOptions<GitHubConfiguration>> AddGitHubConfigurationAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IOptions<GitHubConfiguration>>.New(() => services.AddGitHubConfiguration());
            return serviceAction;
        }
    }
}
