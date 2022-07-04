using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 流量阀值配置
    /// </summary>
    [Table("WCSTrafficThresholdConfig")]
    [EntityAutomaticRegister(Entity = typeof(TrafficThresholdConfig), TableName = "WCSTrafficThresholdConfig")]
    public class TrafficThresholdConfig : SQLServerTableStringEntityBase
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
        /// 阈值Key，一般是任务类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(50, ErrorMessage = "{0}最大长度50个字符")]
        [Column("ThresholdKey")]
        public string ThresholdKey { get; set; }

        /// <summary>
        /// 阈值描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("ThresholdDescribe")]
        public string ThresholdDescribe { get; set; }

        /// <summary>
        /// 最大数量
        /// </summary>
        [Column("MaxQuantity")]
        public int MaxQuantity { get; set; }
    }
}
