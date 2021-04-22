﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopModifyResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 门店创建返回的结果
        /// </summary>
        [JsonPropertyName("logistics_shop_status")]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }
    }
}
