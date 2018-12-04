namespace GardenMembership.SharedKernel.Settings
{
    public class ApplicationSettings
    {
        public ApplicationSecrets ApplicationSecrets { get; set; }
    }

    public class ApplicationSecrets
    {
        public string ConnectionString { get; set; }
    }
}
