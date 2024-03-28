
namespace DnDepcheckerApi;

public class DependencyScanWorker : BackgroundService
{
    private readonly ReposConfig _repoConfig;
    private readonly GitService _gitSvc;
    private readonly PkgService _pkgSvc;

    public DependencyScanWorker(IConfiguration configuration){
        _repoConfig = configuration.GetSection("repoConfig").Get<ReposConfig>();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            foreach(var repo in _repoConfig.Repositories)
            {
                await _gitSvc.GetRepo(repo);
                await _pkgSvc.ScanVunerables(repo);
                await _pkgSvc.ScanOutdated(repo);
                await _gitSvc.CleanUp(repo);
            }
        }
    }
}
