// UpdateManagedVolumeReply.cs
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
    #region UpdateManagedVolumeReply
    public class UpdateManagedVolumeReply: BaseType
    {
        #region members

        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        [JsonProperty("applicationTag")]
        public ManagedVolumeApplicationTag? ApplicationTag { get; set; }

        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        [JsonProperty("mvType")]
        public CdmManagedVolumeType? MvType { get; set; }

        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        [JsonProperty("shareType")]
        public ManagedVolumeShareType? ShareType { get; set; }

        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        [JsonProperty("state")]
        public ManagedVolumeState? State { get; set; }

        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        [JsonProperty("isWritable")]
        public System.Boolean? IsWritable { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        [JsonProperty("pendingSnapshotCount")]
        public System.Int32? PendingSnapshotCount { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        [JsonProperty("usedSize")]
        public System.Int64? UsedSize { get; set; }

        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        [JsonProperty("volumeSize")]
        public System.Int64? VolumeSize { get; set; }

        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        [JsonProperty("links")]
        public List<Link>? Links { get; set; }

        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        [JsonProperty("mainExport")]
        public ManagedVolumeExport? MainExport { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        [JsonProperty("slaManagedVolumeDetails")]
        public SlaManagedVolumeDetail? SlaManagedVolumeDetails { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }


        #endregion

    #region methods

    public UpdateManagedVolumeReply Set(
        ManagedVolumeApplicationTag? ApplicationTag = null,
        CdmManagedVolumeType? MvType = null,
        ManagedVolumeShareType? ShareType = null,
        ManagedVolumeState? State = null,
        List<System.String>? HostPatterns = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsWritable = null,
        System.Int32? NumChannels = null,
        System.Int32? PendingSnapshotCount = null,
        System.String? SmbDomainName = null,
        List<System.String>? SmbValidIps = null,
        List<System.String>? SmbValidUsers = null,
        System.Int32? SnapshotCount = null,
        System.String? Subnet = null,
        System.Int64? UsedSize = null,
        System.Int64? VolumeSize = null,
        List<Link>? Links = null,
        ManagedVolumeExport? MainExport = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        SlaManagedVolumeDetail? SlaManagedVolumeDetails = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( ApplicationTag != null ) {
            this.ApplicationTag = ApplicationTag;
        }
        if ( MvType != null ) {
            this.MvType = MvType;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( HostPatterns != null ) {
            this.HostPatterns = HostPatterns;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsWritable != null ) {
            this.IsWritable = IsWritable;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( PendingSnapshotCount != null ) {
            this.PendingSnapshotCount = PendingSnapshotCount;
        }
        if ( SmbDomainName != null ) {
            this.SmbDomainName = SmbDomainName;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
        }
        if ( SmbValidUsers != null ) {
            this.SmbValidUsers = SmbValidUsers;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( UsedSize != null ) {
            this.UsedSize = UsedSize;
        }
        if ( VolumeSize != null ) {
            this.VolumeSize = VolumeSize;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( MainExport != null ) {
            this.MainExport = MainExport;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( SlaManagedVolumeDetails != null ) {
            this.SlaManagedVolumeDetails = SlaManagedVolumeDetails;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (this.ApplicationTag != null) {
            s += ind + "applicationTag\n" ;
        }
        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        if (this.MvType != null) {
            s += ind + "mvType\n" ;
        }
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        if (this.ShareType != null) {
            s += ind + "shareType\n" ;
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns != null) {
            s += ind + "hostPatterns\n" ;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            s += ind + "isDeleted\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        if (this.IsWritable != null) {
            s += ind + "isWritable\n" ;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            s += ind + "numChannels\n" ;
        }
        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        if (this.PendingSnapshotCount != null) {
            s += ind + "pendingSnapshotCount\n" ;
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName != null) {
            s += ind + "smbDomainName\n" ;
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps != null) {
            s += ind + "smbValidIps\n" ;
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers != null) {
            s += ind + "smbValidUsers\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet != null) {
            s += ind + "subnet\n" ;
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize != null) {
            s += ind + "usedSize\n" ;
        }
        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        if (this.VolumeSize != null) {
            s += ind + "volumeSize\n" ;
        }
        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        if (this.Links != null) {
            s += ind + "links {\n" + this.Links.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        if (this.MainExport != null) {
            s += ind + "mainExport {\n" + this.MainExport.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            s += ind + "pendingSlaDomain {\n" + this.PendingSlaDomain.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        if (this.SlaManagedVolumeDetails != null) {
            s += ind + "slaManagedVolumeDetails {\n" + this.SlaManagedVolumeDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            s += ind + "snappable {\n" + this.Snappable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (this.ApplicationTag == null && Exploration.Includes(parent + ".applicationTag", true))
        {
            this.ApplicationTag = new ManagedVolumeApplicationTag();
        }
        //      C# -> CdmManagedVolumeType? MvType
        // GraphQL -> mvType: CdmManagedVolumeType (enum)
        if (this.MvType == null && Exploration.Includes(parent + ".mvType", true))
        {
            this.MvType = new CdmManagedVolumeType();
        }
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType! (enum)
        if (this.ShareType == null && Exploration.Includes(parent + ".shareType", true))
        {
            this.ShareType = new ManagedVolumeShareType();
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new ManagedVolumeState();
        }
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        if (this.HostPatterns == null && Exploration.Includes(parent + ".hostPatterns", true))
        {
            this.HostPatterns = new List<System.String>();
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted == null && Exploration.Includes(parent + ".isDeleted", true))
        {
            this.IsDeleted = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.Boolean? IsWritable
        // GraphQL -> isWritable: Boolean! (scalar)
        if (this.IsWritable == null && Exploration.Includes(parent + ".isWritable", true))
        {
            this.IsWritable = true;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels", true))
        {
            this.NumChannels = Int32.MinValue;
        }
        //      C# -> System.Int32? PendingSnapshotCount
        // GraphQL -> pendingSnapshotCount: Int! (scalar)
        if (this.PendingSnapshotCount == null && Exploration.Includes(parent + ".pendingSnapshotCount", true))
        {
            this.PendingSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        if (this.SmbDomainName == null && Exploration.Includes(parent + ".smbDomainName", true))
        {
            this.SmbDomainName = "FETCH";
        }
        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        if (this.SmbValidIps == null && Exploration.Includes(parent + ".smbValidIps", true))
        {
            this.SmbValidIps = new List<System.String>();
        }
        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        if (this.SmbValidUsers == null && Exploration.Includes(parent + ".smbValidUsers", true))
        {
            this.SmbValidUsers = new List<System.String>();
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet == null && Exploration.Includes(parent + ".subnet", true))
        {
            this.Subnet = "FETCH";
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize == null && Exploration.Includes(parent + ".usedSize", true))
        {
            this.UsedSize = new System.Int64();
        }
        //      C# -> System.Int64? VolumeSize
        // GraphQL -> volumeSize: Long! (scalar)
        if (this.VolumeSize == null && Exploration.Includes(parent + ".volumeSize", true))
        {
            this.VolumeSize = new System.Int64();
        }
        //      C# -> List<Link>? Links
        // GraphQL -> links: [Link!]! (type)
        if (this.Links == null && Exploration.Includes(parent + ".links"))
        {
            this.Links = new List<Link>();
            this.Links.ApplyExploratoryFieldSpec(parent + ".links");
        }
        //      C# -> ManagedVolumeExport? MainExport
        // GraphQL -> mainExport: ManagedVolumeExport (type)
        if (this.MainExport == null && Exploration.Includes(parent + ".mainExport"))
        {
            this.MainExport = new ManagedVolumeExport();
            this.MainExport.ApplyExploratoryFieldSpec(parent + ".mainExport");
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(parent + ".pendingSlaDomain");
        }
        //      C# -> SlaManagedVolumeDetail? SlaManagedVolumeDetails
        // GraphQL -> slaManagedVolumeDetails: SlaManagedVolumeDetail (type)
        if (this.SlaManagedVolumeDetails == null && Exploration.Includes(parent + ".slaManagedVolumeDetails"))
        {
            this.SlaManagedVolumeDetails = new SlaManagedVolumeDetail();
            this.SlaManagedVolumeDetails.ApplyExploratoryFieldSpec(parent + ".slaManagedVolumeDetails");
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
        {
            this.Snappable = new CdmWorkload();
            this.Snappable.ApplyExploratoryFieldSpec(parent + ".snappable");
        }
    }


    #endregion

    } // class UpdateManagedVolumeReply
    
    #endregion

    public static class ListUpdateManagedVolumeReplyExtensions
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
            this List<UpdateManagedVolumeReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateManagedVolumeReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateManagedVolumeReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types