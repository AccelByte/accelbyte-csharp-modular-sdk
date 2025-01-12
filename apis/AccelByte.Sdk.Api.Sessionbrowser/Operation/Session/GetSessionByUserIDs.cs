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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetSessionByUserIDs
    ///
    /// Query game sessions by comma separated user ids
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetSessionByUserIDs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionByUserIDsBuilder Builder { get => new GetSessionByUserIDsBuilder(); }

        public class GetSessionByUserIDsBuilder
            : OperationBuilder<GetSessionByUserIDsBuilder>
        {





            internal GetSessionByUserIDsBuilder() { }

            internal GetSessionByUserIDsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSessionByUserIDs Build(
                string namespace_,
                string userIds
            )
            {
                GetSessionByUserIDs op = new GetSessionByUserIDs(this,
                    namespace_,
                    userIds
                );

                op.SetBaseFields<GetSessionByUserIDsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetSessionByUserIDs.Response Execute(
                string namespace_,
                string userIds
            )
            {
                GetSessionByUserIDs op = Build(
                    namespace_,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetSessionByUserIDs.Response> ExecuteAsync(
                string namespace_,
                string userIds
            )
            {
                GetSessionByUserIDs op = Build(
                    namespace_,
                    userIds
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

        private GetSessionByUserIDs(GetSessionByUserIDsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["user_ids"] = userIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsSessionByUserIDsResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionbrowser::Session::GetSessionByUserIDs";
        }

        #endregion

        public GetSessionByUserIDs(
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["user_ids"] = userIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetSessionByUserIDs.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetSessionByUserIDs.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsSessionByUserIDsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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