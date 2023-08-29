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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetMockTicketsByTimestamp
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Read mock tickets after the specified timestamp in a channel.
    /// '
    /// </summary>
    public class GetMockTicketsByTimestamp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMockTicketsByTimestampBuilder Builder { get => new GetMockTicketsByTimestampBuilder(); }

        public class GetMockTicketsByTimestampBuilder
            : OperationBuilder<GetMockTicketsByTimestampBuilder>
        {





            internal GetMockTicketsByTimestampBuilder() { }

            internal GetMockTicketsByTimestampBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetMockTicketsByTimestamp Build(
                ModelsQueryMockBy body,
                string channelName,
                string namespace_
            )
            {
                GetMockTicketsByTimestamp op = new GetMockTicketsByTimestamp(this,
                    body,                    
                    channelName,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetMockTicketsResponse? Execute(
                ModelsQueryMockBy body,
                string channelName,
                string namespace_
            )
            {
                GetMockTicketsByTimestamp op = Build(
                    body,
                    channelName,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetMockTicketsByTimestamp(GetMockTicketsByTimestampBuilder builder,
            ModelsQueryMockBy body,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMockTicketsByTimestamp(
            string channelName,            
            string namespace_,            
            Model.ModelsQueryMockBy body            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/query";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsGetMockTicketsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMockTicketsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMockTicketsResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}