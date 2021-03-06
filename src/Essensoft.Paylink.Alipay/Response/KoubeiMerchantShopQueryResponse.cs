﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantShopQueryResponse.
    /// </summary>
    public class KoubeiMerchantShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据商户pid查询门店模型列表
        /// </summary>
        [JsonPropertyName("city_shop_models")]
        public List<CityShopModel> CityShopModels { get; set; }
    }
}
