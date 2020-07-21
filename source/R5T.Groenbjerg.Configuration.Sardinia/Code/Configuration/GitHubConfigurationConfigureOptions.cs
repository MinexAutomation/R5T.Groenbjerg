using System;

using Microsoft.Extensions.Options;


namespace R5T.Groenbjerg.Configuration
{
    public class GitHubConfigurationConfigureOptions : IConfigureOptions<GitHubConfiguration>
    {
        private IOptions<Raw.GitHubConfiguration> RawGitHubConfiguration { get; }


        public GitHubConfigurationConfigureOptions(IOptions<Raw.GitHubConfiguration> rawGitHubConfiguration)
        {
            this.RawGitHubConfiguration = rawGitHubConfiguration;
        }

        public void Configure(GitHubConfiguration options)
        {
            options.UserAccounts = this.RawGitHubConfiguration.Value.UserAccounts;
        }
    }
}