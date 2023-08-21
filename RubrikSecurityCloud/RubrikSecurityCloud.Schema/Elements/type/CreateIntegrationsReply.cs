// CreateIntegrationsReply.cs
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
    #region CreateIntegrationsReply
    public class CreateIntegrationsReply: BaseType
    {
        #region members

        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        [JsonProperty("ids")]
        public List<System.Int64>? Ids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateIntegrationsReply";
    }

    public CreateIntegrationsReply Set(
        List<System.Int64>? Ids = null
    ) 
    {
        if ( Ids != null ) {
            this.Ids = Ids;
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
        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        if (this.Ids != null) {
            s += ind + "ids\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.Int64>? Ids
        // GraphQL -> ids: [Long!]! (scalar)
        if (this.Ids == null && Exploration.Includes(parent + ".ids", true))
        {
            this.Ids = new List<System.Int64>();
        }
    }


    #endregion

    } // class CreateIntegrationsReply
    
    #endregion

    public static class ListCreateIntegrationsReplyExtensions
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
            this List<CreateIntegrationsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateIntegrationsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateIntegrationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types