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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetImageDetail
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get specific version of dedicated servers images.
    /// </summary>
    public class GetImageDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetImageDetailBuilder Builder { get => new GetImageDetailBuilder(); }

        public class GetImageDetailBuilder
            : OperationBuilder<GetImageDetailBuilder>
        {





            internal GetImageDetailBuilder() { }

            internal GetImageDetailBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetImageDetail Build(
                string namespace_,
                string version
            )
            {
                GetImageDetail op = new GetImageDetail(this,
                    namespace_,
                    version
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetImageDetailResponse? Execute(
                string namespace_,
                string version
            )
            {
                GetImageDetail op = Build(
                    namespace_,
                    version
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

        private GetImageDetail(GetImageDetailBuilder builder,
            string namespace_,
            string version
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetImageDetail(
            string namespace_,
            string version
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetImageDetailResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetImageDetailResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetImageDetailResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}