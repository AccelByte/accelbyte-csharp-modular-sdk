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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminGetInboxStats
    ///
    /// Get inbox stats
    /// </summary>
    public class AdminGetInboxStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInboxStatsBuilder Builder { get => new AdminGetInboxStatsBuilder(); }

        public class AdminGetInboxStatsBuilder
            : OperationBuilder<AdminGetInboxStatsBuilder>
        {

            public List<string>? MessageId { get; set; }





            internal AdminGetInboxStatsBuilder() { }

            internal AdminGetInboxStatsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetInboxStatsBuilder SetMessageId(List<string> _messageId)
            {
                MessageId = _messageId;
                return this;
            }





            public AdminGetInboxStats Build(
                string namespace_
            )
            {
                AdminGetInboxStats op = new AdminGetInboxStats(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetInboxStatsResponse? Execute(
                string namespace_
            )
            {
                AdminGetInboxStats op = Build(
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

        private AdminGetInboxStats(AdminGetInboxStatsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.MessageId is not null) QueryParams["messageId"] = builder.MessageId;



            CollectionFormatMap["messageId"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetInboxStats(
            string namespace_,
            List<string>? messageId
        )
        {
            PathParams["namespace"] = namespace_;

            if (messageId is not null) QueryParams["messageId"] = messageId;



            CollectionFormatMap["messageId"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/stats";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetInboxStatsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetInboxStatsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetInboxStatsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}