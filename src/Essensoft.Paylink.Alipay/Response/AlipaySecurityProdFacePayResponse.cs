﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFacePayResponse.
    /// </summary>
    public class AlipaySecurityProdFacePayResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("aa")]
        public string Aa { get; set; }
    }
}
