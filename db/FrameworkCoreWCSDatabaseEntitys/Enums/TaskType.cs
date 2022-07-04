using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 第三方任务类型
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// 生鲜分拣任务
        /// </summary>
        [Description("生鲜分拣任务")]
        FreshSortingTask = 2,

        /// <summary>
        /// 干货分拣任务
        /// </summary>
        [Description("干货分拣任务")]
        DryGoodsSortingTask = 3,

        /// <summary>
        /// 托盘入库任务
        /// </summary>
        [Description("托盘入库任务")]
        TrayInStorageTask = 4,

        /// <summary>
        /// 托盘出库任务
        /// </summary>
        [Description("托盘出库任务")]
        TrayOutStorageTask = 5,

        /// <summary>
        /// 托盘移动任务
        /// </summary>
        [Description("托盘移动任务")]
        TrayMoveTask = 6,

        /// <summary>
        /// 空托盘组任务
        /// </summary>
        [Description("空托盘组任务")]
        EmptyTrayGroupTask = 7,

        /// <summary>
        /// 空周转筐组任务
        /// </summary>
        [Description("空周转筐组任务")]
        EmptyTurnoverBasketGroupTask = 8
    }
}
