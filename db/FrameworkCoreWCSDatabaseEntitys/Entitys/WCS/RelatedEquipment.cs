using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 设备关联表
    /// </summary>
    [Table("WCSRelatedEquipment")]
    [EntityAutomaticRegister(Entity = typeof(RelatedEquipment), TableName = "WCSRelatedEquipment")]
    public class RelatedEquipment : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("EquipmentID")]
        public string EquipmentID { get; set; }

        /// <summary>
        /// 关联设备ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("RelatedEquipmentID")]
        public string RelatedEquipmentID { get; set; }

        /// <summary>
        /// 关联类型
        /// </summary>
        [Column("RelatedType")]
        public string RelatedType { get; set; }

        /// <summary>
        /// 关联信息
        /// </summary>
        [Column("RelatedInfo")]
        public string RelatedInfo { get; set; }
    }
}
