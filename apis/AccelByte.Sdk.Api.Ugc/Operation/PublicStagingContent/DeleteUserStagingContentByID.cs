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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// DeleteUserStagingContentByID
    ///
    /// Delete user staging content by ID
    /// </summary>
    public class DeleteUserStagingContentByID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserStagingContentByIDBuilder Builder { get => new DeleteUserStagingContentByIDBuilder(); }

        public class DeleteUserStagingContentByIDBuilder
            : OperationBuilder<DeleteUserStagingContentByIDBuilder>
        {





            internal DeleteUserStagingContentByIDBuilder() { }

            internal DeleteUserStagingContentByIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserStagingContentByID Build(
                string contentId,
                string namespace_,
                string userId
            )
            {
                DeleteUserStagingContentByID op = new DeleteUserStagingContentByID(this,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DeleteUserStagingContentByIDBuilder>(this);
                return op;
            }

            public void Execute(
                string contentId,
                string namespace_,
                string userId
            )
            {
                DeleteUserStagingContentByID op = Build(
                    contentId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string contentId,
                string namespace_,
                string userId
            )
            {
                DeleteUserStagingContentByID op = Build(
                    contentId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteUserStagingContentByID(DeleteUserStagingContentByIDBuilder builder,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserStagingContentByID(
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/staging-contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}