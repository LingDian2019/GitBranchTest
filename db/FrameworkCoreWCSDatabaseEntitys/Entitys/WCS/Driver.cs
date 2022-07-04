using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// WCS驱动
    /// </summary>
    [Table("WCSDriver")]
    [EntityAutomaticRegister(Entity = typeof(Driver), TableName = "WCSDriver")]
    public class Driver : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 仓库ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("WarehouseID")]
        public string WarehouseID { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("Code")]
        public string Code { get; set; }

        /// <summary>
        /// Code描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("CodeDescribe")]
        public string CodeDescribe { get; set; }

        /// <summary>
        /// 驱动类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [Column("ProtocolType")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [Column("ActivateStatus")]
        public int ActivateStatus { get; set; }

        /// <summary>
        /// 连接状态
        /// </summary>
        [Column("ConnectStatus")]
        public int ConnectStatus { get; set; }

        /// <summary>
        /// 连接描述
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(500, ErrorMessage = "{0}最大长度500个字符")]
        [Column("ConnectDescribe")]
        public string ConnectDescribe { get; set; } = string.Empty;
    }
}
