// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>The result summary of an installation operation.</summary>
    public partial class MachineInstallPatchesResult
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IMachineInstallPatchesResult.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IMachineInstallPatchesResult.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IMachineInstallPatchesResult FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json ? new MachineInstallPatchesResult(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject into a new instance of <see cref="MachineInstallPatchesResult" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MachineInstallPatchesResult(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_errorDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject>("errorDetails"), out var __jsonErrorDetails) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api30.ErrorDetail.FromJson(__jsonErrorDetails) : ErrorDetail;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_installationActivityId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("installationActivityId"), out var __jsonInstallationActivityId) ? (string)__jsonInstallationActivityId : (string)InstallationActivityId;}
            {_rebootStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("rebootStatus"), out var __jsonRebootStatus) ? (string)__jsonRebootStatus : (string)RebootStatus;}
            {_maintenanceWindowExceeded = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonBoolean>("maintenanceWindowExceeded"), out var __jsonMaintenanceWindowExceeded) ? (bool?)__jsonMaintenanceWindowExceeded : MaintenanceWindowExceeded;}
            {_excludedPatchCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber>("excludedPatchCount"), out var __jsonExcludedPatchCount) ? (int?)__jsonExcludedPatchCount : ExcludedPatchCount;}
            {_notSelectedPatchCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber>("notSelectedPatchCount"), out var __jsonNotSelectedPatchCount) ? (int?)__jsonNotSelectedPatchCount : NotSelectedPatchCount;}
            {_pendingPatchCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber>("pendingPatchCount"), out var __jsonPendingPatchCount) ? (int?)__jsonPendingPatchCount : PendingPatchCount;}
            {_installedPatchCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber>("installedPatchCount"), out var __jsonInstalledPatchCount) ? (int?)__jsonInstalledPatchCount : InstalledPatchCount;}
            {_failedPatchCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber>("failedPatchCount"), out var __jsonFailedPatchCount) ? (int?)__jsonFailedPatchCount : FailedPatchCount;}
            {_startDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("startDateTime"), out var __jsonStartDateTime) ? global::System.DateTime.TryParse((string)__jsonStartDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartDateTimeValue) ? __jsonStartDateTimeValue : StartDateTime : StartDateTime;}
            {_lastModifiedDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("lastModifiedDateTime"), out var __jsonLastModifiedDateTime) ? global::System.DateTime.TryParse((string)__jsonLastModifiedDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedDateTimeValue) ? __jsonLastModifiedDateTimeValue : LastModifiedDateTime : LastModifiedDateTime;}
            {_startedBy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("startedBy"), out var __jsonStartedBy) ? (string)__jsonStartedBy : (string)StartedBy;}
            {_patchServiceUsed = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("patchServiceUsed"), out var __jsonPatchServiceUsed) ? (string)__jsonPatchServiceUsed : (string)PatchServiceUsed;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MachineInstallPatchesResult" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MachineInstallPatchesResult" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._errorDetail ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) this._errorDetail.ToJson(null,serializationMode) : null, "errorDetails" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._installationActivityId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._installationActivityId.ToString()) : null, "installationActivityId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._rebootStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._rebootStatus.ToString()) : null, "rebootStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._maintenanceWindowExceeded ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonBoolean((bool)this._maintenanceWindowExceeded) : null, "maintenanceWindowExceeded" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._excludedPatchCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber((int)this._excludedPatchCount) : null, "excludedPatchCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._notSelectedPatchCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber((int)this._notSelectedPatchCount) : null, "notSelectedPatchCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._pendingPatchCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber((int)this._pendingPatchCount) : null, "pendingPatchCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._installedPatchCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber((int)this._installedPatchCount) : null, "installedPatchCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._failedPatchCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNumber((int)this._failedPatchCount) : null, "failedPatchCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._startDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._startDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startDateTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastModifiedDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._lastModifiedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModifiedDateTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._startedBy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._startedBy.ToString()) : null, "startedBy" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._patchServiceUsed)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._patchServiceUsed.ToString()) : null, "patchServiceUsed" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}