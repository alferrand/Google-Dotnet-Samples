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
// Unoffical sample for the Directory directory_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Admin SDK Directory API lets you view and manage enterprise resources such as users and groups, administrative notifications, security features, and more.
// API Documentation Link https://developers.google.com/admin-sdk/directory/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Directory/directory_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Directory.directory_v1/ 
// Install Command: PM>  Install-Package Google.Apis.Directory.directory_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Directory.directory_v1;
using Google.Apis.Directory.directory_v1.Data;
using System;

namespace GoogleSamplecSharpSample.Directorydirectory_v1.Methods
{
  
    public static class MembersSample
    {


        /// <summary>
        /// Remove membership. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group</param>
        /// <param name="memberKey">Email or immutable Id of the member</param>
        public static void Delete(DirectoryService service, string groupKey, string memberKey)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);
                if (memberKey == null)
                    throw new ArgumentNullException(memberKey);

                // Make the request.
                 service.Members.Delete(groupKey, memberKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieve Group Member 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group</param>
        /// <param name="memberKey">Email or immutable Id of the member</param>
        /// <returns>MemberResponse</returns>
        public static Member Get(DirectoryService service, string groupKey, string memberKey)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);
                if (memberKey == null)
                    throw new ArgumentNullException(memberKey);

                // Make the request.
                return service.Members.Get(groupKey, memberKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.Get failed.", ex);
            }
        }

        /// <summary>
        /// Add user to the specified group. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>MemberResponse</returns>
        public static Member Insert(DirectoryService service, string groupKey, Member body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);

                // Make the request.
                return service.Members.Insert(body, groupKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.Insert failed.", ex);
            }
        }
        public class MembersListOptionalParms
        {
            /// Maximum number of results to return. Default is 200
            public int? MaxResults { get; set; }  
            /// Token to specify next page in the list
            public string PageToken { get; set; }  
            /// Comma separated role values to filter list results on.
            public string Roles { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve all members in a group (paginated) 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>MembersResponse</returns>
        public static Members List(DirectoryService service, string groupKey, MembersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);

                // Building the initial request.
                var request = service.Members.List(groupKey);

                // Applying optional parameters to the request.                
                request = (MembersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.List failed.", ex);
            }
        }

        /// <summary>
        /// Update membership of a user in the specified group. This method supports patch semantics. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group. If Id, it should match with id of group object</param>
        /// <param name="memberKey">Email or immutable Id of the user. If Id, it should match with id of member object</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>MemberResponse</returns>
        public static Member Patch(DirectoryService service, string groupKey, string memberKey, Member body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);
                if (memberKey == null)
                    throw new ArgumentNullException(memberKey);

                // Make the request.
                return service.Members.Patch(body, groupKey, memberKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Update membership of a user in the specified group. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/members/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="groupKey">Email or immutable Id of the group. If Id, it should match with id of group object</param>
        /// <param name="memberKey">Email or immutable Id of the user. If Id, it should match with id of member object</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>MemberResponse</returns>
        public static Member Update(DirectoryService service, string groupKey, string memberKey, Member body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (groupKey == null)
                    throw new ArgumentNullException(groupKey);
                if (memberKey == null)
                    throw new ArgumentNullException(memberKey);

                // Make the request.
                return service.Members.Update(body, groupKey, memberKey).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.Update failed.", ex);
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