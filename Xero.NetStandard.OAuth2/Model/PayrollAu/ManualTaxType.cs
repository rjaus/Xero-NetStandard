/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.1.2
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines ManualTaxType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ManualTaxType
    {
        /// <summary>
        /// Enum PAYGMANUAL for value: PAYGMANUAL
        /// </summary>
        [EnumMember(Value = "PAYGMANUAL")]
        PAYGMANUAL = 1,

        /// <summary>
        /// Enum ETPOMANUAL for value: ETPOMANUAL
        /// </summary>
        [EnumMember(Value = "ETPOMANUAL")]
        ETPOMANUAL = 2,

        /// <summary>
        /// Enum ETPRMANUAL for value: ETPRMANUAL
        /// </summary>
        [EnumMember(Value = "ETPRMANUAL")]
        ETPRMANUAL = 3

    }

}
