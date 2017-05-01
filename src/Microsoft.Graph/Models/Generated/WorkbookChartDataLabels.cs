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
    /// The type Workbook Chart Data Labels.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartDataLabels : Entity
    {
    
        /// <summary>
        /// Gets or sets position.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "position", Required = Newtonsoft.Json.Required.Default)]
        public string Position { get; set; }
    
        /// <summary>
        /// Gets or sets separator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "separator", Required = Newtonsoft.Json.Required.Default)]
        public string Separator { get; set; }
    
        /// <summary>
        /// Gets or sets show bubble size.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showBubbleSize", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowBubbleSize { get; set; }
    
        /// <summary>
        /// Gets or sets show category name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showCategoryName", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowCategoryName { get; set; }
    
        /// <summary>
        /// Gets or sets show legend key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showLegendKey", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowLegendKey { get; set; }
    
        /// <summary>
        /// Gets or sets show percentage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showPercentage", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets show series name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showSeriesName", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowSeriesName { get; set; }
    
        /// <summary>
        /// Gets or sets show value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showValue", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowValue { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartDataLabelFormat Format { get; set; }
    
    }
}

