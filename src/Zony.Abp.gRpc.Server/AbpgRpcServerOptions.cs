using System.Net;

namespace Zony.Abp.gRpc.Server
{
    /// <summary>
    /// 定义了启动 gRpc 服务需要使用到的参数。
    /// </summary>
    public class AbpgRpcServerOptions
    {
        /// <summary>
        /// gRpc 服务提供者需要监听的终端点。默认监听地址为 <see cref="IPAddress.Any"/> ，端口是 50000。
        /// </summary>
        public IPEndPoint ListenEndPoint { get; set; }

        /// <summary>
        /// 构造一个新的 <see cref="AbpgRpcServerOptions"/> 对象。
        /// </summary>
        public AbpgRpcServerOptions()
        {
            ListenEndPoint = new IPEndPoint(IPAddress.Any, 50000);
        }
    }
}