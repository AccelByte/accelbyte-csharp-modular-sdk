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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// grantUserPass
    ///
    /// This API is used to grant pass to user, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace, otherwise ignore.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : user season data
    /// </summary>
    public class GrantUserPass : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserPassBuilder Builder { get => new GrantUserPassBuilder(); }

        public class GrantUserPassBuilder
            : OperationBuilder<GrantUserPassBuilder>
        {


            public Model.UserPassGrant? Body { get; set; }




            internal GrantUserPassBuilder() { }

            internal GrantUserPassBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public GrantUserPassBuilder SetBody(Model.UserPassGrant _body)
            {
                Body = _body;
                return this;
            }




            public GrantUserPass Build(
                string namespace_,
                string userId
            )
            {
                GrantUserPass op = new GrantUserPass(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GrantUserPassBuilder>(this);
                return op;
            }

            public Model.UserSeasonSummary? Execute(
                string namespace_,
                string userId
            )
            {
                GrantUserPass op = Build(
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

        private GrantUserPass(GrantUserPassBuilder builder,
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

        public GrantUserPass(
            string namespace_,
            string userId,
            Model.UserPassGrant body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserSeasonSummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}