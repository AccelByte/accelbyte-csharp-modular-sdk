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
    /// GetAllMockMatches
    ///
    /// Read all mock matches in a channel resulted from matching mock tickets.
    /// '
    /// </summary>
    public class GetAllMockMatches : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllMockMatchesBuilder Builder { get => new GetAllMockMatchesBuilder(); }

        public class GetAllMockMatchesBuilder
            : OperationBuilder<GetAllMockMatchesBuilder>
        {





            internal GetAllMockMatchesBuilder() { }

            internal GetAllMockMatchesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAllMockMatches Build(
                string channelName,
                string namespace_
            )
            {
                GetAllMockMatches op = new GetAllMockMatches(this,
                    channelName,
                    namespace_
                );

                op.SetBaseFields<GetAllMockMatchesBuilder>(this);
                return op;
            }

            public GetAllMockMatches.Response Execute(
                string channelName,
                string namespace_
            )
            {
                GetAllMockMatches op = Build(
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
            public async Task<GetAllMockMatches.Response> ExecuteAsync(
                string channelName,
                string namespace_
            )
            {
                GetAllMockMatches op = Build(
                    channelName,
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

        private GetAllMockMatches(GetAllMockMatchesBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetMockMatchesResponse>
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::MockMatchmaking::GetAllMockMatches";
        }

        #endregion

        public GetAllMockMatches(
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/matches";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetAllMockMatches.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAllMockMatches.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetMockMatchesResponse>(payload, ResponseJsonOptions);
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