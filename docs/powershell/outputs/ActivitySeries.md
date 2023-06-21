### ActivitySeries
- id: System.Int64
- startTime: DateTime
- lastUpdated: DateTime
- lastActivityType: ActivityTypeEnum
- lastActivityStatus: ActivityStatusEnum
- severity: ActivitySeverityEnum
- objectId: System.String
- objectName: System.String
- objectType: ActivityObjectTypeEnum
- activitySeriesId: System.String
- clusterUuid: System.String
- clusterName: System.String
- lastEventAddedAt: DateTime
- lastVerifiedAt: DateTime
- isCancelable: System.Boolean
- location: System.String
- isPolarisEventSeries: System.Boolean
- orgId: System.String
  - The organization ID of this event series.
- orgName: System.String
  - The organization name of this event series.
- effectiveThroughput: System.Int64
  - The effective throughput associated with this event, in bytes per second.
- dataTransferred: System.Int64
  - The data transferred associated with this event, in bytes.
- logicalSize: System.Int64
  - Logical size (if applicable), in bytes.
- fid: System.String
- progress: System.String
- failureReason: System.String
- causeErrorMessage: System.String
- causeErrorCode: System.String
- causeErrorReason: System.String
- causeErrorRemedy: System.String
- cluster: Cluster
- activityConnection: ActivityConnection
- organizations: list of Orgs
  - The organizations associated with this event series.