// Copyright 2024 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START spanner_list_backup_schedules]
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Common.V1;
using System;
using System.Collections.Generic;

public class ListBackupSchedulesSample
{
    public IEnumerable<BackupSchedule> ListBackupSchedules(string projectId, string instanceId, string databaseId)
    {
        DatabaseAdminClient client = DatabaseAdminClient.Create();

        var backupSchedules = client.ListBackupSchedules(
            new ListBackupSchedulesRequest
            {
                ParentAsDatabaseName = DatabaseName.FromProjectInstanceDatabase(projectId, instanceId, databaseId),
            });

        foreach (BackupSchedule backupSchedule in backupSchedules)
        {
            Console.WriteLine($"Backup schedule: {backupSchedule}");
        }
        return backupSchedules;
    }
}
// [END spanner_list_backup_schedules]
