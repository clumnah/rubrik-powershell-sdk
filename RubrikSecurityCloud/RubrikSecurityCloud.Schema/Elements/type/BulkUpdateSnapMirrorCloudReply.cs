// BulkUpdateSnapMirrorCloudReply.cs
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
    #region BulkUpdateSnapMirrorCloudReply
    public class BulkUpdateSnapMirrorCloudReply: BaseType
    {
        #region members

        //      C# -> List<UpdateSnapMirrorCloudReply>? Items
        // GraphQL -> items: [UpdateSnapMirrorCloudReply!]! (type)
        [JsonProperty("items")]
        public List<UpdateSnapMirrorCloudReply>? Items { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkUpdateSnapMirrorCloudReply";
    }

    public BulkUpdateSnapMirrorCloudReply Set(
        List<UpdateSnapMirrorCloudReply>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<UpdateSnapMirrorCloudReply>? Items
        // GraphQL -> items: [UpdateSnapMirrorCloudReply!]! (type)
        if (this.Items != null) {
            var fspec = this.Items.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "items {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UpdateSnapMirrorCloudReply>? Items
        // GraphQL -> items: [UpdateSnapMirrorCloudReply!]! (type)
        if (this.Items == null && ec.Includes("items",false))
        {
            this.Items = new List<UpdateSnapMirrorCloudReply>();
            this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));
        }
    }


    #endregion

    } // class BulkUpdateSnapMirrorCloudReply
    
    #endregion

    public static class ListBulkUpdateSnapMirrorCloudReplyExtensions
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
            this List<BulkUpdateSnapMirrorCloudReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkUpdateSnapMirrorCloudReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkUpdateSnapMirrorCloudReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BulkUpdateSnapMirrorCloudReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types