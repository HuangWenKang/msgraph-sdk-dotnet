// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementComplianceSettingStateSummariesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementComplianceSettingStateSummariesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementComplianceSettingStateSummariesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementComplianceSettingStateSummariesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementComplianceSettingStateSummariesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementComplianceSettingStateSummariesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementComplianceSettingStateSummariesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementComplianceSettingStateSummariesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IComplianceSettingStateSummaryRequestBuilder"/> for the specified DeviceManagementComplianceSettingStateSummary.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementComplianceSettingStateSummary.</param>
        /// <returns>The <see cref="IComplianceSettingStateSummaryRequestBuilder"/>.</returns>
        public IComplianceSettingStateSummaryRequestBuilder this[string id]
        {
            get
            {
                return new ComplianceSettingStateSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
