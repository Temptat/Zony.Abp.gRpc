using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Common
{
    public class AbpgRpcCommonModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }

        protected virtual void ConfigureMagicOnion(IServiceCollection services)
        {
            
        }
    }
}