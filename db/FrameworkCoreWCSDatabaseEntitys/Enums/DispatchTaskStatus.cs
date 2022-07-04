using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 调度任务 状态
    /// </summary>
    public enum DispatchTaskStatus
    {
        /// <summary>
        /// 未开始
        /// </summary>
        [Description("未开始")]
        NotStart = 1,

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

        /// <summary>
        /// 系统强制完成
        /// </summary>
        [Description("系统强制完成")]
        SystemConstraintFinish = 4,

        /// <summary>
        /// 用户强制完成
        /// </summary>
        [Description("用户强制完成")]
        ArtificialConstraintFinish = 5,
    }
}
