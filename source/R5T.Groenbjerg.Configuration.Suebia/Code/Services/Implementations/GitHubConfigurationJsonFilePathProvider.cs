using System;

using R5T.Suebia;using R5T.T0064;


namespace R5T.Groenbjerg.Configuration.Suebia
{[ServiceImplementationMarker]
    public class GitHubConfigurationJsonFilePathProvider : IGitHubConfigurationJsonFilePathProvider,IServiceImplementation
    {
        private ISecretsDirectoryFilePathProvider SecretsDirectoryFilePathProvider { get; }


        public GitHubConfigurationJsonFilePathProvider(
            ISecretsDirectoryFilePathProvider secretsDirectoryFilePathProvider)
        {
            this.SecretsDirectoryFilePathProvider = secretsDirectoryFilePathProvider;
        }

        public string GetGitHubConfigurationJsonFilePath()
        {
            var gitHubConfigurationJsonFilePath = this.SecretsDirectoryFilePathProvider.GetSecretsFilePath(FileNames.GitHubConfigurationJsonFileName);
            return gitHubConfigurationJsonFilePath;
        }
    }
}
