// VcdClusterBaseConfig.cs
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
    #region VcdClusterBaseConfig
    public class VcdClusterBaseConfig: BaseType
    {
        #region members

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public VcdClusterBaseConfig Set(
        System.String? CaCerts = null,
        System.String? Hostname = null,
        System.String? Username = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts != null) {
            s += ind + "caCerts\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts", true))
        {
            this.CaCerts = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class VcdClusterBaseConfig
    
    #endregion

    public static class ListVcdClusterBaseConfigExtensions
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
            this List<VcdClusterBaseConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdClusterBaseConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdClusterBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types