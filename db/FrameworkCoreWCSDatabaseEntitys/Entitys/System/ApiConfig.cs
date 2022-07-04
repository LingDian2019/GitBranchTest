using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// Api配置表 
    /// </summary>
    [Table("dbo.SystemApiConfig")]
    [EntityAutomaticRegister(Entity = typeof(ApiConfig), TableName = "SystemApiConfig")]
    public class ApiConfig : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// Api类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        public int ApiType { get; set; }

        /// <summary>
        /// Api组别
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        public string ApiGroup { get; set; }

        /// <summary>
        /// API名称Key   
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        public string NameKey { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string Describe { get; set; }

        /// <summary>
        /// 地址前缀    
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string UrlPrefix { get; set; }

        /// <summary>
        /// 地址后缀
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string UrlSuffix { get; set; }

    }


}
