using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 看板类型
    /// </summary>
    public enum VisualizationType
    {
        /// <summary>
        /// 拓扑图
        /// </summary>
        [Description("拓扑图")]
        Topo = 1,

        /// <summary>
        /// 数据统计
        /// </summary>
        [Description("数据统计")]
        DataStatistics = 2,
    }
}
