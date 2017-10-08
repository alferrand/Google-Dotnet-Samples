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
// Unoffical sample for the Games v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Games/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Games.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Games.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Games.v1;
using Google.Apis.Games.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesv1.Methods
{
  
    public static class TurnBasedMatchesSample
    {

        public class TurnBasedMatchesCancelOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Cancel a turn-based match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Cancel(GamesService service, string matchId, TurnBasedMatchesCancelOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Cancel(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.CancelRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Cancel failed.", ex);
            }
        }
        public class TurnBasedMatchesCreateOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Create a turn-based match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="body">A valid Games v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Create(GamesService service, TurnBasedMatchCreateRequest body, TurnBasedMatchesCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.TurnBasedMatches.Create(body);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Create failed.", ex);
            }
        }
        public class TurnBasedMatchesDeclineOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Decline an invitation to play a turn-based match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/decline
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Decline(GamesService service, string matchId, TurnBasedMatchesDeclineOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Decline(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.DeclineRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Decline failed.", ex);
            }
        }
        public class TurnBasedMatchesDismissOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
        
        }
 
        /// <summary>
        /// Dismiss a turn-based match from the match list. The match will no longer show up in the list and will not generate notifications. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/dismiss
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Dismiss(GamesService service, string matchId, TurnBasedMatchesDismissOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Dismiss(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.DismissRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Dismiss failed.", ex);
            }
        }
        public class TurnBasedMatchesFinishOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Finish a turn-based match. Each player should make this call once, after all results are in. Only the player whose turn it is may make the first call to Finish, and can pass in the final match state. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/finish
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="body">A valid Games v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Finish(GamesService service, string matchId, TurnBasedMatchResults body, TurnBasedMatchesFinishOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Finish(body, matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.FinishRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Finish failed.", ex);
            }
        }
        public class TurnBasedMatchesGetOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// Get match data along with metadata.
            public bool? IncludeMatchData { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Get the data for a turn-based match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Get(GamesService service, string matchId, TurnBasedMatchesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Get(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Get failed.", ex);
            }
        }
        public class TurnBasedMatchesJoinOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Join a turn-based match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/join
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Join(GamesService service, string matchId, TurnBasedMatchesJoinOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Join(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.JoinRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Join failed.", ex);
            }
        }
        public class TurnBasedMatchesLeaveOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Leave a turn-based match when it is not the current player's turn, without canceling the match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/leave
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch Leave(GamesService service, string matchId, TurnBasedMatchesLeaveOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Leave(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.LeaveRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Leave failed.", ex);
            }
        }
        public class TurnBasedMatchesLeaveTurnOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The ID of another participant who should take their turn next. If not set, the match will wait for other player(s) to join via automatching; this is only valid if automatch criteria is set on the match with remaining slots for automatched players.
            public string PendingParticipantId { get; set; }  
        
        }
 
        /// <summary>
        /// Leave a turn-based match during the current player's turn, without canceling the match. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/leaveTurn
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="matchVersion">The version of the match being updated.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch LeaveTurn(GamesService service, string matchId, int? matchVersion, TurnBasedMatchesLeaveTurnOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);
                if (matchVersion == null)
                    throw new ArgumentNullException(matchVersion);

                // Building the initial request.
                var request = service.TurnBasedMatches.LeaveTurn(matchId, matchVersion);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.LeaveTurnRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.LeaveTurn failed.", ex);
            }
        }
        public class TurnBasedMatchesListOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// True if match data should be returned in the response. Note that not all data will necessarily be returned if include_match_data is true; the server may decide to only return data for some of the matches to limit download size for the client. The remainder of the data for these matches will be retrievable on request.
            public bool? IncludeMatchData { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of completed or canceled matches to return in the response. If not set, all matches returned could be completed or canceled.
            public int? MaxCompletedMatches { get; set; }  
            /// The maximum number of matches to return in the response, used for paging. For any response, the actual number of matches to return may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns turn-based matches the player is or was involved in. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchListResponse</returns>
        public static TurnBasedMatchList List(GamesService service, TurnBasedMatchesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.TurnBasedMatches.List();

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.List failed.", ex);
            }
        }
        public class TurnBasedMatchesRematchOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// A randomly generated numeric ID for each request specified by the caller. This number is used at the server to ensure that the request is handled correctly across retries.
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Create a rematch of a match that was previously completed, with the same participants. This can be called by only one player on a match still in their list; the player must have called Finish first. Returns the newly created match; it will be the caller's turn. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/rematch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchRematchResponse</returns>
        public static TurnBasedMatchRematch Rematch(GamesService service, string matchId, TurnBasedMatchesRematchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.Rematch(matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.RematchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Rematch failed.", ex);
            }
        }
        public class TurnBasedMatchesSyncOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// True if match data should be returned in the response. Note that not all data will necessarily be returned if include_match_data is true; the server may decide to only return data for some of the matches to limit download size for the client. The remainder of the data for these matches will be retrievable on request.
            public bool? IncludeMatchData { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of completed or canceled matches to return in the response. If not set, all matches returned could be completed or canceled.
            public int? MaxCompletedMatches { get; set; }  
            /// The maximum number of matches to return in the response, used for paging. For any response, the actual number of matches to return may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns turn-based matches the player is or was involved in that changed since the last sync call, with the least recent changes coming first. Matches that should be removed from the local cache will have a status of MATCH_DELETED. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/sync
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchSyncResponse</returns>
        public static TurnBasedMatchSync Sync(GamesService service, TurnBasedMatchesSyncOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.TurnBasedMatches.Sync();

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.SyncRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Sync failed.", ex);
            }
        }
        public class TurnBasedMatchesTakeTurnOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Commit the results of a player turn. 
        /// Documentation https://developers.google.com/games/v1/reference/turnBasedMatches/takeTurn
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="body">A valid Games v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>TurnBasedMatchResponse</returns>
        public static TurnBasedMatch TakeTurn(GamesService service, string matchId, TurnBasedMatchTurn body, TurnBasedMatchesTakeTurnOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (matchId == null)
                    throw new ArgumentNullException(matchId);

                // Building the initial request.
                var request = service.TurnBasedMatches.TakeTurn(body, matchId);

                // Applying optional parameters to the request.                
                request = (TurnBasedMatchesResource.TakeTurnRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.TakeTurn failed.", ex);
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