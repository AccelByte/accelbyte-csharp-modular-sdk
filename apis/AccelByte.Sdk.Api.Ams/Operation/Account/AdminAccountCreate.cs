// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// AdminAccountCreate
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [CREATE]
    /// </summary>
    public class AdminAccountCreate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAccountCreateBuilder Builder { get => new AdminAccountCreateBuilder(); }

        public class AdminAccountCreateBuilder
            : OperationBuilder<AdminAccountCreateBuilder>
        {





            internal AdminAccountCreateBuilder() { }

            internal AdminAccountCreateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAccountCreate Build(
                ApiAccountCreateRequest body,
                string namespace_
            )
            {
                AdminAccountCreate op = new AdminAccountCreate(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminAccountCreateBuilder>(this);
                return op;
            }

            public Model.ApiAccountCreateResponse? Execute(
                ApiAccountCreateRequest body,
                string namespace_
            )
            {
                AdminAccountCreate op = Build(
                    body,
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
            public async Task<Model.ApiAccountCreateResponse?> ExecuteAsync(
                ApiAccountCreateRequest body,
                string namespace_
            )
            {
                AdminAccountCreate op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminAccountCreate(AdminAccountCreateBuilder builder,
            ApiAccountCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAccountCreate(
            string namespace_,
            Model.ApiAccountCreateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/account";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiAccountCreateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountCreateResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountCreateResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}