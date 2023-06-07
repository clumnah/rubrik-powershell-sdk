// AddAzureCloudAccountWithoutOauthReply.cs
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
    #region AddAzureCloudAccountWithoutOauthReply
    public class AddAzureCloudAccountWithoutOauthReply: BaseType
    {
        #region members

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> List<AddAzureCloudAccountStatus>? Status
        // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
        [JsonProperty("status")]
        public List<AddAzureCloudAccountStatus>? Status { get; set; }


        #endregion

    #region methods

    public AddAzureCloudAccountWithoutOauthReply Set(
        System.String? TenantId = null,
        List<AddAzureCloudAccountStatus>? Status = null
    ) 
    {
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            s += ind + "tenantId\n" ;
        }
        //      C# -> List<AddAzureCloudAccountStatus>? Status
        // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
        if (this.Status != null) {
            s += ind + "status {\n" + this.Status.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && Exploration.Includes(parent + ".tenantId", true))
        {
            this.TenantId = "FETCH";
        }
        //      C# -> List<AddAzureCloudAccountStatus>? Status
        // GraphQL -> status: [AddAzureCloudAccountStatus!]! (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new List<AddAzureCloudAccountStatus>();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
        }
    }


    #endregion

    } // class AddAzureCloudAccountWithoutOauthReply
    
    #endregion

    public static class ListAddAzureCloudAccountWithoutOauthReplyExtensions
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
            this List<AddAzureCloudAccountWithoutOauthReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddAzureCloudAccountWithoutOauthReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddAzureCloudAccountWithoutOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types