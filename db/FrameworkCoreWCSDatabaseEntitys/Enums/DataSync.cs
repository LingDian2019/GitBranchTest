using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 数据同步
    /// </summary>
    public enum DataSync
    {
        /// <summary>
        /// 同步
        /// </summary>
        [Description("等待同步")]
        WaitingSynchronization = 1,

        /// <summary>
        /// 不同步
        /// </summary>
        [Description("不同步")]
        NoSynchronization = 2,

        /// <summary>
        /// 同步完成
        /// </summary>
        [Description("同步完成")]
        SynchronizationComplete = 3,

        /// <summary>
        /// 同步失败
        /// </summary>
        [Description("同步失败")]
        SynchronizationFailure = 4,
    }
}
