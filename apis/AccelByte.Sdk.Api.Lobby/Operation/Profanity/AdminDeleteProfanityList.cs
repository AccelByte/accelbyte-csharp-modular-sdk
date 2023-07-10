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
    /// adminDeleteProfanityList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [DELETE]` with scope `social`
    /// 
    /// delete a list include all filters inside of it
    /// </summary>
    public class AdminDeleteProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteProfanityListBuilder Builder { get => new AdminDeleteProfanityListBuilder(); }

        public class AdminDeleteProfanityListBuilder
            : OperationBuilder<AdminDeleteProfanityListBuilder>
        {





            internal AdminDeleteProfanityListBuilder() { }

            internal AdminDeleteProfanityListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteProfanityList Build(
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityList op = new AdminDeleteProfanityList(this,
                    list,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityList op = Build(
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

        private AdminDeleteProfanityList(AdminDeleteProfanityListBuilder builder,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteProfanityList(
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}";

        public override HttpMethod Method => HttpMethod.Delete;

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