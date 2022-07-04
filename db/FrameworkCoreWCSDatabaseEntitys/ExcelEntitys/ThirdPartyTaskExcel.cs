using System;
using System.ComponentModel.DataAnnotations;
using Magicodes.ExporterAndImporter.Core;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 导出-第三方任务表
    /// </summary>
    public class ThirdPartyTaskExport : BaseEntityExport
    {
        /// <summary>
        /// 第三方任务号
        /// </summary>
        [ExporterHeader(DisplayName = "第三方任务号")]
        public string TaskNumber { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [ExporterHeader(DisplayName = "组名称")]
        public string GroupName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [ExporterHeader(DisplayName = "任务类型")]
        public string TaskType { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [ExporterHeader(DisplayName = "容器条码")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 第三方任务状态
        /// </summary>
        [ExporterHeader(DisplayName = "第三方任务状态")]
        public int Status { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [ExporterHeader(DisplayName = "运行状态")]
        public int RunStatus { get; set; }

        /// <summary>
        /// 优先级，越少越优先，默认优先级100,1代表最优先
        /// </summary>
        [ExporterHeader(DisplayName = "优先级")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [ExporterHeader(DisplayName = "优先级")]
        public string StartCode { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        [ExporterHeader(DisplayName = "优先级")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 目标设备Code，是指这个任务目标是那个设备执行
        /// </summary>
        [ExporterHeader(DisplayName = "目标设备Code")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [ExporterHeader(DisplayName = "目标位置")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 执行任务时间
        /// </summary>
        [ExporterHeader(DisplayName = "执行任务时间")]
        public DateTime ExecutionTaskStartTime { get; set; } = Convert.ToDateTime("1970-01-01 00:00:00");

        /// <summary>
        /// 结束任务时间
        /// </summary>
        [ExporterHeader(DisplayName = "结束任务时间")]
        public DateTime FinishTaskTime { get; set; } = Convert.ToDateTime("1970-01-01 00:00:00");

        /// <summary>
        /// 任务消息
        /// </summary>
        [ExporterHeader(DisplayName = "任务消息")]
        public string TaskMessage { get; set; } = string.Empty;
    }

    /// <summary>
    /// 导出表头-第三方任务表
    /// </summary>
    public class ThirdPartyTaskHeaderExport
    {
        /// <summary>
        /// 第三方任务号
        /// </summary>
        [ExporterHeader(DisplayName = "第三方任务号", IsBold = true)]
        public string TaskNumber { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [ExporterHeader(DisplayName = "组名称", IsBold = true, Format = "#,##0")]
        public string GroupName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [ExporterHeader(DisplayName = "任务类型", IsBold = true, Format = "#,##0")]
        public string TaskType { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [ExporterHeader(DisplayName = "容器条码", IsBold = true)]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 优先级，越少越优先，默认优先级100,1代表最优先
        /// </summary>
        [ExporterHeader(DisplayName = "优先级", IsBold = true, Format = "#,##0")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [ExporterHeader(DisplayName = "优先级", IsBold = true)]
        public string StartCode { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        [ExporterHeader(DisplayName = "优先级", IsBold = true)]
        public string StartLocation { get; set; }

        /// <summary>
        /// 目标设备Code，是指这个任务目标是那个设备执行
        /// </summary>
        [ExporterHeader(DisplayName = "目标设备Code", IsBold = true)]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [ExporterHeader(DisplayName = "目标位置", IsBold = true)]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 执行任务时间
        /// </summary>
        [ExporterHeader(DisplayName = "执行任务时间", IsBold = true)]
        public DateTime ExecutionTaskStartTime { get; set; } = Convert.ToDateTime("1970-01-01 00:00:00");

    }

    /// <summary>
    /// 导入-第三方任务表
    /// </summary>
    public class ThirdPartyTaskImport : BaseEntityImport
    {
        /// <summary>
        /// 第三方任务号
        /// </summary>
        [ImporterHeader(Name = "第三方任务号")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        public string TaskNumber { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [ImporterHeader(Name = "组名称")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        public string GroupName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [ImporterHeader(Name = "任务类型")]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// 容器条码
        /// </summary>
        [ImporterHeader(Name = "容器条码")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        public string ContainerBarcode { get; set; }

        /// <summary>
        /// 优先级,越小越优先,范围只能0到100
        /// </summary>
        [ImporterHeader(Name = "优先级")]
        [Range(1, 100, ErrorMessage = "{0}范围只能0到100")]
        public int Priority { get; set; } = 100;

        /// <summary>
        /// 开始设备Code，是指这个任务最开始那个设备执行
        /// </summary>
        [ImporterHeader(Name = "开始设备Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        public string StartCode { get; set; }

        /// <summary>
        /// 起始位置
        /// </summary>
        [ImporterHeader(Name = "起始位置")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        public string StartLocation { get; set; }

        /// <summary>
        /// 目标设备Code，是指这个任务目标是那个设备执行
        /// </summary>
        [ImporterHeader(Name = "目标设备Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        public string TargetCode { get; set; }

        /// <summary>
        /// 目标位置
        /// </summary>
        [ImporterHeader(Name = "目标位置")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// 其他参数
        /// </summary>
        [ImporterHeader(Name = "其他参数")]
        public string OtherParams { get; set; }

        /// <summary>
        /// 数据备注
        /// </summary>
        [ImporterHeader(Name = "数据备注")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        public string DataDescribe { get; set; }
    }
}
