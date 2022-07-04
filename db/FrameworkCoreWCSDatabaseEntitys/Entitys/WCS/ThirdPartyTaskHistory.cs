using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 第三方任务历史表
    /// </summary>
    [Table("WCSThirdPartyTask_History")]
    [EntityAutomaticRegister(Entity = typeof(ThirdPartyTaskHistory), TableName = "WCSThirdPartyTask_History")]
    public class ThirdPartyTaskHistory : SQLServerTableStringEntityBase
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
        /// 第三方任务号
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("TaskNumber")]
        public string TaskNumber { get; set; }

        /// <summary>
        /// 组号
        /// </summary>
        [Column("GroupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("TaskType")]
        public string TaskType { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("ContainerBarcode")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 第三方任务状态
        /// </summary>
        [Column("Status")]
        public int Status { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [Column("RunStatus")]
        public int RunStatus { get; set; }

        /// <summary>
        /// 优先级，越少越优先，默认优先级100,1代表最优先
        /// </summary>
        [Column("Priority")]
        [Range(1, 100, ErrorMessage = "{0}范围只能1到100")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartCode")]
        public string StartCode { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("StartLocation")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 目标设备Code，是指这个任务目标是那个设备执行
        /// </summary>
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("TargetCode")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("TargetLocation")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 执行任务时间
        /// </summary>
        [Column("ExecutionTaskStartTime")]
        public DateTime ExecutionTaskStartTime { get; set; } = Convert.ToDateTime("1970-01-01 00:00:00");

        /// <summary>
        /// 结束任务时间
        /// </summary>
        [Column("FinishTaskTime")]
        public DateTime FinishTaskTime { get; set; } = Convert.ToDateTime("1970-01-01 00:00:00");

        /// <summary>
        /// 任务消息
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度500个字符")]
        [Column("TaskMessage")]
        public string TaskMessage { get; set; } = string.Empty;

        /// <summary>
        /// 其他参数
        /// </summary>
        [MaxLength(500, ErrorMessage = "{0}最大长度500个字符")]
        [Column("OtherParams")]
        public string OtherParams { get; set; } = string.Empty;

        /// <summary>
        /// 数据同步
        /// </summary>
        [Column("DataSync")]
        public int DataSync { get; set; }
    }
}
