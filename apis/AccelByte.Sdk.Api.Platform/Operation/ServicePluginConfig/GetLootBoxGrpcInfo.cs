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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getLootBoxGrpcInfo
    ///
    /// Get lootbox plugin gRPC info.
    /// </summary>
    public class GetLootBoxGrpcInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLootBoxGrpcInfoBuilder Builder { get => new GetLootBoxGrpcInfoBuilder(); }

        public class GetLootBoxGrpcInfoBuilder
            : OperationBuilder<GetLootBoxGrpcInfoBuilder>
        {

            public bool? Force { get; set; }





            internal GetLootBoxGrpcInfoBuilder() { }

            internal GetLootBoxGrpcInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLootBoxGrpcInfoBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public GetLootBoxGrpcInfo Build(
                string namespace_
            )
            {
                GetLootBoxGrpcInfo op = new GetLootBoxGrpcInfo(this,
                    namespace_
                );

                op.SetBaseFields<GetLootBoxGrpcInfoBuilder>(this);
                return op;
            }

            public GetLootBoxGrpcInfo.Response Execute(
                string namespace_
            )
            {
                GetLootBoxGrpcInfo op = Build(
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
            public async Task<GetLootBoxGrpcInfo.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetLootBoxGrpcInfo op = Build(
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

        private GetLootBoxGrpcInfo(GetLootBoxGrpcInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.GrpcServerInfo>
        {


            protected override string GetFullOperationId() => "Platform::ServicePluginConfig::GetLootBoxGrpcInfo";
        }

        #endregion

        public GetLootBoxGrpcInfo(
            string namespace_,
            bool? force
        )
        {
            PathParams["namespace"] = namespace_;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/grpcInfo";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public GetLootBoxGrpcInfo.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLootBoxGrpcInfo.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.GrpcServerInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}