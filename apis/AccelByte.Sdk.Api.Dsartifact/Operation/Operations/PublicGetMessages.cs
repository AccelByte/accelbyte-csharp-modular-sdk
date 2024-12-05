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

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// publicGetMessages
    ///
    /// get the list of messages.
    /// </summary>
    public class PublicGetMessages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMessagesBuilder Builder { get => new PublicGetMessagesBuilder(); }

        public class PublicGetMessagesBuilder
            : OperationBuilder<PublicGetMessagesBuilder>
        {





            internal PublicGetMessagesBuilder() { }

            internal PublicGetMessagesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetMessages Build(
            )
            {
                PublicGetMessages op = new PublicGetMessages(this
                );

                op.SetBaseFields<PublicGetMessagesBuilder>(this);
                return op;
            }

            public PublicGetMessages.Response Execute(
            )
            {
                PublicGetMessages op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetMessages.Response> ExecuteAsync(
            )
            {
                PublicGetMessages op = Build(
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

        private PublicGetMessages(PublicGetMessagesBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.LogAppMessageDeclaration>>
        {

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsartifact::Operations::PublicGetMessages";
        }

        #endregion

        public PublicGetMessages(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/v1/messages";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetMessages.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetMessages.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.LogAppMessageDeclaration>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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