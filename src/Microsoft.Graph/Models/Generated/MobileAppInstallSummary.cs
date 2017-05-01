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
    /// The type Mobile App Install Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppInstallSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets installed device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notInstalledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotInstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets installed user count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstalledUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed user count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed user count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notInstalledUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotInstalledUserCount { get; set; }
    
    }
}

