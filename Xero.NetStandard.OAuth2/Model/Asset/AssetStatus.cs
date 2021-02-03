/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.8.4
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// See Asset Status Codes.
    /// </summary>
    /// <value>See Asset Status Codes.</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum AssetStatus
    {
        /// <summary>
        /// Enum Draft for value: Draft
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft = 1,

        /// <summary>
        /// Enum Registered for value: Registered
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered = 2,

        /// <summary>
        /// Enum Disposed for value: Disposed
        /// </summary>
        [EnumMember(Value = "Disposed")]
        Disposed = 3

    }

}
