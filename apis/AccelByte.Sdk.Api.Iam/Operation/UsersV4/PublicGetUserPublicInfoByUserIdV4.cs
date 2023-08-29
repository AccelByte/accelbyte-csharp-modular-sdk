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
    /// PublicGetUserPublicInfoByUserIdV4
    ///
    /// 
    /// 
    /// This endpoint requires a valid user token and only returns user's public information.
    /// 
    /// action code: 10129
    /// </summary>
    public class PublicGetUserPublicInfoByUserIdV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserPublicInfoByUserIdV4Builder Builder { get => new PublicGetUserPublicInfoByUserIdV4Builder(); }

        public class PublicGetUserPublicInfoByUserIdV4Builder
            : OperationBuilder<PublicGetUserPublicInfoByUserIdV4Builder>
        {





            internal PublicGetUserPublicInfoByUserIdV4Builder() { }

            internal PublicGetUserPublicInfoByUserIdV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserPublicInfoByUserIdV4 Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPublicInfoByUserIdV4 op = new PublicGetUserPublicInfoByUserIdV4(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelUserPublicInfoResponseV4? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPublicInfoByUserIdV4 op = Build(
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
        }

        private PublicGetUserPublicInfoByUserIdV4(PublicGetUserPublicInfoByUserIdV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserPublicInfoByUserIdV4(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserPublicInfoResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPublicInfoResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPublicInfoResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}