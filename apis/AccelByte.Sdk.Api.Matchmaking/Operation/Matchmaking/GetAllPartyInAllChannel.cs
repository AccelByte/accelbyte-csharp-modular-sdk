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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetAllPartyInAllChannel
    ///
    /// Get all parties queueing in all channels.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetAllPartyInAllChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllPartyInAllChannelBuilder Builder { get => new GetAllPartyInAllChannelBuilder(); }

        public class GetAllPartyInAllChannelBuilder
            : OperationBuilder<GetAllPartyInAllChannelBuilder>
        {





            internal GetAllPartyInAllChannelBuilder() { }

            internal GetAllPartyInAllChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAllPartyInAllChannel Build(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = new GetAllPartyInAllChannel(this,
                    namespace_
                );

                op.SetBaseFields<GetAllPartyInAllChannelBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetAllPartyInAllChannel.Response Execute(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
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
            public async Task<GetAllPartyInAllChannel.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
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

            public GetAllPartyInAllChannel.Response<T1> Execute<T1>(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetAllPartyInAllChannel.Response<T1>> ExecuteAsync<T1>(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetAllPartyInAllChannel(GetAllPartyInAllChannelBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, List<Model.ModelsMatchingParty>>>
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::GetAllPartyInAllChannel";
        }

        public class Response<T1> : ApiResponse<Dictionary<string, List<Model.ModelsMatchingParty<T1>>>>
        {
            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::GetAllPartyInAllChannel";
        }
        #endregion

        public GetAllPartyInAllChannel(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetAllPartyInAllChannel.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAllPartyInAllChannel.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty>>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public GetAllPartyInAllChannel.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAllPartyInAllChannel.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty<T1>>>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}