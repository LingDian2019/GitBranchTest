using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 第三方任务 运行状态
    /// </summary>
    public enum ThirdPartyTaskRunStatus
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
