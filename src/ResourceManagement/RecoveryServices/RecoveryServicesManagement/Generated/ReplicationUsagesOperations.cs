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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of vault usage operations for the Recovery Services
    /// extension.
    /// </summary>
    internal partial class ReplicationUsagesOperations : IServiceOperations<RecoveryServicesManagementClient>, IReplicationUsagesOperations
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationUsagesOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ReplicationUsagesOperations(RecoveryServicesManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.RecoveryServicesManagementClient.
        /// </summary>
        public RecoveryServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the replication usages of a vault.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource group/ Cloud service containing
        /// the resource/ Vault collection.
        /// </param>
        /// <param name='resourceName'>
        /// Required. The name of the resource.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Replication Usgaes.
        /// </returns>
        public async Task<ReplicationUsagesResponse> GetAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("resourceName", resourceName);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/replicationUsages";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ReplicationUsagesResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ReplicationUsagesResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            ReplicationUsages replicationUsagesInstance = new ReplicationUsages();
                            result.ReplicationVaultUsages = replicationUsagesInstance;
                            
                            JToken monitoringSummaryValue = responseDoc["monitoringSummary"];
                            if (monitoringSummaryValue != null && monitoringSummaryValue.Type != JTokenType.Null)
                            {
                                MonitoringSummary monitoringSummaryInstance = new MonitoringSummary();
                                replicationUsagesInstance.MonitoringSummary = monitoringSummaryInstance;
                                
                                JToken unHealthyVmCountValue = monitoringSummaryValue["unHealthyVmCount"];
                                if (unHealthyVmCountValue != null && unHealthyVmCountValue.Type != JTokenType.Null)
                                {
                                    int unHealthyVmCountInstance = ((int)unHealthyVmCountValue);
                                    monitoringSummaryInstance.UnHealthyVmCount = unHealthyVmCountInstance;
                                }
                                
                                JToken unHealthyProviderCountValue = monitoringSummaryValue["unHealthyProviderCount"];
                                if (unHealthyProviderCountValue != null && unHealthyProviderCountValue.Type != JTokenType.Null)
                                {
                                    int unHealthyProviderCountInstance = ((int)unHealthyProviderCountValue);
                                    monitoringSummaryInstance.UnHealthyProviderCount = unHealthyProviderCountInstance;
                                }
                                
                                JToken eventsCountValue = monitoringSummaryValue["eventsCount"];
                                if (eventsCountValue != null && eventsCountValue.Type != JTokenType.Null)
                                {
                                    int eventsCountInstance = ((int)eventsCountValue);
                                    monitoringSummaryInstance.EventsCount = eventsCountInstance;
                                }
                            }
                            
                            JToken jobsSummaryValue = responseDoc["jobsSummary"];
                            if (jobsSummaryValue != null && jobsSummaryValue.Type != JTokenType.Null)
                            {
                                JobsSummary jobsSummaryInstance = new JobsSummary();
                                replicationUsagesInstance.JobsSummary = jobsSummaryInstance;
                                
                                JToken failedJobsValue = jobsSummaryValue["failedJobs"];
                                if (failedJobsValue != null && failedJobsValue.Type != JTokenType.Null)
                                {
                                    int failedJobsInstance = ((int)failedJobsValue);
                                    jobsSummaryInstance.FailedJobs = failedJobsInstance;
                                }
                                
                                JToken suspendedJobsValue = jobsSummaryValue["suspendedJobs"];
                                if (suspendedJobsValue != null && suspendedJobsValue.Type != JTokenType.Null)
                                {
                                    int suspendedJobsInstance = ((int)suspendedJobsValue);
                                    jobsSummaryInstance.SuspendedJobs = suspendedJobsInstance;
                                }
                                
                                JToken inProgressJobsValue = jobsSummaryValue["inProgressJobs"];
                                if (inProgressJobsValue != null && inProgressJobsValue.Type != JTokenType.Null)
                                {
                                    int inProgressJobsInstance = ((int)inProgressJobsValue);
                                    jobsSummaryInstance.InProgressJobs = inProgressJobsInstance;
                                }
                            }
                            
                            JToken protectedItemCountValue = responseDoc["protectedItemCount"];
                            if (protectedItemCountValue != null && protectedItemCountValue.Type != JTokenType.Null)
                            {
                                int protectedItemCountInstance = ((int)protectedItemCountValue);
                                replicationUsagesInstance.ProtectedItemCount = protectedItemCountInstance;
                            }
                            
                            JToken recoveryPlanCountValue = responseDoc["recoveryPlanCount"];
                            if (recoveryPlanCountValue != null && recoveryPlanCountValue.Type != JTokenType.Null)
                            {
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
