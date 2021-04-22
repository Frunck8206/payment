﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 仪表盘访问地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
