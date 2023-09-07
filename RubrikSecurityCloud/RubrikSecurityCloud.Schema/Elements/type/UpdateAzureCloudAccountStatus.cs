// UpdateAzureCloudAccountStatus.cs
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
    #region UpdateAzureCloudAccountStatus
    public class UpdateAzureCloudAccountStatus: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateAzureCloudAccountStatus";
    }

    public UpdateAzureCloudAccountStatus Set(
        System.String? AzureSubscriptionNativeId = null,
        System.Boolean? IsSuccess = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            s += ind + "azureSubscriptionNativeId\n" ;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            s += ind + "isSuccess\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId == null && ec.Includes("azureSubscriptionNativeId",true))
        {
            this.AzureSubscriptionNativeId = "FETCH";
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess == null && ec.Includes("isSuccess",true))
        {
            this.IsSuccess = true;
        }
    }


    #endregion

    } // class UpdateAzureCloudAccountStatus
    
    #endregion

    public static class ListUpdateAzureCloudAccountStatusExtensions
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
            this List<UpdateAzureCloudAccountStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateAzureCloudAccountStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateAzureCloudAccountStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateAzureCloudAccountStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types