### LsnRecoveryPointInput
Supported in v5.0+

- recoveryForkGuid: System.String
  - Supported in v5.0+
      Recovery fork GUID of the recovery point. If not provided, the recovery fork GUID of the latest snapshot is used.
- lsn: System.String
  - Required. Supported in v5.0+
      LSN of the recovery point.
