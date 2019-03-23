namespace NanoFabric.Core
{
    /// <summary>
    /// 注册主机接口
    /// </summary>
    public interface IRegistryHost : IManageServiceInstances, 
        IManageHealthChecks,
        IResolveServiceInstances
    {
    }
}
