﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenLotteryCampBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [JsonPropertyName("env")]
        public string Env { get; set; }
    }
}
