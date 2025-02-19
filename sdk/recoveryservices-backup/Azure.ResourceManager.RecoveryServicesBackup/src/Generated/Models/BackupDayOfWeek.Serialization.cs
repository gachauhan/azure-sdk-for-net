// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal static partial class BackupDayOfWeekExtensions
    {
        public static string ToSerialString(this BackupDayOfWeek value) => value switch
        {
            BackupDayOfWeek.Sunday => "Sunday",
            BackupDayOfWeek.Monday => "Monday",
            BackupDayOfWeek.Tuesday => "Tuesday",
            BackupDayOfWeek.Wednesday => "Wednesday",
            BackupDayOfWeek.Thursday => "Thursday",
            BackupDayOfWeek.Friday => "Friday",
            BackupDayOfWeek.Saturday => "Saturday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupDayOfWeek value.")
        };

        public static BackupDayOfWeek ToBackupDayOfWeek(this string value)
        {
            if (string.Equals(value, "Sunday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Sunday;
            if (string.Equals(value, "Monday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Monday;
            if (string.Equals(value, "Tuesday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Tuesday;
            if (string.Equals(value, "Wednesday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Wednesday;
            if (string.Equals(value, "Thursday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Thursday;
            if (string.Equals(value, "Friday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Friday;
            if (string.Equals(value, "Saturday", StringComparison.InvariantCultureIgnoreCase)) return BackupDayOfWeek.Saturday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupDayOfWeek value.");
        }
    }
}
