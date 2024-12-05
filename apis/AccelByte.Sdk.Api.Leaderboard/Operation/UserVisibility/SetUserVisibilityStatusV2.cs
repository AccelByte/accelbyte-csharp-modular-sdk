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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// SetUserVisibilityStatusV2
    ///
    /// User with false visibility status will have hidden attribute set to true on it's leaderboard entry
    /// </summary>
    public class SetUserVisibilityStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetUserVisibilityStatusV2Builder Builder { get => new SetUserVisibilityStatusV2Builder(); }

        public class SetUserVisibilityStatusV2Builder
            : OperationBuilder<SetUserVisibilityStatusV2Builder>
        {





            internal SetUserVisibilityStatusV2Builder() { }

            internal SetUserVisibilityStatusV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetUserVisibilityStatusV2 Build(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityStatusV2 op = new SetUserVisibilityStatusV2(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<SetUserVisibilityStatusV2Builder>(this);
                return op;
            }

            public SetUserVisibilityStatusV2.Response Execute(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityStatusV2 op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<SetUserVisibilityStatusV2.Response> ExecuteAsync(
                ModelsSetUserVisibilityRequest body,
                string namespace_,
                string userId
            )
            {
                SetUserVisibilityStatusV2 op = Build(
                    body,
                    namespace_,
                    userId
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

        private SetUserVisibilityStatusV2(SetUserVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetUserVisibilityResponse>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::UserVisibility::SetUserVisibilityStatusV2";
        }

        #endregion

        public SetUserVisibilityStatusV2(
            string namespace_,
            string userId,
            Model.ModelsSetUserVisibilityRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/admin/namespaces/{namespace}/users/{userId}/visibility";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public SetUserVisibilityStatusV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SetUserVisibilityStatusV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}