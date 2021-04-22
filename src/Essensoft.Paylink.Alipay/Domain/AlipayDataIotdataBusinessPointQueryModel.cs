﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("business_id")]
        public long BusinessId { get; set; }
    }
}
