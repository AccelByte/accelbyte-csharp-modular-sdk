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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// updateGroupCustomAttributesPublicV2
    ///
    /// Requires valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// This endpoint replaces current group custom attributes entirely. This endpoint will check the group ID of the user based on the access token and compare it with the group ID in path parameter. It will also check the member role of the user based on the access token
    /// 
    /// Action Code: 73311
    /// </summary>
    public class UpdateGroupCustomAttributesPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupCustomAttributesPublicV2Builder Builder { get => new UpdateGroupCustomAttributesPublicV2Builder(); }

        public class UpdateGroupCustomAttributesPublicV2Builder
            : OperationBuilder<UpdateGroupCustomAttributesPublicV2Builder>
        {





            internal UpdateGroupCustomAttributesPublicV2Builder() { }

            internal UpdateGroupCustomAttributesPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGroupCustomAttributesPublicV2 Build(
                ModelsUpdateGroupCustomAttributesRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomAttributesPublicV2 op = new UpdateGroupCustomAttributesPublicV2(this,
                    body,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<UpdateGroupCustomAttributesPublicV2Builder>(this);
                return op;
            }

            public Model.ModelsGroupResponseV1? Execute(
                ModelsUpdateGroupCustomAttributesRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomAttributesPublicV2 op = Build(
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
            public async Task<Model.ModelsGroupResponseV1?> ExecuteAsync(
                ModelsUpdateGroupCustomAttributesRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomAttributesPublicV2 op = Build(
                    body,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ModelsGroupResponseV1<T1>? Execute<T1>(
                ModelsUpdateGroupCustomAttributesRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomAttributesPublicV2 op = Build(
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
            public async Task<Model.ModelsGroupResponseV1<T1>?> ExecuteAsync<T1>(
                ModelsUpdateGroupCustomAttributesRequestV1 body,
                string groupId,
                string namespace_
            )
            {
                UpdateGroupCustomAttributesPublicV2 op = Build(
                    body,
                    groupId,
                    namespace_
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

        private UpdateGroupCustomAttributesPublicV2(UpdateGroupCustomAttributesPublicV2Builder builder,
            ModelsUpdateGroupCustomAttributesRequestV1 body,
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

        public UpdateGroupCustomAttributesPublicV2(
            string groupId,
            string namespace_,
            Model.ModelsUpdateGroupCustomAttributesRequestV1 body
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/attributes/custom";

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