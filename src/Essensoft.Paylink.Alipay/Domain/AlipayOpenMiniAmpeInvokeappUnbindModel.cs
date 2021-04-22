﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeInvokeappUnbindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeInvokeappUnbindModel : AlipayObject
    {
        /// <summary>
        /// 产品ID列表
        /// </summary>
        [JsonPropertyName("product_id_list")]
        public List<long> ProductIdList { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
