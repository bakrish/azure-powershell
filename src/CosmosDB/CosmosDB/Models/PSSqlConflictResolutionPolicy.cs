﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.CosmosDB.Models
{

    public class PSSqlConflictResolutionPolicy
    {
        public PSSqlConflictResolutionPolicy()
        {
        }

        public PSSqlConflictResolutionPolicy(string type)
        {
            Type = type;
        }

        public PSSqlConflictResolutionPolicy(string type, string path, string conflictResolutionProcedure)
        {
            Type = type;
            Path = path;
            ConflictResolutionProcedure = conflictResolutionProcedure;
        }

        public string Type { get; set; }

        public string Path { get; set; }

        public string ConflictResolutionProcedure { get; set; }
    }
}