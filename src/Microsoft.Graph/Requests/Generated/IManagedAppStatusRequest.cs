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
    /// The interface IManagedAppStatusRequest.
    /// </summary>
    public partial interface IManagedAppStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppStatus using PUT.
        /// </summary>
        /// <param name="managedAppStatusToCreate">The ManagedAppStatus to create.</param>
        /// <returns>The created ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> CreateAsync(ManagedAppStatus managedAppStatusToCreate);        /// <summary>
        /// Creates the specified ManagedAppStatus using PUT.
        /// </summary>
        /// <param name="managedAppStatusToCreate">The ManagedAppStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> CreateAsync(ManagedAppStatus managedAppStatusToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppStatus.
        /// </summary>
        /// <returns>The ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppStatus using PATCH.
        /// </summary>
        /// <param name="managedAppStatusToUpdate">The ManagedAppStatus to update.</param>
        /// <returns>The updated ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> UpdateAsync(ManagedAppStatus managedAppStatusToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppStatus using PATCH.
        /// </summary>
        /// <param name="managedAppStatusToUpdate">The ManagedAppStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedAppStatus.</returns>
        System.Threading.Tasks.Task<ManagedAppStatus> UpdateAsync(ManagedAppStatus managedAppStatusToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRequest Expand(Expression<Func<ManagedAppStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRequest Select(Expression<Func<ManagedAppStatus, object>> selectExpression);

    }
}
