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
// Unoffical sample for the Books v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches for books and manages your Google Books library.
// API Documentation Link https://developers.google.com/books/docs/v1/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Books/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Books.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Books.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Booksv1.Methods
{
  
    public static class PromoofferSample
    {

        public class PromoofferAcceptOptionalParms
        {
            /// device android_id
            public string AndroidId { get; set; }  
            /// device device
            public string Device { get; set; }  
            /// device manufacturer
            public string Manufacturer { get; set; }  
            /// device model
            public string Model { get; set; }  
            /// NA
            public string OfferId { get; set; }  
            /// device product
            public string Product { get; set; }  
            /// device serial
            public string Serial { get; set; }  
            /// Volume id to exercise the offer
            public string VolumeId { get; set; }  
        
        }
 
        /// <summary>
        ///  
        /// Documentation https://developers.google.com/books/v1/reference/promooffer/accept
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        public static void Accept(BooksService service, PromoofferAcceptOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Promooffer.Accept();

                // Applying optional parameters to the request.                
                request = (PromoofferResource.AcceptRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Promooffer.Accept failed.", ex);
            }
        }
        public class PromoofferDismissOptionalParms
        {
            /// device android_id
            public string AndroidId { get; set; }  
            /// device device
            public string Device { get; set; }  
            /// device manufacturer
            public string Manufacturer { get; set; }  
            /// device model
            public string Model { get; set; }  
            /// Offer to dimiss
            public string OfferId { get; set; }  
            /// device product
            public string Product { get; set; }  
            /// device serial
            public string Serial { get; set; }  
        
        }
 
        /// <summary>
        ///  
        /// Documentation https://developers.google.com/books/v1/reference/promooffer/dismiss
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        public static void Dismiss(BooksService service, PromoofferDismissOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Promooffer.Dismiss();

                // Applying optional parameters to the request.                
                request = (PromoofferResource.DismissRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Promooffer.Dismiss failed.", ex);
            }
        }
        public class PromoofferGetOptionalParms
        {
            /// device android_id
            public string AndroidId { get; set; }  
            /// device device
            public string Device { get; set; }  
            /// device manufacturer
            public string Manufacturer { get; set; }  
            /// device model
            public string Model { get; set; }  
            /// device product
            public string Product { get; set; }  
            /// device serial
            public string Serial { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of promo offers available to the user 
        /// Documentation https://developers.google.com/books/v1/reference/promooffer/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OffersResponse</returns>
        public static Offers Get(BooksService service, PromoofferGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Promooffer.Get();

                // Applying optional parameters to the request.                
                request = (PromoofferResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Promooffer.Get failed.", ex);
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