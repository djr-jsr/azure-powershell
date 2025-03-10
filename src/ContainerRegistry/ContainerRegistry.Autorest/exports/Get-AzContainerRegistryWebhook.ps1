
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets the properties of the specified webhook.
.Description
Gets the properties of the specified webhook.
.Example
Get-AzContainerRegistryWebhook  -ResourceGroupName "MyResourceGroup" -RegistryName "RegistryExample" -Name "webhook001"
.Example
Get-AzContainerRegistryWebhook  -ResourceGroupName "MyResourceGroup" -RegistryName "RegistryExample"


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.IContainerRegistryIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhook
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IContainerRegistryIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the agent pool.
  [CacheRuleName <String>]: The name of the cache rule.
  [ConnectedRegistryName <String>]: The name of the connected registry.
  [CredentialSetName <String>]: The name of the credential set.
  [ExportPipelineName <String>]: The name of the export pipeline.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [ImportPipelineName <String>]: The name of the import pipeline.
  [PipelineRunName <String>]: The name of the pipeline run.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [RegistryName <String>]: The name of the container registry.
  [ReplicationName <String>]: The name of the replication.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RunId <String>]: The run ID.
  [ScopeMapName <String>]: The name of the scope map.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [TaskName <String>]: The name of the container registry task.
  [TaskRunName <String>]: The name of the task run.
  [TokenName <String>]: The name of the token.
  [WebhookName <String>]: The name of the webhook.

REGISTRY <IRegistry>: The Registry Object.
  Location <String>: The location of the resource. This cannot be changed after the resource is created.
  SkuName <SkuName>: The SKU name of the container registry. Required for registry creation.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource modification (UTC).
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <LastModifiedByType?>]: The type of identity that last modified the resource.
  [Tag <IResourceTags>]: The tags of the resource.
    [(Any) <String>]: This indicates any property can be added to this object.
  [AdminUserEnabled <Boolean?>]: The value that indicates whether the admin user is enabled.
  [AnonymousPullEnabled <Boolean?>]: Enables registry-wide pull from unauthenticated clients.
  [AzureAdAuthenticationAsArmPolicyStatus <AzureAdAuthenticationAsArmPolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [DataEndpointEnabled <Boolean?>]: Enable a single data endpoint per region for serving data.
  [EncryptionStatus <EncryptionStatus?>]: Indicates whether or not the encryption is enabled for container registry.
  [ExportPolicyStatus <ExportPolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [IdentityPrincipalId <String>]: The principal ID of resource identity.
  [IdentityTenantId <String>]: The tenant ID of resource.
  [IdentityType <ResourceIdentityType?>]: The identity type.
  [IdentityUserAssignedIdentity <IIdentityPropertiesUserAssignedIdentities>]: The list of user identities associated with the resource. The user identity         dictionary key references will be ARM resource ids in the form:         '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/             providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    [(Any) <IUserIdentityProperties>]: This indicates any property can be added to this object.
  [KeyVaultPropertyIdentity <String>]: The client id of the identity which will be used to access key vault.
  [KeyVaultPropertyKeyIdentifier <String>]: Key vault uri to access the encryption key.
  [NetworkRuleBypassOption <NetworkRuleBypassOptions?>]: Whether to allow trusted Azure services to access a network restricted registry.
  [NetworkRuleSetDefaultAction <DefaultAction?>]: The default action of allow or deny when no other rules match.
  [NetworkRuleSetIPRule <IIPRule[]>]: The IP ACL rules.
    IPAddressOrRange <String>: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
    [Action <Action?>]: The action of IP ACL rule.
  [PublicNetworkAccess <PublicNetworkAccess?>]: Whether or not public network access is allowed for the container registry.
  [QuarantinePolicyStatus <PolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [RetentionPolicyDay <Int32?>]: The number of days to retain an untagged manifest after which it gets purged.
  [RetentionPolicyStatus <PolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [SoftDeletePolicyRetentionDay <Int32?>]: The number of days after which a soft-deleted item is permanently deleted.
  [SoftDeletePolicyStatus <PolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [TrustPolicyStatus <PolicyStatus?>]: The value that indicates whether the policy is enabled or not.
  [TrustPolicyType <TrustPolicyType?>]: The type of trust policy.
  [ZoneRedundancy <ZoneRedundancy?>]: Whether or not zone redundancy is enabled for this container registry
.Link
https://learn.microsoft.com/powershell/module/az.containerregistry/get-azcontainerregistrywebhook
#>
function Get-AzContainerRegistryWebhook {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhook])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='List', Mandatory)]
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ContainerRegistryName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the container registry.
    ${RegistryName},

    [Parameter(ParameterSetName='List', Mandatory)]
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('WebhookName', 'ResourceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the webhook.
    ${Name},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.IContainerRegistryIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='GetByRegistry', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IRegistry]
    # The Registry Object.
    # To construct, see NOTES section for REGISTRY properties and create a hash table.
    ${Registry},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            List = 'Az.ContainerRegistry.custom\Get-AzContainerRegistryWebhook';
            Get = 'Az.ContainerRegistry.custom\Get-AzContainerRegistryWebhook';
            GetViaIdentity = 'Az.ContainerRegistry.custom\Get-AzContainerRegistryWebhook';
            GetByRegistry = 'Az.ContainerRegistry.custom\Get-AzContainerRegistryWebhook';
        }
        if (('List', 'Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
