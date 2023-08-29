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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// publicGetPartyDataV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// load personal party data in a namespace based on Party ID
    /// 
    /// Action Code: 50101
    /// </summary>
    public class PublicGetPartyDataV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPartyDataV1Builder Builder { get => new PublicGetPartyDataV1Builder(); }

        public class PublicGetPartyDataV1Builder
            : OperationBuilder<PublicGetPartyDataV1Builder>
        {





            internal PublicGetPartyDataV1Builder() { }

            internal PublicGetPartyDataV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetPartyDataV1 Build(
                string namespace_,
                string partyId
            )
            {
                PublicGetPartyDataV1 op = new PublicGetPartyDataV1(this,
                    namespace_,                    
                    partyId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPartyData? Execute(
                string namespace_,
                string partyId
            )
            {
                PublicGetPartyDataV1 op = Build(
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

            public Model.ModelsPartyData<T1>? Execute<T1>(
                string namespace_,
                string partyId
            )
            {
                PublicGetPartyDataV1 op = Build(
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetPartyDataV1(PublicGetPartyDataV1Builder builder,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPartyDataV1(
            string namespace_,            
            string partyId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPartyData? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsPartyData<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPartyData<T1>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}