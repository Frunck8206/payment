﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionCreateModel : AlipayObject
    {
        /// <summary>
        /// 创建的版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonPropertyName("target_bundle_id")]
        public string TargetBundleId { get; set; }
    }
}
