// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type NotebookRequestBuilder.
    /// </summary>
    public partial class NotebookRequestBuilder : EntityRequestBuilder, INotebookRequestBuilder
    {

        /// <summary>
        /// Constructs a new NotebookRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotebookRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new INotebookRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new INotebookRequest Request(IEnumerable<Option> options)
        {
            return new NotebookRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Sections.
        /// </summary>
        /// <returns>The <see cref="INotebookSectionsCollectionRequestBuilder"/>.</returns>
        public INotebookSectionsCollectionRequestBuilder Sections
        {
            get
            {
                return new NotebookSectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SectionGroups.
        /// </summary>
        /// <returns>The <see cref="INotebookSectionGroupsCollectionRequestBuilder"/>.</returns>
        public INotebookSectionGroupsCollectionRequestBuilder SectionGroups
        {
            get
            {
                return new NotebookSectionGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sectionGroups"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for NotebookCopyNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookCopyNotebookRequestBuilder"/>.</returns>
        public INotebookCopyNotebookRequestBuilder CopyNotebook(
            string groupId = null,
            string renameAs = null,
            string notebookFolder = null)
        {
            return new NotebookCopyNotebookRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.CopyNotebook"),
                this.Client,
                groupId,
                renameAs,
                notebookFolder);
        }

        /// <summary>
        /// Gets the request builder for NotebookExportNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookExportNotebookRequestBuilder"/>.</returns>
        public INotebookExportNotebookRequestBuilder ExportNotebook()
        {
            return new NotebookExportNotebookRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.ExportNotebook"),
                this.Client);
        }
    
    }
}
