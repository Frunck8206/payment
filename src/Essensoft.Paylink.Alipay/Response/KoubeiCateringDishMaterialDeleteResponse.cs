﻿using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [JsonPropertyName("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
