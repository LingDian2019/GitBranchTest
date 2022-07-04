using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 设备 状态
    /// </summary>
    public enum EquipmentStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 2,

        /// <summary>
        /// 错误
        /// </summary>
        [Description("错误")]
        Error = 3,
    }
}
