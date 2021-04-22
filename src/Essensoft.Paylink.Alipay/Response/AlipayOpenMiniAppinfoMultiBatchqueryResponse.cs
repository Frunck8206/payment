﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppinfoMultiBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppinfoMultiBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 多端应用信息
        /// </summary>
        [JsonPropertyName("app_base_info_list")]
        public List<MultiAppBaseInfoDto> AppBaseInfoList { get; set; }
    }
}
