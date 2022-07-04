using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 调度任务类型
    /// </summary>
    public enum DispatchTaskType
    {
        /// <summary>
        /// 搬运任务
        /// </summary>
        [Description("搬运任务")]
        Move = 1,

        /// <summary>
        /// 机械拆垛任务
        /// </summary>
        [Description("机械拆垛任务")]
        RobotUnstacke = 2
    }
}
