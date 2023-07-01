// Invoke-RscMutateOracle.cs
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
    [Cmdlet(
        "Invoke",
        "RscMutateOracle",
        DefaultParameterSetName = "RestoreLog")
    ]
    public class Invoke_RscMutateOracle : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // BulkUpdateHost parameter set
        //
        // [GraphQL: bulkUpdateOracleHosts]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.
[GraphQL: bulkUpdateOracleHosts]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateHost { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshDatabase parameter set
        //
        // [GraphQL: refreshOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "RefreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.
[GraphQL: refreshOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter RefreshDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateDataGuardGroup parameter set
        //
        // [GraphQL: updateOracleDataGuardGroup]
        //
        [Parameter(
            ParameterSetName = "UpdateDataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.
[GraphQL: updateOracleDataGuardGroup]",
            Position = 0
        )]
        public SwitchParameter UpdateDataGuardGroup { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteAllDatabaseSnapshot parameter set
        //
        // [GraphQL: deleteAllOracleDatabaseSnapshots]
        //
        [Parameter(
            ParameterSetName = "DeleteAllDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.
[GraphQL: deleteAllOracleDatabaseSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteAllDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // TakeOnDemandDatabaseSnapshot parameter set
        //
        // [GraphQL: takeOnDemandOracleDatabaseSnapshot]
        //
        [Parameter(
            ParameterSetName = "TakeOnDemandDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // TakeOnDemandLogSnapshot parameter set
        //
        // [GraphQL: takeOnDemandOracleLogSnapshot]
        //
        [Parameter(
            ParameterSetName = "TakeOnDemandLogSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleLogSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandLogSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BulkUpdateRac parameter set
        //
        // [GraphQL: bulkUpdateOracleRacs]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateRac",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.
[GraphQL: bulkUpdateOracleRacs]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateRac { get; set; }

        
        // -------------------------------------------------------------------
        // ExportTablespace parameter set
        //
        // [GraphQL: exportOracleTablespace]
        //
        [Parameter(
            ParameterSetName = "ExportTablespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.
[GraphQL: exportOracleTablespace]",
            Position = 0
        )]
        public SwitchParameter ExportTablespace { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateAcoFile parameter set
        //
        // [GraphQL: validateOracleAcoFile]
        //
        [Parameter(
            ParameterSetName = "ValidateAcoFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.
[GraphQL: validateOracleAcoFile]",
            Position = 0
        )]
        public SwitchParameter ValidateAcoFile { get; set; }

        
        // -------------------------------------------------------------------
        // ValidateDatabaseBackup parameter set
        //
        // [GraphQL: validateOracleDatabaseBackups]
        //
        [Parameter(
            ParameterSetName = "ValidateDatabaseBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.
[GraphQL: validateOracleDatabaseBackups]",
            Position = 0
        )]
        public SwitchParameter ValidateDatabaseBackup { get; set; }

        
        // -------------------------------------------------------------------
        // BulkUpdateDatabase parameter set
        //
        // [GraphQL: bulkUpdateOracleDatabases]
        //
        [Parameter(
            ParameterSetName = "BulkUpdateDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.
[GraphQL: bulkUpdateOracleDatabases]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // InstantRecoverSnapshot parameter set
        //
        // [GraphQL: instantRecoverOracleSnapshot]
        //
        [Parameter(
            ParameterSetName = "InstantRecoverSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.
[GraphQL: instantRecoverOracleSnapshot]",
            Position = 0
        )]
        public SwitchParameter InstantRecoverSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // MountDatabase parameter set
        //
        // [GraphQL: mountOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "MountDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.
[GraphQL: mountOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter MountDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // ExportDatabase parameter set
        //
        // [GraphQL: exportOracleDatabase]
        //
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.
[GraphQL: exportOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // CreatePdbRestore parameter set
        //
        // [GraphQL: createOraclePdbRestore]
        //
        [Parameter(
            ParameterSetName = "CreatePdbRestore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.
[GraphQL: createOraclePdbRestore]",
            Position = 0
        )]
        public SwitchParameter CreatePdbRestore { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadDatabaseSnapshot parameter set
        //
        // [GraphQL: downloadOracleDatabaseSnapshot]
        //
        [Parameter(
            ParameterSetName = "DownloadDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: downloadOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteMount parameter set
        //
        // [GraphQL: deleteOracleMount]
        //
        [Parameter(
            ParameterSetName = "DeleteMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.
[GraphQL: deleteOracleMount]",
            Position = 0
        )]
        public SwitchParameter DeleteMount { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreLog parameter set
        //
        // [GraphQL: restoreOracleLogs]
        //
        [Parameter(
            ParameterSetName = "RestoreLog",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.
[GraphQL: restoreOracleLogs]",
            Position = 0
        )]
        public SwitchParameter RestoreLog { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "BulkUpdateHost":
                        this.ProcessRecord_BulkUpdateHost();
                        break;
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
                        break;
                    case "UpdateDataGuardGroup":
                        this.ProcessRecord_UpdateDataGuardGroup();
                        break;
                    case "DeleteAllDatabaseSnapshot":
                        this.ProcessRecord_DeleteAllDatabaseSnapshot();
                        break;
                    case "TakeOnDemandDatabaseSnapshot":
                        this.ProcessRecord_TakeOnDemandDatabaseSnapshot();
                        break;
                    case "TakeOnDemandLogSnapshot":
                        this.ProcessRecord_TakeOnDemandLogSnapshot();
                        break;
                    case "BulkUpdateRac":
                        this.ProcessRecord_BulkUpdateRac();
                        break;
                    case "ExportTablespace":
                        this.ProcessRecord_ExportTablespace();
                        break;
                    case "ValidateAcoFile":
                        this.ProcessRecord_ValidateAcoFile();
                        break;
                    case "ValidateDatabaseBackup":
                        this.ProcessRecord_ValidateDatabaseBackup();
                        break;
                    case "BulkUpdateDatabase":
                        this.ProcessRecord_BulkUpdateDatabase();
                        break;
                    case "InstantRecoverSnapshot":
                        this.ProcessRecord_InstantRecoverSnapshot();
                        break;
                    case "MountDatabase":
                        this.ProcessRecord_MountDatabase();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "CreatePdbRestore":
                        this.ProcessRecord_CreatePdbRestore();
                        break;
                    case "DownloadDatabaseSnapshot":
                        this.ProcessRecord_DownloadDatabaseSnapshot();
                        break;
                    case "DeleteMount":
                        this.ProcessRecord_DeleteMount();
                        break;
                    case "RestoreLog":
                        this.ProcessRecord_RestoreLog();
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

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleHosts.
        protected void ProcessRecord_BulkUpdateHost()
        {
            this._logger.name += " -BulkUpdateHost";
            // Invoke graphql operation bulkUpdateOracleHosts
            InvokeMutationBulkUpdateOracleHosts();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOracleDatabase.
        protected void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Invoke graphql operation refreshOracleDatabase
            InvokeMutationRefreshOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // updateOracleDataGuardGroup.
        protected void ProcessRecord_UpdateDataGuardGroup()
        {
            this._logger.name += " -UpdateDataGuardGroup";
            // Invoke graphql operation updateOracleDataGuardGroup
            InvokeMutationUpdateOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAllOracleDatabaseSnapshots.
        protected void ProcessRecord_DeleteAllDatabaseSnapshot()
        {
            this._logger.name += " -DeleteAllDatabaseSnapshot";
            // Invoke graphql operation deleteAllOracleDatabaseSnapshots
            InvokeMutationDeleteAllOracleDatabaseSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleDatabaseSnapshot.
        protected void ProcessRecord_TakeOnDemandDatabaseSnapshot()
        {
            this._logger.name += " -TakeOnDemandDatabaseSnapshot";
            // Invoke graphql operation takeOnDemandOracleDatabaseSnapshot
            InvokeMutationTakeOnDemandOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleLogSnapshot.
        protected void ProcessRecord_TakeOnDemandLogSnapshot()
        {
            this._logger.name += " -TakeOnDemandLogSnapshot";
            // Invoke graphql operation takeOnDemandOracleLogSnapshot
            InvokeMutationTakeOnDemandOracleLogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleRacs.
        protected void ProcessRecord_BulkUpdateRac()
        {
            this._logger.name += " -BulkUpdateRac";
            // Invoke graphql operation bulkUpdateOracleRacs
            InvokeMutationBulkUpdateOracleRacs();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleTablespace.
        protected void ProcessRecord_ExportTablespace()
        {
            this._logger.name += " -ExportTablespace";
            // Invoke graphql operation exportOracleTablespace
            InvokeMutationExportOracleTablespace();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleAcoFile.
        protected void ProcessRecord_ValidateAcoFile()
        {
            this._logger.name += " -ValidateAcoFile";
            // Invoke graphql operation validateOracleAcoFile
            InvokeMutationValidateOracleAcoFile();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleDatabaseBackups.
        protected void ProcessRecord_ValidateDatabaseBackup()
        {
            this._logger.name += " -ValidateDatabaseBackup";
            // Invoke graphql operation validateOracleDatabaseBackups
            InvokeMutationValidateOracleDatabaseBackups();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleDatabases.
        protected void ProcessRecord_BulkUpdateDatabase()
        {
            this._logger.name += " -BulkUpdateDatabase";
            // Invoke graphql operation bulkUpdateOracleDatabases
            InvokeMutationBulkUpdateOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverOracleSnapshot.
        protected void ProcessRecord_InstantRecoverSnapshot()
        {
            this._logger.name += " -InstantRecoverSnapshot";
            // Invoke graphql operation instantRecoverOracleSnapshot
            InvokeMutationInstantRecoverOracleSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mountOracleDatabase.
        protected void ProcessRecord_MountDatabase()
        {
            this._logger.name += " -MountDatabase";
            // Invoke graphql operation mountOracleDatabase
            InvokeMutationMountOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleDatabase.
        protected void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Invoke graphql operation exportOracleDatabase
            InvokeMutationExportOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // createOraclePdbRestore.
        protected void ProcessRecord_CreatePdbRestore()
        {
            this._logger.name += " -CreatePdbRestore";
            // Invoke graphql operation createOraclePdbRestore
            InvokeMutationCreateOraclePdbRestore();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOracleDatabaseSnapshot.
        protected void ProcessRecord_DownloadDatabaseSnapshot()
        {
            this._logger.name += " -DownloadDatabaseSnapshot";
            // Invoke graphql operation downloadOracleDatabaseSnapshot
            InvokeMutationDownloadOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOracleMount.
        protected void ProcessRecord_DeleteMount()
        {
            this._logger.name += " -DeleteMount";
            // Invoke graphql operation deleteOracleMount
            InvokeMutationDeleteOracleMount();
        }

        // This parameter set invokes a single graphql operation:
        // restoreOracleLogs.
        protected void ProcessRecord_RestoreLog()
        {
            this._logger.name += " -RestoreLog";
            // Invoke graphql operation restoreOracleLogs
            InvokeMutationRestoreOracleLogs();
        }


        // Invoke GraphQL Mutation:
        // bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!): BulkUpdateOracleHostsReply!
        protected void InvokeMutationBulkUpdateOracleHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleHostsInput!"),
            };
            BulkUpdateOracleHostsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BulkUpdateOracleHostsReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleHostsReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleHosts(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleHosts");
            var parameters = "($input: BulkUpdateOracleHostsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleHosts" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleHosts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BulkUpdateOracleHostsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RefreshOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshOracleDatabase");
            var parameters = "($input: RefreshOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshOracleDatabase",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        protected void InvokeMutationUpdateOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            OracleDbDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleDbDetail)psObject.BaseObject;
                } else {
                    fields = (OracleDbDetail)this.Field;
                }
            }
            string document = Mutation.UpdateOracleDataGuardGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateOracleDataGuardGroup");
            var parameters = "($input: UpdateOracleDataGuardGroupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateOracleDataGuardGroup" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateOracleDataGuardGroup",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleDbDetail", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        protected void InvokeMutationDeleteAllOracleDatabaseSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.DeleteAllOracleDatabaseSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAllOracleDatabaseSnapshots");
            var parameters = "($input: DeleteAllOracleDatabaseSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAllOracleDatabaseSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAllOracleDatabaseSnapshots",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.TakeOnDemandOracleDatabaseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.TakeOnDemandOracleDatabaseSnapshot");
            var parameters = "($input: TakeOnDemandOracleDatabaseSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationTakeOnDemandOracleDatabaseSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationTakeOnDemandOracleDatabaseSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationTakeOnDemandOracleLogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.TakeOnDemandOracleLogSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.TakeOnDemandOracleLogSnapshot");
            var parameters = "($input: TakeOnDemandOracleLogSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationTakeOnDemandOracleLogSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationTakeOnDemandOracleLogSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        protected void InvokeMutationBulkUpdateOracleRacs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            BulkUpdateOracleRacsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BulkUpdateOracleRacsReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleRacsReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleRacs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleRacs");
            var parameters = "($input: BulkUpdateOracleRacsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleRacs" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleRacs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BulkUpdateOracleRacsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleTablespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportOracleTablespace(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportOracleTablespace");
            var parameters = "($input: ExportOracleTablespaceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportOracleTablespace" + parameters + "{" + document + "}",
                OperationName = "MutationExportOracleTablespace",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        protected void InvokeMutationValidateOracleAcoFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            ValidateOracleAcoFileReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ValidateOracleAcoFileReply)psObject.BaseObject;
                } else {
                    fields = (ValidateOracleAcoFileReply)this.Field;
                }
            }
            string document = Mutation.ValidateOracleAcoFile(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateOracleAcoFile");
            var parameters = "($input: ValidateOracleAcoFileInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateOracleAcoFile" + parameters + "{" + document + "}",
                OperationName = "MutationValidateOracleAcoFile",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ValidateOracleAcoFileReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!): AsyncRequestStatus!
        protected void InvokeMutationValidateOracleDatabaseBackups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleDatabaseBackupsInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ValidateOracleDatabaseBackups(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ValidateOracleDatabaseBackups");
            var parameters = "($input: ValidateOracleDatabaseBackupsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationValidateOracleDatabaseBackups" + parameters + "{" + document + "}",
                OperationName = "MutationValidateOracleDatabaseBackups",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        protected void InvokeMutationBulkUpdateOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            BulkUpdateOracleDatabasesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BulkUpdateOracleDatabasesReply)psObject.BaseObject;
                } else {
                    fields = (BulkUpdateOracleDatabasesReply)this.Field;
                }
            }
            string document = Mutation.BulkUpdateOracleDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkUpdateOracleDatabases");
            var parameters = "($input: BulkUpdateOracleDatabasesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkUpdateOracleDatabases" + parameters + "{" + document + "}",
                OperationName = "MutationBulkUpdateOracleDatabases",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BulkUpdateOracleDatabasesReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationInstantRecoverOracleSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.InstantRecoverOracleSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InstantRecoverOracleSnapshot");
            var parameters = "($input: InstantRecoverOracleSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInstantRecoverOracleSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationInstantRecoverOracleSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationMountOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.MountOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MountOracleDatabase");
            var parameters = "($input: MountOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMountOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationMountOracleDatabase",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        protected void InvokeMutationExportOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportOracleDatabase(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportOracleDatabase");
            var parameters = "($input: ExportOracleDatabaseInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportOracleDatabase" + parameters + "{" + document + "}",
                OperationName = "MutationExportOracleDatabase",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        protected void InvokeMutationCreateOraclePdbRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateOraclePdbRestore(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateOraclePdbRestore");
            var parameters = "($input: CreateOraclePdbRestoreInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateOraclePdbRestore" + parameters + "{" + document + "}",
                OperationName = "MutationCreateOraclePdbRestore",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadOracleDatabaseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadOracleDatabaseSnapshot");
            var parameters = "($input: DownloadOracleDatabaseSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadOracleDatabaseSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadOracleDatabaseSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteOracleMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteOracleMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteOracleMount");
            var parameters = "($input: DeleteOracleMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteOracleMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteOracleMount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        protected void InvokeMutationRestoreOracleLogs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RestoreOracleLogs(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreOracleLogs");
            var parameters = "($input: RestoreOracleLogsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreOracleLogs" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreOracleLogs",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateOracle
}