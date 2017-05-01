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
    /// The type Task.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Task : Entity
    {
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedTo", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets plan id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planId", Required = Newtonsoft.Json.Required.Default)]
        public string PlanId { get; set; }
    
        /// <summary>
        /// Gets or sets bucket id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bucketId", Required = Newtonsoft.Json.Required.Default)]
        public string BucketId { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets order hint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderHint", Required = Newtonsoft.Json.Required.Default)]
        public string OrderHint { get; set; }
    
        /// <summary>
        /// Gets or sets assignee priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assigneePriority", Required = Newtonsoft.Json.Required.Default)]
        public string AssigneePriority { get; set; }
    
        /// <summary>
        /// Gets or sets percent complete.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "percentComplete", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PercentComplete { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assigned date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assigned by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedBy", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedBy { get; set; }
    
        /// <summary>
        /// Gets or sets due date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dueDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasDescription", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasDescription { get; set; }
    
        /// <summary>
        /// Gets or sets preview type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewType", Required = Newtonsoft.Json.Required.Default)]
        public PreviewType? PreviewType { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets applied categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedCategories", Required = Newtonsoft.Json.Required.Default)]
        public AppliedCategoriesCollection AppliedCategories { get; set; }
    
        /// <summary>
        /// Gets or sets conversation thread id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversationThreadId", Required = Newtonsoft.Json.Required.Default)]
        public string ConversationThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "details", Required = Newtonsoft.Json.Required.Default)]
        public TaskDetails Details { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to task board format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedToTaskBoardFormat", Required = Newtonsoft.Json.Required.Default)]
        public TaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
    
        /// <summary>
        /// Gets or sets progress task board format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "progressTaskBoardFormat", Required = Newtonsoft.Json.Required.Default)]
        public TaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
    
        /// <summary>
        /// Gets or sets bucket task board format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bucketTaskBoardFormat", Required = Newtonsoft.Json.Required.Default)]
        public TaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
    
    }
}

