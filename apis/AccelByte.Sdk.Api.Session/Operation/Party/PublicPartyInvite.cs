// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicPartyInvite
    ///
    /// Invite a user to a party.
    /// platformID represents the native platform of the invitee. API will return the corresponding native platform's userID.
    /// supported platforms:
    /// - STEAM
    /// - XBOX
    /// - PSN
    /// </summary>
    public class PublicPartyInvite : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartyInviteBuilder Builder { get => new PublicPartyInviteBuilder(); }

        public class PublicPartyInviteBuilder
            : OperationBuilder<PublicPartyInviteBuilder>
        {





            internal PublicPartyInviteBuilder() { }

            internal PublicPartyInviteBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPartyInvite Build(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPartyInvite op = new PublicPartyInvite(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPartyInvite op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicPartyInvite(PublicPartyInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartyInvite(
            string namespace_,            
            string partyId,            
            Model.ApimodelsSessionInviteRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}