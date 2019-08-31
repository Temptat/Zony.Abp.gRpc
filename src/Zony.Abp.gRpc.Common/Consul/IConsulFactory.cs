using Consul;
using Volo.Abp.DependencyInjection;

namespace Zony.Abp.gRpc.Common.Consul
{
    public interface IConsulFactory : ISingletonDependency
    {
        IConsulClient CreateConsulClient(ConsulBuildParameters config);
    }
}