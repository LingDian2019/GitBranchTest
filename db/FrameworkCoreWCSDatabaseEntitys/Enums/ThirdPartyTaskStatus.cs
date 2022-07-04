using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 第三方任务状态
    /// </summary>
    public enum ThirdPartyTaskStatus
    {
        /// <summary>
        /// 未开始
        /// </summary>
        [Description("未开始")]
        NoStarted = 1,

        /// <summary>
        /// 已创建任务
        /// </summary>
        [Description("已创建任务")]
        CreateTask = 2,

        /// <summary>
        /// 执行中
        /// </summary>
        [Description("执行中")]
        Execution = 3,

        /// <summary>
        /// 完成
        /// </summary>
        [Description("完成")]
        Finish = 4,
    }
}
