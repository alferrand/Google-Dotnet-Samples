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
// Unoffical sample for the Blogger v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for access to the data within Blogger.
// API Documentation Link https://developers.google.com/blogger/docs/3.0/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Blogger/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Blogger.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Blogger.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Bloggerv3.Methods
{
  
    public static class PostUserInfosSample
    {

        public class PostUserInfosGetOptionalParms
        {
            /// Maximum number of comments to pull back on a post.
            public int? MaxComments { get; set; }  
        
        }
 
        /// <summary>
        /// Gets one post and user info pair, by post ID and user ID. The post user info contains per-user information about the post, such as access rights, specific to the user. 
        /// Documentation https://developers.google.com/blogger/v3/reference/postUserInfos/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="userId">ID of the user for the per-user information to be fetched. Either the word 'self' (sans quote marks) or the user's profile identifier.</param>
        /// <param name="blogId">The ID of the blog.</param>
        /// <param name="postId">The ID of the post to get.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PostUserInfoResponse</returns>
        public static PostUserInfo Get(BloggerService service, string userId, string blogId, string postId, PostUserInfosGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (blogId == null)
                    throw new ArgumentNullException(blogId);
                if (postId == null)
                    throw new ArgumentNullException(postId);

                // Building the initial request.
                var request = service.PostUserInfos.Get(userId, blogId, postId);

                // Applying optional parameters to the request.                
                request = (PostUserInfosResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PostUserInfos.Get failed.", ex);
            }
        }
        public class PostUserInfosListOptionalParms
        {
            /// Latest post date to fetch, a date-time with RFC 3339 formatting.
            public string EndDate { get; set; }  
            /// Whether the body content of posts is included. Default is false.
            public bool? FetchBodies { get; set; }  
            /// Comma-separated list of labels to search for.
            public string Labels { get; set; }  
            /// Maximum number of posts to fetch.
            public int? MaxResults { get; set; }  
            /// Sort order applied to search results. Default is published.
            public string OrderBy { get; set; }  
            /// Continuation token if the request is paged.
            public string PageToken { get; set; }  
            /// Earliest post date to fetch, a date-time with RFC 3339 formatting.
            public string StartDate { get; set; }  
            /// NA
            public string Status { get; set; }  
            /// Access level with which to view the returned result. Note that some fields require elevated access.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of post and post user info pairs, possibly filtered. The post user info contains per-user information about the post, such as access rights, specific to the user. 
        /// Documentation https://developers.google.com/blogger/v3/reference/postUserInfos/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Blogger service.</param>  
        /// <param name="userId">ID of the user for the per-user information to be fetched. Either the word 'self' (sans quote marks) or the user's profile identifier.</param>
        /// <param name="blogId">ID of the blog to fetch posts from.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PostUserInfosListResponse</returns>
        public static PostUserInfosList List(BloggerService service, string userId, string blogId, PostUserInfosListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (blogId == null)
                    throw new ArgumentNullException(blogId);

                // Building the initial request.
                var request = service.PostUserInfos.List(userId, blogId);

                // Applying optional parameters to the request.                
                request = (PostUserInfosResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PostUserInfos.List failed.", ex);
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