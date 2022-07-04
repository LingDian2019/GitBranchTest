using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 驱动类型
    /// </summary>
    public enum DriverType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// LED
        /// </summary>
        [Description("LED")]
        LED = 2,

        /// <summary>
        /// 输送线
        /// </summary>
        [Description("输送线")]
        Conveyor = 3,

        /// <summary>
        /// 机械手
        /// </summary>
        [Description("机械手")]
        Robot = 4,

        /// <summary>
        /// 自动贴标机
        /// </summary>
        [Description("自动贴标机")]
        AutoLabeling = 5,

        /// <summary>
        /// 四向穿梭车
        /// </summary>
        [Description("四向穿梭车")]
        FourWayRGV = 6,

        /// <summary>
        /// 巷道式堆垛机
        /// </summary>
        [Description("巷道式堆垛机")]
        RoadwayStacker = 7,
    }
}
