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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RequestTokenExchangeCodeV3
    ///
    /// This endpoint is being used to request the code to exchange a new token.
    /// The target new token's clientId should NOT be same with current using one.
    /// Path namespace should be target namespace.
    /// Client ID should match the target namespace.
    /// 
    /// The code in response can be consumed by `/iam/v3/token/exchange`
    /// </summary>
    public class RequestTokenExchangeCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestTokenExchangeCodeV3Builder Builder { get => new RequestTokenExchangeCodeV3Builder(); }

        public class RequestTokenExchangeCodeV3Builder
            : OperationBuilder<RequestTokenExchangeCodeV3Builder>
        {





            internal RequestTokenExchangeCodeV3Builder() { }

            internal RequestTokenExchangeCodeV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RequestTokenExchangeCodeV3 Build(
                string clientId,
                string namespace_
            )
            {
                RequestTokenExchangeCodeV3 op = new RequestTokenExchangeCodeV3(this,
                    clientId,
                    namespace_
                );

                op.SetBaseFields<RequestTokenExchangeCodeV3Builder>(this);
                return op;
            }

            public Model.OauthmodelTargetTokenCodeResponse? Execute(
                string clientId,
                string namespace_
            )
            {
                RequestTokenExchangeCodeV3 op = Build(
                    clientId,
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

        private RequestTokenExchangeCodeV3(RequestTokenExchangeCodeV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (clientId is not null) FormParams["client_id"] = clientId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestTokenExchangeCodeV3(
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;


            if (clientId is not null) FormParams["client_id"] = clientId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/namespace/{namespace}/token/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTargetTokenCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTargetTokenCodeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTargetTokenCodeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}