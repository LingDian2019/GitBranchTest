using System.ComponentModel.DataAnnotations.Schema;
using FrameworkCoreDatabase;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 异常口配置
    /// </summary>
    [Table("WCSExceptionExitConfig")]
    [EntityAutomaticRegister(Entity = typeof(ExceptionExitConfig), TableName = "WCSExceptionExitConfig")]
    public class ExceptionExitConfig : SQLServerTableStringEntityBase
    {
        /// <summary>
        /// 申请站台
        /// </summary>
        [Column("CurrentStation")]
        public string CurrentStation { get; set; }

        /// <summary>
        /// 异常口
        /// </summary>
        [Column("ExceptionExit")]
        public string ExceptionExit { get; set; }

        /// <summary>
        /// 仓库Code
        /// </summary>
        [Column("WarehouseCode")]
        public string WarehouseCode { get; set; }
    }
}
