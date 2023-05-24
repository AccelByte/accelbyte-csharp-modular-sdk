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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetTotalActiveSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// </summary>
    public class GetTotalActiveSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTotalActiveSessionBuilder Builder { get => new GetTotalActiveSessionBuilder(); }

        public class GetTotalActiveSessionBuilder
            : OperationBuilder<GetTotalActiveSessionBuilder>
        {

            public string? SessionType { get; set; }





            internal GetTotalActiveSessionBuilder() { }

            internal GetTotalActiveSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetTotalActiveSessionBuilder SetSessionType(string _sessionType)
            {
                SessionType = _sessionType;
                return this;
            }





            public GetTotalActiveSession Build(
                string namespace_
            )
            {
                GetTotalActiveSession op = new GetTotalActiveSession(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsCountActiveSessionResponse? Execute(
                string namespace_
            )
            {
                GetTotalActiveSession op = Build(
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

        private GetTotalActiveSession(GetTotalActiveSessionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.SessionType is not null) QueryParams["session_type"] = builder.SessionType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetTotalActiveSession(
            string namespace_,
            string? sessionType
        )
        {
            PathParams["namespace"] = namespace_;

            if (sessionType is not null) QueryParams["session_type"] = sessionType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/count";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCountActiveSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountActiveSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountActiveSessionResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}