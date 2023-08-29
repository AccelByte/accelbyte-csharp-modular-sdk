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
    /// BulkCreateMockTickets
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Create]
    /// 
    /// Required Scope: social
    /// 
    /// Create and queue mock tickets into specified game mode's pool.
    /// The tickets input will be used as is.
    /// '
    /// </summary>
    public class BulkCreateMockTickets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreateMockTicketsBuilder Builder { get => new BulkCreateMockTicketsBuilder(); }

        public class BulkCreateMockTicketsBuilder
            : OperationBuilder<BulkCreateMockTicketsBuilder>
        {





            internal BulkCreateMockTicketsBuilder() { }

            internal BulkCreateMockTicketsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkCreateMockTickets Build(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = new BulkCreateMockTickets(this,
                    body,
                    channelName,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = Build(
                    body,
                    channelName,
                    namespace_
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

        private BulkCreateMockTickets(BulkCreateMockTicketsBuilder builder,
            List<ModelsMatchingParty> body,
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

        public BulkCreateMockTickets(
            string channelName,
            string namespace_,
            List<Model.ModelsMatchingParty> body
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/bulk";

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