### AzureSqlDatabaseDbLtrExport
Input for exporting Long Term Retention backup of an Azure SQL Database.

- sourceSnapshotRubrikId: System.String
  - Rubrik ID of the snapshot from which database is being exported.
- destinationResourceGroupName: System.String
  - Resource Group in which database is being exported.
- destinationServerName: System.String
  - Database Server in which database is being exported.
- destinationRegionName: System.String
  - Region in which database is being exported.
- dbBackupRedundancy: AzureSqlBackupStorageRedundancyType
  - Specifies the redundancy of the backup of the destination database.
