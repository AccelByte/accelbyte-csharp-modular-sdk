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
    /// updateUserProfileStatus
    ///
    /// Update user profile status.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11406
    ///   *  Returns : user profile
    /// </summary>
    public class UpdateUserProfileStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserProfileStatusBuilder Builder { get => new UpdateUserProfileStatusBuilder(); }

        public class UpdateUserProfileStatusBuilder
            : OperationBuilder<UpdateUserProfileStatusBuilder>
        {


            public Model.UserProfileStatusUpdate? Body { get; set; }




            internal UpdateUserProfileStatusBuilder() { }

            internal UpdateUserProfileStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateUserProfileStatusBuilder SetBody(Model.UserProfileStatusUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateUserProfileStatus Build(
                string namespace_,
                string userId
            )
            {
                UpdateUserProfileStatus op = new UpdateUserProfileStatus(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateUserProfileStatusBuilder>(this);
                return op;
            }

            public Model.UserProfilePrivateInfo? Execute(
                string namespace_,
                string userId
            )
            {
                UpdateUserProfileStatus op = Build(
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

            public Model.UserProfilePrivateInfo<T1, T2>? Execute<T1, T2>(
                string namespace_,
                string userId
            )
            {
                UpdateUserProfileStatus op = Build(
                    namespace_,
                    userId
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

        private UpdateUserProfileStatus(UpdateUserProfileStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateUserProfileStatus(
            string namespace_,
            string userId,
            Model.UserProfileStatusUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/status";

        public override HttpMethod Method => HttpMethod.Patch;

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