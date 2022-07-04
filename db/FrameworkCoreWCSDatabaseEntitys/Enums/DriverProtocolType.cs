using System.ComponentModel;

namespace FrameworkCoreWCSDatabaseEntitys
{
    /// <summary>
    /// 驱动协议类型
    /// </summary>
    public enum DriverProtocolType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknown = 1,

        /// <summary>
        /// Socket客户端
        /// </summary>
        [Description("Socket客户端")]
        SocketClient = 2,

        /// <summary>
        /// Socket服务端
        /// </summary>
        [Description("Socket服务端")]
        SocketServer = 3,

        /// <summary>
        /// 西门子S7网络协议
        /// </summary>
        [Description("西门子S7网络协议")]
        SiemensS7Net = 4,

        /// <summary>
        /// OpcUa客户端
        /// </summary>
        [Description("OpcUa客户端")]
        OpcUaClient = 5,
    }
}
