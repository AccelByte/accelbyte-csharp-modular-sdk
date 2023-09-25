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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminAddCountryBlacklistV3
    ///
    /// Admin update country blacklist:
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MISC [UPDATE]
    /// </summary>
    public class AdminAddCountryBlacklistV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddCountryBlacklistV3Builder Builder { get => new AdminAddCountryBlacklistV3Builder(); }

        public class AdminAddCountryBlacklistV3Builder
            : OperationBuilder<AdminAddCountryBlacklistV3Builder>
        {





            internal AdminAddCountryBlacklistV3Builder() { }

            internal AdminAddCountryBlacklistV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAddCountryBlacklistV3 Build(
                ModelCountryBlacklistRequest body,
                string namespace_
            )
            {
                AdminAddCountryBlacklistV3 op = new AdminAddCountryBlacklistV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelCountryBlacklistRequest body,
                string namespace_
            )
            {
                AdminAddCountryBlacklistV3 op = Build(
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

        private AdminAddCountryBlacklistV3(AdminAddCountryBlacklistV3Builder builder,
            ModelCountryBlacklistRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddCountryBlacklistV3(
            string namespace_,
            Model.ModelCountryBlacklistRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/countries/blacklist";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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