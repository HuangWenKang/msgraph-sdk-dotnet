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
    /// The type Managed Android Lob App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAndroidLobApp : ManagedMobileLobApp
    {
    
        /// <summary>
        /// Gets or sets identity name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityName", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityName { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSupportedOperatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
    }
}

