using System;
using Magicodes.ExporterAndImporter.Core;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 导出基类
    /// </summary>
    public class BaseEntityExport
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [ExporterHeader(DisplayName = "创建时间")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [ExporterHeader(DisplayName = "最后修改时间")]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// 数据描述
        /// </summary>
        [ExporterHeader(DisplayName = "数据描述")]
        public string DataDescribe { get; set; }
    }

    /// <summary>
    /// 导入基类
    /// </summary>
    public class BaseEntityImport
    {

    }
}
