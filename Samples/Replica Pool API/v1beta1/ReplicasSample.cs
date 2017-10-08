﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-10-08
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Replicapool v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Replica Pool API allows users to declaratively provision and manage groups of Google Compute Engine instances based on a common template.
// API Documentation Link https://developers.google.com/compute/docs/replica-pool/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Replicapool/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Replicapool.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Replicapool.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Replicapool.v1beta1;
using Google.Apis.Replicapool.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Replicapoolv1beta1.Methods
{
  
    public static class ReplicasSample
    {


        /// <summary>
        /// Deletes a replica from the pool. 
        /// Documentation https://developers.google.com/replicapool/v1beta1/reference/replicas/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Replicapool service.</param>  
        /// <param name="projectName">The project ID for this request.</param>
        /// <param name="zone">The zone where the replica lives.</param>
        /// <param name="poolName">The replica pool name for this request.</param>
        /// <param name="replicaName">The name of the replica for this request.</param>
        /// <param name="body">A valid Replicapool v1beta1 body.</param>
        /// <returns>ReplicaResponse</returns>
        public static Replica Delete(ReplicapoolService service, string projectName, string zone, string poolName, string replicaName, ReplicasDeleteRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectName == null)
                    throw new ArgumentNullException(projectName);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (poolName == null)
                    throw new ArgumentNullException(poolName);
                if (replicaName == null)
                    throw new ArgumentNullException(replicaName);

                // Make the request.
                return service.Replicas.Delete(body, projectName, zone, poolName, replicaName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Replicas.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets information about a specific replica. 
        /// Documentation https://developers.google.com/replicapool/v1beta1/reference/replicas/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Replicapool service.</param>  
        /// <param name="projectName">The project ID for this request.</param>
        /// <param name="zone">The zone where the replica lives.</param>
        /// <param name="poolName">The replica pool name for this request.</param>
        /// <param name="replicaName">The name of the replica for this request.</param>
        /// <returns>ReplicaResponse</returns>
        public static Replica Get(ReplicapoolService service, string projectName, string zone, string poolName, string replicaName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectName == null)
                    throw new ArgumentNullException(projectName);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (poolName == null)
                    throw new ArgumentNullException(poolName);
                if (replicaName == null)
                    throw new ArgumentNullException(replicaName);

                // Make the request.
                return service.Replicas.Get(projectName, zone, poolName, replicaName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Replicas.Get failed.", ex);
            }
        }
        public class ReplicasListOptionalParms
        {
            /// Maximum count of results to be returned. Acceptable values are 0 to 100, inclusive. (Default: 50)
            public int? MaxResults { get; set; }  
            /// Set this to the nextPageToken value returned by a previous list request to obtain the next page of results from the previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all replicas in a pool. 
        /// Documentation https://developers.google.com/replicapool/v1beta1/reference/replicas/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Replicapool service.</param>  
        /// <param name="projectName">The project ID for this request.</param>
        /// <param name="zone">The zone where the replica pool lives.</param>
        /// <param name="poolName">The replica pool name for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ReplicasListResponseResponse</returns>
        public static ReplicasListResponse List(ReplicapoolService service, string projectName, string zone, string poolName, ReplicasListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectName == null)
                    throw new ArgumentNullException(projectName);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (poolName == null)
                    throw new ArgumentNullException(poolName);

                // Building the initial request.
                var request = service.Replicas.List(projectName, zone, poolName);

                // Applying optional parameters to the request.                
                request = (ReplicasResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Replicas.List failed.", ex);
            }
        }

        /// <summary>
        /// Restarts a replica in a pool. 
        /// Documentation https://developers.google.com/replicapool/v1beta1/reference/replicas/restart
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Replicapool service.</param>  
        /// <param name="projectName">The project ID for this request.</param>
        /// <param name="zone">The zone where the replica lives.</param>
        /// <param name="poolName">The replica pool name for this request.</param>
        /// <param name="replicaName">The name of the replica for this request.</param>
        /// <returns>ReplicaResponse</returns>
        public static Replica Restart(ReplicapoolService service, string projectName, string zone, string poolName, string replicaName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectName == null)
                    throw new ArgumentNullException(projectName);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (poolName == null)
                    throw new ArgumentNullException(poolName);
                if (replicaName == null)
                    throw new ArgumentNullException(replicaName);

                // Make the request.
                return service.Replicas.Restart(projectName, zone, poolName, replicaName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Replicas.Restart failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}