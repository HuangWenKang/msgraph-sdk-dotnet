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
    /// The interface IAndroidForWorkNineWorkEasConfigurationRequest.
    /// </summary>
    public partial interface IAndroidForWorkNineWorkEasConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkNineWorkEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkNineWorkEasConfigurationToCreate">The AndroidForWorkNineWorkEasConfiguration to create.</param>
        /// <returns>The created AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> CreateAsync(AndroidForWorkNineWorkEasConfiguration androidForWorkNineWorkEasConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkNineWorkEasConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkNineWorkEasConfigurationToCreate">The AndroidForWorkNineWorkEasConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> CreateAsync(AndroidForWorkNineWorkEasConfiguration androidForWorkNineWorkEasConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkNineWorkEasConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkNineWorkEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkNineWorkEasConfiguration.
        /// </summary>
        /// <returns>The AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkNineWorkEasConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkNineWorkEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkNineWorkEasConfigurationToUpdate">The AndroidForWorkNineWorkEasConfiguration to update.</param>
        /// <returns>The updated AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> UpdateAsync(AndroidForWorkNineWorkEasConfiguration androidForWorkNineWorkEasConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkNineWorkEasConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkNineWorkEasConfigurationToUpdate">The AndroidForWorkNineWorkEasConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidForWorkNineWorkEasConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkNineWorkEasConfiguration> UpdateAsync(AndroidForWorkNineWorkEasConfiguration androidForWorkNineWorkEasConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkNineWorkEasConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkNineWorkEasConfigurationRequest Expand(Expression<Func<AndroidForWorkNineWorkEasConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkNineWorkEasConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkNineWorkEasConfigurationRequest Select(Expression<Func<AndroidForWorkNineWorkEasConfiguration, object>> selectExpression);

    }
}
