﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppApiQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 应用可申请的接口出参敏感字段列表
        /// </summary>
        [JsonPropertyName("apis")]
        public List<AuthApiDTO> Apis { get; set; }
    }
}
