using Volo.Abp;
using Volo.Abp.Modularity;
using Zony.Abp.gRpc.Common;

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