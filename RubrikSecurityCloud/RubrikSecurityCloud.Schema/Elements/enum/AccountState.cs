// AccountState.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AccountState
    {
        [EnumMember(Value = "ACTIVE_STATE")]
        ACTIVE_STATE,

        [EnumMember(Value = "DELETED_STATE")]
        DELETED_STATE,

        [EnumMember(Value = "GRACE_STATE")]
        GRACE_STATE,

        [EnumMember(Value = "HOLD_STATE")]
        HOLD_STATE,

        [EnumMember(Value = "MARKED_FOR_DELETION_STATE")]
        MARKED_FOR_DELETION_STATE


    } // enum AccountState

} // namespace Rubrik.SecurityCloud.Types