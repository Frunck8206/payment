﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppUserChargeinstQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppUserChargeinstQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
