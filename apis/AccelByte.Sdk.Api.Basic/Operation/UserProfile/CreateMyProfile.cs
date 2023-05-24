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
    /// createMyProfile
    ///
    /// Create my profile.
    ///  Client with user token can create user profile in target namespace
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=1 (CREATE)
    ///   *  Action code : 11401
    ///   *  Returns : Created user profile
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to create publisher user profile
    ///     * can be filled with game namespace in order to create game user profile
    ///   *  Language : allowed format: en, en-US
    ///   *  Country : ISO3166-1 alpha-2 two letter, e.g. US
    ///   * Timezone : IANA time zone, e.g. Asia/Shanghai
    /// </summary>
    public class CreateMyProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMyProfileBuilder Builder { get => new CreateMyProfileBuilder(); }

        public class CreateMyProfileBuilder
            : OperationBuilder<CreateMyProfileBuilder>
        {


            public Model.UserProfilePrivateCreate? Body { get; set; }




            internal CreateMyProfileBuilder() { }

            internal CreateMyProfileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateMyProfileBuilder SetBody(Model.UserProfilePrivateCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateMyProfile Build(
                string namespace_
            )
            {
                CreateMyProfile op = new CreateMyProfile(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.UserProfilePrivateInfo? Execute(
                string namespace_
            )
            {
                CreateMyProfile op = Build(
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
                CreateMyProfile op = Build(
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

        private CreateMyProfile(CreateMyProfileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMyProfile(
            string namespace_,
            Model.UserProfilePrivateCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles";

        public override HttpMethod Method => HttpMethod.Post;

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
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
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
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}