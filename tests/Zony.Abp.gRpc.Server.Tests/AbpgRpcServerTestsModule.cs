using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Server.Tests
{
    [DependsOn(typeof(AbpgRpcCommonModule))]
    public class AbpgRpcServerTestsModule : AbpModule
    {
        
    }
}