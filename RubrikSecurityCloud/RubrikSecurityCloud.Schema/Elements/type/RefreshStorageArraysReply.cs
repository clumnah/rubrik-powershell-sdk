// RefreshStorageArraysReply.cs
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
    #region RefreshStorageArraysReply
    public class RefreshStorageArraysReply: BaseType
    {
        #region members

        //      C# -> List<StorageArrayOperationOutputType>? Responses
        // GraphQL -> responses: [StorageArrayOperationOutputType!]! (type)
        [JsonProperty("responses")]
        public List<StorageArrayOperationOutputType>? Responses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RefreshStorageArraysReply";
    }

    public RefreshStorageArraysReply Set(
        List<StorageArrayOperationOutputType>? Responses = null
    ) 
    {
        if ( Responses != null ) {
            this.Responses = Responses;
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
        //      C# -> List<StorageArrayOperationOutputType>? Responses
        // GraphQL -> responses: [StorageArrayOperationOutputType!]! (type)
        if (this.Responses != null) {
            var fspec = this.Responses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "responses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<StorageArrayOperationOutputType>? Responses
        // GraphQL -> responses: [StorageArrayOperationOutputType!]! (type)
        if (this.Responses == null && Exploration.Includes(parent + ".responses"))
        {
            this.Responses = new List<StorageArrayOperationOutputType>();
            this.Responses.ApplyExploratoryFieldSpec(parent + ".responses");
        }
    }


    #endregion

    } // class RefreshStorageArraysReply
    
    #endregion

    public static class ListRefreshStorageArraysReplyExtensions
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
            this List<RefreshStorageArraysReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RefreshStorageArraysReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RefreshStorageArraysReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types