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
    /// publicPromotePartyLeader
    ///
    /// Promotes a party member to be a party leader. Only leader can promote a new leader.
    /// </summary>
    public class PublicPromotePartyLeader : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPromotePartyLeaderBuilder Builder { get => new PublicPromotePartyLeaderBuilder(); }

        public class PublicPromotePartyLeaderBuilder
            : OperationBuilder<PublicPromotePartyLeaderBuilder>
        {





            internal PublicPromotePartyLeaderBuilder() { }

            internal PublicPromotePartyLeaderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPromotePartyLeader Build(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPromotePartyLeader op = new PublicPromotePartyLeader(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsPartySessionResponse? Execute(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPromotePartyLeader op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsPartySessionResponse<T1, T2>? Execute<T1, T2>(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPromotePartyLeader op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicPromotePartyLeader(PublicPromotePartyLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
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

        public PublicPromotePartyLeader(
            string namespace_,            
            string partyId,            
            Model.ApimodelsPromoteLeaderRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApimodelsPartySessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPartySessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}