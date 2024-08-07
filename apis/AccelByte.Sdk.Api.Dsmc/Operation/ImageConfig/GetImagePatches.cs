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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetImagePatches
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint get image patches by version.
    /// 
    /// Image Size unit is byte.
    /// </summary>
    public class GetImagePatches : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetImagePatchesBuilder Builder { get => new GetImagePatchesBuilder(); }

        public class GetImagePatchesBuilder
            : OperationBuilder<GetImagePatchesBuilder>
        {





            internal GetImagePatchesBuilder() { }

            internal GetImagePatchesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetImagePatches Build(
                string namespace_,
                string version
            )
            {
                GetImagePatches op = new GetImagePatches(this,
                    namespace_,
                    version
                );

                op.SetBaseFields<GetImagePatchesBuilder>(this);
                return op;
            }

            public Model.ModelsListImagePatchesResponse? Execute(
                string namespace_,
                string version
            )
            {
                GetImagePatches op = Build(
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
            public async Task<Model.ModelsListImagePatchesResponse?> ExecuteAsync(
                string namespace_,
                string version
            )
            {
                GetImagePatches op = Build(
                    namespace_,
                    version
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

        private GetImagePatches(GetImagePatchesBuilder builder,
            string namespace_,
            string version
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetImagePatches(
            string namespace_,
            string version
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListImagePatchesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImagePatchesResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListImagePatchesResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}