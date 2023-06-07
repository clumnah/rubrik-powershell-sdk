// LicensedClusterProduct.cs
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
    #region LicensedClusterProduct
    public class LicensedClusterProduct: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        [JsonProperty("nextExpiringBytes")]
        public System.Single? NextExpiringBytes { get; set; }

        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        [JsonProperty("nextExpiringTime")]
        public DateTime? NextExpiringTime { get; set; }

        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        [JsonProperty("numClusters")]
        public System.Int32? NumClusters { get; set; }

        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        [JsonProperty("productTypes")]
        public List<System.String>? ProductTypes { get; set; }

        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        [JsonProperty("purchasedCapacityBytes")]
        public System.Single? PurchasedCapacityBytes { get; set; }

        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        [JsonProperty("registeredCapacityBytes")]
        public System.Single? RegisteredCapacityBytes { get; set; }

        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        [JsonProperty("contributions")]
        public List<CapacityContribution>? Contributions { get; set; }


        #endregion

    #region methods

    public LicensedClusterProduct Set(
        Product? Product = null,
        System.Single? NextExpiringBytes = null,
        DateTime? NextExpiringTime = null,
        System.Int32? NumClusters = null,
        List<System.String>? ProductTypes = null,
        System.Single? PurchasedCapacityBytes = null,
        System.Single? RegisteredCapacityBytes = null,
        List<CapacityContribution>? Contributions = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( NextExpiringBytes != null ) {
            this.NextExpiringBytes = NextExpiringBytes;
        }
        if ( NextExpiringTime != null ) {
            this.NextExpiringTime = NextExpiringTime;
        }
        if ( NumClusters != null ) {
            this.NumClusters = NumClusters;
        }
        if ( ProductTypes != null ) {
            this.ProductTypes = ProductTypes;
        }
        if ( PurchasedCapacityBytes != null ) {
            this.PurchasedCapacityBytes = PurchasedCapacityBytes;
        }
        if ( RegisteredCapacityBytes != null ) {
            this.RegisteredCapacityBytes = RegisteredCapacityBytes;
        }
        if ( Contributions != null ) {
            this.Contributions = Contributions;
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
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            s += ind + "product\n" ;
        }
        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        if (this.NextExpiringBytes != null) {
            s += ind + "nextExpiringBytes\n" ;
        }
        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        if (this.NextExpiringTime != null) {
            s += ind + "nextExpiringTime\n" ;
        }
        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        if (this.NumClusters != null) {
            s += ind + "numClusters\n" ;
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes != null) {
            s += ind + "productTypes\n" ;
        }
        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        if (this.PurchasedCapacityBytes != null) {
            s += ind + "purchasedCapacityBytes\n" ;
        }
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes != null) {
            s += ind + "registeredCapacityBytes\n" ;
        }
        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        if (this.Contributions != null) {
            s += ind + "contributions {\n" + this.Contributions.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product == null && Exploration.Includes(parent + ".product", true))
        {
            this.Product = new Product();
        }
        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        if (this.NextExpiringBytes == null && Exploration.Includes(parent + ".nextExpiringBytes", true))
        {
            this.NextExpiringBytes = new System.Single();
        }
        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        if (this.NextExpiringTime == null && Exploration.Includes(parent + ".nextExpiringTime", true))
        {
            this.NextExpiringTime = new DateTime();
        }
        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        if (this.NumClusters == null && Exploration.Includes(parent + ".numClusters", true))
        {
            this.NumClusters = Int32.MinValue;
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes == null && Exploration.Includes(parent + ".productTypes", true))
        {
            this.ProductTypes = new List<System.String>();
        }
        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        if (this.PurchasedCapacityBytes == null && Exploration.Includes(parent + ".purchasedCapacityBytes", true))
        {
            this.PurchasedCapacityBytes = new System.Single();
        }
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes == null && Exploration.Includes(parent + ".registeredCapacityBytes", true))
        {
            this.RegisteredCapacityBytes = new System.Single();
        }
        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        if (this.Contributions == null && Exploration.Includes(parent + ".contributions"))
        {
            this.Contributions = new List<CapacityContribution>();
            this.Contributions.ApplyExploratoryFieldSpec(parent + ".contributions");
        }
    }


    #endregion

    } // class LicensedClusterProduct
    
    #endregion

    public static class ListLicensedClusterProductExtensions
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
            this List<LicensedClusterProduct> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LicensedClusterProduct> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LicensedClusterProduct());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types