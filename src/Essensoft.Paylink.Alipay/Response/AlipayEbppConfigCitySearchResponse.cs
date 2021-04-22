﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppConfigCitySearchResponse.
    /// </summary>
    public class AlipayEbppConfigCitySearchResponse : AlipayResponse
    {
        /// <summary>
        /// 接口主要输出参数列表: AreaInfoResult{List{ areaInfo：{province, cityList<String>}} }
        /// </summary>
        [JsonPropertyName("area_info_result")]
        public List<AreaInfo> AreaInfoResult { get; set; }
    }
}
