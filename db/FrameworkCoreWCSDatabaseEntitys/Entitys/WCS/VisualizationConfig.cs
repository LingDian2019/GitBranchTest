using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 看板配置表
    /// </summary>
    [Table("WCSVisualizationConfig")]
    [EntityAutomaticRegister(Entity = typeof(VisualizationConfig), TableName = "WCSVisualizationConfig")]
    public class VisualizationConfig : StringEntityBase
    {
        /// <summary>
        /// 仓库ID
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [MaxLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [MinLength(32, ErrorMessage = "{0}最大长度32个字符")]
        [Column("WarehouseID")]
        public string WarehouseID { get; set; }

        /// <summary>
        /// 看板名称
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("VisualizationName")]
        public string VisualizationName { get; set; }

        /// <summary>
        /// 看板类型
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("VisualizationType")]
        public int VisualizationType { get; set; }

        /// <summary>
        /// 看板地址    
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("VisualizationAddress")]
        public string VisualizationAddress { get; set; }

        /// <summary>
        /// 看板内容
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}不能为空")]
        [Column("VisualizationContent")]
        public string VisualizationContent { get; set; }
    }
}
