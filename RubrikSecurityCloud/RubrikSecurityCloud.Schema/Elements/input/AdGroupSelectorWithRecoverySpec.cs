// AdGroupSelectorWithRecoverySpec.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AdGroupSelectorWithRecoverySpec

    public class AdGroupSelectorWithRecoverySpec: IInput
    {
        #region members

        //      C# -> BaseO365SelectorWithRecoverySpec? BaseInfo
        // GraphQL -> baseInfo: BaseO365SelectorWithRecoverySpec! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("baseInfo")]
        public BaseO365SelectorWithRecoverySpec? BaseInfo { get; set; }

        //      C# -> System.String? AdGroupId
        // GraphQL -> adGroupId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("adGroupId")]
        public System.String? AdGroupId { get; set; }


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

    } // class AdGroupSelectorWithRecoverySpec
    #endregion

} // namespace Rubrik.SecurityCloud.Types