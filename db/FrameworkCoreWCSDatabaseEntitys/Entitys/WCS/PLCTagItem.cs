using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// PLC 标签项
    /// </summary>
    [Table("WCSPLCTagItem")]
    [EntityAutomaticRegister(Entity = typeof(PLCTagItem), TableName = "WCSPLCTagItem")]
    public class PLCTagItem : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// PLC 组 ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("PLCTagGroupID")]
        public string PLCTagGroupID { get; set; }

        /// <summary>
        /// 标签顺序
        /// </summary>
        [Column("TagSequence")]
        public int TagSequence { get; set; }

        /// <summary>
        /// 标签Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TagCode")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签类型,使用系统枚举：TypeCode
        /// </summary>
        [Column("TagType")]
        public int TagType { get; set; }

        /// <summary>
        /// 标签地址
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TagAddress")]
        public string TagAddress { get; set; }

        /// <summary>
        /// 标签地址大小
        /// </summary>
        [Column("TagSize")]
        public int TagSize { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TagDescribe")]
        public string TagDescribe { get; set; }

        /// <summary>
        /// 标签标记
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TagFlag")]
        public string TagFlag { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("EquipmentID")]
        public string EquipmentID { get; set; }
    }
}
