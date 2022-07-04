using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 连接状态
    /// </summary>
    public enum ConnectStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// 已连接
        /// </summary>
        [Description("已连接")]
        Connected = 2,

        /// <summary>
        /// 连接异常
        /// </summary>
        [Description("连接异常")]
        ConnectionException = 3,

        /// <summary>
        /// 离线
        /// </summary>
        [Description("离线")]
        Offline = 4,
    }
}
