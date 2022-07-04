using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 调度任务明细
    /// </summary>
    [Table("WCSDispatchTaskItem")]
    [EntityAutomaticRegister(Entity = typeof(DispatchTaskItem), TableName = "WCSDispatchTaskItem")]
    public class DispatchTaskItem : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 主任务ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("DispatchTaskID")]
        public string DispatchTaskID { get; set; }

        /// <summary>
        /// 优先级，越少越优先，默认优先级100,1代表最优先
        /// </summary>
        [Column("Priority")]
        [Range(1, 100, ErrorMessage = "{0}范围只能1到100")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 任务号
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("TaskNumber")]
        [Range(0, 32767, ErrorMessage = "{0}范围只能0到32767")]
        public int TaskNumber { get; set; }

        /// <summary>
        /// 执行序号
        /// </summary>
        [Column("ExecuteSerialNumber")]
        public int ExecuteSerialNumber { get; set; }

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartCode")]
        public string StartCode { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("ContainerBarcode")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 开始位置
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
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
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("TargetCode")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("TargetLocation")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 目标设备类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("TargetType")]
        public string TargetType { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [Column("RunStatus")]
        public int RunStatus { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [Column("Status")]
        public int Status { get; set; }

        /// <summary>
        /// 任务消息
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度500个字符")]
        [Column("TaskMessage")]
        public string TaskMessage { get; set; } = string.Empty;

        /// <summary>
        /// 开始时间
        /// </summary>
        [Column("StartTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [Column("FinishTime")]
        public DateTime? FinshTime { get; set; }
    }
}
