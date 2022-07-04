using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 贴标机任务状态
    /// </summary>
    public enum ALMTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("未开始")]
        Waitting = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("准备就绪")]
        Ready = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("任务下发成功")]
        SendSuccess = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("任务下发失败")]
        SendFailed = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("任务接收")]
        ReceivedSuccess = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("打印完成")]
        PrintFinished = 6
    }
}
