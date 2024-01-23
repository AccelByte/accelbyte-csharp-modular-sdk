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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminProfanityCreateBulk
    ///
    /// Bulk insert new word for profanity censor
    /// </summary>
    public class AdminProfanityCreateBulk : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityCreateBulkBuilder Builder { get => new AdminProfanityCreateBulkBuilder(); }

        public class AdminProfanityCreateBulkBuilder
            : OperationBuilder<AdminProfanityCreateBulkBuilder>
        {





            internal AdminProfanityCreateBulkBuilder() { }

            internal AdminProfanityCreateBulkBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminProfanityCreateBulk Build(
                ModelsDictionaryInsertBulkRequest body,
                string namespace_
            )
            {
                AdminProfanityCreateBulk op = new AdminProfanityCreateBulk(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminProfanityCreateBulkBuilder>(this);
                return op;
            }

            public Model.ModelsDictionary? Execute(
                ModelsDictionaryInsertBulkRequest body,
                string namespace_
            )
            {
                AdminProfanityCreateBulk op = Build(
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
        }

        private AdminProfanityCreateBulk(AdminProfanityCreateBulkBuilder builder,
            ModelsDictionaryInsertBulkRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminProfanityCreateBulk(
            string namespace_,
            Model.ModelsDictionaryInsertBulkRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDictionary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionary>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionary>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}