using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// WCS仓库
    /// </summary>
    [Table("WCSWarehouse")]
    [EntityAutomaticRegister(Entity = typeof(Warehouse), TableName = "WCSWarehouse")]
    public class Warehouse : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 仓库Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("Code")]
        public string Code { get; set; }

        /// <summary>
        /// 仓库区域Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("ZonesCode")]
        public string ZonesCode { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [Column("ActivateStatus")]
        public int ActivateStatus { get; set; }
    }
}
