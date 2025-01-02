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
    /// UpdatePlayTimeWeight
    ///
    /// Update a connection weight between player and playtime.
    /// 
    /// This endpoint is intended to be called by admin for debugging purpose on social matchmaking rule.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdatePlayTimeWeight : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlayTimeWeightBuilder Builder { get => new UpdatePlayTimeWeightBuilder(); }

        public class UpdatePlayTimeWeightBuilder
            : OperationBuilder<UpdatePlayTimeWeightBuilder>
        {





            internal UpdatePlayTimeWeightBuilder() { }

            internal UpdatePlayTimeWeightBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdatePlayTimeWeight Build(
                ModelsUpdatePlayTimeWeightRequest body,
                string namespace_
            )
            {
                UpdatePlayTimeWeight op = new UpdatePlayTimeWeight(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UpdatePlayTimeWeightBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public UpdatePlayTimeWeight.Response Execute(
                ModelsUpdatePlayTimeWeightRequest body,
                string namespace_
            )
            {
                UpdatePlayTimeWeight op = Build(
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
            public async Task<UpdatePlayTimeWeight.Response> ExecuteAsync(
                ModelsUpdatePlayTimeWeightRequest body,
                string namespace_
            )
            {
                UpdatePlayTimeWeight op = Build(
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

        private UpdatePlayTimeWeight(UpdatePlayTimeWeightBuilder builder,
            ModelsUpdatePlayTimeWeightRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsUpdatePlayerPlaytimeWeightResponse>
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::SocialMatchmaking::UpdatePlayTimeWeight";
        }

        #endregion

        public UpdatePlayTimeWeight(
            string namespace_,
            Model.ModelsUpdatePlayTimeWeightRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/social/playtime/namespaces/{namespace}/weight";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public UpdatePlayTimeWeight.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdatePlayTimeWeight.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUpdatePlayerPlaytimeWeightResponse>(payload, ResponseJsonOptions);
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
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}