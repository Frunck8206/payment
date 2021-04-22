﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchQueryResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [JsonPropertyName("task_flow_list")]
        public List<InsSceneTaskFlowDTO> TaskFlowList { get; set; }
    }
}
