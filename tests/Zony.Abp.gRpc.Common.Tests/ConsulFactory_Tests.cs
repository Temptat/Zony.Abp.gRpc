using Shouldly;
using Xunit;
using Zony.Abp.gRpc.Common.Consul;

namespace Zony.Abp.gRpc.Common.Tests
{
    public class ConsulFactory_Tests : AbpgRpcCommonTestBase<AbpgRpcCommonTestsModule>
    {
        private readonly IConsulFactory _consulFactory;

        public ConsulFactory_Tests()
        {
            _consulFactory = GetRequiredService<IConsulFactory>();
        }

        [Fact]
        public void Should_Create_A_ConsulClient()
        {
            var consulClient = _consulFactory.CreateConsulClient(new ConsulBuildParameters("127.0.0.1", 10086, ""));
            
            consulClient.ShouldNotBeNull();
        }
    }
}