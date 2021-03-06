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
    /// The type Group Setting.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupSetting : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of this group of settings, which comes from the associated template.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets template id.
        /// Unique identifier for the template used to create this group of settings. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateId", Required = Newtonsoft.Json.Required.Default)]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Collection of name value pairs. Must contain and set all the settings defined in the template.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SettingValue> Values { get; set; }
    
    }
}

