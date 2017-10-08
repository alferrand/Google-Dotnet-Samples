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
// Unoffical sample for the Shoppingcontent v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages product items, inventory, and Merchant Center accounts for Google Shopping.
// API Documentation Link https://developers.google.com/shopping-content
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Shoppingcontent/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Shoppingcontent.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Shoppingcontent.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Shoppingcontent.v2;
using Google.Apis.Shoppingcontent.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Shoppingcontentv2.Methods
{
  
    public static class AccountstatusesSample
    {


        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/accountstatuses/custombatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <returns>AccountstatusesCustomBatchResponseResponse</returns>
        public static AccountstatusesCustomBatchResponse Custombatch(ShoppingcontentService service, AccountstatusesCustomBatchRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Accountstatuses.Custombatch(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Accountstatuses.Custombatch failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the status of a Merchant Center account. This method can only be called for accounts to which the managing account has access: either the managing account itself for any Merchant Center account, or any sub-account when the managing account is a multi-client account. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/accountstatuses/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="accountId">The ID of the account.</param>
        /// <returns>AccountStatusResponse</returns>
        public static AccountStatus Get(ShoppingcontentService service, string merchantId, string accountId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Make the request.
                return service.Accountstatuses.Get(merchantId, accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Accountstatuses.Get failed.", ex);
            }
        }
        public class AccountstatusesListOptionalParms
        {
            /// The maximum number of account statuses to return in the response, used for paging.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the statuses of the sub-accounts in your Merchant Center account. This method can only be called for multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/accountstatuses/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AccountstatusesListResponseResponse</returns>
        public static AccountstatusesListResponse List(ShoppingcontentService service, string merchantId, AccountstatusesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Accountstatuses.List(merchantId);

                // Applying optional parameters to the request.                
                request = (AccountstatusesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Accountstatuses.List failed.", ex);
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