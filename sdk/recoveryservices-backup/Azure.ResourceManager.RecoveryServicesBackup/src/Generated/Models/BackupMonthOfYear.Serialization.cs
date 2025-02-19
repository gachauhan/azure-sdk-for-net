// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal static partial class BackupMonthOfYearExtensions
    {
        public static string ToSerialString(this BackupMonthOfYear value) => value switch
        {
            BackupMonthOfYear.Invalid => "Invalid",
            BackupMonthOfYear.January => "January",
            BackupMonthOfYear.February => "February",
            BackupMonthOfYear.March => "March",
            BackupMonthOfYear.April => "April",
            BackupMonthOfYear.May => "May",
            BackupMonthOfYear.June => "June",
            BackupMonthOfYear.July => "July",
            BackupMonthOfYear.August => "August",
            BackupMonthOfYear.September => "September",
            BackupMonthOfYear.October => "October",
            BackupMonthOfYear.November => "November",
            BackupMonthOfYear.December => "December",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupMonthOfYear value.")
        };

        public static BackupMonthOfYear ToBackupMonthOfYear(this string value)
        {
            if (string.Equals(value, "Invalid", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.Invalid;
            if (string.Equals(value, "January", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.January;
            if (string.Equals(value, "February", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.February;
            if (string.Equals(value, "March", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.March;
            if (string.Equals(value, "April", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.April;
            if (string.Equals(value, "May", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.May;
            if (string.Equals(value, "June", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.June;
            if (string.Equals(value, "July", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.July;
            if (string.Equals(value, "August", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.August;
            if (string.Equals(value, "September", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.September;
            if (string.Equals(value, "October", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.October;
            if (string.Equals(value, "November", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.November;
            if (string.Equals(value, "December", StringComparison.InvariantCultureIgnoreCase)) return BackupMonthOfYear.December;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BackupMonthOfYear value.");
        }
    }
}
