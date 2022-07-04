using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// PLC 标签组
    /// </summary>
    [Table("WCSPLCTagGroup")]
    [EntityAutomaticRegister(Entity = typeof(PLCTagGroup), TableName = "WCSPLCTagGroup")]
    public class PLCTagGroup : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 驱动ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("DriverID")]
        public string DriverID { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(20, ErrorMessage = "{0}最大长度20个字符")]
        [Column("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 间隔周期，单位毫秒，默认200
        /// </summary>
        [Column("Period")]
        public int Period { get; set; } = 200;

        /// <summary>
        /// 最大读取大小
        /// </summary>
        [Column("MaxSize")]
        public int MaxSize { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [Column("ActivateStatus")]
        public int ActivateStatus { get; set; }
    }
}
