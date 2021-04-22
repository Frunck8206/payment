﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntfortuneYebAssetTradeUnfreezeResponse.
    /// </summary>
    public class AntfortuneYebAssetTradeUnfreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
