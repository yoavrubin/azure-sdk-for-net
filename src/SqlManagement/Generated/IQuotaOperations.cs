// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The Azure SQL Database Management API includes operations for getting
    /// Azure SQL Database Server quotas. Specifically, using the APIs you can
    /// get a specific quota or list all of the quotas for the Azure SQL
    /// Database Server.
    /// </summary>
    public partial interface IQuotaOperations
    {
        /// <summary>
        /// Retrieves the specified quota from the server.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server from which to retrieve
        /// the quota.
        /// </param>
        /// <param name='quotaName'>
        /// The name of the quota to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response structure for the Quota Get operation.
        /// </returns>
        Task<QuotaGetResponse> GetAsync(string serverName, string quotaName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a list of quotas from the server.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server from which to get the
        /// quotas.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response structure for the Quota List operation.
        /// </returns>
        Task<QuotaListResponse> ListAsync(string serverName, CancellationToken cancellationToken);
    }
}
