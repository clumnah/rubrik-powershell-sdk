// TimeRangeInput.cs
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
    #region TimeRangeInput

    public class TimeRangeInput: IInput
    {
        #region members

        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("end")]
        public DateTime? End { get; set; }


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

    } // class TimeRangeInput
    #endregion

} // namespace RubrikSecurityCloud.Types