using System;

using R5T.Suebia;


namespace R5T.Groenbjerg.Configuration.Suebia
{
    public class GitHubConfigurationJsonFilePathProvider : IGitHubConfigurationJsonFilePathProvider
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
