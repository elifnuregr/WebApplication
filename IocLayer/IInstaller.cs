using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IocLayer
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
