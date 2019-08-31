using Volo.Abp.Modularity;
using Zony.Abp.gRpc.Common;

namespace Zony.Abp.gRpc.Server.Tests
{
    [DependsOn(typeof(AbpgRpcCommonModule))]
    public class AbpgRpcServerTestsModule : AbpModule
    {
        
    }
}