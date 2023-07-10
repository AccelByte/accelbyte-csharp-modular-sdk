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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetUserProfilePublicInfo
    ///
    /// Get user profile public info.
    /// Other detail info:
    /// 
    ///   * Action code : 11404
    ///   *  Returns : user public profile
    /// </summary>
    public class PublicGetUserProfilePublicInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserProfilePublicInfoBuilder Builder { get => new PublicGetUserProfilePublicInfoBuilder(); }

        public class PublicGetUserProfilePublicInfoBuilder
            : OperationBuilder<PublicGetUserProfilePublicInfoBuilder>
        {





            internal PublicGetUserProfilePublicInfoBuilder() { }

            internal PublicGetUserProfilePublicInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserProfilePublicInfo Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserProfilePublicInfo op = new PublicGetUserProfilePublicInfo(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.UserProfilePublicInfo? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserProfilePublicInfo op = Build(
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

            public Model.UserProfilePublicInfo<T1>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                PublicGetUserProfilePublicInfo op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetUserProfilePublicInfo(PublicGetUserProfilePublicInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







        }
        #endregion

        public PublicGetUserProfilePublicInfo(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/public";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserProfilePublicInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.UserProfilePublicInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePublicInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}