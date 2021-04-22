﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppApiresQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiresQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
