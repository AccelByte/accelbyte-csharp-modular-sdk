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
    /// RemovePlayerFromSession
    ///
    /// Remove player from game session
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class RemovePlayerFromSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RemovePlayerFromSessionBuilder Builder { get => new RemovePlayerFromSessionBuilder(); }

        public class RemovePlayerFromSessionBuilder
            : OperationBuilder<RemovePlayerFromSessionBuilder>
        {





            internal RemovePlayerFromSessionBuilder() { }

            internal RemovePlayerFromSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RemovePlayerFromSession Build(
                string namespace_,
                string sessionID,
                string userID
            )
            {
                RemovePlayerFromSession op = new RemovePlayerFromSession(this,
                    namespace_,
                    sessionID,
                    userID
                );

                op.SetBaseFields<RemovePlayerFromSessionBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public RemovePlayerFromSession.Response Execute(
                string namespace_,
                string sessionID,
                string userID
            )
            {
                RemovePlayerFromSession op = Build(
                    namespace_,
                    sessionID,
                    userID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RemovePlayerFromSession.Response> ExecuteAsync(
                string namespace_,
                string sessionID,
                string userID
            )
            {
                RemovePlayerFromSession op = Build(
                    namespace_,
                    sessionID,
                    userID
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

        private RemovePlayerFromSession(RemovePlayerFromSessionBuilder builder,
            string namespace_,
            string sessionID,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsAddPlayerResponse>
        {

            public RestapiErrorResponseV2? Error400 { get; set; } = null;

            public RestapiErrorResponseV2? Error404 { get; set; } = null;

            public RestapiErrorResponseV2? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionbrowser::Session::RemovePlayerFromSession";
        }

        #endregion

        public RemovePlayerFromSession(
            string namespace_,
            string sessionID,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player/{userID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public RemovePlayerFromSession.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RemovePlayerFromSession.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsAddPlayerResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV2>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseV2>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV2>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}