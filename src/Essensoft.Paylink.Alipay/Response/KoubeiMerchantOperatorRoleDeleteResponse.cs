﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除处理结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
