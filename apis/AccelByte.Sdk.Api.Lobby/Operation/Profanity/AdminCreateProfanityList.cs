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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminCreateProfanityList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [CREATE]` with scope `social`
    /// 
    /// create a new list
    /// </summary>
    public class AdminCreateProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateProfanityListBuilder Builder { get => new AdminCreateProfanityListBuilder(); }

        public class AdminCreateProfanityListBuilder
            : OperationBuilder<AdminCreateProfanityListBuilder>
        {





            internal AdminCreateProfanityListBuilder() { }

            internal AdminCreateProfanityListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateProfanityList Build(
                ModelsAdminCreateProfanityListRequest body,
                string namespace_
            )
            {
                AdminCreateProfanityList op = new AdminCreateProfanityList(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsAdminCreateProfanityListRequest body,
                string namespace_
            )
            {
                AdminCreateProfanityList op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminCreateProfanityList(AdminCreateProfanityListBuilder builder,
            ModelsAdminCreateProfanityListRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateProfanityList(
            string namespace_,
            Model.ModelsAdminCreateProfanityListRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}