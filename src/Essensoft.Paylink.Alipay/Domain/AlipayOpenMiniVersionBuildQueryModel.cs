﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionBuildQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，默认为支付宝端。支持  com.alipay.alipaywallet：支付宝端。com.alipay.iot.xpaas：IOT端。 例如投放到支付宝钱包是支付宝端。
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
