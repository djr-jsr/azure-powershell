// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PowerShell;

    /// <summary>The policy exemption for Patch request.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyExemptionUpdateTypeConverter))]
    public partial class PolicyExemptionUpdate
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyExemptionUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PolicyExemptionUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyExemptionUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PolicyExemptionUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyExemptionUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceSelector"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).ResourceSelector = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[]) content.GetValueForProperty("ResourceSelector",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).ResourceSelector, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector>(__y, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.ResourceSelectorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssignmentScopeValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).AssignmentScopeValidation = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation?) content.GetValueForProperty("AssignmentScopeValidation",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).AssignmentScopeValidation, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyExemptionUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceSelector"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).ResourceSelector = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[]) content.GetValueForProperty("ResourceSelector",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).ResourceSelector, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector>(__y, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.ResourceSelectorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssignmentScopeValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).AssignmentScopeValidation = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation?) content.GetValueForProperty("AssignmentScopeValidation",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal)this).AssignmentScopeValidation, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The policy exemption for Patch request.
    [System.ComponentModel.TypeConverter(typeof(PolicyExemptionUpdateTypeConverter))]
    public partial interface IPolicyExemptionUpdate

    {

    }
}