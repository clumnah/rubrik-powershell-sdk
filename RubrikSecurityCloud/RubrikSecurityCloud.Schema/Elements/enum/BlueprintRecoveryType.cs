// BlueprintRecoveryType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum BlueprintRecoveryType
    {
        [EnumMember(Value = "CYBER_RECOVERY")]
        CYBER_RECOVERY,

        [EnumMember(Value = "DISASTER_RECOVERY")]
        DISASTER_RECOVERY,

        [EnumMember(Value = "IN_PLACE_RECOVERY")]
        IN_PLACE_RECOVERY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BlueprintRecoveryType

} // namespace RubrikSecurityCloud.Types