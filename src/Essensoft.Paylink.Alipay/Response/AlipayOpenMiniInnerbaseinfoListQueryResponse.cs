﻿using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序列表
        /// </summary>
        [JsonPropertyName("mini_app_list")]
        public MiniAppBaseInfoQueryResponse MiniAppList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
