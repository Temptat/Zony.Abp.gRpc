using Volo.Abp.Modularity;
using Zony.Abp.gRpc.Common;

namespace Zony.Abp.gRpc.Client.Tests
{
    [DependsOn(typeof(AbpgRpcCommonModule))]
    public class AbpgRpcClientTestsModule : AbpModule
    {
        
    }
}