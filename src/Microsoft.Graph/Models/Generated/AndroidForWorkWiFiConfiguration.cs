// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android For Work Wi Fi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkWiFiConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets network name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkName", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ssid", Required = Newtonsoft.Json.Required.Default)]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets connect automatically.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectAutomatically", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectWhenNetworkNameIsHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi security type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wiFiSecurityType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWiFiSecurityType? WiFiSecurityType { get; set; }
    
    }
}

