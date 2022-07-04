using System.ComponentModel.DataAnnotations;
using Magicodes.ExporterAndImporter.Core;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 导出-驱动参数表
    /// </summary>
    public class DriverParameterExport : BaseEntityExport
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        [ImporterHeader(Name = "仓库名称")]
        public string WareHouseName { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [ImporterHeader(Name = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Code描述
        /// </summary>
        [ImporterHeader(Name = "Code描述")]
        public string CodeDescribe { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [ImporterHeader(Name = "属性名称")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [ImporterHeader(Name = "属性值")]
        public string PropertyValue { get; set; }

        /// <summary>
        /// 驱动参数组
        /// </summary>
        [ImporterHeader(Name = "驱动参数组")]
        public int DriverParaGroup { get; set; }

        /// <summary>
        /// 属性描述
        /// </summary>
        [ImporterHeader(Name = "属性描述")]
        public string PropertyDescribe { get; set; }
    }

    /// <summary>
    /// 导入-驱动参数表
    /// </summary>
    public class DriverParameterImport : BaseEntityImport
    {
        /// <summary>
        /// 驱动ID
        /// </summary>
        [ImporterHeader(Name = "驱动ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        public string DriverID { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [ImporterHeader(Name = "属性名称")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [ImporterHeader(Name = "属性值")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string PropertyValue { get; set; }

        /// <summary>
        /// 驱动参数组
        /// </summary>
        [ImporterHeader(Name = "驱动参数组")]
        public int DriverParaGroup { get; set; }

        /// <summary>
        /// 属性描述
        /// </summary>
        [ImporterHeader(Name = "属性描述")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string PropertyDescribe { get; set; }
    }
}
