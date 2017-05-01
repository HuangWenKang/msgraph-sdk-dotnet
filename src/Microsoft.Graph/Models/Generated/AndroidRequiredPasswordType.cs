// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidRequiredPasswordType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidRequiredPasswordType
    {
    
        /// <summary>
        /// device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// alphabetic
        /// </summary>
        Alphabetic = 1,
	
        /// <summary>
        /// alphanumeric
        /// </summary>
        Alphanumeric = 2,
	
        /// <summary>
        /// alphanumeric With Symbols
        /// </summary>
        AlphanumericWithSymbols = 3,
	
        /// <summary>
        /// low Security Biometric
        /// </summary>
        LowSecurityBiometric = 4,
	
        /// <summary>
        /// numeric
        /// </summary>
        Numeric = 5,
	
        /// <summary>
        /// numeric Complex
        /// </summary>
        NumericComplex = 6,
	
    }
}
