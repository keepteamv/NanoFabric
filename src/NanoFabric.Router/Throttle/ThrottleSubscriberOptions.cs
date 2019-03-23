using System;

namespace NanoFabric.Router.Throttle
{
    /// <summary>
    /// 限制的订阅选项类
    /// </summary>
    public class ThrottleSubscriberOptions
    {
        public static readonly ThrottleSubscriberOptions Default = new ThrottleSubscriberOptions();

        /// <summary>
        /// 最大更新数
        /// </summary>
        public int MaxUpdatesPerPeriod { get; set; } = 5;

        /// <summary>
        /// 最大的更新周期
        /// </summary>
        public TimeSpan MaxUpdatesPeriod { get; set; } = TimeSpan.FromSeconds(10);
    }
}