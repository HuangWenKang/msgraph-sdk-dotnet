// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagedDeviceRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DeviceConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder DeviceConfigurationStates { get; }

        /// <summary>
        /// Gets the request builder for DetectedApps.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder"/>.</returns>
        IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder DetectedApps { get; }

        /// <summary>
        /// Gets the request builder for DeviceCategory.
        /// </summary>
        /// <returns>The <see cref="IDeviceCategoryRequestBuilder"/>.</returns>
        IDeviceCategoryRequestBuilder DeviceCategory { get; }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder DeviceCompliancePolicyStates { get; }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceRetire.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRetireRequestBuilder"/>.</returns>
        IManagedDeviceRetireRequestBuilder Retire();

        /// <summary>
        /// Gets the request builder for ManagedDeviceWipe.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWipeRequestBuilder"/>.</returns>
        IManagedDeviceWipeRequestBuilder Wipe();

        /// <summary>
        /// Gets the request builder for ManagedDeviceResetPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceResetPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceResetPasscodeRequestBuilder ResetPasscode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRemoteLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRemoteLockRequestBuilder"/>.</returns>
        IManagedDeviceRemoteLockRequestBuilder RemoteLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceEnableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceEnableLostModeRequestBuilder"/>.</returns>
        IManagedDeviceEnableLostModeRequestBuilder EnableLostMode(
            string message = null,
            string phoneNumber = null,
            string footer = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceDisableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDisableLostModeRequestBuilder"/>.</returns>
        IManagedDeviceDisableLostModeRequestBuilder DisableLostMode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceLocateDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLocateDeviceRequestBuilder"/>.</returns>
        IManagedDeviceLocateDeviceRequestBuilder LocateDevice();

        /// <summary>
        /// Gets the request builder for ManagedDeviceBypassActivationLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBypassActivationLockRequestBuilder"/>.</returns>
        IManagedDeviceBypassActivationLockRequestBuilder BypassActivationLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRebootNow.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRebootNowRequestBuilder"/>.</returns>
        IManagedDeviceRebootNowRequestBuilder RebootNow();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRecoverPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRecoverPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceRecoverPasscodeRequestBuilder RecoverPasscode();
    
    }
}
