using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 调度任务明细 运行状态
    /// </summary>
    public enum DispatchTaskItemRunStatus
    {
        /// <summary>
        /// 不可执行
        /// </summary>
        [Description("不可执行")]
        CannotExecute = 1,

        /// <summary>
        /// 可执行
        /// </summary>
        [Description("可执行")]
        CanExecute = 2,
    }
}
