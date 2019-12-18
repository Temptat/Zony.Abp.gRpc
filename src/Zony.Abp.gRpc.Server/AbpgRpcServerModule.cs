using MagicOnion.Server;
using Microsoft.Extensions.DependencyInjection;
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
            using (var scope = context.ServiceProvider.CreateScope())
            {
                var magicOnionOption = new MagicOnionOptions();
                magicOnionOption.IsReturnExceptionStackTraceInErrorDetail = false;
            }
        }
    }
}