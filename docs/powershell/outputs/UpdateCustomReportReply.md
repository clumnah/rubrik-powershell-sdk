### UpdateCustomReportReply
Metadata for rendering a custom report.

- id: System.Int32
  - ID of the custom report.
- name: System.String
  - Name of the custom report.
- focus: ReportFocusEnum
  - The metrics focus of the custom report.
- isHidden: System.Boolean
  - Specifies whether the report should be hidden from the gallery view.
- isReadOnly: System.Boolean
  - Specifies whether the report is auto-generated and not editable.
- filters: CustomReportFilters
  - The filters applied to the data in the report.
- createdAt: DateTime
  - Time the report was created.
- updatedAt: DateTime
  - Time the report was last updated and saved.
- viewedAt: DateTime
  - Time the report was last viewed or opened.
- room: System.String
  - Room of the report.
- charts: list of ReportChartTypes
  - The list of charts in the custom report.
- tables: list of ReportTableTypes
  - The list of tables in the custom report.
- owner: User
  - The creator of the custom report.
- oldestSyncDate: DateTime
  - Date of the oldest sync for the report.
- newestSyncDate: DateTime
  - Date of the most recent sync for the report.
- scheduledReportConnection: ScheduledReportConnection
