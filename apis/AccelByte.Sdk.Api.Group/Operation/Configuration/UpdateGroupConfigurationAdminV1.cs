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
    /// updateGroupConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update existing configuration. groupAdminRoleId and groupMemberRoleId won't be able to be updated. User can try to change the member role permission instead for each of those member role
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73102
    /// </summary>
    public class UpdateGroupConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupConfigurationAdminV1Builder Builder { get => new UpdateGroupConfigurationAdminV1Builder(); }

        public class UpdateGroupConfigurationAdminV1Builder
            : OperationBuilder<UpdateGroupConfigurationAdminV1Builder>
        {





            internal UpdateGroupConfigurationAdminV1Builder() { }

            internal UpdateGroupConfigurationAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupConfigurationAdminV1 Build(
                ModelsUpdateGroupConfigurationRequestV1 body,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationAdminV1 op = new UpdateGroupConfigurationAdminV1(this,
                    body,
                    configurationCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsUpdateGroupConfigurationResponseV1? Execute(
                ModelsUpdateGroupConfigurationRequestV1 body,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationAdminV1 op = Build(
                    body,
                    configurationCode,
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

        private UpdateGroupConfigurationAdminV1(UpdateGroupConfigurationAdminV1Builder builder,
            ModelsUpdateGroupConfigurationRequestV1 body,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGroupConfigurationAdminV1(
            string configurationCode,
            string namespace_,
            Model.ModelsUpdateGroupConfigurationRequestV1 body
        )
        {
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUpdateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}