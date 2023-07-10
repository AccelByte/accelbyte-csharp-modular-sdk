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
    /// createGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to create new configuration. Before creating the configuration, make sure that member role for admin and group member are already created before.
    /// 
    /// 
    /// 
    /// 
    /// For each of the global rule, it will be the rule detail that consists of these fields:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * ruleAttribute : attribute of the player that needs to be checked
    /// 
    /// 
    ///   * ruleCriteria : criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// 
    /// 
    ///   * ruleValue : value that needs to be checked
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Allowed Action can only be filled with any available action in the Group Service. For the configuration, the only value is "createGroup"
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73103
    /// </summary>
    public class CreateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateGroupConfigurationAdminV1Builder Builder { get => new CreateGroupConfigurationAdminV1Builder(); }

        public class CreateGroupConfigurationAdminV1Builder
            : OperationBuilder<CreateGroupConfigurationAdminV1Builder>
        {





            internal CreateGroupConfigurationAdminV1Builder() { }

            internal CreateGroupConfigurationAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateGroupConfigurationAdminV1 Build(
                ModelsCreateGroupConfigurationRequestV1 body,
                string namespace_
            )
            {
                CreateGroupConfigurationAdminV1 op = new CreateGroupConfigurationAdminV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsCreateGroupConfigurationResponseV1? Execute(
                ModelsCreateGroupConfigurationRequestV1 body,
                string namespace_
            )
            {
                CreateGroupConfigurationAdminV1 op = Build(
                    body,
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

        private CreateGroupConfigurationAdminV1(CreateGroupConfigurationAdminV1Builder builder,
            ModelsCreateGroupConfigurationRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateGroupConfigurationAdminV1(
            string namespace_,
            Model.ModelsCreateGroupConfigurationRequestV1 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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