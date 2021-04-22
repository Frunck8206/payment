﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiModelCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiModelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模型id
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }
    }
}
