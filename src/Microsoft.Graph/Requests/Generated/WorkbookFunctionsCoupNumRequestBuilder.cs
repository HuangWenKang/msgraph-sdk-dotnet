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
    /// The type WorkbookFunctionsCoupNumRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsCoupNumRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsCoupNumRequest>, IWorkbookFunctionsCoupNumRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsCoupNumRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="settlement">A settlement parameter for the OData method call.</param>
        /// <param name="maturity">A maturity parameter for the OData method call.</param>
        /// <param name="frequency">A frequency parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        public WorkbookFunctionsCoupNumRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken settlement,
            Newtonsoft.Json.Linq.JToken maturity,
            Newtonsoft.Json.Linq.JToken frequency,
            Newtonsoft.Json.Linq.JToken basis)
            : base(requestUrl, client)
        {
            this.SetParameter("settlement", settlement, true);
            this.SetParameter("maturity", maturity, true);
            this.SetParameter("frequency", frequency, true);
            this.SetParameter("basis", basis, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsCoupNumRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsCoupNumRequest(functionUrl, this.Client, options);

            if (this.HasParameter("settlement"))
            {
                request.RequestBody.Settlement = this.GetParameter<Newtonsoft.Json.Linq.JToken>("settlement");
            }

            if (this.HasParameter("maturity"))
            {
                request.RequestBody.Maturity = this.GetParameter<Newtonsoft.Json.Linq.JToken>("maturity");
            }

            if (this.HasParameter("frequency"))
            {
                request.RequestBody.Frequency = this.GetParameter<Newtonsoft.Json.Linq.JToken>("frequency");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<Newtonsoft.Json.Linq.JToken>("basis");
            }

            return request;
        }
    }
}
