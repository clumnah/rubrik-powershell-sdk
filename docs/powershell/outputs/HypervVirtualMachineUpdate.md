### HypervVirtualMachineUpdate
Supported in v5.0+

- cloudInstantiationSpec: CloudInstantiationSpec
  - Supported in v5.0+
  Cloud instantiation specification for the selected virtual machine.
- configuredSlaDomainId: System.String
  - Supported in v5.0+
  v5.0-v5.1: Assign this VM to the given SLA domain.
  v5.2+: Assign this VM to the given SLA domain. Existing snapshots of the object will be retained with the configuration of specified SLA Domain.
- virtualDiskIdsExcludedFromSnapshot: list of System.Strings
  - Supported in v5.2+
  A comma-separated list of Hyper-V virtual disk IDs that are excluded from backup.
