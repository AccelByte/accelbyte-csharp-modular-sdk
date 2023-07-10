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
    /// updateMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update member role
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class UpdateMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRoleAdminV1Builder Builder { get => new UpdateMemberRoleAdminV1Builder(); }

        public class UpdateMemberRoleAdminV1Builder
            : OperationBuilder<UpdateMemberRoleAdminV1Builder>
        {





            internal UpdateMemberRoleAdminV1Builder() { }

            internal UpdateMemberRoleAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateMemberRoleAdminV1 Build(
                ModelsUpdateMemberRoleRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRoleAdminV1 op = new UpdateMemberRoleAdminV1(this,
                    body,
                    memberRoleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsMemberRoleResponseV1? Execute(
                ModelsUpdateMemberRoleRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRoleAdminV1 op = Build(
                    body,
                    memberRoleId,
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

        private UpdateMemberRoleAdminV1(UpdateMemberRoleAdminV1Builder builder,
            ModelsUpdateMemberRoleRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMemberRoleAdminV1(
            string memberRoleId,
            string namespace_,
            Model.ModelsUpdateMemberRoleRequestV1 body
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}