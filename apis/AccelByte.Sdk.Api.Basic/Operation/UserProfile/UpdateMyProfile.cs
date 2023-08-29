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
    /// updateMyProfile
    ///
    /// Update my profile.
    /// Updates user profile in the target namespace (namespace in the path). If token's namespace doesn't match the target namespace, the service automatically maps the token's user ID into the user ID in the target namespace. The endpoint returns the updated user profile on a successful call.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11402
    ///   *  Returns : user profile
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to update publisher user profile
    ///     * can be filled with game namespace in order to update game user profile
    ///   *  Language : allowed format: en, en-US
    ///   *  Timezone : IANA time zone, e.g. Asia/Shanghai
    /// </summary>
    public class UpdateMyProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMyProfileBuilder Builder { get => new UpdateMyProfileBuilder(); }

        public class UpdateMyProfileBuilder
            : OperationBuilder<UpdateMyProfileBuilder>
        {


            public Model.UserProfileUpdate? Body { get; set; }




            internal UpdateMyProfileBuilder() { }

            internal UpdateMyProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateMyProfileBuilder SetBody(Model.UserProfileUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateMyProfile Build(
                string namespace_
            )
            {
                UpdateMyProfile op = new UpdateMyProfile(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.UserProfilePrivateInfo? Execute(
                string namespace_
            )
            {
                UpdateMyProfile op = Build(
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

            public Model.UserProfilePrivateInfo<T1, T2>? Execute<T1, T2>(
                string namespace_
            )
            {
                UpdateMyProfile op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateMyProfile(UpdateMyProfileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMyProfile(
            string namespace_,
            Model.UserProfileUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserProfilePrivateInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}