using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// WCS设备
    /// </summary>
    [Table("WCSEquipment")]
    [EntityAutomaticRegister(Entity = typeof(Equipment), TableName = "WCSEquipment")]
    public class Equipment : SQLServerTableStringEntityBase
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
        /// 设备Code
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("Code")]
        public string Code { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 设备模式
        /// </summary>
        [Column("Model")]
        public int Model { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [Column("Status")]
        public int Status { get; set; }

        /// <summary>
        /// 驱动ID
        /// </summary>
        [Column("DriverID")]
        public string DriverID { get; set; }
    }
}
