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
    /// getSingleMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [READ]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get member role based on the role ID
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73203
    /// </summary>
    public class GetSingleMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleMemberRoleAdminV1Builder Builder { get => new GetSingleMemberRoleAdminV1Builder(); }

        public class GetSingleMemberRoleAdminV1Builder
            : OperationBuilder<GetSingleMemberRoleAdminV1Builder>
        {





            internal GetSingleMemberRoleAdminV1Builder() { }

            internal GetSingleMemberRoleAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSingleMemberRoleAdminV1 Build(
                string memberRoleId,
                string namespace_
            )
            {
                GetSingleMemberRoleAdminV1 op = new GetSingleMemberRoleAdminV1(this,
                    memberRoleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsMemberRoleResponseV1? Execute(
                string memberRoleId,
                string namespace_
            )
            {
                GetSingleMemberRoleAdminV1 op = Build(
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

        private GetSingleMemberRoleAdminV1(GetSingleMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSingleMemberRoleAdminV1(
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

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