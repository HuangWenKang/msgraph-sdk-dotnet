// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITaskBoardTaskFormatRequest.
    /// </summary>
    public partial interface ITaskBoardTaskFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TaskBoardTaskFormat using PUT.
        /// </summary>
        /// <param name="taskBoardTaskFormatToCreate">The TaskBoardTaskFormat to create.</param>
        /// <returns>The created TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> CreateAsync(TaskBoardTaskFormat taskBoardTaskFormatToCreate);        /// <summary>
        /// Creates the specified TaskBoardTaskFormat using PUT.
        /// </summary>
        /// <param name="taskBoardTaskFormatToCreate">The TaskBoardTaskFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> CreateAsync(TaskBoardTaskFormat taskBoardTaskFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TaskBoardTaskFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TaskBoardTaskFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TaskBoardTaskFormat.
        /// </summary>
        /// <returns>The TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> GetAsync();

        /// <summary>
        /// Gets the specified TaskBoardTaskFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TaskBoardTaskFormat using PATCH.
        /// </summary>
        /// <param name="taskBoardTaskFormatToUpdate">The TaskBoardTaskFormat to update.</param>
        /// <returns>The updated TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> UpdateAsync(TaskBoardTaskFormat taskBoardTaskFormatToUpdate);

        /// <summary>
        /// Updates the specified TaskBoardTaskFormat using PATCH.
        /// </summary>
        /// <param name="taskBoardTaskFormatToUpdate">The TaskBoardTaskFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TaskBoardTaskFormat.</returns>
        System.Threading.Tasks.Task<TaskBoardTaskFormat> UpdateAsync(TaskBoardTaskFormat taskBoardTaskFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaskBoardTaskFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITaskBoardTaskFormatRequest Expand(Expression<Func<TaskBoardTaskFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITaskBoardTaskFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITaskBoardTaskFormatRequest Select(Expression<Func<TaskBoardTaskFormat, object>> selectExpression);

    }
}
