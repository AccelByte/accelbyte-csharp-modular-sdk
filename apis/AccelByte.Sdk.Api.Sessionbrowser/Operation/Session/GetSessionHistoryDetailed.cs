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
    /// GetSessionHistoryDetailed
    ///
    /// Get session history detailed.
    /// 
    /// if party_id value empty/null, field will not show in response body.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetSessionHistoryDetailed : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionHistoryDetailedBuilder Builder { get => new GetSessionHistoryDetailedBuilder(); }

        public class GetSessionHistoryDetailedBuilder
            : OperationBuilder<GetSessionHistoryDetailedBuilder>
        {





            internal GetSessionHistoryDetailedBuilder() { }

            internal GetSessionHistoryDetailedBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSessionHistoryDetailed Build(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = new GetSessionHistoryDetailed(this,
                    matchID,
                    namespace_
                );

                op.SetBaseFields<GetSessionHistoryDetailedBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetSessionHistoryDetailed.Response Execute(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = Build(
                    matchID,
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
            public async Task<GetSessionHistoryDetailed.Response> ExecuteAsync(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = Build(
                    matchID,
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

        private GetSessionHistoryDetailed(GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>
        {

            public RestapiErrorV1? Error400 { get; set; } = null;

            public RestapiErrorV1? Error401 { get; set; } = null;

            public RestapiErrorV1? Error403 { get; set; } = null;

            public RestapiErrorV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionbrowser::Session::GetSessionHistoryDetailed";
        }

        #endregion

        public GetSessionHistoryDetailed(
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetSessionHistoryDetailed.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetSessionHistoryDetailed.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}