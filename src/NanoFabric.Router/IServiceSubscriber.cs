using NanoFabric.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NanoFabric.Router
{
    /// <summary>
    /// 服务订阅接口
    /// </summary>
    public  interface IServiceSubscriber : IDisposable
    {
        Task<List<RegistryInformation>> Endpoints(CancellationToken ct = default(CancellationToken));
    }
}
