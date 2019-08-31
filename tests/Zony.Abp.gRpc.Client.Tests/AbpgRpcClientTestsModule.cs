using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Client.Tests
{
    [DependsOn(typeof(AbpgRpcCommonModule))]
    public class AbpgRpcClientTestsModule : AbpModule
    {
        
    }
}