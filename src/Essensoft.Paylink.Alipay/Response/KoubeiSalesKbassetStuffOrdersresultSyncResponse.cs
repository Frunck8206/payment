﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffOrdersresultSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffOrdersresultSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 物料单据反馈结果
        /// </summary>
        [JsonPropertyName("orders_feedback_result")]
        public List<AccessOrdersFeedBackResult> OrdersFeedbackResult { get; set; }
    }
}
