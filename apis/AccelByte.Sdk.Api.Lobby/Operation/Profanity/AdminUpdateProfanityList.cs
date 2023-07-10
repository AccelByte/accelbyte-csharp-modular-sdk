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
    /// adminUpdateProfanityList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [UPDATE]` with scope `social`
    /// 
    /// update the list
    /// </summary>
    public class AdminUpdateProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateProfanityListBuilder Builder { get => new AdminUpdateProfanityListBuilder(); }

        public class AdminUpdateProfanityListBuilder
            : OperationBuilder<AdminUpdateProfanityListBuilder>
        {





            internal AdminUpdateProfanityListBuilder() { }

            internal AdminUpdateProfanityListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateProfanityList Build(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                AdminUpdateProfanityList op = new AdminUpdateProfanityList(this,
                    body,
                    list,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                AdminUpdateProfanityList op = Build(
                    body,
                    list,
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

        private AdminUpdateProfanityList(AdminUpdateProfanityListBuilder builder,
            ModelsAdminUpdateProfanityList body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateProfanityList(
            string list,
            string namespace_,
            Model.ModelsAdminUpdateProfanityList body
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}";

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