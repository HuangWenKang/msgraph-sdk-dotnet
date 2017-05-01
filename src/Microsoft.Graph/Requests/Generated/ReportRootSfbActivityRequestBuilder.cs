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
    /// The type ReportRootSfbActivityRequestBuilder.
    /// </summary>
    public partial class ReportRootSfbActivityRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootSfbActivityRequest>, IReportRootSfbActivityRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootSfbActivityRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="view">A view parameter for the OData method call.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        /// <param name="date">A date parameter for the OData method call.</param>
        public ReportRootSfbActivityRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ViewType view,
            PeriodType? period,
            string date)
            : base(requestUrl, client)
        {
            this.SetParameter("view", view, false);
            this.SetParameter("period", period, true);
            this.SetParameter("date", date, true);
        }

        /// <summary>
        /// Constructs a new <see cref="ReportRootSfbActivityRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="view">A view parameter for the OData method call.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        public ReportRootSfbActivityRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ViewType view,
            PeriodType period)
            : base(requestUrl, client)
        {
            this.SetParameter("view", view, false);
            this.SetParameter("period", period, false);
        }

        /// <summary>
        /// Constructs a new <see cref="ReportRootSfbActivityRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="view">A view parameter for the OData method call.</param>
        /// <param name="date">A date parameter for the OData method call.</param>
        public ReportRootSfbActivityRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ViewType view,
            string date)
            : base(requestUrl, client)
        {
            this.SetParameter("view", view, false);
            this.SetParameter("date", date, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootSfbActivityRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootSfbActivityRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
