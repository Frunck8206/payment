﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MonitorHeartbeatSynResponse.
    /// </summary>
    public class MonitorHeartbeatSynResponse : AlipayResponse
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
