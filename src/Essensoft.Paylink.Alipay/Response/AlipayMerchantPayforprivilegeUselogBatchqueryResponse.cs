﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUselogBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUselogBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠使用记录
        /// </summary>
        [JsonPropertyName("use_log_list")]
        public List<PayForPrivilegeRechargeCardUseLog> UseLogList { get; set; }
    }
}
