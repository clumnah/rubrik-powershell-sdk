// DisableTargetReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region DisableTargetReply
    public class DisableTargetReply: BaseType
    {
        #region members

        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        [JsonProperty("status")]
        public ArchivalLocationStatus? Status { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }


        #endregion

    #region methods

    public DisableTargetReply Set(
        ArchivalLocationStatus? Status = null,
        System.String? LocationId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
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
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ArchivalLocationStatus();
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = "FETCH";
        }
    }


    #endregion

    } // class DisableTargetReply
    
    #endregion

    public static class ListDisableTargetReplyExtensions
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
            this List<DisableTargetReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DisableTargetReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DisableTargetReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types