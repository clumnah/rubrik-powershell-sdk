### BulkDeleteFilesetInput
Input for deleting multiple filesets.

- preserveSnapshots: System.Boolean
  - Flag to indicate whether to convert snapshots of all deleted filesets to relics or to delete them. Applies to all filesets. Default is true.
- ids: list of System.Strings
  - Required. Provide a comma-separated list of fileset IDs.
