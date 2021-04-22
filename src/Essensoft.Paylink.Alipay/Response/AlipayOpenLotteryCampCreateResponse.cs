﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampCreateResponse.
    /// </summary>
    public class AlipayOpenLotteryCampCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回新建的活动ID
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
