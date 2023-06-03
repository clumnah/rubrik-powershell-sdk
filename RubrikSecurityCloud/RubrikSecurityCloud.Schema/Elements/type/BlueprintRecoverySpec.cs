// BlueprintRecoverySpec.cs
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
    #region BlueprintRecoverySpec
    public class BlueprintRecoverySpec: BaseType
    {
        #region members

        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        [JsonProperty("planType")]
        public PlanName? PlanType { get; set; }

        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        [JsonProperty("resourceSpecType")]
        public ResourceSpecType? ResourceSpecType { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }

        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        [JsonProperty("isPending")]
        public System.Boolean? IsPending { get; set; }

        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        [JsonProperty("recoverySpecId")]
        public System.String? RecoverySpecId { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        [JsonProperty("childRecoverySpecs")]
        public List<ChildRecoverySpecMap>? ChildRecoverySpecs { get; set; }


        #endregion

    #region methods

    public BlueprintRecoverySpec Set(
        PlanName? PlanType = null,
        ResourceSpecType? ResourceSpecType = null,
        System.String? FailoverId = null,
        System.Boolean? IsPending = null,
        System.String? RecoverySpecId = null,
        System.String? UserData = null,
        System.Int64? Version = null,
        List<ChildRecoverySpecMap>? ChildRecoverySpecs = null
    ) 
    {
        if ( PlanType != null ) {
            this.PlanType = PlanType;
        }
        if ( ResourceSpecType != null ) {
            this.ResourceSpecType = ResourceSpecType;
        }
        if ( FailoverId != null ) {
            this.FailoverId = FailoverId;
        }
        if ( IsPending != null ) {
            this.IsPending = IsPending;
        }
        if ( RecoverySpecId != null ) {
            this.RecoverySpecId = RecoverySpecId;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ChildRecoverySpecs != null ) {
            this.ChildRecoverySpecs = ChildRecoverySpecs;
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
        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        if (this.PlanType != null) {
            s += ind + "planType\n" ;
        }
        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        if (this.ResourceSpecType != null) {
            s += ind + "resourceSpecType\n" ;
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        if (this.FailoverId != null) {
            s += ind + "failoverId\n" ;
        }
        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        if (this.IsPending != null) {
            s += ind + "isPending\n" ;
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        if (this.RecoverySpecId != null) {
            s += ind + "recoverySpecId\n" ;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData != null) {
            s += ind + "userData\n" ;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        if (this.ChildRecoverySpecs != null) {
            s += ind + "childRecoverySpecs {\n" + this.ChildRecoverySpecs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PlanName? PlanType
        // GraphQL -> planType: PlanName! (enum)
        if (this.PlanType == null && Exploration.Includes(parent + ".planType", true))
        {
            this.PlanType = new PlanName();
        }
        //      C# -> ResourceSpecType? ResourceSpecType
        // GraphQL -> resourceSpecType: ResourceSpecType (enum)
        if (this.ResourceSpecType == null && Exploration.Includes(parent + ".resourceSpecType", true))
        {
            this.ResourceSpecType = new ResourceSpecType();
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        if (this.FailoverId == null && Exploration.Includes(parent + ".failoverId", true))
        {
            this.FailoverId = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsPending
        // GraphQL -> isPending: Boolean! (scalar)
        if (this.IsPending == null && Exploration.Includes(parent + ".isPending", true))
        {
            this.IsPending = true;
        }
        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        if (this.RecoverySpecId == null && Exploration.Includes(parent + ".recoverySpecId", true))
        {
            this.RecoverySpecId = new System.String("FETCH");
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData == null && Exploration.Includes(parent + ".userData", true))
        {
            this.UserData = new System.String("FETCH");
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.Int64();
        }
        //      C# -> List<ChildRecoverySpecMap>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMap!]! (type)
        if (this.ChildRecoverySpecs == null && Exploration.Includes(parent + ".childRecoverySpecs"))
        {
            this.ChildRecoverySpecs = new List<ChildRecoverySpecMap>();
            this.ChildRecoverySpecs.ApplyExploratoryFieldSpec(parent + ".childRecoverySpecs");
        }
    }


    #endregion

    } // class BlueprintRecoverySpec
    
    #endregion

    public static class ListBlueprintRecoverySpecExtensions
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
            this List<BlueprintRecoverySpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoverySpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types