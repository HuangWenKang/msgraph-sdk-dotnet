// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookWorksheetsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookWorksheetsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookWorksheetsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookWorksheetsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookWorksheetRequestBuilder"/> for the specified WorkbookWorksheet.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorksheet.</param>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        IWorkbookWorksheetRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetAddRequestBuilder"/>.</returns>
        IWorkbookWorksheetAddRequestBuilder Add(
            string name = null);
    }
}
