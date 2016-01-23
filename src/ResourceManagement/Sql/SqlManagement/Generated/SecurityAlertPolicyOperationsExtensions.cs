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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class SecurityAlertPolicyOperationsExtensions
    {
        /// <summary>
        /// Creates or updates an Azure SQL Database security alert policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISecurityAlertPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// alert policy applies.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Azure
        /// SQL Database security alert policy.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse CreateOrUpdateDatabaseSecurityAlertPolicy(this ISecurityAlertPolicyOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseSecurityAlertPolicyCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityAlertPolicyOperations)s).CreateOrUpdateDatabaseSecurityAlertPolicyAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates or updates an Azure SQL Database security alert policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISecurityAlertPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// alert policy applies.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for creating or updating a Azure
        /// SQL Database security alert policy.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateOrUpdateDatabaseSecurityAlertPolicyAsync(this ISecurityAlertPolicyOperations operations, string resourceGroupName, string serverName, string databaseName, DatabaseSecurityAlertPolicyCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateDatabaseSecurityAlertPolicyAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns an Azure SQL Database security alert policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISecurityAlertPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// alert policy applies.
        /// </param>
        /// <returns>
        /// Represents the response to a get database security alert policy
        /// request.
        /// </returns>
        public static DatabaseSecurityAlertPolicyGetResponse GetDatabaseSecurityAlertPolicy(this ISecurityAlertPolicyOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISecurityAlertPolicyOperations)s).GetDatabaseSecurityAlertPolicyAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns an Azure SQL Database security alert policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.ISecurityAlertPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database for which the security
        /// alert policy applies.
        /// </param>
        /// <returns>
        /// Represents the response to a get database security alert policy
        /// request.
        /// </returns>
        public static Task<DatabaseSecurityAlertPolicyGetResponse> GetDatabaseSecurityAlertPolicyAsync(this ISecurityAlertPolicyOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.GetDatabaseSecurityAlertPolicyAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
    }
}