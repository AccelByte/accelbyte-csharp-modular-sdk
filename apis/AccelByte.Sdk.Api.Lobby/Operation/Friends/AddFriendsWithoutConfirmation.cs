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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// addFriendsWithoutConfirmation
    ///
    /// Friends request in a namespace.
    /// </summary>
    public class AddFriendsWithoutConfirmation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddFriendsWithoutConfirmationBuilder Builder { get => new AddFriendsWithoutConfirmationBuilder(); }

        public class AddFriendsWithoutConfirmationBuilder
            : OperationBuilder<AddFriendsWithoutConfirmationBuilder>
        {





            internal AddFriendsWithoutConfirmationBuilder() { }

            internal AddFriendsWithoutConfirmationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddFriendsWithoutConfirmation Build(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                AddFriendsWithoutConfirmation op = new AddFriendsWithoutConfirmation(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AddFriendsWithoutConfirmationBuilder>(this);
                return op;
            }

            public AddFriendsWithoutConfirmation.Response Execute(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                AddFriendsWithoutConfirmation op = Build(
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
            public async Task<AddFriendsWithoutConfirmation.Response> ExecuteAsync(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                AddFriendsWithoutConfirmation op = Build(
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

        private AddFriendsWithoutConfirmation(AddFriendsWithoutConfirmationBuilder builder,
            ModelBulkFriendsRequest body,
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
        public class Response : ApiResponse
        {

            public RestapiErrorResponseV1? Error400 { get; set; } = null;

            public RestapiErrorResponseV1? Error401 { get; set; } = null;

            public RestapiErrorResponseV1? Error403 { get; set; } = null;

            public RestapiErrorResponseV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Friends::AddFriendsWithoutConfirmation";
        }

        #endregion

        public AddFriendsWithoutConfirmation(
            string namespace_,
            string userId,
            Model.ModelBulkFriendsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/users/{userId}/add/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AddFriendsWithoutConfirmation.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AddFriendsWithoutConfirmation.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}