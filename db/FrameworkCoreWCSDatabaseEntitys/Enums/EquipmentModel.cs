using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 设备 模式
    /// </summary>
    public enum EquipmentModel
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// 手动
        /// </summary>
        [Description("手动")]
        Manual = 2,

        /// <summary>
        /// 自动
        /// </summary>
        [Description("自动")]
        Auto = 3,

        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        Stop = 4,

        /// <summary>
        /// 半自动
        /// </summary>
        [Description("半自动")]
        SemiAutomatic = 5,
    }
}
