// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// adminCreateModAction
    ///
    /// Required permission: ADMIN:REPORTINGCONFIG [CREATE]
    /// Create auto moderation action
    /// </summary>
    public class AdminCreateModAction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateModActionBuilder Builder { get => new AdminCreateModActionBuilder(); }

        public class AdminCreateModActionBuilder
            : OperationBuilder<AdminCreateModActionBuilder>
        {





            internal AdminCreateModActionBuilder() { }

            internal AdminCreateModActionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateModAction Build(
                RestapiActionApiRequest body
            )
            {
                AdminCreateModAction op = new AdminCreateModAction(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.RestapiActionApiResponse? Execute(
                RestapiActionApiRequest body
            )
            {
                AdminCreateModAction op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminCreateModAction(AdminCreateModActionBuilder builder,
            RestapiActionApiRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateModAction(
            Model.RestapiActionApiRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/extensionActions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RestapiActionApiResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiActionApiResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiActionApiResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}