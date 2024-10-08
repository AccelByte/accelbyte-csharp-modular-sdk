// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetUserSinglePlatformAccount
    ///
    /// This endpoint gets user single platform account metadata.
    /// 
    /// 
    /// **Supported Platforms:**
    /// - Steam group (steamnetwork):
    /// - steam
    /// - steamopenid
    /// - PSN group (psn):
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox):
    /// - live
    /// - xblweb
    /// - Oculus group (oculusgroup):
    /// - oculus
    /// - oculusweb
    /// - Google group (google):
    /// - google
    /// - googleplaygames:
    /// - epicgames
    /// - facebook
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - nintendo
    /// - awscognito
    /// - amazon
    /// - netflix
    /// - snapchat
    /// - _oidc platform id_
    /// 
    /// Note:
    /// - You can use either platform id or platform group as **platformId** parameter.
    /// - **Nintendo platform user id**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class AdminGetUserSinglePlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserSinglePlatformAccountBuilder Builder { get => new AdminGetUserSinglePlatformAccountBuilder(); }

        public class AdminGetUserSinglePlatformAccountBuilder
            : OperationBuilder<AdminGetUserSinglePlatformAccountBuilder>
        {

            public bool? CrossNamespace { get; set; }





            internal AdminGetUserSinglePlatformAccountBuilder() { }

            internal AdminGetUserSinglePlatformAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserSinglePlatformAccountBuilder SetCrossNamespace(bool _crossNamespace)
            {
                CrossNamespace = _crossNamespace;
                return this;
            }





            public AdminGetUserSinglePlatformAccount Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetUserSinglePlatformAccount op = new AdminGetUserSinglePlatformAccount(this,
                    namespace_,
                    platformId,
                    userId
                );

                op.SetBaseFields<AdminGetUserSinglePlatformAccountBuilder>(this);
                return op;
            }

            public Model.ModelUserPlatformMetadata? Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetUserSinglePlatformAccount op = Build(
                    namespace_,
                    platformId,
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
            public async Task<Model.ModelUserPlatformMetadata?> ExecuteAsync(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetUserSinglePlatformAccount op = Build(
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ModelUserPlatformMetadata<T1>? Execute<T1>(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetUserSinglePlatformAccount op = Build(
                    namespace_,
                    platformId,
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
            public async Task<Model.ModelUserPlatformMetadata<T1>?> ExecuteAsync<T1>(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetUserSinglePlatformAccount op = Build(
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGetUserSinglePlatformAccount(AdminGetUserSinglePlatformAccountBuilder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;

            if (builder.CrossNamespace != null) QueryParams["crossNamespace"] = Convert.ToString(builder.CrossNamespace)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserSinglePlatformAccount(
            string namespace_,
            string platformId,
            string userId,
            bool? crossNamespace
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;

            if (crossNamespace != null) QueryParams["crossNamespace"] = Convert.ToString(crossNamespace)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/metadata";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserPlatformMetadata? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPlatformMetadata>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPlatformMetadata>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelUserPlatformMetadata<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPlatformMetadata<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPlatformMetadata<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}