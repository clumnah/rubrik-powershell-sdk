// New-RscQueryAzureO365.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'AzureO365' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryAzureO365 is a master cmdlet for AzureO365 work that can invoke any of the following subcommands: Exocompute, CheckStorageAccountName, CheckStorageAccountAccessibility, CheckSubscriptionQuota, CheckResourceGroupName, CheckVirtualNetworkName, ValidateUserRoles, CheckNSGOutboundRules, CheckNetworkSubnet, GetNetworkSubnetUnusedAddr, GetAzureHostType.
    /// </description>
    /// <example>
    /// <code>New-RscQueryAzureO365 -Exocompute [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckStorageAccountName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckStorageAccountAccessibility [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckSubscriptionQuota [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckResourceGroupName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckVirtualNetworkName [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -ValidateUserRoles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckNSGOutboundRules [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -CheckNetworkSubnet [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAzureO365 -GetAzureHostType [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryAzureO365",
        DefaultParameterSetName = "Exocompute")
    ]
    public class New_RscQueryAzureO365 : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Exocompute parameter set
        ///
        /// [GraphQL: azureO365Exocompute]
        /// </summary>
        [Parameter(
            ParameterSetName = "Exocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the exocompute details of the given cluster.
[GraphQL: azureO365Exocompute]",
            Position = 0
        )]
        public SwitchParameter Exocompute { get; set; }

        
        /// <summary>
        /// CheckStorageAccountName parameter set
        ///
        /// [GraphQL: azureO365CheckStorageAccountName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the storage account name.
[GraphQL: azureO365CheckStorageAccountName]",
            Position = 0
        )]
        public SwitchParameter CheckStorageAccountName { get; set; }

        
        /// <summary>
        /// CheckStorageAccountAccessibility parameter set
        ///
        /// [GraphQL: azureO365CheckStorageAccountAccessibility]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckStorageAccountAccessibility",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the accessibility of the storage account.
[GraphQL: azureO365CheckStorageAccountAccessibility]",
            Position = 0
        )]
        public SwitchParameter CheckStorageAccountAccessibility { get; set; }

        
        /// <summary>
        /// CheckSubscriptionQuota parameter set
        ///
        /// [GraphQL: azureO365CheckSubscriptionQuota]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckSubscriptionQuota",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the Azure subscription quota.
[GraphQL: azureO365CheckSubscriptionQuota]",
            Position = 0
        )]
        public SwitchParameter CheckSubscriptionQuota { get; set; }

        
        /// <summary>
        /// CheckResourceGroupName parameter set
        ///
        /// [GraphQL: azureO365CheckResourceGroupName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckResourceGroupName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the resource group name.
[GraphQL: azureO365CheckResourceGroupName]",
            Position = 0
        )]
        public SwitchParameter CheckResourceGroupName { get; set; }

        
        /// <summary>
        /// CheckVirtualNetworkName parameter set
        ///
        /// [GraphQL: azureO365CheckVirtualNetworkName]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckVirtualNetworkName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the virtual network name.
[GraphQL: azureO365CheckVirtualNetworkName]",
            Position = 0
        )]
        public SwitchParameter CheckVirtualNetworkName { get; set; }

        
        /// <summary>
        /// ValidateUserRoles parameter set
        ///
        /// [GraphQL: azureO365ValidateUserRoles]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateUserRoles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validates the user roles in the subscription.
[GraphQL: azureO365ValidateUserRoles]",
            Position = 0
        )]
        public SwitchParameter ValidateUserRoles { get; set; }

        
        /// <summary>
        /// CheckNSGOutboundRules parameter set
        ///
        /// [GraphQL: azureO365CheckNSGOutboundRules]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckNSGOutboundRules",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the NSG Outbound rules of the Azure resources.
[GraphQL: azureO365CheckNSGOutboundRules]",
            Position = 0
        )]
        public SwitchParameter CheckNSGOutboundRules { get; set; }

        
        /// <summary>
        /// CheckNetworkSubnet parameter set
        ///
        /// [GraphQL: azureO365CheckNetworkSubnet]
        /// </summary>
        [Parameter(
            ParameterSetName = "CheckNetworkSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks the network subnet of the Azure resources.
[GraphQL: azureO365CheckNetworkSubnet]",
            Position = 0
        )]
        public SwitchParameter CheckNetworkSubnet { get; set; }

        
        /// <summary>
        /// GetNetworkSubnetUnusedAddr parameter set
        ///
        /// [GraphQL: azureO365GetNetworkSubnetUnusedAddr]
        /// </summary>
        [Parameter(
            ParameterSetName = "GetNetworkSubnetUnusedAddr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the unused addresses available in a subnet.
[GraphQL: azureO365GetNetworkSubnetUnusedAddr]",
            Position = 0
        )]
        public SwitchParameter GetNetworkSubnetUnusedAddr { get; set; }

        
        /// <summary>
        /// GetAzureHostType parameter set
        ///
        /// [GraphQL: azureO365GetAzureHostType]
        /// </summary>
        [Parameter(
            ParameterSetName = "GetAzureHostType",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the AzureHostType of the account.
[GraphQL: azureO365GetAzureHostType]",
            Position = 0
        )]
        public SwitchParameter GetAzureHostType { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Exocompute":
                        this.ProcessRecord_Exocompute();
                        break;
                    case "CheckStorageAccountName":
                        this.ProcessRecord_CheckStorageAccountName();
                        break;
                    case "CheckStorageAccountAccessibility":
                        this.ProcessRecord_CheckStorageAccountAccessibility();
                        break;
                    case "CheckSubscriptionQuota":
                        this.ProcessRecord_CheckSubscriptionQuota();
                        break;
                    case "CheckResourceGroupName":
                        this.ProcessRecord_CheckResourceGroupName();
                        break;
                    case "CheckVirtualNetworkName":
                        this.ProcessRecord_CheckVirtualNetworkName();
                        break;
                    case "ValidateUserRoles":
                        this.ProcessRecord_ValidateUserRoles();
                        break;
                    case "CheckNSGOutboundRules":
                        this.ProcessRecord_CheckNSGOutboundRules();
                        break;
                    case "CheckNetworkSubnet":
                        this.ProcessRecord_CheckNetworkSubnet();
                        break;
                    case "GetNetworkSubnetUnusedAddr":
                        this.ProcessRecord_GetNetworkSubnetUnusedAddr();
                        break;
                    case "GetAzureHostType":
                        this.ProcessRecord_GetAzureHostType();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // azureO365Exocompute.
        internal void ProcessRecord_Exocompute()
        {
            this._logger.name += " -Exocompute";
            // Create new graphql operation azureO365Exocompute
            InitQueryAzureO365Exocompute();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountName.
        internal void ProcessRecord_CheckStorageAccountName()
        {
            this._logger.name += " -CheckStorageAccountName";
            // Create new graphql operation azureO365CheckStorageAccountName
            InitQueryAzureO365CheckStorageAccountName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountAccessibility.
        internal void ProcessRecord_CheckStorageAccountAccessibility()
        {
            this._logger.name += " -CheckStorageAccountAccessibility";
            // Create new graphql operation azureO365CheckStorageAccountAccessibility
            InitQueryAzureO365CheckStorageAccountAccessibility();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckSubscriptionQuota.
        internal void ProcessRecord_CheckSubscriptionQuota()
        {
            this._logger.name += " -CheckSubscriptionQuota";
            // Create new graphql operation azureO365CheckSubscriptionQuota
            InitQueryAzureO365CheckSubscriptionQuota();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckResourceGroupName.
        internal void ProcessRecord_CheckResourceGroupName()
        {
            this._logger.name += " -CheckResourceGroupName";
            // Create new graphql operation azureO365CheckResourceGroupName
            InitQueryAzureO365CheckResourceGroupName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckVirtualNetworkName.
        internal void ProcessRecord_CheckVirtualNetworkName()
        {
            this._logger.name += " -CheckVirtualNetworkName";
            // Create new graphql operation azureO365CheckVirtualNetworkName
            InitQueryAzureO365CheckVirtualNetworkName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365ValidateUserRoles.
        internal void ProcessRecord_ValidateUserRoles()
        {
            this._logger.name += " -ValidateUserRoles";
            // Create new graphql operation azureO365ValidateUserRoles
            InitQueryAzureO365ValidateUserRoles();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNSGOutboundRules.
        internal void ProcessRecord_CheckNSGOutboundRules()
        {
            this._logger.name += " -CheckNSGOutboundRules";
            // Create new graphql operation azureO365CheckNSGOutboundRules
            InitQueryAzureO365CheckNsgOutboundRules();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNetworkSubnet.
        internal void ProcessRecord_CheckNetworkSubnet()
        {
            this._logger.name += " -CheckNetworkSubnet";
            // Create new graphql operation azureO365CheckNetworkSubnet
            InitQueryAzureO365CheckNetworkSubnet();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetNetworkSubnetUnusedAddr.
        internal void ProcessRecord_GetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -GetNetworkSubnetUnusedAddr";
            // Create new graphql operation azureO365GetNetworkSubnetUnusedAddr
            InitQueryAzureO365GetNetworkSubnetUnusedAddr();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetAzureHostType.
        internal void ProcessRecord_GetAzureHostType()
        {
            this._logger.name += " -GetAzureHostType";
            // Create new graphql operation azureO365GetAzureHostType
            InitQueryAzureO365GetAzureHostType();
        }


        // Create new GraphQL Query:
        // azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!): GetAzureO365ExocomputeResp!
        internal void InitQueryAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365Exocompute",
                "($orgId: UUID!,$exocomputeClusterId: String!)",
                "GetAzureO365ExocomputeResp",
                Query.AzureO365Exocompute_ObjectFieldSpec,
                Query.AzureO365ExocomputeFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckStorageAccountName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckStorageAccountName",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckStorageAccountName_ObjectFieldSpec,
                Query.AzureO365CheckStorageAccountNameFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckStorageAccountAccessibility(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     storage_account_name: String!
        //     groupName: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckStorageAccountAccessibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
                Tuple.Create("groupName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckStorageAccountAccessibility",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!,$groupName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckStorageAccountAccessibility_ObjectFieldSpec,
                Query.AzureO365CheckStorageAccountAccessibilityFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckSubscriptionQuota()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckSubscriptionQuota",
                "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckSubscriptionQuota_ObjectFieldSpec,
                Query.AzureO365CheckSubscriptionQuotaFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckResourceGroupName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckResourceGroupName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckResourceGroupName_ObjectFieldSpec,
                Query.AzureO365CheckResourceGroupNameFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckVirtualNetworkName(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     groupName: String!
        //     vnet_name: String!
        //   ): AzureResourceAvailabilityResp!
        internal void InitQueryAzureO365CheckVirtualNetworkName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckVirtualNetworkName",
                "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!,$vnet_name: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckVirtualNetworkName_ObjectFieldSpec,
                Query.AzureO365CheckVirtualNetworkNameFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        internal void InitQueryAzureO365ValidateUserRoles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365ValidateUserRoles",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "AzureUserRoleResp",
                Query.AzureO365ValidateUserRoles_ObjectFieldSpec,
                Query.AzureO365ValidateUserRolesFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckNSGOutboundRules(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //   ): AzureNetworkSecurityGroupResp!
        internal void InitQueryAzureO365CheckNsgOutboundRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckNsgOutboundRules",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!)",
                "AzureNetworkSecurityGroupResp",
                Query.AzureO365CheckNsgOutboundRules_ObjectFieldSpec,
                Query.AzureO365CheckNsgOutboundRulesFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // azureO365CheckNetworkSubnet(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetResp!
        internal void InitQueryAzureO365CheckNetworkSubnet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckNetworkSubnet",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                "AzureNetworkSubnetResp",
                Query.AzureO365CheckNetworkSubnet_ObjectFieldSpec,
                Query.AzureO365CheckNetworkSubnetFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
# REQUIRED
$inputs.Var.strict_addr_check = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // azureO365GetNetworkSubnetUnusedAddr(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetUnusedAddrResp!
        internal void InitQueryAzureO365GetNetworkSubnetUnusedAddr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetNetworkSubnetUnusedAddr",
                "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)",
                "AzureNetworkSubnetUnusedAddrResp",
                Query.AzureO365GetNetworkSubnetUnusedAddr_ObjectFieldSpec,
                Query.AzureO365GetNetworkSubnetUnusedAddrFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
# REQUIRED
$inputs.Var.strict_addr_check = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // azureO365GetAzureHostType: GetAzureHostTypeResp!
        internal void InitQueryAzureO365GetAzureHostType()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetAzureHostType",
                "",
                "GetAzureHostTypeResp",
                Query.AzureO365GetAzureHostType_ObjectFieldSpec,
                Query.AzureO365GetAzureHostTypeFieldSpec,
                @""
            );
        }


    } // class New_RscQueryAzureO365
}