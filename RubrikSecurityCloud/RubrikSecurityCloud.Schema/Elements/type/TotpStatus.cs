// TotpStatus.cs
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
    #region TotpStatus
    public class TotpStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        [JsonProperty("isEnforced")]
        public System.Boolean? IsEnforced { get; set; }

        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        [JsonProperty("isEnforcedUserLevel")]
        public System.Boolean? IsEnforcedUserLevel { get; set; }

        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        [JsonProperty("isSupported")]
        public System.Boolean? IsSupported { get; set; }

        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        [JsonProperty("totpConfigUpdateAt")]
        public DateTime? TotpConfigUpdateAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TotpStatus";
    }

    public TotpStatus Set(
        System.Boolean? IsEnabled = null,
        System.Boolean? IsEnforced = null,
        System.Boolean? IsEnforcedUserLevel = null,
        System.Boolean? IsSupported = null,
        DateTime? TotpConfigUpdateAt = null
    ) 
    {
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( IsEnforced != null ) {
            this.IsEnforced = IsEnforced;
        }
        if ( IsEnforcedUserLevel != null ) {
            this.IsEnforcedUserLevel = IsEnforcedUserLevel;
        }
        if ( IsSupported != null ) {
            this.IsSupported = IsSupported;
        }
        if ( TotpConfigUpdateAt != null ) {
            this.TotpConfigUpdateAt = TotpConfigUpdateAt;
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
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            s += ind + "isEnabled\n" ;
        }
        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        if (this.IsEnforced != null) {
            s += ind + "isEnforced\n" ;
        }
        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        if (this.IsEnforcedUserLevel != null) {
            s += ind + "isEnforcedUserLevel\n" ;
        }
        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        if (this.IsSupported != null) {
            s += ind + "isSupported\n" ;
        }
        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        if (this.TotpConfigUpdateAt != null) {
            s += ind + "totpConfigUpdateAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled", true))
        {
            this.IsEnabled = true;
        }
        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        if (this.IsEnforced == null && Exploration.Includes(parent + ".isEnforced", true))
        {
            this.IsEnforced = true;
        }
        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        if (this.IsEnforcedUserLevel == null && Exploration.Includes(parent + ".isEnforcedUserLevel", true))
        {
            this.IsEnforcedUserLevel = true;
        }
        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        if (this.IsSupported == null && Exploration.Includes(parent + ".isSupported", true))
        {
            this.IsSupported = true;
        }
        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        if (this.TotpConfigUpdateAt == null && Exploration.Includes(parent + ".totpConfigUpdateAt", true))
        {
            this.TotpConfigUpdateAt = new DateTime();
        }
    }


    #endregion

    } // class TotpStatus
    
    #endregion

    public static class ListTotpStatusExtensions
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
            this List<TotpStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TotpStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TotpStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types