using Volo.Abp;
using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Server
{
    [DependsOn(typeof(AbpgRpcCommonModule))]
    public class AbpgRpcServerModule : AbpModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
        }
    }
}