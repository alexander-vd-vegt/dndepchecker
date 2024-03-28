namespace DnDepcheckerApi;

public class ReposConfig{
    public string Schedule {get; set;}
    public List<RepoCredentials> Credentials {get; set;}
    public List<RepoConfig> Repositories {get; set;}
}

public class RepoConfig
{
    public required string Name {get; set;}
    public required string Url {get; set;}
    public string Path {get; set;}
    public string ScanInterval {get; set;}
}

public class RepoCredentials{
    public required string Name {get; set;}
    public required string Username {get; set;}
    public string Password {get; set;}
}

