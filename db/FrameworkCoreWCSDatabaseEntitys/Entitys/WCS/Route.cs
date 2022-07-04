using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 路径
    /// </summary>
    [Table("WCSRoute")]
    [EntityAutomaticRegister(Entity = typeof(Route), TableName = "WCSRoute")]
    public class Route : SQLServerTableStringEntityBase
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
        /// 开始设备Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartCode")]
        public string StartCode { get; set; }

        /// <summary>
        /// 目标设备Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("TargetCode")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 权重,越小越好，与容易被选中
        /// </summary>
        [Column("Weight")]
        public int Weight { get; set; } = 10;

        /// <summary>
        /// 激活状态
        /// </summary>
        [Column("ActivateStatus")]
        public int ActivateStatus { get; set; }

        /// <summary>
        /// 起始设备类型
        /// </summary>
        [Column("StartEquipmentType")]
        public string StartEquipmentType { get; set; }

        /// <summary>
        /// 目标设备类型
        /// </summary>
        [Column("TargetEquipmentType")]
        public string TargetEquipmentType { get; set; }
    }
}
