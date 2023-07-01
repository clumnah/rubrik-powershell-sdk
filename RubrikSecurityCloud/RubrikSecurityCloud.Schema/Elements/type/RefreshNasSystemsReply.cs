// RefreshNasSystemsReply.cs
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
    #region RefreshNasSystemsReply
    public class RefreshNasSystemsReply: BaseType
    {
        #region members

        //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
        // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
        [JsonProperty("discoverNasSystemSummaries")]
        public List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RefreshNasSystemsReply";
    }

    public RefreshNasSystemsReply Set(
        List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries = null
    ) 
    {
        if ( DiscoverNasSystemSummaries != null ) {
            this.DiscoverNasSystemSummaries = DiscoverNasSystemSummaries;
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
        //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
        // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
        if (this.DiscoverNasSystemSummaries != null) {
            var fspec = this.DiscoverNasSystemSummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "discoverNasSystemSummaries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
        // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
        if (this.DiscoverNasSystemSummaries == null && Exploration.Includes(parent + ".discoverNasSystemSummaries"))
        {
            this.DiscoverNasSystemSummaries = new List<DiscoverNasSystemSummary>();
            this.DiscoverNasSystemSummaries.ApplyExploratoryFieldSpec(parent + ".discoverNasSystemSummaries");
        }
    }


    #endregion

    } // class RefreshNasSystemsReply
    
    #endregion

    public static class ListRefreshNasSystemsReplyExtensions
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
            this List<RefreshNasSystemsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RefreshNasSystemsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RefreshNasSystemsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types