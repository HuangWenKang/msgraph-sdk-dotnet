// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder.
    /// </summary>
    public partial class EnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder : BaseActionMethodRequestBuilder<IEnrollmentProfileUpdateDeviceProfileAssignmentRequest>, IEnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="deviceIds">A deviceIds parameter for the OData method call.</param>
        public EnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<string> deviceIds)
            : base(requestUrl, client)
        {
            this.SetParameter("deviceIds", deviceIds, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEnrollmentProfileUpdateDeviceProfileAssignmentRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new EnrollmentProfileUpdateDeviceProfileAssignmentRequest(functionUrl, this.Client, options);

            if (this.HasParameter("deviceIds"))
            {
                request.RequestBody.DeviceIds = this.GetParameter<IEnumerable<string>>("deviceIds");
            }

            return request;
        }
    }
}
