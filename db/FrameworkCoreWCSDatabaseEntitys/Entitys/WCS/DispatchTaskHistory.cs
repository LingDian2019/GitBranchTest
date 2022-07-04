using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    ///  调度任务历史表  
    /// </summary>
    [Table("WCSDispatchTask_History")]
    [EntityAutomaticRegister(Entity = typeof(DispatchTaskHistory), TableName = "WCSDispatchTask_History")]
    public class DispatchTaskHistory : SQLServerTableStringEntityBase
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
        /// 任务号
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("TaskNumber")]
        [Range(1, 32767, ErrorMessage = "{0}范围只能0到32767")]
        public int TaskNumber { get; set; }

        /// <summary>
        /// 第三方任务号
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("ThirdPartyTaskNumber")]
        public string ThirdPartyTaskNumber { get; set; }

        /// <summary>
        /// 子任务总数
        /// </summary>
        [Column("TaskItemCount")]
        public int TaskItemCount { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("ContainerBarcode")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TaskType")]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [Column("TaskStatus")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 优先级，越少越优先，默认优先级100,1代表最优先
        /// </summary>
        [Column("Priority")]
        [Range(1, 100, ErrorMessage = "{0}范围只能1到100")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartCode")]
        public string StartCode { get; set; }

        /// <summary>
        /// 开始位置
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartLocation")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 起始设备类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("StartType")]
        public string StartType { get; set; }

        /// <summary>
        /// 目标设备Code，是指这个任务目标是那个设备执行
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TargetCode")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TargetLocation")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 目标设备类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("TargetType")]
        public string TargetType { get; set; }

        /// <summary>
        /// 任务消息
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(500, ErrorMessage = "{0}最大长度500个字符")]
        [Column("TaskMessage")]
        public string TaskMessage { get; set; } = string.Empty;

        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? FinishTaskTime { get; set; }
    }

}
