﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideOrderResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideOrderResponse : AlipayResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
