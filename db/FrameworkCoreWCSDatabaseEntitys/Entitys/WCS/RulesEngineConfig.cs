using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 规则引擎配置
    /// </summary>
    [Table("WCSRulesEngineConfig")]
    [EntityAutomaticRegister(Entity = typeof(RulesEngineConfig), TableName = "WCSRulesEngineConfig")]
    public class RulesEngineConfig : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("EquipmentID")]
        public string EquipmentID { get; set; }

        /// <summary>
        /// 驱动id
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MinLength(32, ErrorMessage = "{0}最小长度32个字符")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("DriverID")]
        public string DriverID { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [Column("ActivateStatus")]
        public int ActivateStatus { get; set; }

        /// <summary>
        /// 规则引擎配置
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("RuleName")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则引擎配置描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("RuleNameDescribe")]
        public string RuleNameDescribe { get; set; }

        /// <summary>
        /// 表达式
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(500, ErrorMessage = "{0}最大长度500个字符")]
        [Column("Expression")]
        public string Expression { get; set; }

        /// <summary>
        /// 表达式匹配消息
        /// </summary>
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0}不能为空")]
        [MaxLength(500, ErrorMessage = "{0}最大长度500个字符")]
        [Column("ExpressionMessage")]
        public string ExpressionMessage { get; set; } = string.Empty;
    }
}
