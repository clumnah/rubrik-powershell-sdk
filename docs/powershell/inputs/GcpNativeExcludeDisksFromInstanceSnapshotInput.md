### GcpNativeExcludeDisksFromInstanceSnapshotInput
Input required to exclude GCP native disks from GCE instance snapshots.

- instanceId: System.String
  - GCP instance Rubrik ID.
- diskIdToIsExcluded: list of DiskIdToIsExcludeds
  - Mapping from disk ID to whether it is excluded from GCP instance snapshots.
