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
// Unoffical sample for the Appstate v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Google App State API.
// API Documentation Link https://developers.google.com/games/services/web/api/states
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Appstate/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Appstate.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Appstate.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Appstate.v1;
using Google.Apis.Appstate.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Appstatev1.Methods
{
  
    public static class StatesSample
    {

        public class StatesClearOptionalParms
        {
            /// The version of the data to be cleared. Version strings are returned by the server.
            public string CurrentDataVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Clears (sets to empty) the data for the passed key if and only if the passed version matches the currently stored version. This method results in a conflict error on version mismatch. 
        /// Documentation https://developers.google.com/appstate/v1/reference/states/clear
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Appstate service.</param>  
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>WriteResultResponse</returns>
        public static WriteResult Clear(AppstateService service, int? stateKey, StatesClearOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (stateKey == null)
                    throw new ArgumentNullException(stateKey);

                // Building the initial request.
                var request = service.States.Clear(stateKey);

                // Applying optional parameters to the request.                
                request = (StatesResource.ClearRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request States.Clear failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a key and the data associated with it. The key is removed and no longer counts against the key quota. Note that since this method is not safe in the face of concurrent modifications, it should only be used for development and testing purposes. Invoking this method in shipping code can result in data loss and data corruption. 
        /// Documentation https://developers.google.com/appstate/v1/reference/states/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Appstate service.</param>  
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        public static void Delete(AppstateService service, int? stateKey)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (stateKey == null)
                    throw new ArgumentNullException(stateKey);

                // Make the request.
                 service.States.Delete(stateKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request States.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the data corresponding to the passed key. If the key does not exist on the server, an HTTP 404 will be returned. 
        /// Documentation https://developers.google.com/appstate/v1/reference/states/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Appstate service.</param>  
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        /// <returns>GetResponseResponse</returns>
        public static GetResponse Get(AppstateService service, int? stateKey)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (stateKey == null)
                    throw new ArgumentNullException(stateKey);

                // Make the request.
                return service.States.Get(stateKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request States.Get failed.", ex);
            }
        }
        public class StatesListOptionalParms
        {
            /// Whether to include the full data in addition to the version number
            public bool? IncludeData { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all the states keys, and optionally the state data. 
        /// Documentation https://developers.google.com/appstate/v1/reference/states/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Appstate service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListResponseResponse</returns>
        public static ListResponse List(AppstateService service, StatesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.States.List();

                // Applying optional parameters to the request.                
                request = (StatesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request States.List failed.", ex);
            }
        }
        public class StatesUpdateOptionalParms
        {
            /// The version of the app state your application is attempting to update. If this does not match the current version, this method will return a conflict error. If there is no data stored on the server for this key, the update will succeed irrespective of the value of this parameter.
            public string CurrentStateVersion { get; set; }  
        
        }
 
        /// <summary>
        /// Update the data associated with the input key if and only if the passed version matches the currently stored version. This method is safe in the face of concurrent writes. Maximum per-key size is 128KB. 
        /// Documentation https://developers.google.com/appstate/v1/reference/states/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Appstate service.</param>  
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        /// <param name="body">A valid Appstate v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>WriteResultResponse</returns>
        public static WriteResult Update(AppstateService service, int? stateKey, UpdateRequest body, StatesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (stateKey == null)
                    throw new ArgumentNullException(stateKey);

                // Building the initial request.
                var request = service.States.Update(body, stateKey);

                // Applying optional parameters to the request.                
                request = (StatesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request States.Update failed.", ex);
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