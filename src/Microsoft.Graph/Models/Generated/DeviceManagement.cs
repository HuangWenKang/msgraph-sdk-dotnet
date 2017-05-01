// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets subscription state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTermsAndConditionsCollectionPage TermsAndConditions { get; set; }
    
        /// <summary>
        /// Gets or sets android for work settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkSettings", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkSettings AndroidForWorkSettings { get; set; }
    
        /// <summary>
        /// Gets or sets android for work app configuration schemas.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkAppConfigurationSchemas", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAndroidForWorkAppConfigurationSchemasCollectionPage AndroidForWorkAppConfigurationSchemas { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementEnrollmentProfilesCollectionPage EnrollmentProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets imported device identities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementImportedDeviceIdentitiesCollectionPage ImportedDeviceIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets imported apple device identities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedAppleDeviceIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementImportedAppleDeviceIdentitiesCollectionPage ImportedAppleDeviceIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets remote action audits.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteActionAudits", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRemoteActionAuditsCollectionPage RemoteActionAudits { get; set; }
    
        /// <summary>
        /// Gets or sets apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePushNotificationCertificate", Required = Newtonsoft.Json.Required.Default)]
        public ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets device configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationsCollectionPage DeviceConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePoliciesCollectionPage DeviceCompliancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets software update status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdateStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy device state summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyDeviceStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets compliance setting state summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceSettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementComplianceSettingStateSummariesCollectionPage ComplianceSettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration device state summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationDeviceStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCategoriesCollectionPage DeviceCategories { get; set; }
    
        /// <summary>
        /// Gets or sets exchange connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementExchangeConnectorsCollectionPage ExchangeConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets exchange on premises policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeOnPremisesPolicy", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementExchangeOnPremisesPolicy ExchangeOnPremisesPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets mobile threat defense connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileThreatDefenseConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementMobileThreatDefenseConnectorsCollectionPage MobileThreatDefenseConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets notification message templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationMessageTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementNotificationMessageTemplatesCollectionPage NotificationMessageTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets resource operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceOperations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementResourceOperationsCollectionPage ResourceOperations { get; set; }
    
        /// <summary>
        /// Gets or sets telecom expense management partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "telecomExpenseManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionPage TelecomExpenseManagementPartners { get; set; }
    
    }
}

