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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// initiateGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to initiate configuration. This endpoint will automatically create default configuration and member roles with default permission
    /// 
    /// 
    /// 
    /// 
    /// Default Permission for admin role will cover these permission:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * Permission to invite user to group
    /// 
    /// 
    ///   * Permission to accept or reject join request
    /// 
    /// 
    ///   * Permission to kick group member
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Default max member value will be 50 and global rules will be empty
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73104
    /// </summary>
    public class InitiateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static InitiateGroupConfigurationAdminV1Builder Builder { get => new InitiateGroupConfigurationAdminV1Builder(); }

        public class InitiateGroupConfigurationAdminV1Builder
            : OperationBuilder<InitiateGroupConfigurationAdminV1Builder>
        {





            internal InitiateGroupConfigurationAdminV1Builder() { }

            internal InitiateGroupConfigurationAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public InitiateGroupConfigurationAdminV1 Build(
                string namespace_
            )
            {
                InitiateGroupConfigurationAdminV1 op = new InitiateGroupConfigurationAdminV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsCreateGroupConfigurationResponseV1? Execute(
                string namespace_
            )
            {
                InitiateGroupConfigurationAdminV1 op = Build(
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
        }

        private InitiateGroupConfigurationAdminV1(InitiateGroupConfigurationAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public InitiateGroupConfigurationAdminV1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/initiate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCreateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupConfigurationResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateGroupConfigurationResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}