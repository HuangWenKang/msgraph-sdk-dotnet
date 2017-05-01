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
    /// The type WorkbookFunctionsIsTextRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsIsTextRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsIsTextRequest>, IWorkbookFunctionsIsTextRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsIsTextRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="value">A value parameter for the OData method call.</param>
        public WorkbookFunctionsIsTextRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken value)
            : base(requestUrl, client)
        {
            this.SetParameter("value", value, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsIsTextRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsIsTextRequest(functionUrl, this.Client, options);

            if (this.HasParameter("value"))
            {
                request.RequestBody.Value = this.GetParameter<Newtonsoft.Json.Linq.JToken>("value");
            }

            return request;
        }
    }
}
