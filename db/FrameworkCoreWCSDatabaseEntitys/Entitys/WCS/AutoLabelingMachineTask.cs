using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 贴标机任务
    /// </summary>
    [Table("WCSAutoLabelingMachineTask")]
    [EntityAutomaticRegister(Entity = typeof(AutoLabelingMachineTask), TableName = "WCSAutoLabelingMachineTask")]
    public class AutoLabelingMachineTask : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// WMS任务号
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TaskNumber")]
        public string TaskNumber { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("ContainerBarcode")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 标签码
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("LabelCode")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("URL")]
        public string URL { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("EquipmentCode")]
        public string EquipmentCode { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [Column("Status")]
        public int Status { get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("WarehouseID")]
        public string WarehouseID { get; set; }
    }
}
