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
    /// GetUserByPlatformUserID
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint(Public): /iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} [GET]
    /// 
    ///   * Substitute endpoint(Admin): /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} [GET]
    /// 
    /// 
    /// 
    ///   * Note:
    ///     1. difference in V3 response, format difference: Pascal case => Camel case
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER [READ]'
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserByPlatformUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserByPlatformUserIDBuilder Builder { get => new GetUserByPlatformUserIDBuilder(); }

        public class GetUserByPlatformUserIDBuilder
            : OperationBuilder<GetUserByPlatformUserIDBuilder>
        {





            internal GetUserByPlatformUserIDBuilder() { }

            internal GetUserByPlatformUserIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserByPlatformUserID Build(
                string namespace_,
                string platformID,
                string platformUserID
            )
            {
                GetUserByPlatformUserID op = new GetUserByPlatformUserID(this,
                    namespace_,
                    platformID,
                    platformUserID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelPublicUserResponse? Execute(
                string namespace_,
                string platformID,
                string platformUserID
            )
            {
                GetUserByPlatformUserID op = Build(
                    namespace_,
                    platformID,
                    platformUserID
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

        private GetUserByPlatformUserID(GetUserByPlatformUserIDBuilder builder,
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            PathParams["namespace"] = namespace_;

            if (platformID is not null) QueryParams["platformID"] = platformID;
            if (platformUserID is not null) QueryParams["platformUserID"] = platformUserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserByPlatformUserID(
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            PathParams["namespace"] = namespace_;

            if (platformID is not null) QueryParams["platformID"] = platformID;
            if (platformUserID is not null) QueryParams["platformUserID"] = platformUserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byPlatformUserID";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelPublicUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}