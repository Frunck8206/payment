﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosShiftQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosShiftQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
