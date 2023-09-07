// TaskSummaryTable.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region TaskSummaryTable
 
    public class TaskSummaryTable: BaseType, ReportTableType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<TaskSummaryGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [TaskSummaryGroupByEnum!] (enum)
        [JsonProperty("groupBy")]
        public List<TaskSummaryGroupByEnum>? GroupBy { get; set; }

        //      C# -> List<TaskReportTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [TaskReportTableColumnEnum!]! (enum)
        [JsonProperty("selectedColumns")]
        public List<TaskReportTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> TaskSummarySortByEnum? SortBy
        // GraphQL -> sortBy: TaskSummarySortByEnum (enum)
        [JsonProperty("sortBy")]
        public TaskSummarySortByEnum? SortBy { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskSummaryTable";
    }

    public TaskSummaryTable Set(
        ReportFocusEnum? Focus = null,
        List<TaskSummaryGroupByEnum>? GroupBy = null,
        List<TaskReportTableColumnEnum>? SelectedColumns = null,
        TaskSummarySortByEnum? SortBy = null,
        SortOrder? SortOrder = null,
        System.String? Name = null
    ) 
    {
        if ( Focus != null ) {
            this.Focus = Focus;
        }
        if ( GroupBy != null ) {
            this.GroupBy = GroupBy;
        }
        if ( SelectedColumns != null ) {
            this.SelectedColumns = SelectedColumns;
        }
        if ( SortBy != null ) {
            this.SortBy = SortBy;
        }
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            s += ind + "focus\n" ;
        }
        //      C# -> List<TaskSummaryGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [TaskSummaryGroupByEnum!] (enum)
        if (this.GroupBy != null) {
            s += ind + "groupBy\n" ;
        }
        //      C# -> List<TaskReportTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [TaskReportTableColumnEnum!]! (enum)
        if (this.SelectedColumns != null) {
            s += ind + "selectedColumns\n" ;
        }
        //      C# -> TaskSummarySortByEnum? SortBy
        // GraphQL -> sortBy: TaskSummarySortByEnum (enum)
        if (this.SortBy != null) {
            s += ind + "sortBy\n" ;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus == null && ec.Includes("focus",true))
        {
            this.Focus = new ReportFocusEnum();
        }
        //      C# -> List<TaskSummaryGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [TaskSummaryGroupByEnum!] (enum)
        if (this.GroupBy == null && ec.Includes("groupBy",true))
        {
            this.GroupBy = new List<TaskSummaryGroupByEnum>();
        }
        //      C# -> List<TaskReportTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [TaskReportTableColumnEnum!]! (enum)
        if (this.SelectedColumns == null && ec.Includes("selectedColumns",true))
        {
            this.SelectedColumns = new List<TaskReportTableColumnEnum>();
        }
        //      C# -> TaskSummarySortByEnum? SortBy
        // GraphQL -> sortBy: TaskSummarySortByEnum (enum)
        if (this.SortBy == null && ec.Includes("sortBy",true))
        {
            this.SortBy = new TaskSummarySortByEnum();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && ec.Includes("sortOrder",true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class TaskSummaryTable
    
    #endregion

    public static class ListTaskSummaryTableExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<TaskSummaryTable> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummaryTable> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummaryTable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TaskSummaryTable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types