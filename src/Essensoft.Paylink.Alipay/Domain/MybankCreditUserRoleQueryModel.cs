﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditUserRoleQueryModel Data Structure.
    /// </summary>
    public class MybankCreditUserRoleQueryModel : AlipayObject
    {
        /// <summary>
        /// 站点会员信息
        /// </summary>
        [JsonPropertyName("member")]
        public Member Member { get; set; }
    }
}
