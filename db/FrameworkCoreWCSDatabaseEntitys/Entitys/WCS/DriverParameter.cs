using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// WCS驱动参数
    /// </summary>
    [Table("WCSDriverParameter")]
    [EntityAutomaticRegister(Entity = typeof(DriverParameter), TableName = "WCSDriverParameter")]
    public class DriverParameter : SQLServerTableStringEntityBase
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
        /// 属性名称
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("PropertyName")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("PropertyValue")]
        public string PropertyValue { get; set; }

        /// <summary>
        /// 参数组
        /// </summary>
        [Column("DriverParaGroup")]
        public int DriverParaGroup { get; set; }
        /// <summary>
        /// 属性描述
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(100, ErrorMessage = "{0}最大长度100个字符")]
        [Column("PropertyDescribe")]
        public string PropertyDescribe { get; set; }
    }
}
