// ValidationStatusInfo.cs
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
    #region ValidationStatusInfo
    public class ValidationStatusInfo: BaseType
    {
        #region members

        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        [JsonProperty("validationStatus")]
        public ValidationStatus? ValidationStatus { get; set; }

        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        [JsonProperty("failureReasons")]
        public List<System.String>? FailureReasons { get; set; }

        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        [JsonProperty("warningReasons")]
        public List<System.String>? WarningReasons { get; set; }

        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        [JsonProperty("resourceInfo")]
        public ResourceInfo? ResourceInfo { get; set; }


        #endregion

    #region methods

    public ValidationStatusInfo Set(
        ValidationStatus? ValidationStatus = null,
        List<System.String>? FailureReasons = null,
        List<System.String>? WarningReasons = null,
        ResourceInfo? ResourceInfo = null
    ) 
    {
        if ( ValidationStatus != null ) {
            this.ValidationStatus = ValidationStatus;
        }
        if ( FailureReasons != null ) {
            this.FailureReasons = FailureReasons;
        }
        if ( WarningReasons != null ) {
            this.WarningReasons = WarningReasons;
        }
        if ( ResourceInfo != null ) {
            this.ResourceInfo = ResourceInfo;
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
        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        if (this.ValidationStatus != null) {
            s += ind + "validationStatus\n" ;
        }
        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        if (this.FailureReasons != null) {
            s += ind + "failureReasons\n" ;
        }
        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        if (this.WarningReasons != null) {
            s += ind + "warningReasons\n" ;
        }
        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        if (this.ResourceInfo != null) {
            s += ind + "resourceInfo {\n" + this.ResourceInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ValidationStatus? ValidationStatus
        // GraphQL -> validationStatus: ValidationStatus! (enum)
        if (this.ValidationStatus == null && Exploration.Includes(parent + ".validationStatus", true))
        {
            this.ValidationStatus = new ValidationStatus();
        }
        //      C# -> List<System.String>? FailureReasons
        // GraphQL -> failureReasons: [String!]! (scalar)
        if (this.FailureReasons == null && Exploration.Includes(parent + ".failureReasons", true))
        {
            this.FailureReasons = new List<System.String>();
        }
        //      C# -> List<System.String>? WarningReasons
        // GraphQL -> warningReasons: [String!]! (scalar)
        if (this.WarningReasons == null && Exploration.Includes(parent + ".warningReasons", true))
        {
            this.WarningReasons = new List<System.String>();
        }
        //      C# -> ResourceInfo? ResourceInfo
        // GraphQL -> resourceInfo: ResourceInfo (type)
        if (this.ResourceInfo == null && Exploration.Includes(parent + ".resourceInfo"))
        {
            this.ResourceInfo = new ResourceInfo();
            this.ResourceInfo.ApplyExploratoryFieldSpec(parent + ".resourceInfo");
        }
    }


    #endregion

    } // class ValidationStatusInfo
    
    #endregion

    public static class ListValidationStatusInfoExtensions
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
            this List<ValidationStatusInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidationStatusInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidationStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types