// New-RscMutationMssql.cs
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
    /// Mutations for the 'MSSQL' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationMssql is a master cmdlet for Mssql work that can invoke any of the following subcommands: BrowseDatabaseSnapshot, ExportDatabase, RestoreDatabase, BulkUpdateDbs, TakeLogBackup, CreateOnDemandBackup, DeleteDbSnapshots, DeleteLiveMount, BulkCreateOnDemandBackup, CreateLiveMount, UpdateLogShippingConfiguration, DownloadDatabaseFilesFromArchivalLocation, DownloadDatabaseBackupFiles, AssignSlaDomainProperties, UpdateDefaultProperties, CreateLogShippingConfiguration, AssignSlaDomainPropertiesAsync.
    /// </description>
    /// <example>
    /// <code>New-RscMutationMssql -BrowseDatabaseSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -ExportDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -RestoreDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -BulkUpdateDbs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -TakeLogBackup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -CreateOnDemandBackup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -DeleteDbSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -DeleteLiveMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -BulkCreateOnDemandBackup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -CreateLiveMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -UpdateLogShippingConfiguration [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -DownloadDatabaseBackupFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -AssignSlaDomainProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -UpdateDefaultProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -CreateLogShippingConfiguration [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMssql -AssignSlaDomainPropertiesAsync [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationMssql",
        DefaultParameterSetName = "BulkUpdateDbs")
    ]
    public class New_RscMutationMssql : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// BrowseDatabaseSnapshot parameter set
        ///
        /// [GraphQL: browseMssqlDatabaseSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "BrowseDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
[GraphQL: browseMssqlDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter BrowseDatabaseSnapshot { get; set; }

        
        /// <summary>
        /// ExportDatabase parameter set
        ///
        /// [GraphQL: exportMssqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to export a Microsoft SQL database.
[GraphQL: exportMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        /// <summary>
        /// RestoreDatabase parameter set
        ///
        /// [GraphQL: restoreMssqlDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "RestoreDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to restore a Microsoft SQL database.
[GraphQL: restoreMssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter RestoreDatabase { get; set; }

        
        /// <summary>
        /// BulkUpdateDbs parameter set
        ///
        /// [GraphQL: bulkUpdateMssqlDbs]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkUpdateDbs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update multiple Microsoft SQL databases with the specified properties.
[GraphQL: bulkUpdateMssqlDbs]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateDbs { get; set; }

        
        /// <summary>
        /// TakeLogBackup parameter set
        ///
        /// [GraphQL: takeMssqlLogBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "TakeLogBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand log backup for a Microsoft SQL database.
[GraphQL: takeMssqlLogBackup]",
            Position = 0
        )]
        public SwitchParameter TakeLogBackup { get; set; }

        
        /// <summary>
        /// CreateOnDemandBackup parameter set
        ///
        /// [GraphQL: createOnDemandMssqlBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand backup of a Microsoft SQL Database
[GraphQL: createOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter CreateOnDemandBackup { get; set; }

        
        /// <summary>
        /// DeleteDbSnapshots parameter set
        ///
        /// [GraphQL: deleteMssqlDbSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteDbSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete snapshots of a Microsoft SQL Database.
[GraphQL: deleteMssqlDbSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteDbSnapshots { get; set; }

        
        /// <summary>
        /// DeleteLiveMount parameter set
        ///
        /// [GraphQL: deleteMssqlLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
[GraphQL: deleteMssqlLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        /// <summary>
        /// BulkCreateOnDemandBackup parameter set
        ///
        /// [GraphQL: bulkCreateOnDemandMssqlBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkCreateOnDemandBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take a bulk on-demand backup of a Microsoft SQL Database.
[GraphQL: bulkCreateOnDemandMssqlBackup]",
            Position = 0
        )]
        public SwitchParameter BulkCreateOnDemandBackup { get; set; }

        
        /// <summary>
        /// CreateLiveMount parameter set
        ///
        /// [GraphQL: createMssqlLiveMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create live mount of a Microsoft SQL Database.
[GraphQL: createMssqlLiveMount]",
            Position = 0
        )]
        public SwitchParameter CreateLiveMount { get; set; }

        
        /// <summary>
        /// UpdateLogShippingConfiguration parameter set
        ///
        /// [GraphQL: updateMssqlLogShippingConfiguration]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update log shipping configuration of a Microsoft SQL Database.
[GraphQL: updateMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter UpdateLogShippingConfiguration { get; set; }

        
        /// <summary>
        /// DownloadDatabaseFilesFromArchivalLocation parameter set
        ///
        /// [GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadDatabaseFilesFromArchivalLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Microsoft SQL Database backup files from archival location.
[GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseFilesFromArchivalLocation { get; set; }

        
        /// <summary>
        /// DownloadDatabaseBackupFiles parameter set
        ///
        /// [GraphQL: downloadMssqlDatabaseBackupFiles]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadDatabaseBackupFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
[GraphQL: downloadMssqlDatabaseBackupFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseBackupFiles { get; set; }

        
        /// <summary>
        /// AssignSlaDomainProperties parameter set
        ///
        /// [GraphQL: assignMssqlSlaDomainProperties]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignSlaDomainProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainProperties]",
            Position = 0
        )]
        public SwitchParameter AssignSlaDomainProperties { get; set; }

        
        /// <summary>
        /// UpdateDefaultProperties parameter set
        ///
        /// [GraphQL: updateMssqlDefaultProperties]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateDefaultProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the default properties for Microsoft SQL databases.
[GraphQL: updateMssqlDefaultProperties]",
            Position = 0
        )]
        public SwitchParameter UpdateDefaultProperties { get; set; }

        
        /// <summary>
        /// CreateLogShippingConfiguration parameter set
        ///
        /// [GraphQL: createMssqlLogShippingConfiguration]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateLogShippingConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create log shipping configuration of a Microsoft SQL Database.
[GraphQL: createMssqlLogShippingConfiguration]",
            Position = 0
        )]
        public SwitchParameter CreateLogShippingConfiguration { get; set; }

        
        /// <summary>
        /// AssignSlaDomainPropertiesAsync parameter set
        ///
        /// [GraphQL: assignMssqlSlaDomainPropertiesAsync]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignSlaDomainPropertiesAsync",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA domain properties to Mssql objects.
[GraphQL: assignMssqlSlaDomainPropertiesAsync]",
            Position = 0
        )]
        public SwitchParameter AssignSlaDomainPropertiesAsync { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "BrowseDatabaseSnapshot":
                        this.ProcessRecord_BrowseDatabaseSnapshot();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "RestoreDatabase":
                        this.ProcessRecord_RestoreDatabase();
                        break;
                    case "BulkUpdateDbs":
                        this.ProcessRecord_BulkUpdateDbs();
                        break;
                    case "TakeLogBackup":
                        this.ProcessRecord_TakeLogBackup();
                        break;
                    case "CreateOnDemandBackup":
                        this.ProcessRecord_CreateOnDemandBackup();
                        break;
                    case "DeleteDbSnapshots":
                        this.ProcessRecord_DeleteDbSnapshots();
                        break;
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "BulkCreateOnDemandBackup":
                        this.ProcessRecord_BulkCreateOnDemandBackup();
                        break;
                    case "CreateLiveMount":
                        this.ProcessRecord_CreateLiveMount();
                        break;
                    case "UpdateLogShippingConfiguration":
                        this.ProcessRecord_UpdateLogShippingConfiguration();
                        break;
                    case "DownloadDatabaseFilesFromArchivalLocation":
                        this.ProcessRecord_DownloadDatabaseFilesFromArchivalLocation();
                        break;
                    case "DownloadDatabaseBackupFiles":
                        this.ProcessRecord_DownloadDatabaseBackupFiles();
                        break;
                    case "AssignSlaDomainProperties":
                        this.ProcessRecord_AssignSlaDomainProperties();
                        break;
                    case "UpdateDefaultProperties":
                        this.ProcessRecord_UpdateDefaultProperties();
                        break;
                    case "CreateLogShippingConfiguration":
                        this.ProcessRecord_CreateLogShippingConfiguration();
                        break;
                    case "AssignSlaDomainPropertiesAsync":
                        this.ProcessRecord_AssignSlaDomainPropertiesAsync();
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
        // browseMssqlDatabaseSnapshot.
        internal void ProcessRecord_BrowseDatabaseSnapshot()
        {
            this._logger.name += " -BrowseDatabaseSnapshot";
            // Create new graphql operation browseMssqlDatabaseSnapshot
            InitMutationBrowseMssqlDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // exportMssqlDatabase.
        internal void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Create new graphql operation exportMssqlDatabase
            InitMutationExportMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // restoreMssqlDatabase.
        internal void ProcessRecord_RestoreDatabase()
        {
            this._logger.name += " -RestoreDatabase";
            // Create new graphql operation restoreMssqlDatabase
            InitMutationRestoreMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateMssqlDbs.
        internal void ProcessRecord_BulkUpdateDbs()
        {
            this._logger.name += " -BulkUpdateDbs";
            // Create new graphql operation bulkUpdateMssqlDbs
            InitMutationBulkUpdateMssqlDbs();
        }

        // This parameter set invokes a single graphql operation:
        // takeMssqlLogBackup.
        internal void ProcessRecord_TakeLogBackup()
        {
            this._logger.name += " -TakeLogBackup";
            // Create new graphql operation takeMssqlLogBackup
            InitMutationTakeMssqlLogBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMssqlBackup.
        internal void ProcessRecord_CreateOnDemandBackup()
        {
            this._logger.name += " -CreateOnDemandBackup";
            // Create new graphql operation createOnDemandMssqlBackup
            InitMutationCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlDbSnapshots.
        internal void ProcessRecord_DeleteDbSnapshots()
        {
            this._logger.name += " -DeleteDbSnapshots";
            // Create new graphql operation deleteMssqlDbSnapshots
            InitMutationDeleteMssqlDbSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMssqlLiveMount.
        internal void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
            // Create new graphql operation deleteMssqlLiveMount
            InitMutationDeleteMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateOnDemandMssqlBackup.
        internal void ProcessRecord_BulkCreateOnDemandBackup()
        {
            this._logger.name += " -BulkCreateOnDemandBackup";
            // Create new graphql operation bulkCreateOnDemandMssqlBackup
            InitMutationBulkCreateOnDemandMssqlBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLiveMount.
        internal void ProcessRecord_CreateLiveMount()
        {
            this._logger.name += " -CreateLiveMount";
            // Create new graphql operation createMssqlLiveMount
            InitMutationCreateMssqlLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlLogShippingConfiguration.
        internal void ProcessRecord_UpdateLogShippingConfiguration()
        {
            this._logger.name += " -UpdateLogShippingConfiguration";
            // Create new graphql operation updateMssqlLogShippingConfiguration
            InitMutationUpdateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseFilesFromArchivalLocation.
        internal void ProcessRecord_DownloadDatabaseFilesFromArchivalLocation()
        {
            this._logger.name += " -DownloadDatabaseFilesFromArchivalLocation";
            // Create new graphql operation downloadMssqlDatabaseFilesFromArchivalLocation
            InitMutationDownloadMssqlDatabaseFilesFromArchivalLocation();
        }

        // This parameter set invokes a single graphql operation:
        // downloadMssqlDatabaseBackupFiles.
        internal void ProcessRecord_DownloadDatabaseBackupFiles()
        {
            this._logger.name += " -DownloadDatabaseBackupFiles";
            // Create new graphql operation downloadMssqlDatabaseBackupFiles
            InitMutationDownloadMssqlDatabaseBackupFiles();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainProperties.
        internal void ProcessRecord_AssignSlaDomainProperties()
        {
            this._logger.name += " -AssignSlaDomainProperties";
            // Create new graphql operation assignMssqlSlaDomainProperties
            InitMutationAssignMssqlSlaDomainProperties();
        }

        // This parameter set invokes a single graphql operation:
        // updateMssqlDefaultProperties.
        internal void ProcessRecord_UpdateDefaultProperties()
        {
            this._logger.name += " -UpdateDefaultProperties";
            // Create new graphql operation updateMssqlDefaultProperties
            InitMutationUpdateMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // createMssqlLogShippingConfiguration.
        internal void ProcessRecord_CreateLogShippingConfiguration()
        {
            this._logger.name += " -CreateLogShippingConfiguration";
            // Create new graphql operation createMssqlLogShippingConfiguration
            InitMutationCreateMssqlLogShippingConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // assignMssqlSlaDomainPropertiesAsync.
        internal void ProcessRecord_AssignSlaDomainPropertiesAsync()
        {
            this._logger.name += " -AssignSlaDomainPropertiesAsync";
            // Create new graphql operation assignMssqlSlaDomainPropertiesAsync
            InitMutationAssignMssqlSlaDomainPropertiesAsync();
        }


        // Create new GraphQL Mutation:
        // browseMssqlDatabaseSnapshot(input: BrowseMssqlDatabaseSnapshotInput!): BrowseMssqlDatabaseSnapshotReply!
        internal void InitMutationBrowseMssqlDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseMssqlDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBrowseMssqlDatabaseSnapshot",
                "($input: BrowseMssqlDatabaseSnapshotInput!)",
                "BrowseMssqlDatabaseSnapshotReply",
                Mutation.BrowseMssqlDatabaseSnapshot_ObjectFieldSpec,
                Mutation.BrowseMssqlDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		endPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# OPTIONAL
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		startPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		backupType = <MssqlBackupType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlBackupType]) for enum values.
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationExportMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportMssqlDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportMssqlDatabase",
                "($input: ExportMssqlDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportMssqlDatabase_ObjectFieldSpec,
                Mutation.ExportMssqlDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		allowOverwrite = <System.Boolean>
		# OPTIONAL
		finishRecovery = <System.Boolean>
		# OPTIONAL
		maxDataStreams = <System.Int32>
		# OPTIONAL
		targetDataFilePath = <System.String>
		# OPTIONAL
		targetFilePaths = @(
			@{
				# OPTIONAL
				newFilename = <System.String>
				# OPTIONAL
				newLogicalName = <System.String>
				# REQUIRED
				exportPath = <System.String>
				# REQUIRED
				logicalName = <System.String>
			}
		)
		# OPTIONAL
		targetLogFilePath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# REQUIRED
		targetDatabaseName = <System.String>
		# REQUIRED
		targetInstanceId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreMssqlDatabase(input: RestoreMssqlDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationRestoreMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreMssqlDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreMssqlDatabase",
                "($input: RestoreMssqlDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreMssqlDatabase_ObjectFieldSpec,
                Mutation.RestoreMssqlDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		finishRecovery = <System.Boolean>
		# OPTIONAL
		maxDataStreams = <System.Int32>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
        internal void InitMutationBulkUpdateMssqlDbs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateMssqlDbsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateMssqlDbs",
                "($input: BulkUpdateMssqlDbsInput!)",
                "BulkUpdateMssqlDbsReply",
                Mutation.BulkUpdateMssqlDbs_ObjectFieldSpec,
                Mutation.BulkUpdateMssqlDbsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbsUpdateProperties = @(
		@{
			# REQUIRED
			databaseId = <System.String>
			# REQUIRED
			updateProperties = @{
				# OPTIONAL
				configuredSlaDomainId = <System.String>
				# OPTIONAL
				maxDataStreams = <System.Int32>
				# OPTIONAL
				postBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				preBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				isPaused = <System.Boolean>
				# OPTIONAL
				shouldForceFull = <System.Boolean>
				# OPTIONAL
				mssqlNonSlaProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
				}
				# OPTIONAL
				mssqlSlaPatchProperties = @{
					# OPTIONAL
					configuredSlaDomainId = <System.String>
					# OPTIONAL
					useConfiguredDefaultLogRetention = <System.Boolean>
					# OPTIONAL
					mssqlSlaRelatedProperties = @{
						# OPTIONAL
						copyOnly = <System.Boolean>
						# OPTIONAL
						logBackupFrequencyInSeconds = <System.Int32>
						# OPTIONAL
						logRetentionHours = <System.Int32>
						# OPTIONAL
						hasLogConfigFromSla = <System.Boolean>
						# OPTIONAL
						hostLogRetention = <System.Int32>
					}
				}
				# OPTIONAL
				mssqlSlaRelatedProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
					# OPTIONAL
					hasLogConfigFromSla = <System.Boolean>
					# OPTIONAL
					hostLogRetention = <System.Int32>
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
        internal void InitMutationTakeMssqlLogBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeMssqlLogBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeMssqlLogBackup",
                "($input: TakeMssqlLogBackupInput!)",
                "AsyncRequestStatus",
                Mutation.TakeMssqlLogBackup_ObjectFieldSpec,
                Mutation.TakeMssqlLogBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandMssqlBackup(input: CreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMssqlBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandMssqlBackup",
                "($input: CreateOnDemandMssqlBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandMssqlBackup_ObjectFieldSpec,
                Mutation.CreateOnDemandMssqlBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMssqlDbSnapshots(input: DeleteMssqlDbSnapshotsInput!): ResponseSuccess!
        internal void InitMutationDeleteMssqlDbSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMssqlDbSnapshots",
                "($input: DeleteMssqlDbSnapshotsInput!)",
                "ResponseSuccess",
                Mutation.DeleteMssqlDbSnapshots_ObjectFieldSpec,
                Mutation.DeleteMssqlDbSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMssqlLiveMount(input: DeleteMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMssqlLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMssqlLiveMount",
                "($input: DeleteMssqlLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteMssqlLiveMount_ObjectFieldSpec,
                Mutation.DeleteMssqlLiveMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        internal void InitMutationBulkCreateOnDemandMssqlBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateOnDemandMssqlBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateOnDemandMssqlBackup",
                "($input: BulkCreateOnDemandMssqlBackupInput!)",
                "AsyncRequestStatus",
                Mutation.BulkCreateOnDemandMssqlBackup_ObjectFieldSpec,
                Mutation.BulkCreateOnDemandMssqlBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		availabilityGroupIds = @(
			<System.String>
		)
		# OPTIONAL
		databaseIds = @(
			<System.String>
		)
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		instanceIds = @(
			<System.String>
		)
		# OPTIONAL
		windowsClusterIds = @(
			<System.String>
		)
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateMssqlLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLiveMount",
                "($input: CreateMssqlLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLiveMount_ObjectFieldSpec,
                Mutation.CreateMssqlLiveMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetInstanceId = <System.String>
		# OPTIONAL
		recoveryModel = <MssqlDatabaseRecoveryModel> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseRecoveryModel]) for enum values.
		# REQUIRED
		mountedDatabaseName = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMssqlLogShippingConfiguration(input: UpdateMssqlLogShippingConfigurationInput!): UpdateMssqlLogShippingConfigurationReply!
        internal void InitMutationUpdateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlLogShippingConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMssqlLogShippingConfiguration",
                "($input: UpdateMssqlLogShippingConfigurationInput!)",
                "UpdateMssqlLogShippingConfigurationReply",
                Mutation.UpdateMssqlLogShippingConfiguration_ObjectFieldSpec,
                Mutation.UpdateMssqlLogShippingConfigurationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
        internal void InitMutationDownloadMssqlDatabaseFilesFromArchivalLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseFilesFromArchivalLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseFilesFromArchivalLocation",
                "($input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
        internal void InitMutationDownloadMssqlDatabaseBackupFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseBackupFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseBackupFiles",
                "($input: DownloadMssqlDatabaseBackupFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseBackupFiles_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseBackupFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		items = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
        internal void InitMutationAssignMssqlSlaDomainProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainProperties",
                "($input: AssignMssqlSlaDomainPropertiesInput!)",
                "ResponseSuccess",
                Mutation.AssignMssqlSlaDomainProperties_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = <System.Boolean>
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = <System.Boolean>
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			useConfiguredDefaultLogRetention = <System.Boolean>
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = <System.Boolean>
				# OPTIONAL
				logBackupFrequencyInSeconds = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				hostLogRetention = <System.Int32>
			}
		}
		# OPTIONAL
		existingSnapshotRetention = <ExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
        internal void InitMutationUpdateMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlDefaultPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMssqlDefaultProperties",
                "($input: UpdateMssqlDefaultPropertiesInput!)",
                "UpdateMssqlDefaultPropertiesReply",
                Mutation.UpdateMssqlDefaultProperties_ObjectFieldSpec,
                Mutation.UpdateMssqlDefaultPropertiesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	defaultProperties = @{
		# OPTIONAL
		cbtStatus = <System.Boolean>
		# OPTIONAL
		logBackupFrequencyInSeconds = <System.Int64>
		# OPTIONAL
		logRetentionTimeInHours = <System.Int32>
		# OPTIONAL
		shouldUseDefaultBackupLocation = <System.Boolean>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
        internal void InitMutationCreateMssqlLogShippingConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLogShippingConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLogShippingConfiguration",
                "($input: CreateMssqlLogShippingConfigurationInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLogShippingConfiguration_ObjectFieldSpec,
                Mutation.CreateMssqlLogShippingConfigurationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = <System.Int32>
		# OPTIONAL
		mssqlLogShippingCreateConfig = @{
			# OPTIONAL
			maxDataStreams = <System.Int32>
			# OPTIONAL
			targetDataFilePath = <System.String>
			# OPTIONAL
			targetFilePaths = @(
				@{
					# OPTIONAL
					newFilename = <System.String>
					# OPTIONAL
					newLogicalName = <System.String>
					# REQUIRED
					exportPath = <System.String>
					# REQUIRED
					logicalName = <System.String>
				}
			)
			# OPTIONAL
			targetLogFilePath = <System.String>
			# OPTIONAL
			mssqlLogShippingTargetStateOptions = @{
				# OPTIONAL
				shouldDisconnectStandbyUsers = <System.Boolean>
				# REQUIRED
				state = <MssqlLogShippingOkState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
			}
			# REQUIRED
			targetDatabaseName = <System.String>
			# REQUIRED
			targetInstanceId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
        internal void InitMutationAssignMssqlSlaDomainPropertiesAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainPropertiesAsync",
                "($input: AssignMssqlSlaDomainPropertiesAsyncInput!)",
                "AssignMssqlSlaDomainPropertiesAsyncReply",
                Mutation.AssignMssqlSlaDomainPropertiesAsync_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesAsyncFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = <System.Boolean>
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = <System.Boolean>
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			useConfiguredDefaultLogRetention = <System.Boolean>
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = <System.Boolean>
				# OPTIONAL
				logBackupFrequencyInSeconds = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				hostLogRetention = <System.Int32>
			}
		}
		# OPTIONAL
		existingSnapshotRetention = <ExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }


    } // class New_RscMutationMssql
}