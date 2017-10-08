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
// Unoffical sample for the Drive v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev2.Methods
{
  
    public static class PropertiesSample
    {

        public class PropertiesDeleteOptionalParms
        {
            /// The visibility of the property.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a property. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(DriveService service, string fileId, string propertyKey, PropertiesDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (propertyKey == null)
                    throw new ArgumentNullException(propertyKey);

                // Building the initial request.
                var request = service.Properties.Delete(fileId, propertyKey);

                // Applying optional parameters to the request.                
                request = (PropertiesResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.Delete failed.", ex);
            }
        }
        public class PropertiesGetOptionalParms
        {
            /// The visibility of the property.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Gets a property by its key. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PropertyResponse</returns>
        public static Property Get(DriveService service, string fileId, string propertyKey, PropertiesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (propertyKey == null)
                    throw new ArgumentNullException(propertyKey);

                // Building the initial request.
                var request = service.Properties.Get(fileId, propertyKey);

                // Applying optional parameters to the request.                
                request = (PropertiesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.Get failed.", ex);
            }
        }

        /// <summary>
        /// Adds a property to a file, or updates it if it already exists. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <returns>PropertyResponse</returns>
        public static Property Insert(DriveService service, string fileId, Property body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Make the request.
                return service.Properties.Insert(body, fileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Lists a file's properties. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <returns>PropertyListResponse</returns>
        public static PropertyList List(DriveService service, string fileId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Make the request.
                return service.Properties.List(fileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.List failed.", ex);
            }
        }
        public class PropertiesPatchOptionalParms
        {
            /// The visibility of the property.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a property, or adds it if it doesn't exist. This method supports patch semantics. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PropertyResponse</returns>
        public static Property Patch(DriveService service, string fileId, string propertyKey, Property body, PropertiesPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (propertyKey == null)
                    throw new ArgumentNullException(propertyKey);

                // Building the initial request.
                var request = service.Properties.Patch(body, fileId, propertyKey);

                // Applying optional parameters to the request.                
                request = (PropertiesResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.Patch failed.", ex);
            }
        }
        public class PropertiesUpdateOptionalParms
        {
            /// The visibility of the property.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a property, or adds it if it doesn't exist. 
        /// Documentation https://developers.google.com/drive/v2/reference/properties/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="propertyKey">The key of the property.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PropertyResponse</returns>
        public static Property Update(DriveService service, string fileId, string propertyKey, Property body, PropertiesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (propertyKey == null)
                    throw new ArgumentNullException(propertyKey);

                // Building the initial request.
                var request = service.Properties.Update(body, fileId, propertyKey);

                // Applying optional parameters to the request.                
                request = (PropertiesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Properties.Update failed.", ex);
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