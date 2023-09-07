// UpdateStorageArraysReply.cs
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
    #region UpdateStorageArraysReply
    public class UpdateStorageArraysReply: BaseType
    {
        #region members

        //      C# -> List<UpdateStorageArrayReplyType>? Responses
        // GraphQL -> responses: [UpdateStorageArrayReplyType!]! (type)
        [JsonProperty("responses")]
        public List<UpdateStorageArrayReplyType>? Responses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateStorageArraysReply";
    }

    public UpdateStorageArraysReply Set(
        List<UpdateStorageArrayReplyType>? Responses = null
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
        //      C# -> List<UpdateStorageArrayReplyType>? Responses
        // GraphQL -> responses: [UpdateStorageArrayReplyType!]! (type)
        if (this.Responses != null) {
            var fspec = this.Responses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "responses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UpdateStorageArrayReplyType>? Responses
        // GraphQL -> responses: [UpdateStorageArrayReplyType!]! (type)
        if (this.Responses == null && ec.Includes("responses",false))
        {
            this.Responses = new List<UpdateStorageArrayReplyType>();
            this.Responses.ApplyExploratoryFieldSpec(ec.NewChild("responses"));
        }
    }


    #endregion

    } // class UpdateStorageArraysReply
    
    #endregion

    public static class ListUpdateStorageArraysReplyExtensions
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
            this List<UpdateStorageArraysReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateStorageArraysReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateStorageArraysReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateStorageArraysReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types