// ModifyIpmiReply.cs
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
    #region ModifyIpmiReply
    public class ModifyIpmiReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        [JsonProperty("isAvailable")]
        public System.Boolean? IsAvailable { get; set; }

        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        [JsonProperty("access")]
        public IpmiAccess? Access { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ModifyIpmiReply";
    }

    public ModifyIpmiReply Set(
        System.Boolean? IsAvailable = null,
        IpmiAccess? Access = null
    ) 
    {
        if ( IsAvailable != null ) {
            this.IsAvailable = IsAvailable;
        }
        if ( Access != null ) {
            this.Access = Access;
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
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (this.IsAvailable != null) {
            s += ind + "isAvailable\n" ;
        }
        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        if (this.Access != null) {
            var fspec = this.Access.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "access {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (this.IsAvailable == null && Exploration.Includes(parent + ".isAvailable", true))
        {
            this.IsAvailable = true;
        }
        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        if (this.Access == null && Exploration.Includes(parent + ".access"))
        {
            this.Access = new IpmiAccess();
            this.Access.ApplyExploratoryFieldSpec(parent + ".access");
        }
    }


    #endregion

    } // class ModifyIpmiReply
    
    #endregion

    public static class ListModifyIpmiReplyExtensions
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
            this List<ModifyIpmiReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ModifyIpmiReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ModifyIpmiReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types