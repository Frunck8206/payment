﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseGroupQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseGroupQueryModel : AlipayObject
    {
        /// <summary>
        /// 群的id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
