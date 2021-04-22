﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSnapshotBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSnapshotBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 股票唯一编码，symbol=code.market
        /// </summary>
        [JsonPropertyName("symbols")]
        public List<string> Symbols { get; set; }
    }
}
