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
    /// The type WorkbookFunctionsReptRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsReptRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsReptRequest>, IWorkbookFunctionsReptRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsReptRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="text">A text parameter for the OData method call.</param>
        /// <param name="numberTimes">A numberTimes parameter for the OData method call.</param>
        public WorkbookFunctionsReptRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken text,
            Newtonsoft.Json.Linq.JToken numberTimes)
            : base(requestUrl, client)
        {
            this.SetParameter("text", text, true);
            this.SetParameter("numberTimes", numberTimes, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsReptRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsReptRequest(functionUrl, this.Client, options);

            if (this.HasParameter("text"))
            {
                request.RequestBody.Text = this.GetParameter<Newtonsoft.Json.Linq.JToken>("text");
            }

            if (this.HasParameter("numberTimes"))
            {
                request.RequestBody.NumberTimes = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numberTimes");
            }

            return request;
        }
    }
}
