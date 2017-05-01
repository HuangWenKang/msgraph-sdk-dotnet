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
    /// The type WorkbookFunctionsTimeRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsTimeRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsTimeRequest>, IWorkbookFunctionsTimeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsTimeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="hour">A hour parameter for the OData method call.</param>
        /// <param name="minute">A minute parameter for the OData method call.</param>
        /// <param name="second">A second parameter for the OData method call.</param>
        public WorkbookFunctionsTimeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken hour,
            Newtonsoft.Json.Linq.JToken minute,
            Newtonsoft.Json.Linq.JToken second)
            : base(requestUrl, client)
        {
            this.SetParameter("hour", hour, true);
            this.SetParameter("minute", minute, true);
            this.SetParameter("second", second, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsTimeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsTimeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("hour"))
            {
                request.RequestBody.Hour = this.GetParameter<Newtonsoft.Json.Linq.JToken>("hour");
            }

            if (this.HasParameter("minute"))
            {
                request.RequestBody.Minute = this.GetParameter<Newtonsoft.Json.Linq.JToken>("minute");
            }

            if (this.HasParameter("second"))
            {
                request.RequestBody.Second = this.GetParameter<Newtonsoft.Json.Linq.JToken>("second");
            }

            return request;
        }
    }
}
