// LabelType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region LabelType

    public class LabelType: IInput
    {
        #region members

        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("labelKey")]
        public System.String? LabelKey { get; set; }

        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("labelValue")]
        public System.String? LabelValue { get; set; }

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class LabelType
    #endregion

} // namespace RubrikSecurityCloud.Types