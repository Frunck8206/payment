﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeSendQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeSendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中奖信息列表
        /// </summary>
        [JsonPropertyName("prize_detail_list")]
        public List<PrizeDetail> PrizeDetailList { get; set; }
    }
}
