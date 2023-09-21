// New-RscGqlMutationBackupO365Mailbox.cs
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
    /// Create new GraphQL Mutation backupO365Mailbox
    /// backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365Mailbox")
    ]
    public class New_RscGqlMutationBackupO365Mailbox : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365Mailbox");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365Mailbox
        /// backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365Mailbox();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365Mailbox()
        {
            this._logger.name += " -backupO365Mailbox";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Mailbox",
                "($mailboxIds: [UUID!]!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Mailbox_ObjectFieldSpec,
                Mutation.BackupO365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.mailboxIds = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlMutationBackupO365Mailbox
}