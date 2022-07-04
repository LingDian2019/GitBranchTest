using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 调度任务明细 状态
    /// </summary>
    public enum DispatchTaskItemStatus
    {
        /// <summary>
        /// 未开始
        /// </summary>
        [Description("未开始")]
        NoStarted = 1,

        /// <summary>
        /// 运行中
        /// </summary>
        [Description("运行中")]
        Running = 2,

        /// <summary>
        /// 完成
        /// </summary>
        [Description("完成")]
        Finish = 3,
    }
}
