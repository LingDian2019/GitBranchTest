using System.ComponentModel.DataAnnotations;
using FrameworkCoreApplication;
using Magicodes.ExporterAndImporter.Core;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 导出-驱动表
    /// </summary>
    public class DriverExport : BaseEntityExport
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        [ExporterHeader(DisplayName = "仓库名称")]
        public string WareHouseName { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [ExporterHeader(DisplayName = "驱动Code")]
        public string Code { get; set; }

        /// <summary>
        /// Code描述
        /// </summary>
        [ExporterHeader(DisplayName = "驱动Code描述")]
        public string CodeDescribe { get; set; }

        /// <summary>
        /// 驱动类型
        /// </summary>
        [ExporterHeader(DisplayName = "驱动类型")]
        public DriverType Type { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [ExporterHeader(DisplayName = "协议类型")]
        public DriverProtocolType ProtocolType { get; set; }

        /// <summary>
        /// 连接状态
        /// </summary>
        [ExporterHeader(DisplayName = "连接状态")]
        public ConnectStatus ConnectStatus { get; set; }

        /// <summary>
        /// 连接描述
        /// </summary>
        [ExporterHeader(DisplayName = "连接描述")]
        public string ConnectDescribe { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [ExporterHeader(DisplayName = "激活状态")]
        public ActivateStatus ActivateStatus { get; set; }
    }

    /// <summary>
    /// 导入-驱动表
    /// </summary>
    public class DriverImport : BaseEntityImport
    {
        /// <summary>
        /// Code
        /// </summary>
        [ImporterHeader(Name = "驱动Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        public string Code { get; set; }

        /// <summary>
        /// Code描述
        /// </summary>
        [ImporterHeader(Name = "驱动描述")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string CodeDescribe { get; set; } = string.Empty;

        /// <summary>
        /// 驱动类型
        /// </summary>
        [ImporterHeader(Name = "驱动类型")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        public DriverType Type { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [ImporterHeader(Name = "协议类型")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        public DriverProtocolType ProtocolType { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        public ActivateStatus ActivateStatus { get; set; }
    }
}
