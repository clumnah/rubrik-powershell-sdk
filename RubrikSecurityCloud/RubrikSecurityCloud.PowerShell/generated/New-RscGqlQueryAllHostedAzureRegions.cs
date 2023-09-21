// New-RscGqlQueryAllHostedAzureRegions.cs
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
    /// Create new GraphQL Query allHostedAzureRegions
    /// allHostedAzureRegions: AzureRegionsResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllHostedAzureRegions")
    ]
    public class New_RscGqlQueryAllHostedAzureRegions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allHostedAzureRegions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allHostedAzureRegions
        /// allHostedAzureRegions: AzureRegionsResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allHostedAzureRegions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allHostedAzureRegions()
        {
            this._logger.name += " -allHostedAzureRegions";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllHostedAzureRegions",
                "",
                "AzureRegionsResp",
                Query.AllHostedAzureRegions_ObjectFieldSpec,
                Query.AllHostedAzureRegionsFieldSpec,
                @""
            );
        }

    } // class New-RscGqlQueryAllHostedAzureRegions
}