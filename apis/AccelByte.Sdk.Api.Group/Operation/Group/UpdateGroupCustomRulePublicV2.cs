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
    /// updateGroupCustomRulePublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Update group custom rule. This endpoint will check the group ID of the user based on the access token
    /// and compare it with the group ID in path parameter. It will also check the member role of the user based
    /// on the access token
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73308
    /// </summary>
    public class UpdateGroupCustomRulePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupCustomRulePublicV2Builder Builder { get => new UpdateGroupCustomRulePublicV2Builder(); }

        public class UpdateGroupCustomRulePublicV2Builder
            : OperationBuilder<UpdateGroupCustomRulePublicV2Builder>
        {





            internal UpdateGroupCustomRulePublicV2Builder() { }

            internal UpdateGroupCustomRulePublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupCustomRulePublicV2 Build(
                ModelsUpdateGroupCustomRuleRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomRulePublicV2 op = new UpdateGroupCustomRulePublicV2(this,
                    body,
                    groupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGroupResponseV1? Execute(
                ModelsUpdateGroupCustomRuleRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomRulePublicV2 op = Build(
                    body,
                    groupId,
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

            public Model.ModelsGroupResponseV1<T1>? Execute<T1>(
                ModelsUpdateGroupCustomRuleRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomRulePublicV2 op = Build(
                    body,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateGroupCustomRulePublicV2(UpdateGroupCustomRulePublicV2Builder builder,
            ModelsUpdateGroupCustomRuleRequestV1 body,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGroupCustomRulePublicV2(
            string groupId,
            string namespace_,
            Model.ModelsUpdateGroupCustomRuleRequestV1 body
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/custom";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsGroupResponseV1<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}